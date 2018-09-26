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
    public partial class AddDib : Form
    {
        String archivoCar = @"c:\AdminDibujos\Carpetas.sneik";
        String archivoDib;
        String nomArchDib;
        String directorio;
        String nombreCar;
        String nombreDib;
        String ruta = @"c:\";
        Boolean imgSelec = false;
        List<String> dibujos = new List<string>();
        List<String> carpetas = new List<string>();
        public AddDib(String nombreCar)
        {
            this.nombreCar = nombreCar;
            InitializeComponent();
            CargarLista();
        }

        private void BtnAcep_Click(object sender, EventArgs e)
        {
            Boolean repetido = false;
            nombreDib = txtNombre.Text;
            foreach (String dib in dibujos)
            {
                String[] dibsep = dib.Split(';');
                repetido = dibsep[0].Equals(nombreDib);
                if (!repetido)
                {
                    repetido = dibsep[1].Equals(nomArchDib);
                }
            }
            if (!imgSelec)
            {
                MessageBox.Show("Tienes que seleccionar un arhcivo.", "Imagen no seleccionada",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nombreDib.Length < 3)
            {
                MessageBox.Show("El nombre del dibujo no es valido, debe contener al menos 3 caracteres", "Nombre no valido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (repetido)
            {
                MessageBox.Show("El nombre del dibujo ya existe o el archivo ya existe en la carpeta", "Dibujo no valido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean entro = false;
                int numDibCopy = 0;
                for (int i = 0; i < carpetas.Count(); i++)
                {
                    if (listCar.GetItemChecked(i))
                    {
                        entro = true;
                        nombreCar = listCar.GetItemText(listCar.Items[i]);
                        directorio = @"c:\AdminDibujos\" + nombreCar;
                        archivoDib = "c:\\AdminDibujos\\" + nombreCar + "\\Dibujos.sneik";
                        try
                        {
                            dibujos.Clear();
                            File.Copy(ruta, directorio + @"\" + nomArchDib, true);
                            numDibCopy++;
                            StreamReader archi = new StreamReader(archivoDib);
                            String nomDib = "Def";
                            while (nomDib != null)
                            {
                                nomDib = archi.ReadLine();
                                if (nomDib != null && !nomDib.Equals("Default"))
                                {
                                    dibujos.Add(nomDib);
                                }
                            }
                            archi.Close();
                            StreamWriter archi2 = new StreamWriter(archivoDib);
                            foreach (String dib in dibujos)
                            {
                                if (!dib.Equals("Default;Default;No"))
                                {
                                    archi2.WriteLine(dib);
                                }

                            }
                            archi2.WriteLine(nombreDib + ";" + nomArchDib + ";No");
                            archi2.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Carpeta no generada, no se pueden añadir imagenes a las carpetas sin generar", "Error leve",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (!entro)
                {
                   MessageBox.Show("No se ha añadido el dibujo a ninguna carpeta, 0 seleccionadas.", "Dibujo no añadido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se ha añadido el dibujo a "+ numDibCopy + " carpetas", "Dibujo añadido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private void BtnCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            openDib.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif";
            openDib.Title = "Selecciona el dibujo que quieres añadir";
            if (openDib.ShowDialog() == DialogResult.OK)
            {
                imgSelec = true;
                ruta = @openDib.FileName;
                String[] rutasep = ruta.Split('\\');
                Array.Reverse(rutasep);
                nomArchDib = rutasep[0];
                txtRuta.Text = ruta;
            }
            
        }

        private void CargarLista()
        {
            try
            {
                carpetas.Clear();
                StreamReader archi = new StreamReader(archivoCar);
                String NomCar = "Def";
                while (NomCar != null)
                {
                    NomCar = archi.ReadLine();
                    if (NomCar != null && !NomCar.Equals("Favoritos"))
                    {
                        carpetas.Add(NomCar);
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
            foreach (String car in carpetas)
            {
                listCar.Items.Add(car);
            }
            for (int i = 0; i < carpetas.Count(); i++)
            {
                if(nombreCar.Equals(listCar.Items[i]))
                {
                    listCar.SetItemChecked(i,true);
                }
            }
        }
    }
}
