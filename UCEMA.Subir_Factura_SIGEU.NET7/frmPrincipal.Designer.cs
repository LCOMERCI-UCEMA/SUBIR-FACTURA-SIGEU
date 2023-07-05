namespace UCEMA.Subir_Factura_SIGEU.NET7
{
   partial class frmPrincipal
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
         dlgAbrirArchivo = new OpenFileDialog();
         btnCargarFactura = new Button();
         tabTipoComprobante = new TabControl();
         tabFactura = new TabPage();
         grpImporteTotal = new GroupBox();
         txtImporteTotal = new TextBox();
         grpFechaVto = new GroupBox();
         dtpickerFechaVencimiento = new DateTimePicker();
         grpItemsFactura = new GroupBox();
         txtImporte09 = new TextBox();
         txtImporte08 = new TextBox();
         txtImporte07 = new TextBox();
         txtImporte06 = new TextBox();
         txtImporte05 = new TextBox();
         txtImporte04 = new TextBox();
         txtImporte03 = new TextBox();
         txtImporte02 = new TextBox();
         txtImporte01 = new TextBox();
         txtItem09 = new TextBox();
         txtItem08 = new TextBox();
         txtItem07 = new TextBox();
         txtItem06 = new TextBox();
         txtItem05 = new TextBox();
         txtItem04 = new TextBox();
         txtItem03 = new TextBox();
         txtItem02 = new TextBox();
         txtItem01 = new TextBox();
         grpEmpresa = new GroupBox();
         lblPos = new Label();
         txtCUIT = new TextBox();
         btnBuscarEmpresa = new Button();
         dgvEmpresa = new DataGridView();
         grpNumFactura = new GroupBox();
         lblNumFactura = new Label();
         btnValidarNumFactura = new Button();
         txtNumFactura = new TextBox();
         tabNotaCredito = new TabPage();
         groupBox1 = new GroupBox();
         txtImporteTotalNC = new TextBox();
         groupBox3 = new GroupBox();
         dtpickerFechaVencimientoNC = new DateTimePicker();
         groupBox4 = new GroupBox();
         btnCargarNotaCredito = new Button();
         txtImporteNC09 = new TextBox();
         txtImporteNC08 = new TextBox();
         txtImporteNC07 = new TextBox();
         txtImporteNC06 = new TextBox();
         txtImporteNC05 = new TextBox();
         txtImporteNC04 = new TextBox();
         txtImporteNC03 = new TextBox();
         txtImporteNC02 = new TextBox();
         txtImporteNC01 = new TextBox();
         txtItemNC09 = new TextBox();
         txtItemNC08 = new TextBox();
         txtItemNC07 = new TextBox();
         txtItemNC06 = new TextBox();
         txtItemNC05 = new TextBox();
         txtItemNC04 = new TextBox();
         txtItemNC03 = new TextBox();
         txtItemNC02 = new TextBox();
         txtItemNC01 = new TextBox();
         groupBox5 = new GroupBox();
         label1 = new Label();
         btnValidarNotaCredito = new Button();
         txtNotaCredito = new TextBox();
         grpNumeroFC = new GroupBox();
         label2 = new Label();
         btnValidarFacturaExistente = new Button();
         txtNumFacturaNC = new TextBox();
         btnCargando = new Button();
         tabTipoComprobante.SuspendLayout();
         tabFactura.SuspendLayout();
         grpImporteTotal.SuspendLayout();
         grpFechaVto.SuspendLayout();
         grpItemsFactura.SuspendLayout();
         grpEmpresa.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) dgvEmpresa).BeginInit();
         grpNumFactura.SuspendLayout();
         tabNotaCredito.SuspendLayout();
         groupBox1.SuspendLayout();
         groupBox3.SuspendLayout();
         groupBox4.SuspendLayout();
         groupBox5.SuspendLayout();
         grpNumeroFC.SuspendLayout();
         SuspendLayout();
         // 
         // btnCargarFactura
         // 
         btnCargarFactura.Anchor = AnchorStyles.Bottom;
         btnCargarFactura.Enabled = false;
         btnCargarFactura.Location = new Point(228, 602);
         btnCargarFactura.Name = "btnCargarFactura";
         btnCargarFactura.Size = new Size(107, 24);
         btnCargarFactura.TabIndex = 7;
         btnCargarFactura.Text = "&Cargar Factura";
         btnCargarFactura.UseVisualStyleBackColor = true;
         btnCargarFactura.Click += btnCargarFactura_Click;
         // 
         // tabTipoComprobante
         // 
         tabTipoComprobante.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         tabTipoComprobante.Controls.Add(tabFactura);
         tabTipoComprobante.Controls.Add(tabNotaCredito);
         tabTipoComprobante.Location = new Point(12, 12);
         tabTipoComprobante.Name = "tabTipoComprobante";
         tabTipoComprobante.SelectedIndex = 0;
         tabTipoComprobante.Size = new Size(573, 674);
         tabTipoComprobante.TabIndex = 8;
         // 
         // tabFactura
         // 
         tabFactura.Controls.Add(grpImporteTotal);
         tabFactura.Controls.Add(grpFechaVto);
         tabFactura.Controls.Add(btnCargarFactura);
         tabFactura.Controls.Add(grpItemsFactura);
         tabFactura.Controls.Add(grpEmpresa);
         tabFactura.Controls.Add(grpNumFactura);
         tabFactura.Location = new Point(4, 24);
         tabFactura.Name = "tabFactura";
         tabFactura.Padding = new Padding(3);
         tabFactura.Size = new Size(565, 646);
         tabFactura.TabIndex = 0;
         tabFactura.Text = "Factura";
         tabFactura.UseVisualStyleBackColor = true;
         // 
         // grpImporteTotal
         // 
         grpImporteTotal.Controls.Add(txtImporteTotal);
         grpImporteTotal.Enabled = false;
         grpImporteTotal.Location = new Point(293, 243);
         grpImporteTotal.Name = "grpImporteTotal";
         grpImporteTotal.Size = new Size(266, 59);
         grpImporteTotal.TabIndex = 6;
         grpImporteTotal.TabStop = false;
         grpImporteTotal.Text = "Importe Total";
         // 
         // txtImporteTotal
         // 
         txtImporteTotal.Location = new Point(19, 22);
         txtImporteTotal.MaxLength = 9;
         txtImporteTotal.Name = "txtImporteTotal";
         txtImporteTotal.PlaceholderText = "0";
         txtImporteTotal.Size = new Size(227, 23);
         txtImporteTotal.TabIndex = 0;
         txtImporteTotal.TextAlign = HorizontalAlignment.Right;
         txtImporteTotal.KeyPress += txtNumFactura_KeyPress;
         txtImporteTotal.Leave += txtImporteTotal_Leave;
         // 
         // grpFechaVto
         // 
         grpFechaVto.Controls.Add(dtpickerFechaVencimiento);
         grpFechaVto.Enabled = false;
         grpFechaVto.Location = new Point(6, 243);
         grpFechaVto.Name = "grpFechaVto";
         grpFechaVto.Size = new Size(266, 59);
         grpFechaVto.TabIndex = 6;
         grpFechaVto.TabStop = false;
         grpFechaVto.Text = "Fecha de vencimiento";
         // 
         // dtpickerFechaVencimiento
         // 
         dtpickerFechaVencimiento.Format = DateTimePickerFormat.Short;
         dtpickerFechaVencimiento.Location = new Point(19, 22);
         dtpickerFechaVencimiento.Name = "dtpickerFechaVencimiento";
         dtpickerFechaVencimiento.Size = new Size(227, 23);
         dtpickerFechaVencimiento.TabIndex = 0;
         dtpickerFechaVencimiento.ValueChanged += dtpickerFechaVencimiento_ValueChanged;
         dtpickerFechaVencimiento.Leave += dtpickerFechaVencimiento_Leave;
         // 
         // grpItemsFactura
         // 
         grpItemsFactura.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         grpItemsFactura.Controls.Add(txtImporte09);
         grpItemsFactura.Controls.Add(txtImporte08);
         grpItemsFactura.Controls.Add(txtImporte07);
         grpItemsFactura.Controls.Add(txtImporte06);
         grpItemsFactura.Controls.Add(txtImporte05);
         grpItemsFactura.Controls.Add(txtImporte04);
         grpItemsFactura.Controls.Add(txtImporte03);
         grpItemsFactura.Controls.Add(txtImporte02);
         grpItemsFactura.Controls.Add(txtImporte01);
         grpItemsFactura.Controls.Add(txtItem09);
         grpItemsFactura.Controls.Add(txtItem08);
         grpItemsFactura.Controls.Add(txtItem07);
         grpItemsFactura.Controls.Add(txtItem06);
         grpItemsFactura.Controls.Add(txtItem05);
         grpItemsFactura.Controls.Add(txtItem04);
         grpItemsFactura.Controls.Add(txtItem03);
         grpItemsFactura.Controls.Add(txtItem02);
         grpItemsFactura.Controls.Add(txtItem01);
         grpItemsFactura.Enabled = false;
         grpItemsFactura.Location = new Point(6, 308);
         grpItemsFactura.Name = "grpItemsFactura";
         grpItemsFactura.Size = new Size(553, 332);
         grpItemsFactura.TabIndex = 5;
         grpItemsFactura.TabStop = false;
         grpItemsFactura.Text = "Ítems";
         // 
         // txtImporte09
         // 
         txtImporte09.Enabled = false;
         txtImporte09.Location = new Point(438, 254);
         txtImporte09.Name = "txtImporte09";
         txtImporte09.Size = new Size(94, 23);
         txtImporte09.TabIndex = 23;
         // 
         // txtImporte08
         // 
         txtImporte08.Enabled = false;
         txtImporte08.Location = new Point(438, 225);
         txtImporte08.Name = "txtImporte08";
         txtImporte08.Size = new Size(94, 23);
         txtImporte08.TabIndex = 21;
         // 
         // txtImporte07
         // 
         txtImporte07.Enabled = false;
         txtImporte07.Location = new Point(438, 196);
         txtImporte07.Name = "txtImporte07";
         txtImporte07.Size = new Size(94, 23);
         txtImporte07.TabIndex = 19;
         // 
         // txtImporte06
         // 
         txtImporte06.Enabled = false;
         txtImporte06.Location = new Point(438, 167);
         txtImporte06.Name = "txtImporte06";
         txtImporte06.Size = new Size(94, 23);
         txtImporte06.TabIndex = 17;
         // 
         // txtImporte05
         // 
         txtImporte05.Enabled = false;
         txtImporte05.Location = new Point(438, 138);
         txtImporte05.Name = "txtImporte05";
         txtImporte05.Size = new Size(94, 23);
         txtImporte05.TabIndex = 15;
         // 
         // txtImporte04
         // 
         txtImporte04.Enabled = false;
         txtImporte04.Location = new Point(438, 109);
         txtImporte04.Name = "txtImporte04";
         txtImporte04.Size = new Size(94, 23);
         txtImporte04.TabIndex = 13;
         // 
         // txtImporte03
         // 
         txtImporte03.Enabled = false;
         txtImporte03.Location = new Point(438, 80);
         txtImporte03.Name = "txtImporte03";
         txtImporte03.Size = new Size(94, 23);
         txtImporte03.TabIndex = 11;
         // 
         // txtImporte02
         // 
         txtImporte02.Enabled = false;
         txtImporte02.Location = new Point(438, 51);
         txtImporte02.Name = "txtImporte02";
         txtImporte02.Size = new Size(94, 23);
         txtImporte02.TabIndex = 9;
         // 
         // txtImporte01
         // 
         txtImporte01.Enabled = false;
         txtImporte01.Location = new Point(438, 22);
         txtImporte01.Name = "txtImporte01";
         txtImporte01.Size = new Size(94, 23);
         txtImporte01.TabIndex = 7;
         // 
         // txtItem09
         // 
         txtItem09.Enabled = false;
         txtItem09.Location = new Point(19, 254);
         txtItem09.Name = "txtItem09";
         txtItem09.Size = new Size(392, 23);
         txtItem09.TabIndex = 22;
         // 
         // txtItem08
         // 
         txtItem08.Enabled = false;
         txtItem08.Location = new Point(19, 225);
         txtItem08.Name = "txtItem08";
         txtItem08.Size = new Size(392, 23);
         txtItem08.TabIndex = 20;
         // 
         // txtItem07
         // 
         txtItem07.Enabled = false;
         txtItem07.Location = new Point(19, 196);
         txtItem07.Name = "txtItem07";
         txtItem07.Size = new Size(392, 23);
         txtItem07.TabIndex = 18;
         // 
         // txtItem06
         // 
         txtItem06.Enabled = false;
         txtItem06.Location = new Point(19, 167);
         txtItem06.Name = "txtItem06";
         txtItem06.Size = new Size(392, 23);
         txtItem06.TabIndex = 16;
         // 
         // txtItem05
         // 
         txtItem05.Enabled = false;
         txtItem05.Location = new Point(19, 138);
         txtItem05.Name = "txtItem05";
         txtItem05.Size = new Size(392, 23);
         txtItem05.TabIndex = 14;
         // 
         // txtItem04
         // 
         txtItem04.Enabled = false;
         txtItem04.Location = new Point(19, 109);
         txtItem04.Name = "txtItem04";
         txtItem04.Size = new Size(392, 23);
         txtItem04.TabIndex = 12;
         // 
         // txtItem03
         // 
         txtItem03.Enabled = false;
         txtItem03.Location = new Point(19, 80);
         txtItem03.Name = "txtItem03";
         txtItem03.Size = new Size(392, 23);
         txtItem03.TabIndex = 10;
         // 
         // txtItem02
         // 
         txtItem02.Enabled = false;
         txtItem02.Location = new Point(19, 51);
         txtItem02.Name = "txtItem02";
         txtItem02.Size = new Size(392, 23);
         txtItem02.TabIndex = 8;
         // 
         // txtItem01
         // 
         txtItem01.Enabled = false;
         txtItem01.Location = new Point(19, 22);
         txtItem01.Name = "txtItem01";
         txtItem01.Size = new Size(392, 23);
         txtItem01.TabIndex = 6;
         // 
         // grpEmpresa
         // 
         grpEmpresa.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         grpEmpresa.Controls.Add(lblPos);
         grpEmpresa.Controls.Add(txtCUIT);
         grpEmpresa.Controls.Add(btnBuscarEmpresa);
         grpEmpresa.Controls.Add(dgvEmpresa);
         grpEmpresa.Enabled = false;
         grpEmpresa.Location = new Point(6, 77);
         grpEmpresa.Name = "grpEmpresa";
         grpEmpresa.Size = new Size(553, 160);
         grpEmpresa.TabIndex = 4;
         grpEmpresa.TabStop = false;
         grpEmpresa.Text = "Empresa";
         // 
         // lblPos
         // 
         lblPos.AutoSize = true;
         lblPos.BorderStyle = BorderStyle.FixedSingle;
         lblPos.Location = new Point(19, 25);
         lblPos.Name = "lblPos";
         lblPos.Size = new Size(2, 17);
         lblPos.TabIndex = 11;
         lblPos.Visible = false;
         // 
         // txtCUIT
         // 
         txtCUIT.Location = new Point(62, 22);
         txtCUIT.MaxLength = 11;
         txtCUIT.Name = "txtCUIT";
         txtCUIT.PlaceholderText = "Ej: 00000000000 (hasta 11 dígitos)";
         txtCUIT.Size = new Size(243, 23);
         txtCUIT.TabIndex = 4;
         txtCUIT.TextAlign = HorizontalAlignment.Right;
         txtCUIT.KeyDown += txtCUIT_KeyDown;
         txtCUIT.KeyPress += txtCUIT_KeyPress;
         // 
         // btnBuscarEmpresa
         // 
         btnBuscarEmpresa.Location = new Point(336, 22);
         btnBuscarEmpresa.Name = "btnBuscarEmpresa";
         btnBuscarEmpresa.Size = new Size(75, 23);
         btnBuscarEmpresa.TabIndex = 5;
         btnBuscarEmpresa.Text = "&Buscar";
         btnBuscarEmpresa.UseVisualStyleBackColor = true;
         btnBuscarEmpresa.Click += btnBuscarEmpresa_Click;
         // 
         // dgvEmpresa
         // 
         dgvEmpresa.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = Color.Firebrick;
         dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
         dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
         dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
         dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dgvEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvEmpresa.Location = new Point(19, 58);
         dgvEmpresa.Name = "dgvEmpresa";
         dgvEmpresa.RowTemplate.Height = 25;
         dgvEmpresa.Size = new Size(514, 86);
         dgvEmpresa.TabIndex = 10;
         // 
         // grpNumFactura
         // 
         grpNumFactura.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         grpNumFactura.Controls.Add(lblNumFactura);
         grpNumFactura.Controls.Add(btnValidarNumFactura);
         grpNumFactura.Controls.Add(txtNumFactura);
         grpNumFactura.Location = new Point(6, 6);
         grpNumFactura.Name = "grpNumFactura";
         grpNumFactura.Size = new Size(553, 61);
         grpNumFactura.TabIndex = 3;
         grpNumFactura.TabStop = false;
         grpNumFactura.Text = "Número";
         // 
         // lblNumFactura
         // 
         lblNumFactura.AutoSize = true;
         lblNumFactura.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
         lblNumFactura.Location = new Point(438, 24);
         lblNumFactura.Name = "lblNumFactura";
         lblNumFactura.Size = new Size(94, 19);
         lblNumFactura.TabIndex = 2;
         lblNumFactura.Text = "50000####";
         // 
         // btnValidarNumFactura
         // 
         btnValidarNumFactura.Location = new Point(336, 21);
         btnValidarNumFactura.Name = "btnValidarNumFactura";
         btnValidarNumFactura.Size = new Size(75, 23);
         btnValidarNumFactura.TabIndex = 1;
         btnValidarNumFactura.Text = "&Validar";
         btnValidarNumFactura.UseVisualStyleBackColor = true;
         btnValidarNumFactura.Click += btnValidarNumFactura_Click;
         // 
         // txtNumFactura
         // 
         txtNumFactura.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
         txtNumFactura.Location = new Point(62, 22);
         txtNumFactura.MaxLength = 9;
         txtNumFactura.Name = "txtNumFactura";
         txtNumFactura.PlaceholderText = "Ej: 000001234 (hasta 9 dígitos)";
         txtNumFactura.Size = new Size(243, 23);
         txtNumFactura.TabIndex = 0;
         txtNumFactura.TextAlign = HorizontalAlignment.Right;
         txtNumFactura.KeyDown += txtNumFactura_KeyDown;
         txtNumFactura.KeyPress += txtNumFactura_KeyPress;
         // 
         // tabNotaCredito
         // 
         tabNotaCredito.Controls.Add(groupBox1);
         tabNotaCredito.Controls.Add(groupBox3);
         tabNotaCredito.Controls.Add(groupBox4);
         tabNotaCredito.Controls.Add(groupBox5);
         tabNotaCredito.Controls.Add(grpNumeroFC);
         tabNotaCredito.Location = new Point(4, 24);
         tabNotaCredito.Name = "tabNotaCredito";
         tabNotaCredito.Padding = new Padding(3);
         tabNotaCredito.Size = new Size(565, 646);
         tabNotaCredito.TabIndex = 1;
         tabNotaCredito.Text = "Nota de Crédito";
         tabNotaCredito.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(txtImporteTotalNC);
         groupBox1.Location = new Point(293, 243);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new Size(266, 59);
         groupBox1.TabIndex = 10;
         groupBox1.TabStop = false;
         groupBox1.Text = "Importe Total";
         // 
         // txtImporteTotalNC
         // 
         txtImporteTotalNC.Location = new Point(19, 22);
         txtImporteTotalNC.MaxLength = 9;
         txtImporteTotalNC.Name = "txtImporteTotalNC";
         txtImporteTotalNC.PlaceholderText = "0";
         txtImporteTotalNC.Size = new Size(227, 23);
         txtImporteTotalNC.TabIndex = 0;
         txtImporteTotalNC.TextAlign = HorizontalAlignment.Right;
         // 
         // groupBox3
         // 
         groupBox3.Controls.Add(dtpickerFechaVencimientoNC);
         groupBox3.Location = new Point(6, 243);
         groupBox3.Name = "groupBox3";
         groupBox3.Size = new Size(266, 59);
         groupBox3.TabIndex = 11;
         groupBox3.TabStop = false;
         groupBox3.Text = "Fecha de vencimiento";
         // 
         // dtpickerFechaVencimientoNC
         // 
         dtpickerFechaVencimientoNC.Format = DateTimePickerFormat.Short;
         dtpickerFechaVencimientoNC.Location = new Point(19, 22);
         dtpickerFechaVencimientoNC.Name = "dtpickerFechaVencimientoNC";
         dtpickerFechaVencimientoNC.Size = new Size(227, 23);
         dtpickerFechaVencimientoNC.TabIndex = 0;
         // 
         // groupBox4
         // 
         groupBox4.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         groupBox4.Controls.Add(btnCargarNotaCredito);
         groupBox4.Controls.Add(txtImporteNC09);
         groupBox4.Controls.Add(txtImporteNC08);
         groupBox4.Controls.Add(txtImporteNC07);
         groupBox4.Controls.Add(txtImporteNC06);
         groupBox4.Controls.Add(txtImporteNC05);
         groupBox4.Controls.Add(txtImporteNC04);
         groupBox4.Controls.Add(txtImporteNC03);
         groupBox4.Controls.Add(txtImporteNC02);
         groupBox4.Controls.Add(txtImporteNC01);
         groupBox4.Controls.Add(txtItemNC09);
         groupBox4.Controls.Add(txtItemNC08);
         groupBox4.Controls.Add(txtItemNC07);
         groupBox4.Controls.Add(txtItemNC06);
         groupBox4.Controls.Add(txtItemNC05);
         groupBox4.Controls.Add(txtItemNC04);
         groupBox4.Controls.Add(txtItemNC03);
         groupBox4.Controls.Add(txtItemNC02);
         groupBox4.Controls.Add(txtItemNC01);
         groupBox4.Location = new Point(6, 308);
         groupBox4.Name = "groupBox4";
         groupBox4.Size = new Size(553, 332);
         groupBox4.TabIndex = 9;
         groupBox4.TabStop = false;
         groupBox4.Text = "Ítems";
         // 
         // btnCargarNotaCredito
         // 
         btnCargarNotaCredito.Enabled = false;
         btnCargarNotaCredito.Location = new Point(202, 294);
         btnCargarNotaCredito.Name = "btnCargarNotaCredito";
         btnCargarNotaCredito.Size = new Size(146, 24);
         btnCargarNotaCredito.TabIndex = 24;
         btnCargarNotaCredito.Text = "&Cargar Nota de Crédito";
         btnCargarNotaCredito.UseVisualStyleBackColor = true;
         // 
         // txtImporteNC09
         // 
         txtImporteNC09.Location = new Point(438, 254);
         txtImporteNC09.Name = "txtImporteNC09";
         txtImporteNC09.Size = new Size(94, 23);
         txtImporteNC09.TabIndex = 23;
         // 
         // txtImporteNC08
         // 
         txtImporteNC08.Location = new Point(438, 225);
         txtImporteNC08.Name = "txtImporteNC08";
         txtImporteNC08.Size = new Size(94, 23);
         txtImporteNC08.TabIndex = 21;
         // 
         // txtImporteNC07
         // 
         txtImporteNC07.Location = new Point(438, 196);
         txtImporteNC07.Name = "txtImporteNC07";
         txtImporteNC07.Size = new Size(94, 23);
         txtImporteNC07.TabIndex = 19;
         // 
         // txtImporteNC06
         // 
         txtImporteNC06.Location = new Point(438, 167);
         txtImporteNC06.Name = "txtImporteNC06";
         txtImporteNC06.Size = new Size(94, 23);
         txtImporteNC06.TabIndex = 17;
         // 
         // txtImporteNC05
         // 
         txtImporteNC05.Location = new Point(438, 138);
         txtImporteNC05.Name = "txtImporteNC05";
         txtImporteNC05.Size = new Size(94, 23);
         txtImporteNC05.TabIndex = 15;
         // 
         // txtImporteNC04
         // 
         txtImporteNC04.Location = new Point(438, 109);
         txtImporteNC04.Name = "txtImporteNC04";
         txtImporteNC04.Size = new Size(94, 23);
         txtImporteNC04.TabIndex = 13;
         // 
         // txtImporteNC03
         // 
         txtImporteNC03.Location = new Point(438, 80);
         txtImporteNC03.Name = "txtImporteNC03";
         txtImporteNC03.Size = new Size(94, 23);
         txtImporteNC03.TabIndex = 11;
         // 
         // txtImporteNC02
         // 
         txtImporteNC02.Location = new Point(438, 51);
         txtImporteNC02.Name = "txtImporteNC02";
         txtImporteNC02.Size = new Size(94, 23);
         txtImporteNC02.TabIndex = 9;
         // 
         // txtImporteNC01
         // 
         txtImporteNC01.Location = new Point(438, 22);
         txtImporteNC01.Name = "txtImporteNC01";
         txtImporteNC01.Size = new Size(94, 23);
         txtImporteNC01.TabIndex = 7;
         // 
         // txtItemNC09
         // 
         txtItemNC09.Location = new Point(19, 254);
         txtItemNC09.Name = "txtItemNC09";
         txtItemNC09.Size = new Size(392, 23);
         txtItemNC09.TabIndex = 22;
         // 
         // txtItemNC08
         // 
         txtItemNC08.Location = new Point(19, 225);
         txtItemNC08.Name = "txtItemNC08";
         txtItemNC08.Size = new Size(392, 23);
         txtItemNC08.TabIndex = 20;
         // 
         // txtItemNC07
         // 
         txtItemNC07.Location = new Point(19, 196);
         txtItemNC07.Name = "txtItemNC07";
         txtItemNC07.Size = new Size(392, 23);
         txtItemNC07.TabIndex = 18;
         // 
         // txtItemNC06
         // 
         txtItemNC06.Location = new Point(19, 167);
         txtItemNC06.Name = "txtItemNC06";
         txtItemNC06.Size = new Size(392, 23);
         txtItemNC06.TabIndex = 16;
         // 
         // txtItemNC05
         // 
         txtItemNC05.Location = new Point(19, 138);
         txtItemNC05.Name = "txtItemNC05";
         txtItemNC05.Size = new Size(392, 23);
         txtItemNC05.TabIndex = 14;
         // 
         // txtItemNC04
         // 
         txtItemNC04.Location = new Point(19, 109);
         txtItemNC04.Name = "txtItemNC04";
         txtItemNC04.Size = new Size(392, 23);
         txtItemNC04.TabIndex = 12;
         // 
         // txtItemNC03
         // 
         txtItemNC03.Location = new Point(19, 80);
         txtItemNC03.Name = "txtItemNC03";
         txtItemNC03.Size = new Size(392, 23);
         txtItemNC03.TabIndex = 10;
         // 
         // txtItemNC02
         // 
         txtItemNC02.Location = new Point(19, 51);
         txtItemNC02.Name = "txtItemNC02";
         txtItemNC02.Size = new Size(392, 23);
         txtItemNC02.TabIndex = 8;
         // 
         // txtItemNC01
         // 
         txtItemNC01.Location = new Point(19, 22);
         txtItemNC01.Name = "txtItemNC01";
         txtItemNC01.Size = new Size(392, 23);
         txtItemNC01.TabIndex = 6;
         // 
         // groupBox5
         // 
         groupBox5.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         groupBox5.Controls.Add(label1);
         groupBox5.Controls.Add(btnValidarNotaCredito);
         groupBox5.Controls.Add(txtNotaCredito);
         groupBox5.Location = new Point(6, 77);
         groupBox5.Name = "groupBox5";
         groupBox5.Size = new Size(553, 61);
         groupBox5.TabIndex = 7;
         groupBox5.TabStop = false;
         groupBox5.Text = "N° Nota Crédito";
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
         label1.Location = new Point(438, 24);
         label1.Name = "label1";
         label1.Size = new Size(94, 19);
         label1.TabIndex = 2;
         label1.Text = "50000####";
         // 
         // btnValidarNotaCredito
         // 
         btnValidarNotaCredito.Location = new Point(336, 21);
         btnValidarNotaCredito.Name = "btnValidarNotaCredito";
         btnValidarNotaCredito.Size = new Size(75, 23);
         btnValidarNotaCredito.TabIndex = 1;
         btnValidarNotaCredito.Text = "&Validar";
         btnValidarNotaCredito.UseVisualStyleBackColor = true;
         // 
         // txtNotaCredito
         // 
         txtNotaCredito.Location = new Point(62, 22);
         txtNotaCredito.MaxLength = 9;
         txtNotaCredito.Name = "txtNotaCredito";
         txtNotaCredito.PlaceholderText = "Ej: 000001234 (hasta 9 dígitos)";
         txtNotaCredito.Size = new Size(243, 23);
         txtNotaCredito.TabIndex = 0;
         txtNotaCredito.TextAlign = HorizontalAlignment.Right;
         // 
         // grpNumeroFC
         // 
         grpNumeroFC.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         grpNumeroFC.Controls.Add(label2);
         grpNumeroFC.Controls.Add(btnValidarFacturaExistente);
         grpNumeroFC.Controls.Add(txtNumFacturaNC);
         grpNumeroFC.Location = new Point(6, 6);
         grpNumeroFC.Name = "grpNumeroFC";
         grpNumeroFC.Size = new Size(553, 61);
         grpNumeroFC.TabIndex = 7;
         grpNumeroFC.TabStop = false;
         grpNumeroFC.Text = "N° Factura";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
         label2.Location = new Point(438, 24);
         label2.Name = "label2";
         label2.Size = new Size(94, 19);
         label2.TabIndex = 2;
         label2.Text = "50000####";
         // 
         // btnValidarFacturaExistente
         // 
         btnValidarFacturaExistente.Location = new Point(336, 21);
         btnValidarFacturaExistente.Name = "btnValidarFacturaExistente";
         btnValidarFacturaExistente.Size = new Size(75, 23);
         btnValidarFacturaExistente.TabIndex = 1;
         btnValidarFacturaExistente.Text = "&Validar";
         btnValidarFacturaExistente.UseVisualStyleBackColor = true;
         btnValidarFacturaExistente.Click += btnValidarFacturaExistente_Click;
         // 
         // txtNumFacturaNC
         // 
         txtNumFacturaNC.Location = new Point(62, 22);
         txtNumFacturaNC.MaxLength = 9;
         txtNumFacturaNC.Name = "txtNumFacturaNC";
         txtNumFacturaNC.PlaceholderText = "Ej: 000001234 (hasta 9 dígitos)";
         txtNumFacturaNC.Size = new Size(243, 23);
         txtNumFacturaNC.TabIndex = 0;
         txtNumFacturaNC.TextAlign = HorizontalAlignment.Right;
         // 
         // btnCargando
         // 
         btnCargando.Location = new Point(506, 6);
         btnCargando.Name = "btnCargando";
         btnCargando.Size = new Size(75, 23);
         btnCargando.TabIndex = 12;
         btnCargando.Text = "CARGAR";
         btnCargando.UseVisualStyleBackColor = true;
         btnCargando.Click += btnCargando_Click;
         // 
         // frmPrincipal
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(597, 698);
         Controls.Add(btnCargando);
         Controls.Add(tabTipoComprobante);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         Icon = (Icon) resources.GetObject("$this.Icon");
         KeyPreview = true;
         MaximizeBox = false;
         Name = "frmPrincipal";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Subir Comprobante (SIGEU) - UCEMA";
         Load += frmPrincipal_Load;
         KeyDown += frmPrincipal_KeyDown;
         tabTipoComprobante.ResumeLayout(false);
         tabFactura.ResumeLayout(false);
         grpImporteTotal.ResumeLayout(false);
         grpImporteTotal.PerformLayout();
         grpFechaVto.ResumeLayout(false);
         grpItemsFactura.ResumeLayout(false);
         grpItemsFactura.PerformLayout();
         grpEmpresa.ResumeLayout(false);
         grpEmpresa.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) dgvEmpresa).EndInit();
         grpNumFactura.ResumeLayout(false);
         grpNumFactura.PerformLayout();
         tabNotaCredito.ResumeLayout(false);
         groupBox1.ResumeLayout(false);
         groupBox1.PerformLayout();
         groupBox3.ResumeLayout(false);
         groupBox4.ResumeLayout(false);
         groupBox4.PerformLayout();
         groupBox5.ResumeLayout(false);
         groupBox5.PerformLayout();
         grpNumeroFC.ResumeLayout(false);
         grpNumeroFC.PerformLayout();
         ResumeLayout(false);
      }

      #endregion
      private OpenFileDialog dlgAbrirArchivo;
      private Button btnCargarFactura;
      private TabControl tabTipoComprobante;
      private TabPage tabFactura;
      private GroupBox grpItemsFactura;
      private TextBox txtImporte09;
      private TextBox txtImporte08;
      private TextBox txtImporte07;
      private TextBox txtImporte06;
      private TextBox txtImporte05;
      private TextBox txtImporte04;
      private TextBox txtImporte03;
      private TextBox txtImporte02;
      private TextBox txtImporte01;
      private TextBox txtItem09;
      private TextBox txtItem08;
      private TextBox txtItem07;
      private TextBox txtItem06;
      private TextBox txtItem05;
      private TextBox txtItem04;
      private TextBox txtItem03;
      private TextBox txtItem02;
      private TextBox txtItem01;
      private GroupBox grpEmpresa;
      private Label lblPos;
      private TextBox txtCUIT;
      private Button btnBuscarEmpresa;
      private DataGridView dgvEmpresa;
      private GroupBox grpNumFactura;
      private Label lblNumFactura;
      private Button btnValidarNumFactura;
      private TextBox txtNumFactura;
      private TabPage tabNotaCredito;
      private GroupBox grpFechaVto;
      private GroupBox grpImporteTotal;
      private DateTimePicker dtpickerFechaVencimiento;
      private TextBox txtImporteTotal;
      private GroupBox groupBox1;
      private TextBox txtImporteTotalNC;
      private GroupBox groupBox3;
      private DateTimePicker dtpickerFechaVencimientoNC;
      private GroupBox groupBox4;
      private TextBox txtImporteNC09;
      private TextBox txtImporteNC08;
      private TextBox txtImporteNC07;
      private TextBox txtImporteNC06;
      private TextBox txtImporteNC05;
      private TextBox txtImporteNC04;
      private TextBox txtImporteNC03;
      private TextBox txtImporteNC02;
      private TextBox txtImporteNC01;
      private TextBox txtItemNC09;
      private TextBox txtItemNC08;
      private TextBox txtItemNC07;
      private TextBox txtItemNC06;
      private TextBox txtItemNC05;
      private TextBox txtItemNC04;
      private TextBox txtItemNC03;
      private TextBox txtItemNC02;
      private TextBox txtItemNC01;
      private GroupBox grpNumeroFC;
      private Label label2;
      private Button btnValidarFacturaExistente;
      private TextBox txtNumFacturaNC;
      private Button btnCargarNotaCredito;
      private GroupBox groupBox5;
      private Label label1;
      private Button btnValidarNotaCredito;
      private TextBox txtNotaCredito;
      private Button btnCargando;
   }
}