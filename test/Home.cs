using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Modulos;

namespace test
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Inquilino inquilino = new Inquilino();
            inquilino.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Departamentos depa = new Departamentos();
            depa.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Rentas Rentas = new Rentas();
            Rentas.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.Show();
        }
    }
}
