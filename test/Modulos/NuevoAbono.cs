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
using System.IO;
using Microsoft.VisualBasic.Devices;

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
        public static string Dirección { get; set; }
        Computer ju = new Computer();
        void Motor(string Mot)
        {
            string pop = Mot;

            //Archivos
            for (int i = 0; i < Directory.EnumerateFiles(Mot).Count(); i++)
            {
                FileInfo k = new FileInfo(Directory.GetFiles(Mot)[i]);
                if (k.Name == "ReciboGGRentals.docx")
                {
                    Dirección = k.FullName;
                }
            }

            //Carpetas
            if (Directory.EnumerateDirectories(Mot).Count() > 0)
            {
                for (int i = 0; i < Directory.EnumerateDirectories(Mot).Count(); i++)
                {
                    Motor(Directory.GetDirectories(Mot)[i]);
                }
            }
        }
        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            int deuda = conexion.deudas(user_TBX.ToString())-int.Parse(cantidad_TBX.Text.ToString());
            if (deuda > 0)
            {
                conexion.CMD("UPDATE rentas SET deudas = '" + deuda + " ', WHERE id_inquilino =" + user_TBX.Text.ToString() + "'");

                //Formato que creará para el recibo de que abono
                string NumerosALetras = c.enletras(cantidad_TBX.Texts); //metodo que convierte a letras

                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);//busca el archivo en la carpeta mi musica
                Motor(ruta); //llamamos el metodo para que busque el archivo
                objWord.Application objAplicacion = new objWord.Application();
                object oMissing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc";

                //Start Word and create a new document.
                objWord._Application oWord;
                objWord._Document oDoc;
                oWord = new objWord.Application();
                oWord.Visible = true;
                object oTemplate = Dirección; //Se debe de especificar correctamente su ubicación
                oDoc = oWord.Documents.Open(ref oTemplate, ref oMissing,
                    ref oMissing, ref oMissing);

                //Para añadir el numero de folio
                object Folio = "Folio"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range place = oDoc.Bookmarks.get_Item(ref Folio).Range;
                place.Text = "238601";// lo que se desea modificar
                object rangoP = place;
                oDoc.Bookmarks.Add("Folio", ref rangoP); //Marcador que modificará

                //Para añadir la fecha
                object Fecha = "Fecha"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range Time = oDoc.Bookmarks.get_Item(ref Fecha).Range;
                Time.Text = Propiedades.Fecha.ToString();// lo que se desea modificar
                object rangoF = Time;
                oDoc.Bookmarks.Add("Fecha", ref rangoF); //Marcador que modificará

                //Para añadir el nombre de la persona que abono
                object Cliente = "Cliente"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range C = oDoc.Bookmarks.get_Item(ref Cliente).Range;
 /*que busque la persona que pago*/  C.Text = user_TBX.Texts;// lo que se desea modificar
                object CLienteO = C;
                oDoc.Bookmarks.Add("Cliente", ref CLienteO); //Marcador que modificará

                //Para añadir la cantidad de dinero en numeros
                object CantidadNum = "CantidadNum"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range CantNum = oDoc.Bookmarks.get_Item(ref CantidadNum).Range;
                CantNum.Text = cantidad_TBX.Texts;// lo que se desea modificar
                object OCantNum = CantNum;
                oDoc.Bookmarks.Add("CantidadNum", ref OCantNum); //Marcador que modificará

                //Para añadir la cantidad en letras
                object CantidadLetras = "CantidadLetras"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range letras = oDoc.Bookmarks.get_Item(ref CantidadLetras).Range;
                letras.Text = NumerosALetras;// lo que se desea modificar
                object OLetras = letras;
                oDoc.Bookmarks.Add("CantidadLetras", ref OLetras); //Marcador que modificará

                //Para añadir si es renta o abono
                object RentaAbono = "RentaAbono"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range Abono = oDoc.Bookmarks.get_Item(ref RentaAbono).Range;
                Abono.Text = "Abono";// lo que se desea modificar
                object OAbono = Abono;
                oDoc.Bookmarks.Add("RentaAbono", ref OAbono); //Marcador que modificará

                //Para añadir el meotdo de pago
                object Pago = "Pago"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range Metodopago = oDoc.Bookmarks.get_Item(ref Pago).Range;
                Metodopago.Text = MetodoPago_TBX.Texts;// lo que se desea modificar
                object OPago = Metodopago;
                oDoc.Bookmarks.Add("Pago", ref OPago); //Marcador que modificará

                //Para añadir el nombre de la persona que abono en el segundo marcador
                object Cliente2 = "Cliente2"; //Se debe añadir el marcador en la plantilla de word
                objWord.Range C2 = oDoc.Bookmarks.get_Item(ref Cliente2).Range;
                /*que busque la persona que pago*/
                C2.Text = user_TBX.Texts;// lo que se desea modificar
                object CLienteO2 = C2;
                oDoc.Bookmarks.Add("Cliente2", ref CLienteO2); //Marcador que modificará
            }
            else
            {
                conexion.CMD("DELETE FROM rentas WHERE id_inquilino= '"+user_TBX.Text.ToString()+"'");
            }
        }

        private void NuevoAbono_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT * FROM rentas";
            DataSet ds = conexion.GetDataSet(sqlCommand);
            Data_Abonados.DataSource = ds.Tables[0];
            Data_Abonados.Update();
        }
    }
}
