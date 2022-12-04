using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.Modulos
{
    public partial class VistaRentas : UserControl
    {
        public VistaRentas()
        {
            InitializeComponent();
        }
        public delegate void RentaDelegado();
        public event RentaDelegado Rentas;
        private void label1_Click(object sender, EventArgs e)
        {
            Rentas();
        }
    }
}
