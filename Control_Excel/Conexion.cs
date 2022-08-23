using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Control_Excel
{
    internal class Conexion
    {

        //Funcion para conectarse a la base de datos
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "excel";
            string usuario = "root";
            string password = "pepe";
            string cadenaConexion = "Database=" + bd + ";Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + password + "";
            try
            {

                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;

            }
        }
    }
}
