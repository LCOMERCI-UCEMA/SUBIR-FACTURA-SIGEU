
using Entidades;
using Utilidades;
using System.Data;
using Console = System.Diagnostics.Debug;

namespace UCEMA.Subir_Factura_SIGEU.NET7
{
   public partial class frmPrincipal : Form
   {
      protected int cursorPos_CUIT;
      protected Color? textColor;
      protected DataTable? dtEmpresa;

      protected PictureBox? picOverlay;
      protected frmCargando formCargando;
      protected DialogResult? dlgCargando;

      protected Factura factura;
      protected NotaCredito notaCredito;

      protected readonly List<(TextBox descripcion, TextBox importe)> itemsFactura = new List<(TextBox, TextBox)>();
      protected readonly List<(TextBox descripcion, TextBox importe)> itemsNotaCredito = new List<(TextBox, TextBox)>();

      public frmPrincipal()
      {
         InitializeComponent();
         formCargando = new frmCargando();

         InitializeDialog();
         InitializeFormUtils();
         InitializeFacturaItems();

         cursorPos_CUIT = 0;
         textColor = txtNumFactura.ForeColor;

         factura = new Factura();
         notaCredito = new NotaCredito();
      }

      private void InitializeFacturaItems()
      {
         itemsFactura.Add((txtItem01, txtImporte01));
         itemsFactura.Add((txtItem02, txtImporte02));
         itemsFactura.Add((txtItem03, txtImporte03));
         itemsFactura.Add((txtItem04, txtImporte04));
         itemsFactura.Add((txtItem05, txtImporte05));
         itemsFactura.Add((txtItem06, txtImporte06));
         itemsFactura.Add((txtItem07, txtImporte07));
         itemsFactura.Add((txtItem08, txtImporte08));
         itemsFactura.Add((txtItem09, txtImporte09));

         foreach (var itemFactura in itemsFactura)
         {
            itemFactura.descripcion.Enabled = false;
            itemFactura.importe.Enabled = false;
         }

         itemsFactura[0].descripcion.Enabled = true;
      }

      private void InitializeNotaCreditoItems()
      {
         itemsNotaCredito.Add((txtItem01, txtImporte01));
         itemsNotaCredito.Add((txtItem02, txtImporte02));
         itemsNotaCredito.Add((txtItem03, txtImporte03));
         itemsNotaCredito.Add((txtItem04, txtImporte04));
         itemsNotaCredito.Add((txtItem05, txtImporte05));
         itemsNotaCredito.Add((txtItem06, txtImporte06));
         itemsNotaCredito.Add((txtItem07, txtImporte07));
         itemsNotaCredito.Add((txtItem08, txtImporte08));
         itemsNotaCredito.Add((txtItem09, txtImporte09));

         foreach (var itemNotaCredito in itemsNotaCredito)
         {
            itemNotaCredito.descripcion.Enabled = false;
            itemNotaCredito.importe.Enabled = false;
         }

         itemsNotaCredito[0].descripcion.Enabled = true;
      }

      private void InitializeFormUtils()
      {
         FormUtils.OnLoadBegin = () =>
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

         FormUtils.OnLoadEnd = () =>
         {
            Console.WriteLine("CALL: FormUtils.onLoadEnd()");
            if (formCargando.Visible)
            {
               formCargando.Hide();
            }
            //picOverlay.Hide();
         };
      }

      public void InitializeDialog()
      {
         // hago el overlay semi-transparente que se mostrara por detras del form cargando
         picOverlay = new PictureBox();

         picOverlay.Dock = DockStyle.Fill;
         picOverlay.BackColor = Color.Transparent;
         picOverlay.Visible = false;
         //picOverlay.BringToFront();

         this.Controls.Add(picOverlay);


         // form cargando
         formCargando.Owner = this;
         //formCargando.StartPosition = FormStartPosition.CenterParent;
         formCargando.StartPosition = FormStartPosition.Manual;
         formCargando.TopMost = true;
         formCargando.FormBorderStyle = FormBorderStyle.None;
         formCargando.Opacity = 0.64;
         //formCargando.TransparencyKey = Color.FromArgb(128, Color.FromKnownColor(KnownColor.Control));
      }

      private void frmPrincipal_Load(object sender, EventArgs e)
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

      /// <summary>
      ///   Step 1: Validar el número de factura
      /// </summary>
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
            return;
         }

