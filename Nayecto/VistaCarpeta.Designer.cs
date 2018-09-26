namespace Nayecto
{
    partial class VistaCarpeta
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImgCarpet = new System.Windows.Forms.PictureBox();
            this.NameCarpet = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCarpet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ImgCarpet);
            this.panel3.Controls.Add(this.NameCarpet);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 200);
            this.panel3.TabIndex = 1;
            // 
            // ImgCarpet
            // 
            this.ImgCarpet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ImgCarpet.Image = global::Nayecto.Properties.Resources.Dibujo1;
            this.ImgCarpet.Location = new System.Drawing.Point(4, 4);
            this.ImgCarpet.Name = "ImgCarpet";
            this.ImgCarpet.Size = new System.Drawing.Size(284, 168);
            this.ImgCarpet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCarpet.TabIndex = 1;
            this.ImgCarpet.TabStop = false;
            // 
            // NameCarpet
            // 
            this.NameCarpet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameCarpet.AutoSize = true;
            this.NameCarpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCarpet.Location = new System.Drawing.Point(3, 175);
            this.NameCarpet.Name = "NameCarpet";
            this.NameCarpet.Size = new System.Drawing.Size(108, 25);
            this.NameCarpet.TabIndex = 0;
            this.NameCarpet.Text = "Proyectos";
            // 
            // VistaCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "VistaCarpeta";
            this.Size = new System.Drawing.Size(305, 203);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCarpet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgCarpet;
        private System.Windows.Forms.Label NameCarpet;
    }
}
