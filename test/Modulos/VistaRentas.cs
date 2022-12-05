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
    public partial class VistaRentas : UserControl
    {
        Conexion.SQL Conexion = new Conexion.SQL();
        public VistaRentas()
        {
            InitializeComponent();
        }
        public delegate void RentaDelegado();
        public event RentaDelegado Rentas;
        private void label1_Click(object sender, EventArgs e)
        {
            Rentas();
        }

        private void VistaRentas_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * FROM rentas";
            DataSet ds = Conexion.GetDataSet(sqlCommand);
            rentas_DATA.DataSource = ds.Tables[0];
            rentas_DATA.Update();
        }
    }
}
