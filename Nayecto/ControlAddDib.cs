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
    public partial class ControlAddDib : UserControl
    {
        String carpeta;
        public ControlAddDib(String carpeta)
        {
            this.carpeta = carpeta;
            InitializeComponent();
        }

        private void AddDib_Click(object sender, EventArgs e)
        {
            AddDib anyadirDib = new AddDib(carpeta);
            anyadirDib.Show();
        }
    }
}