         grpEmpresa.Enabled = true; // Habilito el grupo de controles de empresa
         lblNumFactura.ForeColor = Color.LimeGreen;
         txtCUIT.Focus();

         factura.NumeroFactura = long.Parse(strIdFactura);
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

      /// <summary>
      ///   Step 2: Buscar la empresa por CUIT
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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

         // Chequeo si la empresa tiene domicilio registrado
         string? empresaDomicilio = datosEmpresa.Rows[0]["DOMICILIO"].ToString();

         if (empresaDomicilio == Constantes.SIN_DOMICILIO)
         {
            MessageBox.Show("No se puede aceptar la factura porque la empresa no tiene domicilio registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         factura.Cuit = long.Parse(cuitEmpresa);
         factura.IdEmpresa = idEmpresa;

         grpFechaVto.Enabled = true;
         grpImporteTotal.Enabled = true;

         dtpickerFechaVencimiento.Focus();

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

         // muestro por pantalla el contenido del objeto factura
         Console.WriteLine(factura.ToString());

         // Si está todo OK, se procede a cargar la factura
         FormUtils.LoadingON();
         DataTable dtCargarFactura = await Logica.Script.CargarFacturaAsync(factura);
         FormUtils.LoadingOFF();
      }

      /// <summary>
      ///   Step 3: Fijar la fecha de vencimiento de la factura
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void dtpickerFechaVencimiento_ValueChanged(object sender, EventArgs e)
      {
         //Console.WriteLine("CALL: dtpickerFechaVencimiento_ValueChanged()");
         factura.FechaVencimiento = dtpickerFechaVencimiento.Value;
      }

      private async void btnValidarFacturaExistente_Click(object sender, EventArgs e)
      {
         string strIdFactura = txtNumFacturaNC.Text;

         if (strIdFactura.Length == 0)
         {
            MessageBox.Show("El número de factura no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFacturaNC.Focus();
            return;
         }

         if (strIdFactura.Length > 9)
         {
            MessageBox.Show("El número de factura no puede tener más de 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFacturaNC.Focus();
            return;
         }

         strIdFactura = FacturaHelper.AplicarMascara(strIdFactura);

         FormUtils.LoadingON();
         bool facturaExiste = await Logica.Script.FacturaExisteAsync(long.Parse(strIdFactura));
         FormUtils.LoadingOFF();

         lblNumFacturaNC.Text = strIdFactura;

         if (facturaExiste)
         {
            lblNumFacturaNC.ForeColor = Color.Red;
            txtNumFacturaNC.Focus();
            return;
         }

         grpNumeroNC.Enabled = true; // Habilito el grupo de número de nota de crédito
         lblNumFacturaNC.ForeColor = Color.LimeGreen;
         txtNotaCredito.Focus();

         notaCredito.NumeroFactura = long.Parse(strIdFactura);
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

         factura.ImporteTotal = importeTotal;

         grpItemsFactura.Enabled = true; // Habilito grupo de items de factura
         //txtItem01.Enabled = true; // Habilito primer item de factura
      }

      private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e);
      }

      private void dtpickerFechaVencimiento_Leave(object sender, EventArgs e)
      {
         factura.FechaVencimiento = dtpickerFechaVencimiento.Value;

         if (fechaSuperaElAño(dtpickerFechaVencimiento.Value))
         {
            MessageBox.Show("La fecha de vencimiento no debería ser mayor a 1 año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FormUtils.StatusMessage("La fecha de vencimiento no debería ser mayor a 1 año.");
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

      private void txtImporteTotal_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e, true);
      }

      private void ItemImporte_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e, true);
      }

