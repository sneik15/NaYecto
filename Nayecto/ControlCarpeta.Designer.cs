namespace Nayecto
{
    partial class ControlCarpeta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnCarpeta = new System.Windows.Forms.Panel();
            this.ImgCarpeta = new System.Windows.Forms.PictureBox();
            this.Nomcarpeta = new System.Windows.Forms.Label();
            this.PnCarpeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCarpeta)).BeginInit();
            this.SuspendLayout();
            // 
            // PnCarpeta
            // 
            this.PnCarpeta.Controls.Add(this.ImgCarpeta);
            this.PnCarpeta.Controls.Add(this.Nomcarpeta);
            this.PnCarpeta.Location = new System.Drawing.Point(0, 0);
            this.PnCarpeta.Name = "PnCarpeta";
            this.PnCarpeta.Size = new System.Drawing.Size(300, 200);
            this.PnCarpeta.TabIndex = 1;
            // 
            // ImgCarpeta
            // 
            this.ImgCarpeta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ImgCarpeta.Image = global::Nayecto.Properties.Resources.carpetaDef;
            this.ImgCarpeta.Location = new System.Drawing.Point(4, 4);
            this.ImgCarpeta.Name = "ImgCarpeta";
            this.ImgCarpeta.Size = new System.Drawing.Size(284, 168);
            this.ImgCarpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCarpeta.TabIndex = 1;
            this.ImgCarpeta.TabStop = false;
            this.ImgCarpeta.Click += new System.EventHandler(this.ImgCarpeta_Click);
            // 
            // Nomcarpeta
            // 
            this.Nomcarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nomcarpeta.AutoSize = true;
            this.Nomcarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomcarpeta.Location = new System.Drawing.Point(3, 175);
            this.Nomcarpeta.Name = "Nomcarpeta";
            this.Nomcarpeta.Size = new System.Drawing.Size(80, 25);
            this.Nomcarpeta.TabIndex = 0;
            this.Nomcarpeta.Text = "Default";
            // 
            // ControlCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnCarpeta);
            this.Name = "ControlCarpeta";
            this.Size = new System.Drawing.Size(300, 200);
            this.PnCarpeta.ResumeLayout(false);
            this.PnCarpeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCarpeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnCarpeta;
        private System.Windows.Forms.PictureBox ImgCarpeta;
        private System.Windows.Forms.Label Nomcarpeta;
    }
}
