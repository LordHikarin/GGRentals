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

        public delegate void CrearDelegado();
        public event CrearDelegado CrearInquilino;

        private void Inquilino_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * FROM inquilinos";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CrearInquilino();
        }

        private void Btn_Borrar_Click(object sender, EventArgs e) // al seleccionar uno que lo borre
        {

        }
    }
}
