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
    public partial class VentanaPrincipal : Form
    {
        String archivoCar = @"c:\AdminDibujos\Carpetas.sneik";
        String directorio = @"c:\AdminDibujos";
        List<String> carpetas = new List<string>();
        List<ControlCarpeta> carpetasObj = new List<ControlCarpeta>();

        public VentanaPrincipal()
        {
            CrearCarpeta();
            LeerCarpetas();
            InitializeComponent();
            AddGUICarpetas();
            AddGUIFav();
        }

        public void AddGUICarpetas()
        {
            carpetasObj.Clear();
            foreach(String car in carpetas){
                carpetasObj.Add(new ControlCarpeta(car,this));
            }
            ContenedorCarpetas.Controls.Add(new CtrAddCarpeta(carpetas));
            foreach(ControlCarpeta contr in carpetasObj)
            {
                ContenedorCarpetas.Controls.Add(contr);
            }
        }

        private void CrearCarpeta()
        {
            try
            {
                if(!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                    StreamWriter archi = new StreamWriter(archivoCar);
                    archi.WriteLine("Carpeta por defecto");
                    archi.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error con los datos de guardado del programa, " +
                    "es posible que nada de lo que hagas se guarde o que los datos esten corruptos","Error grave[Crear]",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LeerCarpetas()
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
                    "es posible que nada de lo que hagas se guarde o que los datos esten corruptos", "Error grave[Leer]",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CrearCarpeta();
            }
        }

        private void AddGUIFav()
        {
            pnFav.Controls.Clear();
            Favoritos fav = new Favoritos(this);
            int cont = 0;
            Control toAdd;
            do
            {
                toAdd = fav.getFav(cont);
                pnFav.Controls.Add(toAdd);
                cont++;
            } while (toAdd != null);
            fav.Close();
        }

        private void addCarClick(object sender, EventArgs e)
        {
            AddCarpeta addcar = new AddCarpeta(carpetas);
            addcar.Show();
        }

        private void Foto_Click(object sender, EventArgs e)
        {
            //Visualizador foto = new Visualizador();
            //foto.Show();
        }

        private void FotoAdd(object sender, EventArgs e)
        {
            AddDib adddib = new AddDib("none");
            adddib.Show();
        }

        private void ClickAcerde(object sender, EventArgs e)
        {
            Acercade formulario = new Acercade();
            formulario.Show();
        }

        private void DelCar(object sender, EventArgs e)
        {
            DelCar borcar = new DelCar(archivoCar,this);
            borcar.Show();
        }

        private void CanNom(object sender, EventArgs e)
        {
            CamNom cambi = new CamNom();
            cambi.Show();
        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FavoritosClick(object sender, EventArgs e)
        {
            Favoritos fav = new Favoritos(this);
            fav.Show();
        }

        public void LimpiarCarpetas()
        {
            ContenedorCarpetas.Controls.Clear();
        }

        private void Refrescar(object sender, EventArgs e)
        {
             LeerCarpetas();
             LimpiarCarpetas();
             AddGUICarpetas();
             AddGUIFav();
        }
        public void BorrarCarpeta(String carpeta)
        {
            carpetas.Remove(carpeta);
            foreach (ControlCarpeta contr in carpetasObj)
            {
                if (contr.getNombre().Equals(carpeta))
                {
                    contr.Liberar();
                }
            }
        }

        public void DisImageControl(String carpeta)
        {
            foreach (ControlCarpeta contr in carpetasObj)
            {
                if (contr.getNombre().Equals(carpeta))
                {
                    contr.Liberar();
                }
            }
        }
    }
}
