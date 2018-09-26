using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nayecto
{
    public partial class AddCarpeta : Form
    {
        String archivoCar = @"c:\AdminDibujos\Carpetas.sneik";
        List<String> carpetas = new List<string>();
        public AddCarpeta(List<String> carp)
        {
            carpetas = carp;
            InitializeComponent();
        }

        private void BtnAceptar(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            if (nombre.Contains(';') || nombre.Contains(':') || nombre.Contains('/') || nombre.Contains('\\') || nombre.Contains('*') 
                || nombre.Contains('?') || nombre.Contains('"') || nombre.Contains('<') || nombre.Contains('>') || nombre.Contains('|'))
            {
                MessageBox.Show("Nombre de carpeta no valido, no puede contener ninguno de los siguientes caracteres: ( ; : / \\ * ? " + 
                    '"' + " < > | )", "Nombre no valido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(nombre.Length < 3)
            {
                MessageBox.Show("El nombre de la carpeta tiene que ser mayor de 3 caracteres","Nombre no valido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(carpetas.Contains(nombre)){
                MessageBox.Show("Carpeta ya creada, no se permiten duplicados", "Nombre no valido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StreamWriter archi = new StreamWriter(archivoCar);
                foreach(String car in carpetas)
                {
                    archi.WriteLine(car);
                }
                archi.WriteLine(nombre);
                archi.Close();
                Close();
            }
        }

        private void BtnCancelar(object sender, EventArgs e)
        {
            Close();
        }
    }
}
