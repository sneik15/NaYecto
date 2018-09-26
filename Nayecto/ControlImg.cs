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
    public partial class ControlImg : UserControl
    {
        String archivoImg;
        String nombre;
        String archivo;
        String directorioConf;
        Boolean defecto;
        VentanaPrincipal uso;
        String carpeta;
        String favorita;
        public ControlImg(String nombre,String archivo,Boolean defecto,String directorioConf,String archivoImg,
            VentanaPrincipal usar,String carpeta,String favorita)
        {
            uso = usar;
            this.nombre = nombre;
            this.archivo = archivo;
            this.directorioConf = directorioConf;
            this.defecto = defecto;
            this.archivoImg = archivoImg;
            this.carpeta = carpeta;
            this.favorita = favorita;
            InitializeComponent();
            nombreImagen.Text = nombre;
            CargarImg();
            ComprobarFav();
        }

        private void CargarImg()
        {
            
            try{
                FileStream ms = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                imgVisual.Image = Image.FromStream(ms);
                ms.Close();
                ComprobarFav();
            }
            catch{
                MessageBox.Show("Error en la carga del archivo "  + archivo + " :(", "Error grave",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                List<String> imagenes = new List<string>();
                imagenes.Clear();
                StreamReader archi1 = new StreamReader(archivoImg);
                String nomDib = "Def";
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(nombre))
                    {
                        imagenes.Add(nomDib);
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoImg);
                foreach (String ncar in imagenes)
                {
                    archi.WriteLine(ncar);
                }
                archi.Close();
                Dispose();
            }
        }

        private void ImgVisual_Click(object sender, EventArgs e)
        {
            Visualizador dibu = new Visualizador(nombre,archivo,carpeta,favorita);
            dibu.Show();
        }

        private void BtnPredeter_Click(object sender, EventArgs e)
        {
            File.Delete(directorioConf);
            StreamWriter archi = new StreamWriter(directorioConf);
            String[] nomArchSep = archivo.Split('\\');
            Array.Reverse(nomArchSep);
            archi.WriteLine(nomArchSep[0]);
            archi.Close();
            
        }

        private void BtnBorr_Click(object sender, EventArgs e)
        { DialogResult resultado;
            resultado = MessageBox.Show("Esta imagen se borrara para siempre del programa, estas seguro?", "Atencion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (resultado == DialogResult.OK)
            {
                List<String> imagenes = new List<string>();
                imagenes.Clear();
                StreamReader archi1 = new StreamReader(archivoImg);
                String nomDib = "Def";
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(nombre))
                    {
                        imagenes.Add(nomDib);
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoImg);
                foreach (String ncar in imagenes)
                {
                    archi.WriteLine(ncar);
                }
                archi.Close();
                imgVisual.Image.Dispose();
                String[] carpeta = directorioConf.Split('\\');
                carpeta.Reverse();
                uso.DisImageControl(carpeta[1]);
                try
                {
                    File.Delete(archivo);
                }
                catch
                {
                    MessageBox.Show("Error con el borrado del archivo de la imagen, borrar manualmente", "Error leve",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Dispose();
            }
        }

        private void BtnFav_Click(object sender, EventArgs e)
        {
            if (favorita.Equals("No"))
            {
                favorita = "Si";
                List<String> imagenes = new List<string>();
                imagenes.Clear();
                StreamReader archi1 = new StreamReader(archivoImg);
                String nomDib = "Def";
                String[] nArchSep = archivo.Split('\\');
                String nomArch = nArchSep[3];
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(nombre + ";" + nomArch))
                    {
                        imagenes.Add(nomDib);
                    }
                    else if (nomDib != null && nomDib.StartsWith(nombre + ";" + nomArch))
                    {
                        imagenes.Add(nombre + ";" + nomArch + ";Si");
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoImg);
                foreach (String ncar in imagenes)
                {
                    archi.WriteLine(ncar);
                }
                archi.Close();
                ComprobarFav();
            }
            else if (favorita.Equals("Si"))
            {
                favorita = "No";
                List<String> imagenes = new List<string>();
                imagenes.Clear();
                StreamReader archi1 = new StreamReader(archivoImg);
                String nomDib = "Def";
                String[] nArchSep = archivo.Split('\\');
                String nomArch = nArchSep[3];
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(nombre + ";" + nomArch))
                    {
                        imagenes.Add(nomDib);
                    }
                    else if (nomDib != null && nomDib.StartsWith(nombre + ";" + nomArch))
                    {
                        imagenes.Add(nombre + ";" + nomArch + ";No");
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoImg);
                foreach (String ncar in imagenes)
                {
                    archi.WriteLine(ncar);
                }
                archi.Close();
                ComprobarFav();
            }
            
        }
        private void ComprobarFav()
        {
            if (favorita.Equals("Si"))
            {
                btnFav.BackColor = Color.SkyBlue;
            }
            else
            {
                btnFav.BackColor = Color.Transparent;
            }
        }
    }
}
