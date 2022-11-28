using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.Modulos
{
    public partial class Rentas : UserControl
    {
        Conexion.SQL Conexion = new Conexion.SQL();
        int costo=500;
        int deuda=0;
        public Rentas()
        {
            InitializeComponent();
        }

        private void Rentas_Load(object sender, EventArgs e)
        {

            string sqlCommand = "SELECT * FROM departamentos";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            rentas_DATA.DataSource = ds;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            deuda=Convert.ToInt32((dateTimePicker1.Value - dateTimePicker2.Value).TotalDays)*costo);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            Conexion.CMD("`ggrentals`.`rentas` (`id_inquilino`, `id_departamento`, `fecha_inicio`, `fecha_final`, `deudas`) VALUES ('" + inquilino_id_TBX.ToString() + "','" + Departamento_id_TBX.ToString() + "','" + dateTimePicker1.Value + "','" + dateTimePicker1.Value + "','" + deuda + "');");
        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
            Conexion.CMD("DELETE FROM `ggrentals`.`rentas` WHERE(`id_inquilino` = '"+inquilino_id_TBX.ToString()+"')");
        }
    }
}
