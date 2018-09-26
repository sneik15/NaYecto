namespace Nayecto
{
    partial class ControlAddDib
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
            this.addDib = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addDib)).BeginInit();
            this.SuspendLayout();
            // 
            // addDib
            // 
            this.addDib.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addDib.Image = global::Nayecto.Properties.Resources.add;
            this.addDib.Location = new System.Drawing.Point(0, 0);
            this.addDib.Name = "addDib";
            this.addDib.Size = new System.Drawing.Size(300, 200);
            this.addDib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addDib.TabIndex = 1;
            this.addDib.TabStop = false;
            this.addDib.Click += new System.EventHandler(this.AddDib_Click);
            // 
            // ControlAddDib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addDib);
            this.Name = "ControlAddDib";
            this.Size = new System.Drawing.Size(300, 200);
            ((System.ComponentModel.ISupportInitialize)(this.addDib)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox addDib;
    }
}
