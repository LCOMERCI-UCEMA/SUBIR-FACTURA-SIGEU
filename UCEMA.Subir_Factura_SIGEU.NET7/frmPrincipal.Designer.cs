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
         btnCargarFactura = new Button();
         tabTipoComprobante = new TabControl();
         tabFactura = new TabPage();
         grpImporteTotal = new GroupBox();
         txtImporteTotal = new TextBox();
         grpFechaVto = new GroupBox();
         dtpickerFechaVencimiento = new DateTimePicker();
         grpItemsFactura = new GroupBox();
         dgvCargarFactura = new DataGridView();
         lblImporteCalculadoFC = new Label();
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
         grpImporteTotalNC = new GroupBox();
         txtImporteTotalNC = new TextBox();
         grpFechaVtoNC = new GroupBox();
         dtpickerFechaVtoNC = new DateTimePicker();
         grpItemsNC = new GroupBox();
         lblImporteCalculadoNC = new Label();
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
         grpNumeroNC = new GroupBox();
         lblNumeroNC = new Label();
         btnValidarNotaCredito = new Button();
         txtNotaCredito = new TextBox();
         grpNumeroFC = new GroupBox();
         lblNumFacturaNC = new Label();
         btnValidarFacturaExistente = new Button();
         txtNumFacturaNC = new TextBox();
         btnCargando = new Button();
         statusbar = new StatusStrip();
         lblStatusInformation = new ToolStripStatusLabel();
         tabTipoComprobante.SuspendLayout();
         tabFactura.SuspendLayout();
         grpImporteTotal.SuspendLayout();
         grpFechaVto.SuspendLayout();
         grpItemsFactura.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) dgvCargarFactura).BeginInit();
         grpEmpresa.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) dgvEmpresa).BeginInit();
         grpNumFactura.SuspendLayout();
         tabNotaCredito.SuspendLayout();
         grpImporteTotalNC.SuspendLayout();
         grpFechaVtoNC.SuspendLayout();
         grpItemsNC.SuspendLayout();
         grpNumeroNC.SuspendLayout();
         grpNumeroFC.SuspendLayout();
         statusbar.SuspendLayout();
         SuspendLayout();
         // 
         // btnCargarFactura
         // 
         btnCargarFactura.Anchor = AnchorStyles.Bottom;
         btnCargarFactura.Enabled = false;
         btnCargarFactura.Location = new Point(228, 675);
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
         tabTipoComprobante.Size = new Size(573, 747);
         tabTipoComprobante.TabIndex = 0;
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
         tabFactura.Size = new Size(565, 719);
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
         grpImporteTotal.TabIndex = 3;
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
         txtImporteTotal.TextChanged += txtImporteTotal_TextChanged;
         txtImporteTotal.KeyPress += txtImporteTotal_KeyPress;
         txtImporteTotal.Leave += txtImporteTotal_Leave;
         // 
         // grpFechaVto
         // 
         grpFechaVto.Controls.Add(dtpickerFechaVencimiento);
         grpFechaVto.Enabled = false;
         grpFechaVto.Location = new Point(6, 243);
         grpFechaVto.Name = "grpFechaVto";
         grpFechaVto.Size = new Size(266, 59);
         grpFechaVto.TabIndex = 2;
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
         grpItemsFactura.Controls.Add(dgvCargarFactura);
         grpItemsFactura.Controls.Add(lblImporteCalculadoFC);
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
         grpItemsFactura.Size = new Size(553, 405);
         grpItemsFactura.TabIndex = 4;
         grpItemsFactura.TabStop = false;
         grpItemsFactura.Tag = "FC";
         grpItemsFactura.Text = "Ítems";
         // 
         // dgvCargarFactura
         // 
         dgvCargarFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvCargarFactura.Location = new Point(19, 292);
         dgvCargarFactura.Name = "dgvCargarFactura";
         dgvCargarFactura.RowTemplate.Height = 25;
         dgvCargarFactura.Size = new Size(513, 66);
         dgvCargarFactura.TabIndex = 25;
         // 
         // lblImporteCalculadoFC
         // 
         lblImporteCalculadoFC.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
         lblImporteCalculadoFC.BorderStyle = BorderStyle.FixedSingle;
         lblImporteCalculadoFC.ForeColor = SystemColors.ControlText;
         lblImporteCalculadoFC.Location = new Point(438, 367);
         lblImporteCalculadoFC.Name = "lblImporteCalculadoFC";
         lblImporteCalculadoFC.Size = new Size(94, 24);
         lblImporteCalculadoFC.TabIndex = 24;
         lblImporteCalculadoFC.Text = "0";
         lblImporteCalculadoFC.TextAlign = ContentAlignment.MiddleRight;
         // 
         // txtImporte09
         // 
         txtImporte09.BorderStyle = BorderStyle.FixedSingle;
         txtImporte09.Enabled = false;
         txtImporte09.Location = new Point(438, 254);
         txtImporte09.Name = "txtImporte09";
         txtImporte09.Size = new Size(94, 23);
         txtImporte09.TabIndex = 23;
         txtImporte09.Tag = "importe";
         txtImporte09.TextChanged += ItemImporte_TextChanged;
         txtImporte09.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte08
         // 
         txtImporte08.BorderStyle = BorderStyle.FixedSingle;
         txtImporte08.Enabled = false;
         txtImporte08.Location = new Point(438, 225);
         txtImporte08.Name = "txtImporte08";
         txtImporte08.Size = new Size(94, 23);
         txtImporte08.TabIndex = 21;
         txtImporte08.Tag = "importe";
         txtImporte08.TextChanged += ItemImporte_TextChanged;
         txtImporte08.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte07
         // 
         txtImporte07.BorderStyle = BorderStyle.FixedSingle;
         txtImporte07.Enabled = false;
         txtImporte07.Location = new Point(438, 196);
         txtImporte07.Name = "txtImporte07";
         txtImporte07.Size = new Size(94, 23);
         txtImporte07.TabIndex = 19;
         txtImporte07.Tag = "importe";
         txtImporte07.TextChanged += ItemImporte_TextChanged;
         txtImporte07.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte06
         // 
         txtImporte06.BorderStyle = BorderStyle.FixedSingle;
         txtImporte06.Enabled = false;
         txtImporte06.Location = new Point(438, 167);
         txtImporte06.Name = "txtImporte06";
         txtImporte06.Size = new Size(94, 23);
         txtImporte06.TabIndex = 17;
         txtImporte06.Tag = "importe";
         txtImporte06.TextChanged += ItemImporte_TextChanged;
         txtImporte06.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte05
         // 
         txtImporte05.BorderStyle = BorderStyle.FixedSingle;
         txtImporte05.Enabled = false;
         txtImporte05.Location = new Point(438, 138);
         txtImporte05.Name = "txtImporte05";
         txtImporte05.Size = new Size(94, 23);
         txtImporte05.TabIndex = 15;
         txtImporte05.Tag = "importe";
         txtImporte05.TextChanged += ItemImporte_TextChanged;
         txtImporte05.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte04
         // 
         txtImporte04.BorderStyle = BorderStyle.FixedSingle;
         txtImporte04.Enabled = false;
         txtImporte04.Location = new Point(438, 109);
         txtImporte04.Name = "txtImporte04";
         txtImporte04.Size = new Size(94, 23);
         txtImporte04.TabIndex = 13;
         txtImporte04.Tag = "importe";
         txtImporte04.TextChanged += ItemImporte_TextChanged;
         txtImporte04.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte03
         // 
         txtImporte03.BorderStyle = BorderStyle.FixedSingle;
         txtImporte03.Enabled = false;
         txtImporte03.Location = new Point(438, 80);
         txtImporte03.Name = "txtImporte03";
         txtImporte03.Size = new Size(94, 23);
         txtImporte03.TabIndex = 11;
         txtImporte03.Tag = "importe";
         txtImporte03.TextChanged += ItemImporte_TextChanged;
         txtImporte03.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte02
         // 
         txtImporte02.BorderStyle = BorderStyle.FixedSingle;
         txtImporte02.Enabled = false;
         txtImporte02.Location = new Point(438, 51);
         txtImporte02.Name = "txtImporte02";
         txtImporte02.Size = new Size(94, 23);
         txtImporte02.TabIndex = 9;
         txtImporte02.Tag = "importe";
         txtImporte02.TextChanged += ItemImporte_TextChanged;
         txtImporte02.KeyPress += ItemImporte_KeyPress;
         // 
         // txtImporte01
         // 
         txtImporte01.BorderStyle = BorderStyle.FixedSingle;
         txtImporte01.Enabled = false;
         txtImporte01.Location = new Point(438, 22);
         txtImporte01.Name = "txtImporte01";
         txtImporte01.Size = new Size(94, 23);
         txtImporte01.TabIndex = 7;
         txtImporte01.Tag = "importe";
         txtImporte01.TextChanged += ItemImporte_TextChanged;
         txtImporte01.KeyPress += ItemImporte_KeyPress;
         // 
         // txtItem09
         // 
         txtItem09.Enabled = false;
         txtItem09.Location = new Point(19, 254);
         txtItem09.Name = "txtItem09";
         txtItem09.Size = new Size(392, 23);
         txtItem09.TabIndex = 22;
         txtItem09.Tag = "descripcion";
         txtItem09.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem08
         // 
         txtItem08.Enabled = false;
         txtItem08.Location = new Point(19, 225);
         txtItem08.Name = "txtItem08";
         txtItem08.Size = new Size(392, 23);
         txtItem08.TabIndex = 20;
         txtItem08.Tag = "descripcion";
         txtItem08.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem07
         // 
         txtItem07.Enabled = false;
         txtItem07.Location = new Point(19, 196);
         txtItem07.Name = "txtItem07";
         txtItem07.Size = new Size(392, 23);
         txtItem07.TabIndex = 18;
         txtItem07.Tag = "descripcion";
         txtItem07.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem06
         // 
         txtItem06.Enabled = false;
         txtItem06.Location = new Point(19, 167);
         txtItem06.Name = "txtItem06";
         txtItem06.Size = new Size(392, 23);
         txtItem06.TabIndex = 16;
         txtItem06.Tag = "descripcion";
         txtItem06.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem05
         // 
         txtItem05.Enabled = false;
         txtItem05.Location = new Point(19, 138);
         txtItem05.Name = "txtItem05";
         txtItem05.Size = new Size(392, 23);
         txtItem05.TabIndex = 14;
         txtItem05.Tag = "descripcion";
         txtItem05.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem04
         // 
         txtItem04.Enabled = false;
         txtItem04.Location = new Point(19, 109);
         txtItem04.Name = "txtItem04";
         txtItem04.Size = new Size(392, 23);
         txtItem04.TabIndex = 12;
         txtItem04.Tag = "descripcion";
         txtItem04.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem03
         // 
         txtItem03.Enabled = false;
         txtItem03.Location = new Point(19, 80);
         txtItem03.Name = "txtItem03";
         txtItem03.Size = new Size(392, 23);
         txtItem03.TabIndex = 10;
         txtItem03.Tag = "descripcion";
         txtItem03.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem02
         // 
         txtItem02.Enabled = false;
         txtItem02.Location = new Point(19, 51);
         txtItem02.Name = "txtItem02";
         txtItem02.Size = new Size(392, 23);
         txtItem02.TabIndex = 8;
         txtItem02.Tag = "descripcion";
         txtItem02.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItem01
         // 
         txtItem01.Enabled = false;
         txtItem01.Location = new Point(19, 22);
         txtItem01.Name = "txtItem01";
         txtItem01.Size = new Size(392, 23);
         txtItem01.TabIndex = 0;
         txtItem01.Tag = "descripcion";
         txtItem01.TextChanged += ItemDescripcion_TextChanged;
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
         grpEmpresa.TabIndex = 1;
         grpEmpresa.TabStop = false;
         grpEmpresa.Text = "CUIT Empresa";
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
         txtCUIT.TabIndex = 0;
         txtCUIT.TextAlign = HorizontalAlignment.Right;
         txtCUIT.KeyDown += txtCUIT_KeyDown;
         txtCUIT.KeyPress += txtCUIT_KeyPress;
         // 
         // btnBuscarEmpresa
         // 
         btnBuscarEmpresa.Location = new Point(336, 22);
         btnBuscarEmpresa.Name = "btnBuscarEmpresa";
         btnBuscarEmpresa.Size = new Size(75, 23);
         btnBuscarEmpresa.TabIndex = 1;
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
         dgvEmpresa.Location = new Point(19, 59);
         dgvEmpresa.Name = "dgvEmpresa";
         dgvEmpresa.RowTemplate.Height = 25;
         dgvEmpresa.Size = new Size(514, 85);
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
         grpNumFactura.TabIndex = 0;
         grpNumFactura.TabStop = false;
         grpNumFactura.Text = "N° Factura";
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
         tabNotaCredito.Controls.Add(grpImporteTotalNC);
         tabNotaCredito.Controls.Add(grpFechaVtoNC);
         tabNotaCredito.Controls.Add(grpItemsNC);
         tabNotaCredito.Controls.Add(grpNumeroNC);
         tabNotaCredito.Controls.Add(grpNumeroFC);
         tabNotaCredito.Location = new Point(4, 24);
         tabNotaCredito.Name = "tabNotaCredito";
         tabNotaCredito.Padding = new Padding(3);
         tabNotaCredito.Size = new Size(565, 719);
         tabNotaCredito.TabIndex = 1;
         tabNotaCredito.Text = "Nota de Crédito";
         tabNotaCredito.UseVisualStyleBackColor = true;
         // 
         // grpImporteTotalNC
         // 
         grpImporteTotalNC.Controls.Add(txtImporteTotalNC);
         grpImporteTotalNC.Enabled = false;
         grpImporteTotalNC.Location = new Point(293, 243);
         grpImporteTotalNC.Name = "grpImporteTotalNC";
         grpImporteTotalNC.Size = new Size(266, 59);
         grpImporteTotalNC.TabIndex = 3;
         grpImporteTotalNC.TabStop = false;
         grpImporteTotalNC.Text = "Importe Total";
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
         txtImporteTotalNC.TextChanged += txtImporteTotalNC_TextChanged;
         txtImporteTotalNC.KeyPress += txtImporteTotalNC_KeyPress;
         txtImporteTotalNC.Leave += txtImporteTotalNC_Leave;
         // 
         // grpFechaVtoNC
         // 
         grpFechaVtoNC.Controls.Add(dtpickerFechaVtoNC);
         grpFechaVtoNC.Enabled = false;
         grpFechaVtoNC.Location = new Point(6, 243);
         grpFechaVtoNC.Name = "grpFechaVtoNC";
         grpFechaVtoNC.Size = new Size(266, 59);
         grpFechaVtoNC.TabIndex = 2;
         grpFechaVtoNC.TabStop = false;
         grpFechaVtoNC.Text = "Fecha de vencimiento";
         // 
         // dtpickerFechaVtoNC
         // 
         dtpickerFechaVtoNC.Format = DateTimePickerFormat.Short;
         dtpickerFechaVtoNC.Location = new Point(19, 22);
         dtpickerFechaVtoNC.Name = "dtpickerFechaVtoNC";
         dtpickerFechaVtoNC.Size = new Size(227, 23);
         dtpickerFechaVtoNC.TabIndex = 0;
         dtpickerFechaVtoNC.ValueChanged += dtpickerFechaVtoNC_ValueChanged;
         dtpickerFechaVtoNC.Leave += dtpickerFechaVtoNC_Leave;
         // 
         // grpItemsNC
         // 
         grpItemsNC.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
         grpItemsNC.Controls.Add(lblImporteCalculadoNC);
         grpItemsNC.Controls.Add(btnCargarNotaCredito);
         grpItemsNC.Controls.Add(txtImporteNC09);
         grpItemsNC.Controls.Add(txtImporteNC08);
         grpItemsNC.Controls.Add(txtImporteNC07);
         grpItemsNC.Controls.Add(txtImporteNC06);
         grpItemsNC.Controls.Add(txtImporteNC05);
         grpItemsNC.Controls.Add(txtImporteNC04);
         grpItemsNC.Controls.Add(txtImporteNC03);
         grpItemsNC.Controls.Add(txtImporteNC02);
         grpItemsNC.Controls.Add(txtImporteNC01);
         grpItemsNC.Controls.Add(txtItemNC09);
         grpItemsNC.Controls.Add(txtItemNC08);
         grpItemsNC.Controls.Add(txtItemNC07);
         grpItemsNC.Controls.Add(txtItemNC06);
         grpItemsNC.Controls.Add(txtItemNC05);
         grpItemsNC.Controls.Add(txtItemNC04);
         grpItemsNC.Controls.Add(txtItemNC03);
         grpItemsNC.Controls.Add(txtItemNC02);
         grpItemsNC.Controls.Add(txtItemNC01);
         grpItemsNC.Enabled = false;
         grpItemsNC.Location = new Point(6, 308);
         grpItemsNC.Name = "grpItemsNC";
         grpItemsNC.Size = new Size(553, 329);
         grpItemsNC.TabIndex = 4;
         grpItemsNC.TabStop = false;
         grpItemsNC.Tag = "NC";
         grpItemsNC.Text = "Ítems";
         // 
         // lblImporteCalculadoNC
         // 
         lblImporteCalculadoNC.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
         lblImporteCalculadoNC.AutoSize = true;
         lblImporteCalculadoNC.Location = new Point(519, 294);
         lblImporteCalculadoNC.Name = "lblImporteCalculadoNC";
         lblImporteCalculadoNC.Size = new Size(13, 15);
         lblImporteCalculadoNC.TabIndex = 25;
         lblImporteCalculadoNC.Text = "0";
         lblImporteCalculadoNC.TextAlign = ContentAlignment.TopRight;
         // 
         // btnCargarNotaCredito
         // 
         btnCargarNotaCredito.Enabled = false;
         btnCargarNotaCredito.Location = new Point(202, 294);
         btnCargarNotaCredito.Name = "btnCargarNotaCredito";
         btnCargarNotaCredito.Size = new Size(146, 24);
         btnCargarNotaCredito.TabIndex = 18;
         btnCargarNotaCredito.Text = "&Cargar Nota de Crédito";
         btnCargarNotaCredito.UseVisualStyleBackColor = true;
         btnCargarNotaCredito.Click += btnCargarNotaCredito_Click;
         // 
         // txtImporteNC09
         // 
         txtImporteNC09.Location = new Point(438, 254);
         txtImporteNC09.Name = "txtImporteNC09";
         txtImporteNC09.Size = new Size(94, 23);
         txtImporteNC09.TabIndex = 17;
         txtImporteNC09.Tag = "importe";
         txtImporteNC09.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC08
         // 
         txtImporteNC08.Location = new Point(438, 225);
         txtImporteNC08.Name = "txtImporteNC08";
         txtImporteNC08.Size = new Size(94, 23);
         txtImporteNC08.TabIndex = 15;
         txtImporteNC08.Tag = "importe";
         txtImporteNC08.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC07
         // 
         txtImporteNC07.Location = new Point(438, 196);
         txtImporteNC07.Name = "txtImporteNC07";
         txtImporteNC07.Size = new Size(94, 23);
         txtImporteNC07.TabIndex = 13;
         txtImporteNC07.Tag = "importe";
         txtImporteNC07.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC06
         // 
         txtImporteNC06.Location = new Point(438, 167);
         txtImporteNC06.Name = "txtImporteNC06";
         txtImporteNC06.Size = new Size(94, 23);
         txtImporteNC06.TabIndex = 11;
         txtImporteNC06.Tag = "importe";
         txtImporteNC06.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC05
         // 
         txtImporteNC05.Location = new Point(438, 138);
         txtImporteNC05.Name = "txtImporteNC05";
         txtImporteNC05.Size = new Size(94, 23);
         txtImporteNC05.TabIndex = 9;
         txtImporteNC05.Tag = "importe";
         txtImporteNC05.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC04
         // 
         txtImporteNC04.Location = new Point(438, 109);
         txtImporteNC04.Name = "txtImporteNC04";
         txtImporteNC04.Size = new Size(94, 23);
         txtImporteNC04.TabIndex = 7;
         txtImporteNC04.Tag = "importe";
         txtImporteNC04.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC03
         // 
         txtImporteNC03.Location = new Point(438, 80);
         txtImporteNC03.Name = "txtImporteNC03";
         txtImporteNC03.Size = new Size(94, 23);
         txtImporteNC03.TabIndex = 5;
         txtImporteNC03.Tag = "importe";
         txtImporteNC03.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC02
         // 
         txtImporteNC02.Location = new Point(438, 51);
         txtImporteNC02.Name = "txtImporteNC02";
         txtImporteNC02.Size = new Size(94, 23);
         txtImporteNC02.TabIndex = 3;
         txtImporteNC02.Tag = "importe";
         txtImporteNC02.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtImporteNC01
         // 
         txtImporteNC01.Location = new Point(438, 22);
         txtImporteNC01.Name = "txtImporteNC01";
         txtImporteNC01.Size = new Size(94, 23);
         txtImporteNC01.TabIndex = 1;
         txtImporteNC01.Tag = "importe";
         txtImporteNC01.TextChanged += ItemImporteNC_TextChanged;
         // 
         // txtItemNC09
         // 
         txtItemNC09.Location = new Point(19, 254);
         txtItemNC09.Name = "txtItemNC09";
         txtItemNC09.Size = new Size(392, 23);
         txtItemNC09.TabIndex = 16;
         txtItemNC09.Tag = "descripcion";
         txtItemNC09.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC08
         // 
         txtItemNC08.Location = new Point(19, 225);
         txtItemNC08.Name = "txtItemNC08";
         txtItemNC08.Size = new Size(392, 23);
         txtItemNC08.TabIndex = 14;
         txtItemNC08.Tag = "descripcion";
         txtItemNC08.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC07
         // 
         txtItemNC07.Location = new Point(19, 196);
         txtItemNC07.Name = "txtItemNC07";
         txtItemNC07.Size = new Size(392, 23);
         txtItemNC07.TabIndex = 12;
         txtItemNC07.Tag = "descripcion";
         txtItemNC07.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC06
         // 
         txtItemNC06.Location = new Point(19, 167);
         txtItemNC06.Name = "txtItemNC06";
         txtItemNC06.Size = new Size(392, 23);
         txtItemNC06.TabIndex = 10;
         txtItemNC06.Tag = "descripcion";
         txtItemNC06.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC05
         // 
         txtItemNC05.Location = new Point(19, 138);
         txtItemNC05.Name = "txtItemNC05";
         txtItemNC05.Size = new Size(392, 23);
         txtItemNC05.TabIndex = 8;
         txtItemNC05.Tag = "descripcion";
         txtItemNC05.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC04
         // 
         txtItemNC04.Location = new Point(19, 109);
         txtItemNC04.Name = "txtItemNC04";
         txtItemNC04.Size = new Size(392, 23);
         txtItemNC04.TabIndex = 6;
         txtItemNC04.Tag = "descripcion";
         txtItemNC04.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC03
         // 
         txtItemNC03.Location = new Point(19, 80);
         txtItemNC03.Name = "txtItemNC03";
         txtItemNC03.Size = new Size(392, 23);
         txtItemNC03.TabIndex = 4;
         txtItemNC03.Tag = "descripcion";
         txtItemNC03.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC02
         // 
         txtItemNC02.Location = new Point(19, 51);
         txtItemNC02.Name = "txtItemNC02";
         txtItemNC02.Size = new Size(392, 23);
         txtItemNC02.TabIndex = 2;
         txtItemNC02.Tag = "descripcion";
         txtItemNC02.TextChanged += ItemDescripcion_TextChanged;
         // 
         // txtItemNC01
         // 
         txtItemNC01.Location = new Point(19, 22);
         txtItemNC01.Name = "txtItemNC01";
         txtItemNC01.Size = new Size(392, 23);
         txtItemNC01.TabIndex = 0;
         txtItemNC01.Tag = "descripcion";
         txtItemNC01.TextChanged += ItemDescripcion_TextChanged;
         // 
         // grpNumeroNC
         // 
         grpNumeroNC.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         grpNumeroNC.Controls.Add(lblNumeroNC);
         grpNumeroNC.Controls.Add(btnValidarNotaCredito);
         grpNumeroNC.Controls.Add(txtNotaCredito);
         grpNumeroNC.Enabled = false;
         grpNumeroNC.Location = new Point(6, 77);
         grpNumeroNC.Name = "grpNumeroNC";
         grpNumeroNC.Size = new Size(553, 61);
         grpNumeroNC.TabIndex = 1;
         grpNumeroNC.TabStop = false;
         grpNumeroNC.Text = "N° Nota Crédito";
         // 
         // lblNumeroNC
         // 
         lblNumeroNC.AutoSize = true;
         lblNumeroNC.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
         lblNumeroNC.Location = new Point(438, 24);
         lblNumeroNC.Name = "lblNumeroNC";
         lblNumeroNC.Size = new Size(94, 19);
         lblNumeroNC.TabIndex = 2;
         lblNumeroNC.Text = "50000####";
         // 
         // btnValidarNotaCredito
         // 
         btnValidarNotaCredito.Location = new Point(336, 21);
         btnValidarNotaCredito.Name = "btnValidarNotaCredito";
         btnValidarNotaCredito.Size = new Size(75, 23);
         btnValidarNotaCredito.TabIndex = 1;
         btnValidarNotaCredito.Text = "&Validar";
         btnValidarNotaCredito.UseVisualStyleBackColor = true;
         btnValidarNotaCredito.Click += btnValidarNotaCredito_Click;
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
         txtNotaCredito.KeyDown += txtNotaCredito_KeyDown;
         txtNotaCredito.KeyPress += txtNotaCredito_KeyPress;
         // 
         // grpNumeroFC
         // 
         grpNumeroFC.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
         grpNumeroFC.Controls.Add(lblNumFacturaNC);
         grpNumeroFC.Controls.Add(btnValidarFacturaExistente);
         grpNumeroFC.Controls.Add(txtNumFacturaNC);
         grpNumeroFC.Location = new Point(6, 6);
         grpNumeroFC.Name = "grpNumeroFC";
         grpNumeroFC.Size = new Size(553, 61);
         grpNumeroFC.TabIndex = 0;
         grpNumeroFC.TabStop = false;
         grpNumeroFC.Text = "N° Factura";
         // 
         // lblNumFacturaNC
         // 
         lblNumFacturaNC.AutoSize = true;
         lblNumFacturaNC.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
         lblNumFacturaNC.Location = new Point(438, 24);
         lblNumFacturaNC.Name = "lblNumFacturaNC";
         lblNumFacturaNC.Size = new Size(94, 19);
         lblNumFacturaNC.TabIndex = 2;
         lblNumFacturaNC.Text = "50000####";
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
         txtNumFacturaNC.KeyDown += txtNumFacturaNC_KeyDown;
         txtNumFacturaNC.KeyPress += txtNumFacturaNC_KeyPress;
         // 
         // btnCargando
         // 
         btnCargando.Location = new Point(506, 6);
         btnCargando.Name = "btnCargando";
         btnCargando.Size = new Size(75, 23);
         btnCargando.TabIndex = 12;
         btnCargando.Text = "CARGAR";
         btnCargando.UseVisualStyleBackColor = true;
         btnCargando.Visible = false;
         btnCargando.Click += btnCargando_Click;
         // 
         // statusbar
         // 
         statusbar.Items.AddRange(new ToolStripItem[] { lblStatusInformation });
         statusbar.Location = new Point(0, 780);
         statusbar.Name = "statusbar";
         statusbar.Size = new Size(597, 22);
         statusbar.SizingGrip = false;
         statusbar.TabIndex = 13;
         // 
         // lblStatusInformation
         // 
         lblStatusInformation.Name = "lblStatusInformation";
         lblStatusInformation.Size = new Size(0, 17);
         // 
         // frmPrincipal
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(597, 802);
         Controls.Add(statusbar);
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
         ((System.ComponentModel.ISupportInitialize) dgvCargarFactura).EndInit();
         grpEmpresa.ResumeLayout(false);
         grpEmpresa.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) dgvEmpresa).EndInit();
         grpNumFactura.ResumeLayout(false);
         grpNumFactura.PerformLayout();
         tabNotaCredito.ResumeLayout(false);
         grpImporteTotalNC.ResumeLayout(false);
         grpImporteTotalNC.PerformLayout();
         grpFechaVtoNC.ResumeLayout(false);
         grpItemsNC.ResumeLayout(false);
         grpItemsNC.PerformLayout();
         grpNumeroNC.ResumeLayout(false);
         grpNumeroNC.PerformLayout();
         grpNumeroFC.ResumeLayout(false);
         grpNumeroFC.PerformLayout();
         statusbar.ResumeLayout(false);
         statusbar.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
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
      private GroupBox grpImporteTotalNC;
      private TextBox txtImporteTotalNC;
      private GroupBox grpFechaVtoNC;
      private DateTimePicker dtpickerFechaVtoNC;
      private GroupBox grpItemsNC;
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
      private Label lblNumFacturaNC;
      private Button btnValidarFacturaExistente;
      private TextBox txtNumFacturaNC;
      private Button btnCargarNotaCredito;
      private GroupBox grpNumeroNC;
      private Label lblNumeroNC;
      private Button btnValidarNotaCredito;
      private TextBox txtNotaCredito;
      private Button btnCargando;
      private StatusStrip statusbar;
      private ToolStripStatusLabel lblStatusInformation;
      private Label lblImporteCalculadoFC;
      private Label lblImporteCalculadoNC;
      private DataGridView dgvCargarFactura;
   }
}