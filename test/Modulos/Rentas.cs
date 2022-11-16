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
    public partial class Rentas : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
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
    }
}
