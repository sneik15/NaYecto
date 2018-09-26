namespace Nayecto
{
    partial class VentanaPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDibujoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.borrarCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelPrograaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ContenedorCarpetas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFav = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDibujoToolStripMenuItem,
            this.agregarCarpetaToolStripMenuItem,
            this.toolStripSeparator1,
            this.borrarCarpetaToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarDibujoToolStripMenuItem
            // 
            this.agregarDibujoToolStripMenuItem.Name = "agregarDibujoToolStripMenuItem";
            this.agregarDibujoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarDibujoToolStripMenuItem.Text = "Agregar dibujo";
            this.agregarDibujoToolStripMenuItem.Click += new System.EventHandler(this.FotoAdd);
            // 
            // agregarCarpetaToolStripMenuItem
            // 
            this.agregarCarpetaToolStripMenuItem.Name = "agregarCarpetaToolStripMenuItem";
            this.agregarCarpetaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarCarpetaToolStripMenuItem.Text = "Agregar carpeta";
            this.agregarCarpetaToolStripMenuItem.Click += new System.EventHandler(this.addCarClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // borrarCarpetaToolStripMenuItem
            // 
            this.borrarCarpetaToolStripMenuItem.Name = "borrarCarpetaToolStripMenuItem";
            this.borrarCarpetaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.borrarCarpetaToolStripMenuItem.Text = "Borrar carpeta";
            this.borrarCarpetaToolStripMenuItem.Click += new System.EventHandler(this.DelCar);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.Salir);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombreDeUsuarioToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cambiarNombreDeUsuarioToolStripMenuItem
            // 
            this.cambiarNombreDeUsuarioToolStripMenuItem.Name = "cambiarNombreDeUsuarioToolStripMenuItem";
            this.cambiarNombreDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarNombreDeUsuarioToolStripMenuItem.Text = "Cambiar nombre de usuario";
            this.cambiarNombreDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.CanNom);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelPrograaToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            // 
            // acercaDelPrograaToolStripMenuItem
            // 
            this.acercaDelPrograaToolStripMenuItem.Name = "acercaDelPrograaToolStripMenuItem";
            this.acercaDelPrograaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.acercaDelPrograaToolStripMenuItem.Text = "Acerca del Programa";
            this.acercaDelPrograaToolStripMenuItem.Click += new System.EventHandler(this.ClickAcerde);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox8.Image = global::Nayecto.Properties.Resources.add;
            this.pictureBox8.Location = new System.Drawing.Point(708, 529);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(330, 141);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.FotoAdd);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(819, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Favoritos";
            this.linkLabel1.Click += new System.EventHandler(this.FavoritosClick);
            // 
            // ContenedorCarpetas
            // 
            this.ContenedorCarpetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContenedorCarpetas.AutoScroll = true;
            this.ContenedorCarpetas.Location = new System.Drawing.Point(12, 27);
            this.ContenedorCarpetas.Name = "ContenedorCarpetas";
            this.ContenedorCarpetas.Size = new System.Drawing.Size(690, 643);
            this.ContenedorCarpetas.TabIndex = 3;
            // 
            // pnFav
            // 
            this.pnFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFav.AutoScroll = true;
            this.pnFav.Location = new System.Drawing.Point(708, 54);
            this.pnFav.Name = "pnFav";
            this.pnFav.Size = new System.Drawing.Size(330, 469);
            this.pnFav.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(920, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 20);
            this.panel1.TabIndex = 5;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pnFav);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ContenedorCarpetas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Administrador de dibujos[LetalCabbage]";
            this.Activated += new System.EventHandler(this.Refrescar);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDibujoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem borrarCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelPrograaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel ContenedorCarpetas;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.FlowLayoutPanel pnFav;
        private System.Windows.Forms.Panel panel1;
    }
}

