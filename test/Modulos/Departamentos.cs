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

        public delegate void CrearDelegado();
        public event CrearDelegado CrearDepartamento;

        private void Departamentos_Load(object sender, EventArgs e)
        {
           string sqlCommand = "SELECT * FROM departamentos";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            dept_DATA.DataSource = ds.Tables[0];
            dept_DATA.Update();
        }

        private void new_BTN_Click(object sender, EventArgs e)
        {

        }

        private void del_BTN_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            CrearDepartamento();
        }
    }
}
