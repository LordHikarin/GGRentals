using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objWord = Microsoft.Office.Interop.Word;

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

        private void BtnRdn_contrato_Click(object sender, EventArgs e)
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
            object Lugar = "Lugar"; //Se debe añadir el marcador en la plantilla de word
            objWord.Range place = oDoc.Bookmarks.get_Item(ref Lugar).Range;
            place.Text = "Puerto Peñasco, Sonora, México";// lo que se desea modificar
            object rangoP = place;
            oDoc.Bookmarks.Add("Lugar", ref rangoP); //Marcador que modificará
        }
    }
}
