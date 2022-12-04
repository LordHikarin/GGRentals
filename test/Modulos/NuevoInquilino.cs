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
    public partial class NuevoInquilino : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        public NuevoInquilino()
        {
            InitializeComponent();
        }
        public delegate void volverDelegate();
        public event volverDelegate Volver;

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            conexion.CMD("INSERT INTO `ggrentals`.`inquilinos` (`id_Inquilino`, `nombre`, `telefono`, `correo`, `nom_TB`, `dir_TB`, `tel_TB`) VALUES ('" + id_inquilino_TBX.Text.ToString() + "', '" + nombre_inquilino_TBX.Text.ToString() + "', '" + tel_inquilino_TBX.Text.ToString() + "', '" + correo_inquilino_TBX.Text.ToString() + "', '" + nombre_tb_TBX.Text.ToString() + "', '" + dir_tb_TBX.Text.ToString() + "', '" + tel_tb_TBX.Text.ToString() + "');");
        }
    }
}
