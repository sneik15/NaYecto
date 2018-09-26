namespace Nayecto
{
    partial class AddDib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDib));
            this.label1 = new System.Windows.Forms.Label();
            this.openDib = new System.Windows.Forms.OpenFileDialog();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listCar = new System.Windows.Forms.CheckedListBox();
            this.BtnAcep = new System.Windows.Forms.Button();
            this.BtnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta del dibujo:";
            // 
            // openDib
            // 
            this.openDib.FileName = "openDib";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(120, 10);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Seleccionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(16, 33);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(443, 22);
            this.txtRuta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del dibujo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(330, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Añadir dibujo a estas carpetas:";
            // 
            // listCar
            // 
            this.listCar.FormattingEnabled = true;
            this.listCar.Location = new System.Drawing.Point(13, 105);
            this.listCar.Name = "listCar";
            this.listCar.Size = new System.Drawing.Size(552, 229);
            this.listCar.TabIndex = 7;
            // 
            // BtnAcep
            // 
            this.BtnAcep.Location = new System.Drawing.Point(490, 6);
            this.BtnAcep.Name = "BtnAcep";
            this.BtnAcep.Size = new System.Drawing.Size(75, 23);
            this.BtnAcep.TabIndex = 8;
            this.BtnAcep.Text = "Aceptar";
            this.BtnAcep.UseVisualStyleBackColor = true;
            this.BtnAcep.Click += new System.EventHandler(this.BtnAcep_Click);
            // 
            // BtnCan
            // 
            this.BtnCan.Location = new System.Drawing.Point(490, 76);
            this.BtnCan.Name = "BtnCan";
            this.BtnCan.Size = new System.Drawing.Size(75, 23);
            this.BtnCan.TabIndex = 9;
            this.BtnCan.Text = "Cancelar";
            this.BtnCan.UseVisualStyleBackColor = true;
            this.BtnCan.Click += new System.EventHandler(this.BtnCan_Click);
            // 
            // AddDib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 353);
            this.Controls.Add(this.BtnCan);
            this.Controls.Add(this.BtnAcep);
            this.Controls.Add(this.listCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(593, 391);
            this.MinimumSize = new System.Drawing.Size(593, 391);
            this.Name = "AddDib";
            this.Text = "Añadir dibujo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openDib;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox listCar;
        private System.Windows.Forms.Button BtnAcep;
        private System.Windows.Forms.Button BtnCan;
    }
}