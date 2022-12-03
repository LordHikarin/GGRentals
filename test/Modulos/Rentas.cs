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

        private void Rentas_Load(object sender, EventArgs e)
        {

            string sqlCommand = "SELECT * FROM rentas";
            DataSet ds = Conexion.GetDataSet(sqlCommand);
            rentas_DATA.DataSource = ds.Tables[0];
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            deuda=Convert.ToInt32(((dateTimePicker1.Value - dateTimePicker2.Value).TotalDays)*costo);
        }

        private void new_BTN_Click(object sender, EventArgs e)
        {

            Conexion.CMD("`ggrentals`.`rentas` (`id_inquilino`, `id_departamento`, `fecha_inicio`, `fecha_final`, `deudas`) VALUES ('" + inquilino_id_TBX.ToString() + "','" + Departamento_id_TBX.ToString() + "','" + dateTimePicker1.Value + "','" + dateTimePicker1.Value + "','" + deuda + "');");
        }

        private void del_BTN_Click(object sender, EventArgs e)
        {
            Conexion.CMD("DELETE FROM `ggrentals`.`rentas` WHERE(`id_inquilino` = '"+inquilino_id_TBX.ToString()+"')");
        }

        private void btn_Contrato_Click(object sender, EventArgs e)
        {
            //string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//la ruta especificada es el escritorio
            objWord.Application objAplicacion = new objWord.Application();
            //creación del documento
            /*objWord.Document objDocumento = objAplicacion.Documents.Add();
            //Parrafo 1
            objWord.Paragraph objTitulo = objDocumento.Content.Paragraphs.Add(Type.Missing);*/
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            objWord._Application oWord;
            objWord._Document oDoc;
            oWord = new objWord.Application();
            oWord.Visible = true;
            object oTemplate = "C:\\Users\\orlan\\Downloads\\CONTRATO.docx";
            oDoc = oWord.Documents.Open(ref oTemplate, ref oMissing,
                ref oMissing, ref oMissing);
        }
    }
}
