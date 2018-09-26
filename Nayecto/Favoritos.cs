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
    public partial class Favoritos : Form
    {
        String directorio;
        String archivoConf;
        String archivoDib;
        String archivoCar = @"c:\AdminDibujos\Carpetas.sneik";
        String nombre = "Carpeta por defecto";
        List<String> dibujos = new List<string>();
        List<String> carpetas = new List<string>();
        VentanaPrincipal uso;
        public Favoritos(VentanaPrincipal uso)
        {
            this.uso = uso;
            InitializeComponent();
            Text = nombre;
            archivoConf = "c:\\AdminDibujos\\" + nombre + "\\Config.sneik";
            archivoDib = "c:\\AdminDibujos\\" + nombre + "\\Dibujos.sneik";
            directorio = "c:\\AdminDibujos\\" + nombre;
            CargarCarpetas();
            AddGUI();
        }
        private void CargarCarpetas()
        {
            try
            {
                carpetas.Clear();
                StreamReader archi = new StreamReader(archivoCar);
                String NomCar = "Def";
                while (NomCar != null)
                {
                    NomCar = archi.ReadLine();
                    if (NomCar != null)
                    {
                        carpetas.Add(NomCar);
                    }
                }
                archi.Close();
            }
            catch
            {
                MessageBox.Show("Error con los datos de guardado del programa, " +
                    "es posible que nada de lo que hagas se guarde o que los datos esten corruptos", "Error grave[CargarCarFAV]",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddGUI()
        {
            foreach(String car in carpetas)
            {
                nombre = car;
                archivoConf = "c:\\AdminDibujos\\" + nombre + "\\Config.sneik";
                archivoDib = "c:\\AdminDibujos\\" + nombre + "\\Dibujos.sneik";
                directorio = "c:\\AdminDibujos\\" + nombre;
                if (Directory.Exists(directorio))
                {
                    try
                    {
                        dibujos.Remove("Default;Default;No");
                        int numElem = dibujos.Count();
                        dibujos.Clear();
                        StreamReader archi = new StreamReader(archivoDib);
                        String nomDib = "Def";
                        while (nomDib != null)
                        {
                            nomDib = archi.ReadLine();
                            if (nomDib != null && !nomDib.Equals("Default;Default;No"))
                            {
                                dibujos.Add(nomDib);
                            }
                        }
                        archi.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error con los datos de guardado del programa, " +
                            "es posible que nada de lo que hagas se guarde o que los datos esten corruptos", "Error grave[AddGUIFAV]",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (String dib in dibujos)
                    {
                        String[] nomSep = dib.Split(';');
                        Boolean defecto = nomSep[1].Equals(false);
                        if (nomSep[2].Equals("Si"))
                        {
                            contFav.Controls.Add(new ControlImg(nomSep[0], directorio + "\\" + nomSep[1], defecto,
                            archivoConf, archivoDib, uso, nombre, nomSep[2]));
                        }
                    }
                }
            }
        }

        private void Refrescar(object sender, EventArgs e)
        {
            contFav.Controls.Clear();
            CargarCarpetas();
            AddGUI();
        }

        public Control getFav(int num)
        {
            try
            {
                return contFav.Controls[0];
            }
            catch
            {
                return null;
            }
            
        }
    }
}
