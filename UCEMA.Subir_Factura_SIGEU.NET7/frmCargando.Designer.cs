namespace UCEMA.Subir_Factura_SIGEU.NET7
{
   partial class frmCargando
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
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
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         picLoading = new PictureBox();
         ((System.ComponentModel.ISupportInitialize) picLoading).BeginInit();
         SuspendLayout();
         // 
         // picLoading
         // 
         picLoading.Anchor = AnchorStyles.None;
         picLoading.Image = Properties.Resources.loading;
         picLoading.Location = new Point(64, 64);
         picLoading.Name = "picLoading";
         picLoading.Size = new Size(128, 128);
         picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
         picLoading.TabIndex = 2;
         picLoading.TabStop = false;
         // 
         // frmCargando
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(256, 256);
         ControlBox = false;
         Controls.Add(picLoading);
         FormBorderStyle = FormBorderStyle.FixedSingle;
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmCargando";
         SizeGripStyle = SizeGripStyle.Hide;
         StartPosition = FormStartPosition.CenterParent;
         Text = "Cargando...";
         TopMost = true;
         ((System.ComponentModel.ISupportInitialize) picLoading).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private PictureBox picLoading;
   }
}