using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SpreadsheetLight;


namespace Control_Excel
{
    class Consultas
    {
        
        //Metodo para llenar el datagrid principal
        public void llenarGrid(DataGridView grid)
        {
            //Se abre la conexion con la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            //Consulta que hacemos a la base de datos para llenar el grid
            string query = "SELECT fecha, concepto, movimiento, importe, disponible, observaciones, MES , Año FROM gastos inner join meses on gastos.idmes = meses.idmes inner join años on gastos.idaño = años.idaño";

            MySqlCommand consulta = new MySqlCommand(query, conexionBD);

            MySqlDataAdapter da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);

            grid.DataSource = dt;
            conexionBD.Close();
        }

        






    }

    
}
