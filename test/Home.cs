﻿using System;
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

        private void admin_BTN_Click(object sender, EventArgs e)
        {
            adm.Visible = true;
        }

        private void rentas_BTN_Click(object sender, EventArgs e)
        {
            rent.Visible = true;
        }

        private void inq_BTN_Click(object sender, EventArgs e)
        {
            inq.Visible = true;
        }

        private void dept_BTN_Click(object sender, EventArgs e)
        {
           dept.Visible = true;
        }

        private void home_BTN_Click(object sender, EventArgs e)
        {

        }
    }
}
