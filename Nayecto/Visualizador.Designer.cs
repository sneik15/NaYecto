namespace Nayecto
{
    partial class Visualizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDefec = new System.Windows.Forms.Button();
            this.btnAnte = new System.Windows.Forms.Button();
            this.btnSigui = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.visPrinci = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visPrinci)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDefec);
            this.panel1.Controls.Add(this.btnAnte);
            this.panel1.Controls.Add(this.btnSigui);
            this.panel1.Controls.Add(this.btnFav);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Location = new System.Drawing.Point(12, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnDefec
            // 
            this.btnDefec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefec.Location = new System.Drawing.Point(630, 3);
            this.btnDefec.Name = "btnDefec";
            this.btnDefec.Size = new System.Drawing.Size(240, 46);
            this.btnDefec.TabIndex = 5;
            this.btnDefec.Text = "Establecer como dibujo por defecto...";
            this.btnDefec.UseVisualStyleBackColor = true;
            this.btnDefec.Click += new System.EventHandler(this.btnDefec_Click);
            // 
            // btnAnte
            // 
            this.btnAnte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAnte.BackgroundImage = global::Nayecto.Properties.Resources.if_arrow_left_173147;
            this.btnAnte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnte.Location = new System.Drawing.Point(386, 3);
            this.btnAnte.Name = "btnAnte";
            this.btnAnte.Size = new System.Drawing.Size(50, 46);
            this.btnAnte.TabIndex = 4;
            this.btnAnte.UseVisualStyleBackColor = true;
            this.btnAnte.Click += new System.EventHandler(this.btnAnte_Click);
            // 
            // btnSigui
            // 
            this.btnSigui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSigui.BackgroundImage = global::Nayecto.Properties.Resources.flecha;
            this.btnSigui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSigui.Location = new System.Drawing.Point(496, 3);
            this.btnSigui.Name = "btnSigui";
            this.btnSigui.Size = new System.Drawing.Size(50, 46);
            this.btnSigui.TabIndex = 3;
            this.btnSigui.UseVisualStyleBackColor = true;
            this.btnSigui.Click += new System.EventHandler(this.btnSigui_Click);
            // 
            // btnFav
            // 
            this.btnFav.AllowDrop = true;
            this.btnFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFav.BackColor = System.Drawing.Color.Transparent;
            this.btnFav.BackgroundImage = global::Nayecto.Properties.Resources.Corazon;
            this.btnFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFav.Location = new System.Drawing.Point(442, 3);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(48, 46);
            this.btnFav.TabIndex = 2;
            this.btnFav.UseVisualStyleBackColor = false;
            this.btnFav.Click += new System.EventHandler(this.BtnFav_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackgroundImage = global::Nayecto.Properties.Resources.borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.Location = new System.Drawing.Point(876, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(53, 46);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(3, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 46);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Exportar...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // visPrinci
            // 
            this.visPrinci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visPrinci.BackColor = System.Drawing.SystemColors.ControlDark;
            this.visPrinci.Image = global::Nayecto.Properties.Resources.dibdefecto;
            this.visPrinci.Location = new System.Drawing.Point(12, 12);
            this.visPrinci.Name = "visPrinci";
            this.visPrinci.Size = new System.Drawing.Size(934, 541);
            this.visPrinci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visPrinci.TabIndex = 0;
            this.visPrinci.TabStop = false;
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 625);
            this.Controls.Add(this.visPrinci);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visualizador";
            this.Text = "Default";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visPrinci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox visPrinci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Button btnAnte;
        private System.Windows.Forms.Button btnSigui;
        private System.Windows.Forms.Button btnDefec;
    }
}