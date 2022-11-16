using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Navigation;

namespace test.Conexion
{
    //Aqui dentro debe ir todo metodo que Requiera SQL
    class SQL
    {
        //Tipo de usuario, se asigna en Login
        public string user = "";


        //Conexion SQL
        readonly SqlConnection cn;
        SqlCommand cmd;

        //Abrir conexion con SQL
        public SQL(){
            try
            {
                //Ingresar informacion de la base de datos
                cn = new SqlConnection("Data Source = Localhot; User ID = root; Password = 4696; Initial Catalog = GGRentals;");
                cn.Open();
                MessageBox.Show("Conexion Correcta.");
            }
            catch (Exception x)
            {
                MessageBox.Show("Conexion Fallida, "+x.ToString());
            }
        }
        //Comando SQL, ejecuta un Query
        public void CMD(string query)
        {
            try
            {
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cambios Efectuados Correctamente.");
            }
            catch (Exception x)
            {
                MessageBox.Show("Error, " + x.ToString());
            }
        }
        /*Misma Conexion, diferente metodo de uso
        ** Desmarcar solo si el primero causa errores **
        SqlDataAdapter dr;
        public void SQL(string command)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
                {
                    DataSource = "Localhost",
                    UserID = "root",
                    Password = "4696",
                    InitialCatalog = "GGRentals"
                };
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(command, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cambios Efectuados Correctamente.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion.");
            }
        }
        */

        //Login, se usa en la primera pantalla
        public Boolean Login(string query)
        {
            try
            {
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error, " + x.ToString());
                return false;
            }

        }

        //Rellenar un Dataset con un query SELECT*FROM Tabla
        public DataSet GetDataSet(string sqlCommand)
        {
            DataSet ds = new DataSet();
            cmd = new SqlCommand(sqlCommand, cn);
            cmd.Connection.Open();
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            ds.Tables.Add(table);
            return ds;
        }
    }
}
