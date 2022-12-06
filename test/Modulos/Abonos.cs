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
    public partial class Abonos : UserControl
    {
        public delegate void DelegadoAgregar();
        public event DelegadoAgregar AgregarAbono;
        public Abonos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AgregarAbono();
        }

        private void Abonos_Load(object sender, EventArgs e)
        {

        }
    }
}
