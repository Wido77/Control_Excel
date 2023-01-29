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
//Llamar elementos del chartcontrol
using System.Windows.Forms.DataVisualization.Charting;

namespace Control_Excel
{
    public partial class Grafico : Form
    {
        public Grafico()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            //Reader para poder leer el procedimiento almacenado
            MySqlDataReader read = null;
            List<int> listaGastos = new List<int>(); 

            try
            {
                //Como vamos a utilizar un procedimiento almacenado, hay que llamarlo (gastosMeses)
                MySqlCommand pAlmacenado = new MySqlCommand("gastosMeses", conexionBD);
                //Le decimos que vamos a utilzar un procedimiento almacenado
                pAlmacenado.CommandType = CommandType.StoredProcedure;
                //Recorremos 12 veces el procedimiento sumando 1 al mes
                for (int i = 1; i <= 12; i++)
                {
                    //Le pasamos un
                    pAlmacenado.Parameters.AddWithValue("@MES", i);

                    int resultadoSP = Convert.ToInt32(pAlmacenado.ExecuteScalar());
                    listaGastos.Add(resultadoSP);
                    pAlmacenado.Parameters.Clear();

                }

                foreach (int numero in listaGastos)
                {
                    listBox1.Items.Add(numero);
                }
                int[] pruebaArray = listaGastos.ToArray();
                string[] mesesArray = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                c1.Series[0].Points.DataBindXY(mesesArray,pruebaArray );
                //cChart.ChartAreas[0].AxisX.CustomLabels.Add( 0,1,"Enero");
                //cChart.ChartAreas[0].AxisX.CustomLabels.Add( 2,4,"Febrero");
               
                //for (int index = 0; index <= 12; index++)

                //{
                //    MessageBox.Show(Convert.ToString(pruebaArray[index]));
                //}

                //pAlmacenado.ExecuteNonQuery();

                //Recorrer el procedimiento almacenado
                //read = pAlmacenado.ExecuteReader();
                //while (read.Read())
                //{
                //    txtboxEnero.Text = Convert.ToString(read["Enero"]);
                //    txtBoxFebrero.Text = Convert.ToString(read["Febrero"]);

                //}




                conexionBD.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        //Esta es la funcion que tenia en el form principal para rellenar el grafico de todos los tipos de gastos, pero en teoria lo voy a colocar aqui.
        public void llenarGrafica(string resultadoComboAño, string resultadoMes)
        {
            //Se abre la conexion con la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            List<int> listaGastos = new List<int>();


            try
            {
                //Como vamos a utilizar un procedimiento almacenado, hay que llamarlo (gastosMeses)
                MySqlCommand pAlmacenado = new MySqlCommand("graficoImporte", conexionBD);
                //Le decimos que vamos a utilzar un procedimiento almacenado
                pAlmacenado.CommandType = CommandType.StoredProcedure;
                // Añadimos los parámetros y sus valores al objeto SqlCommand
                pAlmacenado.Parameters.AddWithValue("@MES", resultadoMes);
                pAlmacenado.Parameters.AddWithValue("@AÑO", resultadoComboAño);

                DataSet dataSet = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(pAlmacenado);
                da.Fill(dataSet);
                c1.DataSource = dataSet.Tables[0];
                //c1.Series[0].IsValueShownAsLabel = true;
                //c1.Series[0].Points.AddXY("Tipo", "Importe");
                //c1.Legends.Add("Tipo");
                //c1.Series[0].XValueMember = "TIPO";

                //c1.Series[0].YValueMembers = "importe";

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string category = row["TIPO"].ToString();
                    double value = Convert.ToDouble(row["IMPORTE"]);

                    c1.Series[0].Points.AddXY(category, value);
                    c1.Series[0].IsValueShownAsLabel = true;
                    c1.Series[0].ChartType = SeriesChartType.Doughnut;
                }

                c1.Legends.Add("Tipo");


                //// Crea un nuevo conjunto de datos para almacenar los resultados del procedimiento almacenado
                //DataSet dataSet = new DataSet();
                //MySqlDataAdapter da = new MySqlDataAdapter(pAlmacenado);
                ////// Rellena el conjunto de datos con los resultados del procedimiento almacenado
                //da.Fill(dataSet);
                ////Se muestran los datos en numero
                //c1.Series[0].IsValueShownAsLabel = true;

                //foreach (DataRow row in dataSet.Tables[0].Rows)
                //{
                //    c1.Series[0].Points.Add(new DataPoint(Convert.ToDouble("Tipo"), Convert.ToDouble("importe")));
                //}

                ////Mostrar en porcentaje
                //double total = 0;
                //foreach (DataPoint point in c1.Series[0].Points)
                //{
                //    total += point.YValues[0];
                //}
                //foreach (DataPoint point in c1.Series[0].Points)
                //{
                //    point.Label = string.Format("{0:0.00}%", (point.YValues[0] / total) * 100);
                //}

                //// Asigna el conjunto de datos como origen de datos del gráfico
                //c1.DataSource = dataSet.Tables[0];

                //c1.Series[0].XValueMember = "TIPO";

                //c1.Series[0].YValueMembers = "importe";

                // Refresca el gráfico para que muestre los datos actualizados
                c1.Invalidate();


                conexionBD.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }



        }
    }
}
