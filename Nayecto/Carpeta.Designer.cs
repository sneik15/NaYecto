namespace Nayecto
{
    partial class Carpeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carpeta));
            this.contCarpeta = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // contCarpeta
            // 
            this.contCarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contCarpeta.AutoScroll = true;
            this.contCarpeta.Location = new System.Drawing.Point(12, 12);
            this.contCarpeta.Name = "contCarpeta";
            this.contCarpeta.Size = new System.Drawing.Size(980, 601);
            this.contCarpeta.TabIndex = 0;
            // 
            // Carpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 625);
            this.Controls.Add(this.contCarpeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carpeta";
            this.Text = "Carpeta";
            this.Activated += new System.EventHandler(this.Refrescar);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contCarpeta;
    }
}