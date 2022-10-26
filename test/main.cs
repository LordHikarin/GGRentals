using FontAwesome.Sharp;
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

namespace test
{
    public partial class main : MaterialForm
    {
        public main()
        {
            InitializeComponent();
        }
        Conexion.SQL Conexion = new Conexion.SQL();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            SQL(usr_TBX.Text.ToString(), psw_TBX.Text.ToString());
        }

        public void SQL(string user, string password)
        {
            if (Conexion.Login("SELECT * FROM Empleado WHERE Usuario = '" + user + "'and Contraseña = '" + password + "'"))
            {
                Home rentas = new Home();
                this.Hide();
                rentas.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void usr_TBX_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usr_TBX.Text) && !String.IsNullOrEmpty(psw_TBX.Text))
            {
                login_BTN.Enabled = true;
                login_BTN.BackColor = Color.Orchid;
            }
            else
            {
                login_BTN.Enabled = false;
                login_BTN.BackColor = Color.Gray;
            }
        }

        private void psw_TBX_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usr_TBX.Text) && !String.IsNullOrEmpty(psw_TBX.Text))
            {
                login_BTN.Enabled = true;
                login_BTN.BackColor = Color.Orchid;
            }
            else
            {
                login_BTN.Enabled = false;
                login_BTN.BackColor = Color.Gray;
            }

        }
    }
}
