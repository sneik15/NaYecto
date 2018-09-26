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
    public partial class Carpeta : Form
    {
        String directorio;
        String archivoConf;
        String archivoDib;
        String nombre = "Carpeta por defecto";
        String imgDefecto = "Default;Default;No";
        List<String> dibujos = new List<string>();
        VentanaPrincipal uso;
        public Carpeta(String nombre, VentanaPrincipal usar)
        {
            uso = usar;
            InitializeComponent();
            this.nombre = nombre;
            Text = nombre;
            archivoConf = "c:\\AdminDibujos\\" + nombre + "\\Config.sneik";
            archivoDib = "c:\\AdminDibujos\\" + nombre + "\\Dibujos.sneik";
            directorio = "c:\\AdminDibujos\\" + nombre;
            ConfigCarpeta();
            CargarConfig();
            CargarDibujos();
            AddGUIDibujos();
        }

        private void AddGUIDibujos()
        {
            foreach (String dib in dibujos)
            {
                String[] nomSep = dib.Split(';');
                Boolean defecto = nomSep[1].Equals(imgDefecto);
                contCarpeta.Controls.Add(new ControlImg(nomSep[0], directorio + "\\" + nomSep[1],defecto,
                    archivoConf,archivoDib,uso,nombre,nomSep[2]));
            }
            contCarpeta.Controls.Add(new ControlAddDib(nombre));
        }

        private void ConfigCarpeta()
        {
            try
            {
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                    StreamWriter archi = new StreamWriter(archivoConf);
                    archi.WriteLine(imgDefecto);
                    archi.Close();
                    StreamWriter archi2 = new StreamWriter(archivoDib);
                    archi2.WriteLine(imgDefecto);
                    archi2.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error con los datos de guardado de la carpeta, " +
                    "es posible que nada de lo que hagas se guarde o que los datos esten corruptos", "Error grave[ConfCar]",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarConfig()
        {
            StreamReader archi = new StreamReader(archivoConf);
            imgDefecto = archi.ReadLine();
            archi.Close();
        }

        private Boolean CargarDibujos()
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
                if (dibujos.Count() == numElem && !(contCarpeta.Controls.Count <= 1))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Error con los datos de guardado del programa, " +
                    "es posible que nada de lo que hagas se guarde o que los datos esten corruptos", "Error grave[Cargar Dib]",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Refrescar(object sender, EventArgs e)
        {
            if (CargarDibujos()) { 
                contCarpeta.Controls.Clear();
                AddGUIDibujos();
            }
        }
    }
}
