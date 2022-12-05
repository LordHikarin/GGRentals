//using MySqlConnector;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace test.Conexion
{
    //Aqui dentro debe ir todo metodo que Requiera SQL
    class SQL
    {
        //Tipo de usuario, se asigna en Login
        public Boolean user;


        //Conexion SQL
        readonly MySqlConnection cn;
        MySqlCommand cmd;

        //Abrir conexion con SQL
        public SQL() {
            try
            {
                //Descomenta el que necesites
                //Ingresar informacion de la base de datos
                cn = new MySqlConnection("Data Source = bdv13p7ggah8rblyzmc3-mysql.services.clever-cloud.com; User ID = ujjuygkfcbwb4z5y; Password = NC7HN23JXMQL3598JbYi; Initial Catalog =bdv13p7ggah8rblyzmc3;");
                cn.Open();
                //MessageBox.Show("Conexion Correcta.");
            }
            catch (Exception x)
            {
                MessageBox.Show("Conexion Fallida, " + x.ToString());
            }

        }
        //Comando SQL, ejecuta un Query
        public void CMD(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cambios Efectuados Correctamente.");
                cn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show("Error, " + x.ToString());
            }
        }
        public int Contador(string query) {
            int contador = 0;
            try
            {
                cmd = new MySqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    contador++;
                }
                cn.Close();
                return contador;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error, " + x.ToString());
                return contador;
            }
        }

        //Login, se usa en la primera pantalla
        public Boolean Login(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetValue(3).ToString().Equals("1")) {
                        Propiedades.admin = true;
                    }
                    cn.Close();
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
            cmd = new MySqlCommand(sqlCommand, cn);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            ds.Tables.Add(table);
            cn.Close();
            return ds;
        }
    }
}