      /// <summary>
      ///   Step 5: Cargar la descripcion de los items de la factura
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void ItemDescripcion_TextChanged(object sender, EventArgs e)
      {
         Control? grupoPadre = FormUtils.GetParentGroupBox((Control) sender);
         string? tagGrupoPadre = grupoPadre?.Tag?.ToString()?.ToUpper();

         if (tagGrupoPadre == null)
         {
            Console.WriteLine("El textbox no pertenece a un grupo de ítems (fijar Tag como FC o NC)");
            return;
         }

         List<(TextBox descripcion, TextBox importe)> itemSource =
            tagGrupoPadre == Constantes.GRUPO_FACTURA
               ? itemsFactura
               : itemsNotaCredito;

         Control btnCargarComprobante =
            tagGrupoPadre == Constantes.GRUPO_FACTURA
               ? btnCargarFactura
               : btnCargarNotaCredito;

         TextBox txtDescripcion = (TextBox) sender;
         (TextBox descripcion, TextBox importe)
            renglonActual = itemSource.FirstOrDefault(par => par.descripcion == txtDescripcion);
         int indiceActual = itemSource.IndexOf(renglonActual);


         (TextBox descripcion, TextBox importe)
            renglonSiguiente = itemSource[indiceActual + 1];


         bool hayDescripcion = !string.IsNullOrWhiteSpace(txtDescripcion.Text);
         bool hayImporte = !string.IsNullOrWhiteSpace(renglonActual.importe.Text);

         int ultimoIndice = itemSource.Count - 1;

         if (hayDescripcion)
         {
            // Habilitar el TextBox de importe del par actual
            renglonActual.importe.Enabled = true;
            renglonSiguiente.descripcion.Enabled = indiceActual < ultimoIndice && hayImporte ? true : false;
         }
         else if (!hayImporte)
         {
            renglonActual.importe.Enabled = false;
            renglonSiguiente.descripcion.Enabled = indiceActual < ultimoIndice ? false : true;
         }

         btnCargarComprobante.Enabled = ChequearPresenciaDeImporte(itemSource);
      }

      /// <summary>
      ///   Step 5: Cargar el importe de los items de la factura.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void ItemImporte_TextChanged(object sender, EventArgs e)
      {
         TextBox txtImporte = (TextBox) sender;
         (TextBox descripcion, TextBox importe) parActual = itemsFactura.FirstOrDefault(par => par.importe == txtImporte);
         int indiceActual = itemsFactura.IndexOf(parActual);

         bool hayDescripcion = !string.IsNullOrWhiteSpace(parActual.descripcion.Text);
         bool hayImporte = !string.IsNullOrWhiteSpace(txtImporte.Text);

         if (indiceActual < itemsFactura.Count - 1)
         {
            var siguientePar = itemsFactura[indiceActual + 1];

            if (hayImporte && hayDescripcion)
            {
               siguientePar.descripcion.Enabled = true;
            }
            else
            {
               siguientePar.descripcion.Enabled = false;
            }
         }

         lblImporteCalculadoFC.Text = CalcularImporteTotal_Factura().ToString();
         lblImporteCalculadoFC.ForeColor = CalcularImporteTotal_Factura() == Decimal.Parse(txtImporteTotal.Text)
            ? Color.Green
            : Color.Red;
         btnCargarFactura.Enabled = ChequearPresenciaDeImporte(itemsFactura) 
            && CalcularImporteTotal_Factura() == Decimal.Parse(txtImporteTotal.Text);
      }

      private decimal CalcularImporteTotal_Factura()
      {
         return CalcularImporteTotal(grpItemsFactura);
      }

      private decimal CalcularImporteTotal_NotaCredito()
      {
         return CalcularImporteTotal(grpItemsNC);
      }

      private decimal CalcularImporteTotal(GroupBox itemsContainer)
      {
         decimal total = 0m;

         //  recorrer todos los textbox de importe y sumarlos (son solo los que tienen el campo tag = "importe"
         IEnumerable<TextBox> camposImporte = itemsContainer
            .Controls
            .OfType<TextBox>()
            .Where(txt => txt.Tag?.ToString() == "importe");

         foreach (TextBox txtImporte in camposImporte)
         {
            if (decimal.TryParse(txtImporte.Text, out decimal importe))
            {
               total += importe;
            }
         }

         return Math.Round(total, 2);
      }

      /// <summary>
      ///   Step: Cargar la descripcion de los items de la nota de credito.
      /// </summary>
      private void ItemDescripcionNC_TextChanged(object sender, EventArgs e)
      {
         TextBox txtDescripcion = (TextBox) sender;
         (TextBox descripcion, TextBox importe)
            renglonActual = itemsNotaCredito.FirstOrDefault(par => par.descripcion == txtDescripcion);

         int indiceActual = itemsNotaCredito.IndexOf(renglonActual);

         (TextBox descripcion, TextBox importe)
            renglonSiguiente = itemsNotaCredito[indiceActual + 1];

         bool hayDescripcion = !string.IsNullOrWhiteSpace(txtDescripcion.Text);
         bool hayImporte = !string.IsNullOrWhiteSpace(renglonActual.importe.Text);

         int ultimoIndice = itemsNotaCredito.Count - 1;

         if (hayDescripcion)
         {
            // Habilitar el TextBox de importe del par actual
            renglonActual.importe.Enabled = true;
            renglonSiguiente.descripcion.Enabled = indiceActual < ultimoIndice && hayImporte ? true : false;
         }
         else if (!hayImporte)
         {
            renglonActual.importe.Enabled = false;
            renglonSiguiente.descripcion.Enabled = indiceActual < ultimoIndice ? false : true;
         }

         btnCargarNotaCredito.Enabled = ChequearPresenciaDeImporte(itemsNotaCredito);
      }

