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
    public partial class NuevoDepartamentos : UserControl
    {
        public NuevoDepartamentos()
        {
            InitializeComponent();
        }
        Conexion.SQL conexion = new Conexion.SQL();

        public delegate void volverDelegate();
        public event volverDelegate Volver;

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            conexion.CMD("INSERT INTO `ggrentals`.`departamentos` (`id_departamentos`, `nombre`, `ubicacion`, `costo`) VALUES ('" + departamento_ID_TBX.Text.ToString() + "','" + departamento_TBX.Text.ToString() + "', '" + ubicacion_TBX.Text.ToString() + "', '" + costo_TBX.Text.ToString() + "');");
            
        }

        private void NuevoDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
