using Org.BouncyCastle.Utilities.Collections;
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
    public partial class NuevoAbono : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        public delegate void volverDelegate();
        public event volverDelegate Volver;
        public NuevoAbono()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            int deuda = conexion.deudas(user_TBX.ToString())-int.Parse(cantidad_TBX.Text.ToString());
            if (deuda > 0)
            {
                conexion.CMD("UPDATE rentas SET deudas = '" + deuda + " ', WHERE id_inquilino =" + user_TBX.Text.ToString() + "'");
            }
            else
            {
                conexion.CMD("DELETE FROM rentas WHERE id_inquilino= '"+user_TBX.Text.ToString()+"'");
            }
        }
    }
}
