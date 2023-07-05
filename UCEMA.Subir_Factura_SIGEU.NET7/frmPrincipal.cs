
using Entidades;
using Utilidades;
using System.Data;
using Console = System.Diagnostics.Debug;

namespace UCEMA.Subir_Factura_SIGEU.NET7
{
   public partial class frmPrincipal : Form
   {
      protected int cursorPos_CUIT;
      protected Color textColor;
      protected DataTable? dtEmpresa;

      protected PictureBox picOverlay;
      protected frmCargando formCargando;
      protected DialogResult dlgCargando;

      Factura factura;
      NotaCredito notaCredito;

      public frmPrincipal()
      {
         InitializeComponent();
         InitializeDialog();

         cursorPos_CUIT = 0;
         textColor = txtNumFactura.ForeColor;

         factura = new Factura();
         notaCredito = new NotaCredito();

         FormUtils.onLoadBegin = () =>
         {
            Console.WriteLine("CALL: FormUtils.onLoadBegin()");

            int parentCenterX = this.Location.X + (this.Width / 2) - (formCargando.Width / 2);
            int parentCenterY = this.Location.Y + (this.Height / 2) - (formCargando.Height / 2);

            formCargando.Location = new Point(parentCenterX, parentCenterY);
            //picOverlay.Show();
            if (!formCargando.Visible)
            {
               formCargando.Show(this);
            }
         };

         FormUtils.onLoadEnd = () =>
         {
            Console.WriteLine("CALL: FormUtils.onLoadEnd()");
            if (formCargando.Visible)
            {
               formCargando.Hide();
            }
            //picOverlay.Hide();
         };
      }

      private void InitializeDialog()
      {
         // hago el overlay semi-transparente que se mostrara por detras del form cargando
         picOverlay = new PictureBox();

         picOverlay.Dock = DockStyle.Fill;
         picOverlay.BackColor = Color.Transparent;
         picOverlay.Visible = false;
         //picOverlay.BringToFront();

         this.Controls.Add(picOverlay);


         // form cargando
         formCargando = new frmCargando();

         formCargando.Owner = this;
         //formCargando.StartPosition = FormStartPosition.CenterParent;
         formCargando.StartPosition = FormStartPosition.Manual;
         formCargando.TopMost = true;
         formCargando.FormBorderStyle = FormBorderStyle.None;
         formCargando.Opacity = 0.64;
         //formCargando.TransparencyKey = Color.FromArgb(128, Color.FromKnownColor(KnownColor.Control));
      }

      private async void frmPrincipal_Load(object sender, EventArgs e)
      {
         this.KeyPreview = true;
         txtNumFactura.Focus();
         /*
            txtCUIT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCUIT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // Me traigo una lista de CUITs para no andar adivinando
            DataTable dtAllCUITs = await Logica.Script.GetAllCUITsAsync();

            AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();
            foreach (DataRow row in dtAllCUITs.Rows)
            {
               autocomplete.Add(row["N_CUIT"].ToString());
            }
            txtCUIT.AutoCompleteCustomSource = autocomplete;
         */
      }

      private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
      {
         switch (e.KeyCode)
         {
            case Keys.Escape:
               {
                  DialogResult res = MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                  if (res == DialogResult.Yes)
                  {
                     Application.Exit();
                  }
                  break;
               }
         }
      }

      private async void btnValidarNumFactura_Click(object sender, EventArgs e)
      {
         string strIdFactura = txtNumFactura.Text;

         if (strIdFactura.Length == 0)
         {
            MessageBox.Show("El número de factura no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFactura.Focus();
            return;
         }

         if (strIdFactura.Length > 9)
         {
            MessageBox.Show("El número de factura no puede tener más de 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFactura.Focus();
            return;
         }

         strIdFactura = FacturaHelper.AplicarMascara(strIdFactura);
         FormUtils.LoadingON();

         bool facturaExiste = await Logica.Script.FacturaExisteAsync(long.Parse(strIdFactura));
         FormUtils.LoadingOFF();
         lblNumFactura.Text = strIdFactura;

         if (facturaExiste)
         {
            lblNumFactura.ForeColor = Color.Red;
            txtNumFactura.Focus();
         }
         else
         {
            lblNumFactura.ForeColor = Color.LimeGreen;
            grpEmpresa.Enabled = true;
            txtCUIT.Focus();
            factura.NumeroFactura = long.Parse(strIdFactura);
         }
      }

      private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e);
      }

      private void txtCUIT_KeyUp(object sender, KeyEventArgs e)
      {
         lblPos.Text = txtCUIT.SelectionStart.ToString();
      }

      private void txtCUIT_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            //MessageBox.Show("Se presionó enter", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBuscarEmpresa.PerformClick();
         }

