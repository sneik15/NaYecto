namespace Nayecto
{
    partial class DelCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelCar));
            this.label1 = new System.Windows.Forms.Label();
            this.ListaCarpetas = new System.Windows.Forms.CheckedListBox();
            this.btnAcep = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar de la lista las carpetas a borrar:";
            // 
            // ListaCarpetas
            // 
            this.ListaCarpetas.FormattingEnabled = true;
            this.ListaCarpetas.Location = new System.Drawing.Point(16, 43);
            this.ListaCarpetas.Name = "ListaCarpetas";
            this.ListaCarpetas.Size = new System.Drawing.Size(404, 199);
            this.ListaCarpetas.TabIndex = 1;
            // 
            // btnAcep
            // 
            this.btnAcep.Location = new System.Drawing.Point(345, 246);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(75, 23);
            this.btnAcep.TabIndex = 2;
            this.btnAcep.Text = "Aceptar";
            this.btnAcep.UseVisualStyleBackColor = true;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(12, 246);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 3;
            this.btnCan.Text = "Cancelar";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // DelCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 280);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAcep);
            this.Controls.Add(this.ListaCarpetas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(448, 319);
            this.MinimumSize = new System.Drawing.Size(448, 319);
            this.Name = "DelCar";
            this.Text = "Borrar Carpetas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ListaCarpetas;
        private System.Windows.Forms.Button btnAcep;
        private System.Windows.Forms.Button btnCan;
    }
}