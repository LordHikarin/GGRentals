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

        Conexion.SQL Conexion = new Conexion.SQL();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Propiedades.admin)
            {
                iconButton1.Visible = true;
                iconButton1.Enabled = true;
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Administracion adm = new Administracion { Location = new Point(0, 0) };
            adm.CrearUsuario += new Administracion.CrearDelegado(CrearUsuario);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(adm);

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
            Inquilino inquilino = new Inquilino { Location = new Point(0, 0) };
            inquilino.CrearInquilino += new Inquilino.CrearDelegado(CrearInquilino);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(inquilino);

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            VistaRentas rentas = new VistaRentas() { Location = new Point(0, 0) };
            rentas.Rentas += new VistaRentas.RentaDelegado(Rentals);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(rentas);
        }
        public void GoRentals()// usario control VistaRentas.cs
        {
            VistaRentas rentas = new VistaRentas() { Location = new Point(0, 0) };
            rentas.Rentas += new VistaRentas.RentaDelegado(Rentals);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(rentas);
        }
        public void Rentals() // usuario control Rentas.cs
        {
            Rentas rentas = new Rentas() { Location = new Point(0, 0) };
            rentas.Volver += new Rentas.VolverDelegado(GoRentals);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(rentas);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        public void CrearDepartamento() //Para volver al de departamentos
        {
            NuevoDepartamentos rentas = new NuevoDepartamentos() { Location = new Point(0, 0) };
            rentas.Volver += new NuevoDepartamentos.volverDelegate(departamentos);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(rentas);

        }
        public void departamentos() // Vista de los departamentos
        {
            Departamentos dep = new Departamentos { Location = new Point(0, 0) };
            dep.CrearDepartamento += new Departamentos.CrearDelegado(CrearDepartamento);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(dep);
        }
        public void CrearInquilino()
        {
            NuevoInquilino inq = new NuevoInquilino() { Location = new Point(0, 0) };
            inq.Volver += new NuevoInquilino.volverDelegate(inquilinos);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(inq);

        }
        public void inquilinos()
        {
            Inquilino inquilino = new Inquilino { Location = new Point(0, 0) };
            inquilino.CrearInquilino += new Inquilino.CrearDelegado(CrearInquilino);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(inquilino);
        }
        public void CrearUsuario()
        {
            NuevoUsuario user = new NuevoUsuario() { Location = new Point(0, 0) };
            user.Volver += new NuevoUsuario.volverDelegate(usuario);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(user);

        }
        public void usuario()
        {
            Administracion adm = new Administracion { Location = new Point(0, 0) };
            adm.CrearUsuario += new Administracion.CrearDelegado(CrearUsuario);
            HomeContainer.Controls.Clear();
            HomeContainer.Controls.Add(adm);
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
