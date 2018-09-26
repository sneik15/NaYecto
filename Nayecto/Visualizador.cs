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
    public partial class Visualizador : Form
    {
        String imagenNom;
        String imagenRut;
        String archivoDib;
        String nombreCar;
        String archivoCar;
        String directorioConf;
        String favorita;
        List<String> dibujos = new List<string>();
        public Visualizador(String imagenNom, String imagenRut, String car,String favorita)
        {
            this.imagenNom = imagenNom;
            this.imagenRut = imagenRut;
            this.favorita = favorita;
            nombreCar = car;
            archivoDib = "c:\\AdminDibujos\\" + nombreCar + "\\Dibujos.sneik";
            archivoCar = "c:\\AdminDibujos\\" + nombreCar + "\\";
            directorioConf = "c:\\AdminDibujos\\" + nombreCar + "\\Config.sneik";
            InitializeComponent();
            CargarImg();
            CargarDibujos();
            Text = imagenNom;
            ComprobarFav();
        }

        private void CargarImg()
        {
            try
            {
                FileStream ms = new FileStream(imagenRut, FileMode.Open, FileAccess.Read);
                visPrinci.Image = Image.FromStream(ms);
                ms.Close();
                ComprobarFav();
            }
            catch
            {
                MessageBox.Show("Error en la carga del archivo " + imagenRut + " :(", "Error grave",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Esta imagen se borrara para siempre del programa, estas seguro?", "Atencion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (resultado == DialogResult.OK)
            {
                List<String> imagenes = new List<string>();
                imagenes.Clear();
                StreamReader archi1 = new StreamReader(archivoDib);
                String nomDib = "Def";
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(imagenNom))
                    {
                        imagenes.Add(nomDib);
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoDib);
                foreach (String ncar in imagenes)
                {
                    archi.WriteLine(ncar);
                }
                archi.Close();
                try
                {
                    File.Delete(imagenRut);
                }
                catch
                {
                    MessageBox.Show("Error con el borrado del archivo de la imagen, borrar manualmente", "Error leve",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Dispose();
            }
        }

        private void btnSigui_Click(object sender, EventArgs e)
        {
            int posicion = 0;
            foreach (String dib in dibujos)
            {
                if (dib.Split(';')[0].Equals(imagenNom))
                {
                    posicion = dibujos.IndexOf(dib) + 1;
                    if (posicion > dibujos.Count() - 1)
                    {
                        posicion = 0;
                    }
                    break;
                }
            }

            String[] dibsep = dibujos[posicion].Split(';');
            imagenNom = dibsep[0];
            imagenRut = archivoCar + dibsep[1];
            CargarImg();
            CargarDibujos();
            Text = imagenNom;
        }

        private void btnAnte_Click(object sender, EventArgs e)
        {
            int posicion = dibujos.Count() - 1;
            foreach (String dib in dibujos)
            {
                if (dib.Split(';')[0].Equals(imagenNom))
                {
                    posicion = dibujos.IndexOf(dib) - 1;
                    if (posicion < 0)
                    {
                        posicion = dibujos.Count() - 1;
                    }
                    break;
                }
            }

            String[] dibsep = dibujos[posicion].Split(';');
            imagenNom = dibsep[0];
            imagenRut = archivoCar + dibsep[1];
            CargarImg();
            CargarDibujos();
            Text = imagenNom;
        }

        private void btnDefec_Click(object sender, EventArgs e)
        {
            File.Delete(directorioConf);
            StreamWriter archi = new StreamWriter(directorioConf);
            String[] nomArchSep = imagenRut.Split('\\');
            Array.Reverse(nomArchSep);
            archi.WriteLine(nomArchSep[0]);
            archi.Close();
        }

        private void BtnFav_Click(object sender, EventArgs e)
        {
            if (favorita.Equals("No"))
            {
                favorita = "Si";
                List<String> imagenes = new List<string>();
                imagenes.Clear();
                StreamReader archi1 = new StreamReader(archivoDib);
                String nomDib = "Def";
                String[] nArchSep = imagenRut.Split('\\');
                String nomArch = nArchSep[3];
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(imagenNom + ";" + nomArch))
                    {
                        imagenes.Add(nomDib);
                    }
                    else if (nomDib != null && nomDib.StartsWith(imagenNom + ";" + nomArch))
                    {
                        imagenes.Add(imagenNom + ";" + nomArch + ";Si");
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoDib);
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
                StreamReader archi1 = new StreamReader(archivoDib);
                String nomDib = "Def";
                String[] nArchSep = imagenRut.Split('\\');
                String nomArch = nArchSep[3];
                while (nomDib != null)
                {
                    nomDib = archi1.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default;No") && !nomDib.StartsWith(imagenNom + ";" + nomArch))
                    {
                        imagenes.Add(nomDib);
                    }
                    else if (nomDib != null && nomDib.StartsWith(imagenNom + ";" + nomArch))
                    {
                        imagenes.Add(imagenNom + ";" + nomArch + ";No");
                    }
                }
                archi1.Close();
                StreamWriter archi = new StreamWriter(archivoDib);
                foreach (String ncar in imagenes)
                {
                    archi.WriteLine(ncar);
                }
                archi.Close();
                ComprobarFav();
            }
        }

        private void CargarDibujos()
        {
            try
            {
                dibujos.Clear();
                StreamReader archi = new StreamReader(archivoDib);
                String nomDib = "Def";
                while (nomDib != null)
                {
                    nomDib = archi.ReadLine();
                    if (nomDib != null && !nomDib.Equals("Default;Default"))
                    {
                        dibujos.Add(nomDib);
                    }
                }
                archi.Close();
            }
            catch
            {
                MessageBox.Show("Error con los datos de guardado del programa, " +
                    "es posible que nada de lo que hagas se guarde o que los datos esten corruptos", "Error grave",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComprobarFav()
        {
            if(favorita.Equals("Si"))
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
