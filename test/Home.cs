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

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion() { Location = new Point(41, 93) };
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(admin);


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Departamentos dep = new Departamentos { Location = new Point(0, 0) };
            dep.CrearDepartamento += new Departamentos.CrearDelegado(CrearDepartamento);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(dep);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Inquilino inquilino = new Inquilino() { Location = new Point(0, 0) };
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(inquilino);

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            VistaRentas rentas = new VistaRentas() { Location = new Point(0, 0) };
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(rentas);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        public void CrearDepartamento()
        {
            NuevoDepartamentos rentas = new NuevoDepartamentos() { Location = new Point(0, 0) };
            rentas.Volver += new NuevoDepartamentos.volverDelegate(departamentos);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(rentas);

        }
        public void departamentos()
        {
            Departamentos dep = new Departamentos { Location = new Point(0, 0) };
            dep.CrearDepartamento += new Departamentos.CrearDelegado(CrearDepartamento);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(dep);
        }
    }
}
