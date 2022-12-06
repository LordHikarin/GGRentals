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
    public partial class NuevoAbono : UserControl
    {
        public delegate void volverDelegate();
        public event volverDelegate Volver;
        public NuevoAbono()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
