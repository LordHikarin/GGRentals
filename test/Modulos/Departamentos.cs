using System;
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
    public partial class Departamentos : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        public Departamentos()
        {
            InitializeComponent();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * FROM departamentos";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            dept_DATA.DataSource = ds;
        }

        private void new_BTN_Click(object sender, EventArgs e)
        {
            conexion.CMD("INSERT INTO `ggrentals`.`departamentos` (`id_departamentos`, `nombre`, `ubicacion`, `costo`) VALUES ('"+departamento_ID_TBX.Text.ToString()+"','"+departamento_TBX.Text.ToString()+"', '"+ubicacion_TBX.Text.ToString()+"', '"+costo_TBX.Text.ToString()+"');");
        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
            conexion.CMD("DELETE FROM `ggrentals`.`departamentos` WHERE(`id_departamentos` = '" + departamento_ID_TBX.Text.ToString() + "')");
        }
    }
}
