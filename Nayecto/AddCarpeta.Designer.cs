﻿namespace Nayecto
{
    partial class AddCarpeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarpeta));
            this.label1 = new System.Windows.Forms.Label();
            this.botAceptar = new System.Windows.Forms.Button();
            this.botCan = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // botAceptar
            // 
            this.botAceptar.Location = new System.Drawing.Point(12, 52);
            this.botAceptar.Name = "botAceptar";
            this.botAceptar.Size = new System.Drawing.Size(75, 23);
            this.botAceptar.TabIndex = 4;
            this.botAceptar.Text = "Aceptar";
            this.botAceptar.UseVisualStyleBackColor = true;
            this.botAceptar.Click += new System.EventHandler(this.BtnAceptar);
            // 
            // botCan
            // 
            this.botCan.Location = new System.Drawing.Point(265, 52);
            this.botCan.Name = "botCan";
            this.botCan.Size = new System.Drawing.Size(75, 23);
            this.botCan.TabIndex = 5;
            this.botCan.Text = "Cancelar";
            this.botCan.UseVisualStyleBackColor = true;
            this.botCan.Click += new System.EventHandler(this.BtnCancelar);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // AddCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 83);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.botCan);
            this.Controls.Add(this.botAceptar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCarpeta";
            this.Text = "Añadir carpeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botAceptar;
        private System.Windows.Forms.Button botCan;
        private System.Windows.Forms.TextBox txtNombre;
    }
}