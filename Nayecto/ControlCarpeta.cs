using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nayecto
{
    public partial class ControlCarpeta: UserControl
    {
        String nombre = "Carpeta por defecto";
        String archivoConf;
        String directorio;
        VentanaPrincipal uso;
        public ControlCarpeta(String nombreped,VentanaPrincipal usar)
        {
            uso = usar;
            InitializeComponent();
            nombre = nombreped;
            Nomcarpeta.Text = nombre;
            archivoConf = "c:\\AdminDibujos\\" + nombre + "\\Config.sneik";
            directorio = "c:\\AdminDibujos\\" + nombre + "\\";
            if (Directory.Exists(directorio))
            {
                CargarImg();
            }
        }

        private void ImgCarpeta_Click(object sender, EventArgs e)
        {
            Carpeta carpeta = new Carpeta(nombre,uso);
            carpeta.Show();
        }

        private void CargarImg()
        {
            StreamReader archi = new StreamReader(archivoConf);
            String defaultIMG = archi.ReadLine();
            archi.Close();
            if (!defaultIMG.Equals("Default;Default;No"))
            {
                try
                {
                    FileStream ms = new FileStream(directorio + defaultIMG, FileMode.Open, FileAccess.Read);
                    ImgCarpeta.Image = Image.FromStream(ms);
                    ms.Close();
                }
                catch
                {
                    StreamWriter arch = new StreamWriter(archivoConf);
                    arch.WriteLine("Default;Default;No");
                    arch.Close();
                    MessageBox.Show("Imagen por defecto de la carpeta no encontrada :(", "Error leve",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Liberar()
        {
            ImgCarpeta.Image.Dispose();
        }

        public String getNombre()
        {
            return nombre;
        }
    }
}
