namespace Nayecto
{
    partial class CtrAddCarpeta
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
            this.pnAddCar = new System.Windows.Forms.Panel();
            this.lblAddCar = new System.Windows.Forms.Label();
            this.imgAddCar = new System.Windows.Forms.PictureBox();
            this.pnAddCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddCar
            // 
            this.pnAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAddCar.Controls.Add(this.imgAddCar);
            this.pnAddCar.Controls.Add(this.lblAddCar);
            this.pnAddCar.Location = new System.Drawing.Point(0, 0);
            this.pnAddCar.Name = "pnAddCar";
            this.pnAddCar.Size = new System.Drawing.Size(300, 200);
            this.pnAddCar.TabIndex = 4;
            // 
            // lblAddCar
            // 
            this.lblAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddCar.AutoSize = true;
            this.lblAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCar.Location = new System.Drawing.Point(3, 175);
            this.lblAddCar.Name = "lblAddCar";
            this.lblAddCar.Size = new System.Drawing.Size(156, 25);
            this.lblAddCar.TabIndex = 0;
            this.lblAddCar.Text = "Añadir Carpeta";
            // 
            // imgAddCar
            // 
            this.imgAddCar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgAddCar.Image = global::Nayecto.Properties.Resources.addcarpeta;
            this.imgAddCar.Location = new System.Drawing.Point(4, 4);
            this.imgAddCar.Name = "imgAddCar";
            this.imgAddCar.Size = new System.Drawing.Size(284, 168);
            this.imgAddCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAddCar.TabIndex = 1;
            this.imgAddCar.TabStop = false;
            this.imgAddCar.Click += new System.EventHandler(this.imgAddCar_Click);
            // 
            // CtrAddCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAddCar);
            this.Name = "CtrAddCarpeta";
            this.Size = new System.Drawing.Size(300, 200);
            this.pnAddCar.ResumeLayout(false);
            this.pnAddCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAddCar;
        private System.Windows.Forms.PictureBox imgAddCar;
        private System.Windows.Forms.Label lblAddCar;
    }
}
