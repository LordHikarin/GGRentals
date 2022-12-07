using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using objWord = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace test.Modulos
{
    public partial class NuevoAbono : UserControl
    {
        Conexion.SQL conexion = new Conexion.SQL();
        Conversion c = new Conversion();
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
                string NumerosALetras = c.enletras(cantidad_TBX.Texts);
                //string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//la ruta especificada es el escritorio
                objWord.Application objAplicacion = new objWord.Application();
                //creación del documento
                //objWord.Document objDocumento = objAplicacion.Documents.Add();
                //Parrafo 1
                //objWord.Paragraph objTitulo = objDocumento.Content.Paragraphs.Add(Type.Missing);
                object oMissing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";

                //Start Word and create a new document.
                objWord._Application oWord;
                objWord._Document oDoc;
                oWord = new objWord.Application();
                oWord.Visible = true;
                object oTemplate = "C:\\Users\\orlan\\Music\\RECIBO.docx"; //Se debe de especificar correctamente su ubicación
                oDoc = oWord.Documents.Open(ref oTemplate, ref oMissing,
                    ref oMissing, ref oMissing);
                object Lugar = "Lugar"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range place = oDoc.Bookmarks.get_Item(ref Lugar).Range;
                place.Text = "Puerto Peñasco, Sonora, México";// lo que se desea modificar
                object rangoP = place;
                oDoc.Bookmarks.Add("Lugar", ref rangoP); //Marcador que modificará
            }
            else
            {
                conexion.CMD("DELETE FROM rentas WHERE id_inquilino= '"+user_TBX.Text.ToString()+"'");
            }
        }
    }
}
