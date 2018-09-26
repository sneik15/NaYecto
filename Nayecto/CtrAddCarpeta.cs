using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nayecto
{
    public partial class CtrAddCarpeta : UserControl
    {
        List<String> carpetas = new List<string>();
        public CtrAddCarpeta(List<String> carp)
        {
            carpetas = carp;
            InitializeComponent();
        }

        private void imgAddCar_Click(object sender, EventArgs e)
        {
            AddCarpeta addcar = new AddCarpeta(carpetas);
            addcar.Show();
        }
    }
}
