﻿using System;
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
    public partial class Login : Form
    {
        Conexion.SQL Conexion = new Conexion.SQL();
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            //Si el usuario y contraseña coinciden, cambiar de pantalla
            try
            {
                if (Conexion.Login("SELECT * FROM empleados WHERE nombre = BINARY '" + TxtBoxContraseña.Text.ToString() + "'and contraseña = BINARY '" + TxtBoxUsuario.Text.ToString() + "'"))
                {
                    Propiedades.admin = true;
                    Home rentas = new Home();
                    this.Hide();
                    rentas.ShowDialog();
                    this.Close();
                }
                else
                //Contraseña o Usuario incorrecto
                {
                    MessageBox.Show("Datos incorrectos o usuario no encontrado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void usr_TBX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void psw_TBX_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void circularImagen1_Click(object sender, EventArgs e)
        {

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
             try
            {
                if (Conexion.Login($"select * from empleados where nombre = '{TxtBoxUsuario.Texts}' and contraseña = '{TxtBoxContraseña.Texts}'"))
                {
                    Home rentas = new Home();
                    this.Hide();
                    rentas.ShowDialog();
                    this.Close();
                }
                else
                //Contraseña o Usuario incorrecto
                {
                    MessageBox.Show("Datos incorrectos o usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void botonRedondo1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBoxContraseña.Texts) && !String.IsNullOrEmpty(TxtBoxUsuario.Texts))
            {
                login_BTN.Enabled = true;
                login_BTN.BackgroundColor = Color.FromArgb(74, 156, 242);
            }
            else
            {
                login_BTN.Enabled = false;
                login_BTN.BackgroundColor = Color.Gray;
            }
        }

        private void TxtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtBoxContraseña.Texts) && !String.IsNullOrEmpty(TxtBoxUsuario.Texts))
            {
                login_BTN.Enabled = true;
                login_BTN.BackgroundColor = Color.FromArgb(74, 156, 242);
            }
            else
            {
                login_BTN.Enabled = false;
                login_BTN.BackgroundColor = Color.Gray;
            }
        }
    }
}