      /// <summary>
      ///   Step: Cargar el importe de los items de la nota de credito.
      /// </summary>
      private void ItemImporteNC_TextChanged(object sender, EventArgs e)
      {
         TextBox txtImporte = (TextBox) sender;
         (TextBox descripcion, TextBox importe) parActual = itemsNotaCredito.FirstOrDefault(par => par.importe == txtImporte);
         int indiceActual = itemsNotaCredito.IndexOf(parActual);

         bool hayDescripcion = !string.IsNullOrWhiteSpace(parActual.descripcion.Text);
         bool hayImporte = !string.IsNullOrWhiteSpace(txtImporte.Text);

         if (indiceActual < itemsNotaCredito.Count - 1)
         {
            var siguientePar = itemsNotaCredito[indiceActual + 1];

            siguientePar.descripcion.Enabled = hayImporte && hayDescripcion;
         }

         btnCargarNotaCredito.Enabled = ChequearPresenciaDeImporte(itemsNotaCredito);
         lblImporteCalculadoNC.Text = CalcularImporteTotal_NotaCredito().ToString();
      }

      /// <summary>
      ///   Step 4: Fijar el importe total de la factura.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void txtImporteTotal_TextChanged(object sender, EventArgs e)
      {
         TextBox txtImporteTotal = (TextBox) sender;
         bool hayImporteTotal = !string.IsNullOrWhiteSpace(txtImporteTotal.Text);

         grpItemsFactura.Enabled = hayImporteTotal;
      }

      /// <summary>
      ///   Chequeo si hay algun importe con valor.
      /// </summary>
      /// <returns></returns>
      private bool ChequearPresenciaDeImporte(List<(TextBox descripcion, TextBox importe)> items)
      {
         bool hayImporte = false;

         foreach (var (descripcion, importe) in items)
         {
            // chequeo si hay algun importe con valor
            hayImporte = hayImporte || !string.IsNullOrWhiteSpace(importe.Text);
         }

         return hayImporte;
      }

