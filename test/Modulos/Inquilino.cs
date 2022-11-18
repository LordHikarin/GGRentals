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
            string sqlCommand = "SELECT * FROM inquilinos";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            dataGridView1.DataSource = ds;

        }
    }
}
