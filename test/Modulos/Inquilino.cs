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
    public partial class Inquilino : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        public Inquilino()
        {
            InitializeComponent();
        }

        private void Inquilino_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * FROM inquilino";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            dataGridView1.DataSource = ds;

        }

        private void new_BTN_Click(object sender, EventArgs e)
        {
            conexion.CMD("INSERT INTO `ggrentals`.`inquilinos` (`id_Inquilino`, `nombre`, `telefono`, `correo`, `nom_TB`, `dir_TB`, `tel_TB`) VALUES ('"+inquilino_id_TBX.Text.ToString()+"', '"+nombre_inquilino_TBX.Text.ToString()+"', '"+tel_inquilino_TBX.Text.ToString()+"', '"+correo_inquilino_TBX.Text.ToString()+"', '"+nombre_tb_TBX.Text.ToString()+"', '"+dir_tb_TBX.Text.ToString()+"', '"+tel_tb_TBX.Text.ToString()+"');");
        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
            conexion.CMD("DELETE FROM `ggrentals`.`inquilinos` WHERE(`id_inquilino` = '" + inquilino_id_TBX.ToString() + "')");
        }
    }
}
