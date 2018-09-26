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
    public partial class DelCar : Form
    {
        String archivoCar;
        List<String> carpetasNEW = new List<string>();
        List<String> carpetas = new List<string>();
        String directorio = "c:\\AdminDibujos\\";
        VentanaPrincipal uso;
        public DelCar(String archivoCar,VentanaPrincipal ven)
        {
            uso = ven;
            this.archivoCar = archivoCar;
            InitializeComponent();
            CargarLista();
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
            foreach(String car in carpetas)
            {
                ListaCarpetas.Items.Add(car);
            }
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Todas las carpetas seleccionadas se borraran junto con todas sus imagenes, estas seguro?", "Atencion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if(resultado == DialogResult.OK)
            {
                List<String> carpetasBorrar = new List<string>();
                int borradas = 0;
                for (int i = 0; i < carpetas.Count(); i++)
                {
                    if (ListaCarpetas.GetItemChecked(i))
                    {
                        String nombre = carpetas[i];
                        uso.BorrarCarpeta(nombre);
                        uso.LimpiarCarpetas();
                        uso.AddGUICarpetas();
                        carpetasBorrar.Add(directorio + nombre);
                        borradas++;
                    }
                    else
                    {
                        carpetasNEW.Add(carpetas[i]);
                    }
                }
                if(borradas > 0)
                {
                    StreamWriter archi = new StreamWriter(archivoCar);
                    foreach (String bcar in carpetasBorrar)
                    {
                        try
                        {
                            Directory.Delete(bcar, true);
                        }
                        catch
                        {
                            MessageBox.Show("Error con el borrado de algun archivo de la carpeta, borrar manualmente", "Error leve",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    foreach (String ncar in carpetasNEW)
                    {
                        archi.WriteLine(ncar);
                    }
                    archi.Close();
                    MessageBox.Show("Borrado completado exitosamente, carpetas borradas: " + borradas, "Borrado completado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    carpetas = carpetasNEW;
                    carpetasNEW.Clear();
                    MessageBox.Show("No se ha borrado ninguna carpeta, ninguna carpeta seleccionada", "Borrado cancelado",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Borrado cancelado", "Borrado cancelado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
