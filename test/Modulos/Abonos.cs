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
    public partial class Abonos : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        public delegate void DelegadoAgregar();
        public event DelegadoAgregar AgregarAbono;
        public Abonos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AgregarAbono();
        }

        private void Abonos_Load(object sender, EventArgs e) // que cargue la tabla
        {
            string sqlCommand = "SELECT * FROM rentas";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            abonos_DATA.DataSource = ds.Tables[0];
            abonos_DATA.Update();
        }

        private void TxtBx_Search__TextChanged(object sender, EventArgs e) //Para que busque el usuario por todos los abonos
        {

        }
    }
}