         cursorPos_CUIT = txtCUIT.SelectionStart;
         lblPos.Text = cursorPos_CUIT.ToString();
      }

      private void txtCUIT_Enter(object sender, EventArgs e)
      {
         cursorPos_CUIT = txtCUIT.SelectionStart;
         lblPos.Text = cursorPos_CUIT.ToString();
      }

      private async void btnBuscarEmpresa_Click(object sender, EventArgs e)
      {
         string cuitEmpresa = txtCUIT.Text.Trim();

         if (string.IsNullOrWhiteSpace(cuitEmpresa))
         {
            MessageBox.Show("El CUIT no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         if (cuitEmpresa.Length != 11)
         {
            MessageBox.Show("El CUIT debe tener 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         FormUtils.LoadingON();
         DataTable datosEmpresa = await Logica.Script.BuscarEmpresaAsync(cuitEmpresa);
         FormUtils.LoadingOFF();

         if (datosEmpresa.Rows.Count == 0)
         {
            MessageBox.Show("No se encontraron datos para el CUIT ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         dgvEmpresa.DataSource = null;
         dgvEmpresa.DataSource = datosEmpresa;

         int idEmpresa = int.Parse(datosEmpresa.Rows[0]["N_ID_EMPRESA"].ToString() ?? "0");

         if (idEmpresa == 0)
         {
            MessageBox.Show("idEmpresa no puede ser 0.\nRevise los datos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         // Check if the company has a registered address.
         FormUtils.LoadingON();
         DataTable empresaDomicilio = await Logica.Script.BuscarEmpresaDomicilioAsync(idEmpresa);
         FormUtils.LoadingOFF();

         if (empresaDomicilio.Rows.Count == 0)
         {
            MessageBox.Show("No se puede aceptar la factura porque la empresa no tiene domicilio registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         factura.Cuit = long.Parse(cuitEmpresa);
         factura.IdEmpresa = idEmpresa;

         grpFechaVto.Enabled = true;
         grpImporteTotal.Enabled = true;

         //btnCargarFactura.Enabled = true;
      }

      private async void btnCargarFactura_Click(object sender, EventArgs e)
      {
         if (factura.NumeroFactura == 0)
         {
            // Error, el número de factura no puede ser 0, revise los datos por favor.
            MessageBox.Show("El número de factura no puede ser 0.\nRevise los datos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFactura.Focus();
            return;
         }

         if (factura.Cuit == 0)
         {
            // Error, el CUIT no puede ser 0, revise los datos por favor.
            MessageBox.Show("El CUIT no puede ser 0.\nRevise los datos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtCUIT.Focus();
            return;
         }

         if (factura.IdEmpresa == 0)
         {
            // Error, el idEmpresa no puede ser 0, revise los datos por favor.
            MessageBox.Show("idEmpresa no puede ser 0.\nRevise los datos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtCUIT.Focus();
            return;
         }

         factura.Importe1 = txtImporte01.Text.Trim();
         factura.Importe2 = txtImporte02.Text.Trim();
         factura.Importe3 = txtImporte03.Text.Trim();
         factura.Importe4 = txtImporte04.Text.Trim();
         factura.Importe5 = txtImporte05.Text.Trim();
         factura.Importe6 = txtImporte06.Text.Trim();
         factura.Importe7 = txtImporte07.Text.Trim();
         factura.Importe8 = txtImporte08.Text.Trim();
         factura.Importe9 = txtImporte09.Text.Trim();

         factura.Descripcion1 = txtItem01.Text.Trim();
         factura.Descripcion2 = txtItem02.Text.Trim();
         factura.Descripcion3 = txtItem03.Text.Trim();
         factura.Descripcion4 = txtItem04.Text.Trim();
         factura.Descripcion5 = txtItem05.Text.Trim();
         factura.Descripcion6 = txtItem06.Text.Trim();
         factura.Descripcion7 = txtItem07.Text.Trim();
         factura.Descripcion8 = txtItem08.Text.Trim();
         factura.Descripcion9 = txtItem09.Text.Trim();

         // muestro por pantalla el contenido del objeto factura
         Console.WriteLine(factura.ToString());

         // Si está todo OK, se procede a cargar la factura
         //FormUtils.LoadingON();
         //bool facturaCargada = await Logica.Script.CargarFacturaAsync(factura);
         //FormUtils.LoadingOFF();
      }

      private void dtpickerFechaVencimiento_ValueChanged(object sender, EventArgs e)
      {
         Console.WriteLine("CALL: dtpickerFechaVencimiento_ValueChanged()");
         factura.FechaVencimiento = dtpickerFechaVencimiento.Value;
      }

      private void btnValidarFacturaExistente_Click(object sender, EventArgs e)
      {
         int idFactura = int.Parse(txtNumFacturaNC.Text.Trim());
         bool facturaExiste = Logica.Script.FacturaExiste(idFactura);

         if (facturaExiste)
         {
            txtNumFacturaNC.ForeColor = Color.Green;
            notaCredito.NumeroFactura = idFactura;
            txtNotaCredito.Focus();
         }
      }

      private void txtImporteTotal_Leave(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(txtImporteTotal.Text))
         {
            return;
         }

         decimal importeTotal = decimal.Parse(txtImporteTotal.Text.Trim());

         if (importeTotal < 0)
         {
            MessageBox.Show("El importe total no puede ser negativo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtImporteTotal.Focus();
         }
      }

      private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e);
      }

      private void dtpickerFechaVencimiento_Leave(object sender, EventArgs e)
      {
         // valido que la fecha del control no sea mayor a 1 año
         DateTime fechaVencimiento = dtpickerFechaVencimiento.Value;
         DateTime fechaActual = DateTime.Now;

         factura.FechaVencimiento = fechaVencimiento;

         if (fechaVencimiento < fechaActual.AddYears(-1))
         {
            MessageBox.Show("La fecha de vencimiento no debería ser mayor a 1 año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void txtNumFactura_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnValidarNumFactura.PerformClick();
         }
      }

      private async void btnCargando_Click(object sender, EventArgs e)
      {
         FormUtils.LoadingON();
         await Task.Run(() => { Thread.Sleep(5000); });
         FormUtils.LoadingOFF();
      }
   }
}