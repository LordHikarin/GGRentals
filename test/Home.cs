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
    public partial class Home : Form
    {
        Rentas rent= new Rentas();
        Inquilino inq= new Inquilino();
        Departamentos dept= new Departamentos();
        Administracion adm = new Administracion();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
