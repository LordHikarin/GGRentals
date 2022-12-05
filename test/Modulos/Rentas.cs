using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objWord = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace test.Modulos
{
    public partial class Rentas : UserControl
    {
        Conexion.SQL Conexion = new Conexion.SQL();
        int costo=500;
        int deuda=0;
        public Rentas()
        {
            InitializeComponent();
        }
        public delegate void VolverDelegado();
        public event VolverDelegado Volver;

        private void Rentas_Load(object sender, EventArgs e)
        {
            /*
            */
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            deuda=Convert.ToInt32(((dtTime_Salida.Value - dtTime_LLegada.Value).TotalDays)*costo);
            TxtBx_Costo.Texts = deuda.ToString();
        }

        private void new_BTN_Click(object sender, EventArgs e)
        {

        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
        }

        private void btn_Contrato_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void BtnRdn_contrato_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            Conexion.CMD("DELETE FROM `ggrentals`.`rentas` WHERE(`id_inquilino` = '" + TxtBx_idInquilino.ToString() + "')");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Conexion.CMD("`ggrentals`.`rentas` (`id_inquilino`, `id_departamento`, `fecha_inicio`, `fecha_final`, `deudas`) VALUES ('" + TxtBx_IdDepa.ToString() + "','" + TxtBx_idInquilino.ToString() + "','" + dtTime_LLegada.Value + "','" + dtTime_Salida.Value + "','" + deuda + "');");
        }
    }
}
