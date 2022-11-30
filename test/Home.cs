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
        Administracion u1 = new Administracion();
        Departamentos u2 = new Departamentos();
        Inquilino u3= new Inquilino();
        Rentas u4 = new Rentas();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void adm_BTN_Click(object sender, EventArgs e)
        {
            u1.Show();
            u1.Dock = DockStyle.Fill;
            u2.Hide();
            u3.Hide();
            u4.Hide();
            this.Controls.Add(u1);
        }

        private void dept_BTN_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Show();
            u2.Dock = DockStyle.Fill;
            u3.Hide();
            u4.Hide();
            this.Controls.Add(u2);

        }

        private void inq_BTN_Click(object sender, EventArgs e)
        {
            u1.Hide();
            u2.Hide();
            u3.Show();
            u3.Dock = DockStyle.Fill;
            u4.Hide();
            this.Controls.Add(u3);
        }

        private void rent_BTN_Click(object sender, EventArgs e)
        {

            u1.Hide();
            u2.Hide();
            u3.Hide();
            u4.Show();
            u4.Dock = DockStyle.Fill;
            this.Controls.Add(u4);
        }
    }
}
