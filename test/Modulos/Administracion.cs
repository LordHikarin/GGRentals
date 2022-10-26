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
                string command = "backup database GGRentals to disk = 'C:\\backup\\" + nombre_TBX.Text.ToString() + ".bak' with name = 'backup prueba 1', description = 'Backup Complete'";
                conexion.CMD(command);
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
                string command = "Restore Database GGRentals From Disk = 'c:\\backup\\" + nombre_TBX.Text.ToString() + ".bak' with file = 1, recovery";
                conexion.CMD(command);
            }
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }
    }
}
