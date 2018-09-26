namespace Nayecto
{
    partial class ControlImg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFav = new System.Windows.Forms.Button();
            this.btnBorr = new System.Windows.Forms.Button();
            this.btnPredeter = new System.Windows.Forms.Button();
            this.nombreImagen = new System.Windows.Forms.Label();
            this.imgVisual = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFav);
            this.panel1.Controls.Add(this.btnBorr);
            this.panel1.Controls.Add(this.btnPredeter);
            this.panel1.Controls.Add(this.nombreImagen);
            this.panel1.Controls.Add(this.imgVisual);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 1;
            // 
            // btnFav
            // 
            this.btnFav.BackColor = System.Drawing.Color.Transparent;
            this.btnFav.BackgroundImage = global::Nayecto.Properties.Resources.Corazon;
            this.btnFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFav.ForeColor = System.Drawing.Color.Black;
            this.btnFav.Location = new System.Drawing.Point(3, 3);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(22, 24);
            this.btnFav.TabIndex = 4;
            this.btnFav.UseVisualStyleBackColor = false;
            this.btnFav.Click += new System.EventHandler(this.BtnFav_Click);
            // 
            // btnBorr
            // 
            this.btnBorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorr.ForeColor = System.Drawing.Color.Red;
            this.btnBorr.Location = new System.Drawing.Point(273, 4);
            this.btnBorr.Name = "btnBorr";
            this.btnBorr.Size = new System.Drawing.Size(23, 23);
            this.btnBorr.TabIndex = 3;
            this.btnBorr.Text = "X";
            this.btnBorr.UseVisualStyleBackColor = true;
            this.btnBorr.Click += new System.EventHandler(this.BtnBorr_Click);
            // 
            // btnPredeter
            // 
            this.btnPredeter.Location = new System.Drawing.Point(212, 176);
            this.btnPredeter.Name = "btnPredeter";
            this.btnPredeter.Size = new System.Drawing.Size(85, 23);
            this.btnPredeter.TabIndex = 2;
            this.btnPredeter.Text = "Predeterminar";
            this.btnPredeter.UseVisualStyleBackColor = true;
            this.btnPredeter.Click += new System.EventHandler(this.BtnPredeter_Click);
            // 
            // nombreImagen
            // 
            this.nombreImagen.AutoSize = true;
            this.nombreImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreImagen.Location = new System.Drawing.Point(3, 174);
            this.nombreImagen.Name = "nombreImagen";
            this.nombreImagen.Size = new System.Drawing.Size(61, 20);
            this.nombreImagen.TabIndex = 1;
            this.nombreImagen.Text = "Default";
            // 
            // imgVisual
            // 
            this.imgVisual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgVisual.Image = global::Nayecto.Properties.Resources.dibdefecto;
            this.imgVisual.Location = new System.Drawing.Point(3, 3);
            this.imgVisual.Name = "imgVisual";
            this.imgVisual.Size = new System.Drawing.Size(294, 168);
            this.imgVisual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVisual.TabIndex = 0;
            this.imgVisual.TabStop = false;
            this.imgVisual.Click += new System.EventHandler(this.ImgVisual_Click);
            // 
            // ControlImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ControlImg";
            this.Size = new System.Drawing.Size(300, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nombreImagen;
        private System.Windows.Forms.PictureBox imgVisual;
        private System.Windows.Forms.Button btnPredeter;
        private System.Windows.Forms.Button btnBorr;
        private System.Windows.Forms.Button btnFav;
    }
}
