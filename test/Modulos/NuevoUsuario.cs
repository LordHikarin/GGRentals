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
    public partial class NuevoUsuario : UserControl
    {
        public delegate void volverDelegate();
        public event volverDelegate Volver;
        Conexion.SQL conexion = new Conexion.SQL();
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            int usuario = conexion.Contador("SELECT * FROM empleados;");
            conexion.CMD("INSERT INTO empleados VALUES (" + usuario + ", '" + user_TBX.Texts.ToString() +"', '" + password_TBX.Texts.ToString() + "', "+ TxtBx_Permisos.Texts.ToString()+")");
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
