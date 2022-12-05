﻿using System;
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
    public partial class Administracion : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        public delegate void CrearDelegado();
        public event CrearDelegado CrearUsuario;
        public Administracion()
        {
            InitializeComponent();
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nombre_TBX.Text))
            {
                MessageBox.Show("Favor de introducir un nombre.");
            }
            else
            {
                string query = "backup database GGRentals to disk = 'C:\\backup\\" + nombre_TBX.Text.ToString() + ".bak' with name = 'backup GGRentals', description = 'Backup Complete';";
                conexion.CMD(query);
            }
        }

        private void Restore_BTN_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nombre_TBX.Text))
            {
                MessageBox.Show("Favor de introducir un nombre.");
            }
            else
            {
                string query = "Restore Database GGRentals From Disk = 'c:\\backup\\" + nombre_TBX.Text.ToString() + ".bak' with file = 1, recovery;";
                conexion.CMD(query);
            }
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * FROM empleados";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            usuarios_DATA.DataSource = ds.Tables[0];
            usuarios_DATA.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
        }
    }
}