      private void txtNumFacturaNC_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnValidarNumFactura.PerformClick();
         }
      }

      private void txtNumFacturaNC_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e);
      }

      private void txtNotaCredito_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnValidarNotaCredito.PerformClick();
         }

         //cursorPos_CUIT = txtNotaCredito.SelectionStart;
         //lblPos.Text = cursorPos_CUIT.ToString();
      }

      private void txtNotaCredito_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e);
      }

      private async void btnValidarNotaCredito_Click(object sender, EventArgs e)
      {
         string strIdNotaCredito = txtNumFacturaNC.Text;

         if (strIdNotaCredito.Length == 0)
         {
            MessageBox.Show("El número de factura no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFacturaNC.Focus();
            return;
         }

         if (strIdNotaCredito.Length > 9)
         {
            MessageBox.Show("El número de factura no puede tener más de 9 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFacturaNC.Focus();
            return;
         }

         strIdNotaCredito = FacturaHelper.AplicarMascara(strIdNotaCredito);

         FormUtils.LoadingON();
         bool notaCreditoExiste = await Logica.Script.NotaCreditoExisteAsync(long.Parse(strIdNotaCredito));
         FormUtils.LoadingOFF();

         lblNumeroNC.Text = strIdNotaCredito;

         if (notaCreditoExiste)
         {
            lblNumeroNC.ForeColor = Color.Red;
            txtNumFacturaNC.Focus();
            return;
         }

         grpFechaVtoNC.Enabled = true; // Habilito el grupo de fecha de vencimiento de la nota de crédito
         grpImporteTotalNC.Enabled = true; // Habilito el grupo de importe total de la nota de crédito

         lblNumeroNC.ForeColor = Color.LimeGreen;
         dtpickerFechaVtoNC.Focus();

         notaCredito.NumeroFactura = long.Parse(strIdNotaCredito);
      }

      private void dtpickerFechaVtoNC_Leave(object sender, EventArgs e)
      {
         notaCredito.FechaVencimiento = dtpickerFechaVtoNC.Value;

         if (fechaSuperaElAño(dtpickerFechaVtoNC.Value))
         {
            MessageBox.Show("La fecha de vencimiento no debería ser mayor a 1 año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FormUtils.StatusMessage("La fecha de vencimiento no debería ser mayor a 1 año.");
         }
      }

      private void dtpickerFechaVtoNC_ValueChanged(object sender, EventArgs e)
      {
         notaCredito.FechaVencimiento = dtpickerFechaVtoNC.Value;
      }

      private void txtImporteTotalNC_TextChanged(object sender, EventArgs e)
      {
         TextBox txtImporteTotalNC = (TextBox) sender;
         bool hayImporteTotalNC = !string.IsNullOrWhiteSpace(txtImporteTotalNC.Text);

         grpItemsNC.Enabled = hayImporteTotalNC;
      }

      private void txtImporteTotalNC_KeyPress(object sender, KeyPressEventArgs e)
      {
         FormUtils.Numeric_KeyPress(ref sender, ref e, true);
      }

      private void txtImporteTotalNC_Leave(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(txtImporteTotalNC.Text))
         {
            return;
         }

         decimal importeTotalNC = decimal.Parse(txtImporteTotalNC.Text.Trim());

         if (importeTotalNC < 0)
         {
            MessageBox.Show("El importe total no puede ser negativo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtImporteTotalNC.Focus();
         }

         notaCredito.ImporteTotal = importeTotalNC;

         grpItemsNC.Enabled = true; // Habilito grupo de items de factura
                                    //txtItem01.Enabled = true; // Habilito primer item de factura
      }

      private void btnCargarNotaCredito_Click(object sender, EventArgs e)
      {
         if (notaCredito.NumeroFactura == 0)
         {
            // Error, el número de notaCredito no puede ser 0, revise los datos por favor.
            MessageBox.Show("El número de notaCredito no puede ser 0.\nRevise los datos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFactura.Focus();
            return;
         }

         if (notaCredito.NumeroNota == 0)
         {
            // Error, el número de notaCredito no puede ser 0, revise los datos por favor.
            MessageBox.Show("El número de notaCredito no puede ser 0.\nRevise los datos por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNumFactura.Focus();
            return;
         }

         if (fechaSuperaElAño(dtpickerFechaVtoNC.Value))
         {
            MessageBox.Show("La fecha de vencimiento no debería ser mayor a 1 año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FormUtils.StatusMessage("La fecha de vencimiento no debería ser mayor a 1 año.");
         }

         notaCredito.Importe1 = txtImporteNC01.Text.Trim();
         notaCredito.Importe2 = txtImporteNC02.Text.Trim();
         notaCredito.Importe3 = txtImporteNC03.Text.Trim();
         notaCredito.Importe4 = txtImporteNC04.Text.Trim();
         notaCredito.Importe5 = txtImporteNC05.Text.Trim();
         notaCredito.Importe6 = txtImporteNC06.Text.Trim();
         notaCredito.Importe7 = txtImporteNC07.Text.Trim();
         notaCredito.Importe8 = txtImporteNC08.Text.Trim();
         notaCredito.Importe9 = txtImporteNC09.Text.Trim();

         notaCredito.Descripcion1 = txtItemNC01.Text.Trim();
         notaCredito.Descripcion2 = txtItemNC02.Text.Trim();
         notaCredito.Descripcion3 = txtItemNC03.Text.Trim();
         notaCredito.Descripcion4 = txtItemNC04.Text.Trim();
         notaCredito.Descripcion5 = txtItemNC05.Text.Trim();
         notaCredito.Descripcion6 = txtItemNC06.Text.Trim();
         notaCredito.Descripcion7 = txtItemNC07.Text.Trim();
         notaCredito.Descripcion8 = txtItemNC08.Text.Trim();
         notaCredito.Descripcion9 = txtItemNC09.Text.Trim();

         // muestro por pantalla el contenido del objeto notaCredito
         Console.WriteLine(notaCredito.ToString());

         // Si está todo OK, se procede a cargar la notaCredito
         //FormUtils.LoadingON();
         //bool notaCreditoCargada = await Logica.Script.CargarFacturaAsync(notaCredito);
         //FormUtils.LoadingOFF();
      }

      private bool fechaSuperaElAño(DateTime dtFecha)
      {
         DateTime fechaActual = DateTime.Now;

         return dtFecha < fechaActual.AddYears(-1);
      }
   }
}