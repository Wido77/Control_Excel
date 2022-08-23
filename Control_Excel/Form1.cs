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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenarComboboxes();
            lblSumatorioR.Text = "0";



        }
        //Al darle al boton de cargar en base de datos, te abre un explorador para seleccionar el excel y despues, lo importa
        //Revisar este metodo dentro del boton, seguro que se puede crear una funcion aparte para no tenerlo que hacer en el propio boton
        public void btnCargar_Click(object sender, EventArgs e)
        {
            //Se comprueba que el resultado de openfiledialog sea OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Ruta = openFileDialog1.FileName;
                //Creamos una worksheet llamada sl
                SLDocument sl = new SLDocument(Ruta);
                SLWorksheetStatistics propiedades = sl.GetWorksheetStatistics();
                
                int ultimaFila = propiedades.EndRowIndex;

                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                //Se recorre el excel por filas, empezando por la fila 6 y llegando al final del documento
                for (int i = 6; i <= ultimaFila; i++)
                {
                    string codigo = sl.GetCellValueAsString("B" + i);

                    string sql = "INSERT INTO gastos (fecha, concepto, movimiento, importe, disponible, observaciones ) VALUES (@fecha,  @concepto, " +
                        "@movimiento, @importe, @disponible, @observaciones)";

                    try
                    {

                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                        //Insertar datos en la base de datos, los campos con @ no son los nombres de la base de datos, son los alias creados anteriormente
                        comando.Parameters.AddWithValue("@fecha", sl.GetCellValueAsDateTime("B" + i));
                        comando.Parameters.AddWithValue("@fecha_valor", sl.GetCellValueAsDateTime("C" + i));
                        comando.Parameters.AddWithValue("@concepto", sl.GetCellValueAsString("D" + i));
                        comando.Parameters.AddWithValue("@movimiento", sl.GetCellValueAsString("E" + i));
                        comando.Parameters.AddWithValue("@importe", sl.GetCellValueAsInt32("F" + i));
                        comando.Parameters.AddWithValue("@disponible", sl.GetCellValueAsInt32("H" + i));
                        comando.Parameters.AddWithValue("@observaciones", sl.GetCellValueAsString("J" + i));

                        comando.ExecuteNonQuery();

                    }

                    catch (MySqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                        MessageBox.Show("La plantilla no se ha cargado o ha habido un problema al cargar el archivo");

                    }
                }

                MessageBox.Show("La plantilla se ha cargado");
                conexionBD.Close();

            }

            else
            {
                
            }



        }


        //Metodo para el boton de grid --> Hace una consulta a la base de datos para mostrar todo lo de la base de datos
        private void btnGrid_Click(object sender, EventArgs e)
        {
            Consultas cmda = new Consultas();
            cmda.llenarGrid(DataGridView1);
        }

        //Metodo para cargar el combobox
        public void llenarComboboxes()
        {
            try
            {
                //Se abre la conexion con la base de datos
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                //Consulta que hacemos a la base de datos para llenar el combobox
                string query = "SELECT * from meses";
                string query2 = "SELECT * from años";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);
                MySqlCommand consulta2 = new MySqlCommand(query2, conexionBD);

                //Comandos para tener un datasource
                MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Comandos para llenar el combobox
                comboBox1.ValueMember = "idaño";
                comboBox1.DisplayMember = "mes";
                comboBox1.DataSource = dt;

                MySqlDataAdapter DA = new MySqlDataAdapter(consulta2);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                //Comandos para llenar el combobox
                cboxAño.ValueMember = "idaño";
                cboxAño.DisplayMember = "Año";
                cboxAño.DataSource = DT;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un problema al cargar el combobox");
            }





        }

        public void ResetSource()
        {
            DataGridView1.Refresh();
        }

        private void btnAño_Click(object sender, EventArgs e)
        {
            string resultadoComboAño;
            resultadoComboAño = cboxAño.GetItemText(cboxAño.SelectedItem);
            llenarAño(DataGridView1, resultadoComboAño);
        }

        //Metodo para llenar el datagrid en funcion del mes

        public void btnMes_Click(object sender, EventArgs e)
        {
            
            string resultadoCombo;
            resultadoCombo = comboBox1.GetItemText(comboBox1.SelectedItem);
            //Form1 cmda = new Form1();
            llenarMes(DataGridView1,resultadoCombo);
            llenarGastos(resultadoCombo);
            llenarIngresos(resultadoCombo);
            llenarAhorros(resultadoCombo);
            llenarDia1(resultadoCombo);
            llenarDia31(resultadoCombo);
            llenarComboboxConcepto(comboBox2, resultadoCombo);
            gpboxMes.Text = resultadoCombo;



        }
        public string pruebaReturn
        {
            get { return comboBox1.GetItemText(comboBox1.SelectedItem); }
            set { value = comboBox1.GetItemText(comboBox1.SelectedItem); }
        }

        public void llenarMes(DataGridView grid, string resultadoCombo)
        {


            // MessageBox.Show(resultadoCombo);
            //Se abre la conexion con la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();


            //Consulta que hacemos a la base de datos para llenar el grid
            string query = "SELECT FECHA, CONCEPTO, MOVIMIENTO, IMPORTE, DISPONIBLE, OBSERVACIONES, MES, AÑO FROM GASTOS INNER JOIN MESES ON GASTOS.idmes = meses.IDMES INNER JOIN AÑOS ON GASTOS.idaño=AÑOS.idaño WHERE MESES.MES = '" + resultadoCombo + "';";

            MySqlCommand consulta = new MySqlCommand(query, conexionBD);

            MySqlDataAdapter da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);

            grid.DataSource = dt;
            conexionBD.Close();
        }

        public void llenarAño(DataGridView grid, string resultadoComboAño)
        {


            //Se abre la conexion con la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();


            //Consulta que hacemos a la base de datos para llenar el grid
            string query = "SELECT FECHA, CONCEPTO, MOVIMIENTO, IMPORTE, DISPONIBLE, OBSERVACIONES, MES, AÑO FROM GASTOS INNER JOIN AÑOS ON GASTOS.idaño=AÑOS.idaño INNER JOIN MESES ON GASTOS.idmes = meses.IDMES WHERE años.Año = '" + resultadoComboAño + "';";

            MySqlCommand consulta = new MySqlCommand(query, conexionBD);

            MySqlDataAdapter da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);

            grid.DataSource = dt;
            conexionBD.Close();
        }

        public void llenarGastos(string resultadoCombo)
        {
            //Se abre la conexion con la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            //Consulta que hacemos a la base de datos para llenar el campo gastos
            string query = "SELECT ABS(SUM(importe)) FROM gastos  INNER JOIN meses ON gastos.idmes = meses.idmes WHERE meses.mes = '" + resultadoCombo + "' AND tipo = 'Gastos'";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            int Gastos = Convert.ToInt32(consulta.ExecuteScalar());
            lblGastosR.Text = Convert.ToString(Gastos) + " €"; 
            
        }

        public void llenarIngresos(string resultadoCombo)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            //Consulta que hacemos a la base de datos para llenar el campo gastos
            string query = "SELECT ABS(SUM(importe)) FROM gastos  INNER JOIN meses ON gastos.idmes = meses.idmes WHERE meses.mes = '" + resultadoCombo + "' AND tipo = 'Ingresos'";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            int Ingresos = Convert.ToInt32(consulta.ExecuteScalar());
            lblIngresosR.Text = Convert.ToString(Ingresos) + " €";
        }

        public void llenarAhorros(string resultadoCombo)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            //Consulta que hacemos a la base de datos para llenar el campo gastos
            string query = "SELECT SUM(IMPORTE) AS AHORROS FROM gastos INNER JOIN meses ON meses.idmes=gastos.IDMES WHERE meses.mes = '" + resultadoCombo + "'";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            int Ahorros = Convert.ToInt32(consulta.ExecuteScalar());
            if (Ahorros > 0)
            {
                lblAhorrosR.ForeColor = Color.Blue;
            }
            else
            {
                lblAhorrosR.ForeColor = Color.DarkRed;
            }
            lblAhorrosR.Text = Convert.ToString(Ahorros) + " €";
        }

        public void llenarDia1(string resultadoCombo)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            //Consulta que hacemos a la base de datos para llenar el campo dia1
            string query = "SELECT disponible FROM gastos INNER JOIN meses ON meses.idmes=gastos.IDMES WHERE meses.mes = '" + resultadoCombo + "' ORDER BY fecha asc LIMIT 1";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            int Ahorros = Convert.ToInt32(consulta.ExecuteScalar());
            //lblDisp1.Text = Convert.ToString(Ahorros) + " €";
        }

        public void llenarDia31(string resultadoCombo)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            //Consulta que hacemos a la base de datos para llenar el campo dia31
            string query = "SELECT disponible FROM gastos INNER JOIN meses ON meses.idmes=gastos.IDMES WHERE meses.mes = '" + resultadoCombo + "' ORDER BY fecha desc LIMIT 1";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            int Ahorros = Convert.ToInt32(consulta.ExecuteScalar());
            //lblDisp31.Text = Convert.ToString(Ahorros) + " €";
        }

        private void btnGrafico1_Click(object sender, EventArgs e)
        {
            Form Grafico1 = new Queries();
            Grafico1.Show();
            
        }

        public void llenarComboboxConcepto(ComboBox combo, string resultadoCombo)
        {
            try
            {
                //Se abre la conexion con la base de datos
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                //MessageBox.Show(resultadoCombo);

                //Consulta que hacemos a la base de datos para llenar el combobox
                //string query = "SELECT concepto from gastos  INNER JOIN meses ON meses.idmes=gastos.IDMES WHERE meses.mes = '" + resultadoCombo + "' GROUP BY concepto";
                string query = "SELECT tipos.Concepto from tipos INNER JOIN gastos ON gastos.idtipo = tipos.idtipo INNER JOIN meses ON meses.idmes = gastos.IDMES WHERE meses.mes = '" + resultadoCombo + "'  GROUP BY tipos.concepto";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);

                //Comandos para tener un datasource
                MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Comandos para llenar el combobox
                comboBox2.ValueMember = "idtipo";
                comboBox2.DisplayMember = "concepto";
                comboBox2.DataSource = dt;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un problema al cargar el combobox");
                MessageBox.Show(ex.Message.ToString());
               
            }
        }

        public void btnConcepto_Click(object sender, EventArgs e)
        {
            string resultadoTipo = comboBox2.GetItemText(comboBox2.SelectedItem);
            //MessageBox.Show(resultadoTipo);
            string resultadoCombo;
            resultadoCombo = comboBox1.GetItemText(comboBox1.SelectedItem);
            Form Desglose = new Desglose(resultadoTipo, resultadoCombo);
            Desglose.Show();
            string resultadoComboConcepto;
            resultadoComboConcepto = comboBox2.GetItemText(comboBox2.SelectedItem);
            
 
            Form1 form1 = new Form1();
            form1.pruebaReturn = comboBox1.GetItemText(comboBox1.SelectedItem);
            llenarGastosConcepto(pruebaReturn, resultadoComboConcepto);
            gpboxConcepto.Text = resultadoComboConcepto;
        }

        public void llenarGastosConcepto(string resultadoCombo, string resultadoComboConcepto)
        {

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
     
            //Consulta que hacemos a la base de datos para llenar el campo gastos
            string query = "SELECT SUM(importe) FROM gastos  INNER JOIN meses ON gastos.idmes = meses.idmes INNER JOIN tipos ON gastos.idtipo = tipos.idtipo WHERE meses.mes = '" + resultadoCombo + "' and tipos.Concepto = '"+resultadoComboConcepto + "'";
            //MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            //int Gastos = Convert.ToInt32(consulta.ExecuteScalar());
            //lblGastosC.Text = Convert.ToString(Gastos) + " €";
            comparaConcepto(query);
            
        }

        //No funciona esta funcion de sumatorio, revisar
        public void comparaConcepto(string query)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            
            int Gastos = Convert.ToInt32(consulta.ExecuteScalar());
           // int total = Convert.ToInt32(lblSumatorioR.Text);
            if (Gastos < 0)
            {
                lblGastosC.Text = Convert.ToString(Gastos) + " €";

                
                //total = total + Convert.ToInt32(consulta.ExecuteScalar());
                //    //Gastos = Gastos + contador;
                //lblSumatorioR.Text = Convert.ToString(total) + " €";
                
            }
            else
            {
                lblIngresosC.Text = Convert.ToString(Gastos) + " €";
                //for (int i = 0; i < 100; i++)
                //{
                //    int contador = 0;
                //    Gastos = Gastos + contador;
                //    lblSumatorioR.Text = Convert.ToString(Gastos) + " €";
                //}
               
            }
        }

        //Metodo para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPruebaForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar a este usuario?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Le has dado a que si");
            }

            else
            {
                MessageBox.Show("Le has dado a que no");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }

}
