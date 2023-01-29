using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Control_Excel
{
    public partial class Queries : Form
    {
        MySqlConnection conexionBD = Conexion.conexion();
        public Queries()
        {
            InitializeComponent();
            Size = new Size(456, 218);


        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {

            cbox2.Visible = true;
            cbox3.Visible = true;
            btnEjecutar.Visible = true;

            if (cbox1.Text == "Mes")
            {
                lblIdmes.Visible = true;
                lblTipo.Visible = false;
                lblAño.Visible = true;
                llenarComboboxMes(cbox2);
                llenarComboboxAño(cbox3);
            }
            else if (cbox1.Text == "Tipo")
            {
                lblTipo.Visible = true;
                lblAño.Visible = false;
                lblIdmes.Visible = false;
            }
        }

        public void llenarComboboxMes(ComboBox combo)
        {
            try
            {
                //Se abre la conexion con la base de datos
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                //Consulta que hacemos a la base de datos para llenar el combobox
                string query = "SELECT * FROM meses";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);

                //Comandos para tener un datasource
                MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Comandos para llenar el combobox
                cbox2.ValueMember = "idmes";
                cbox2.DisplayMember = "mes";
                cbox2.DataSource = dt;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un problema al cargar el combobox");
            }
        }

        public void llenarComboboxAño(ComboBox combico)
        {
            try
            {
                //Se abre la conexion con la base de datos
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                //Consulta que hacemos a la base de datos para llenar el combobox
                string query = "SELECT * FROM años";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);

                //Comandos para tener un datasource
                MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Comandos para llenar el combobox
                cbox3.ValueMember = "idaño";
                cbox3.DisplayMember = "año";
                cbox3.DataSource = dt;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un problema al cargar el combobox");
            }







        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            Size = new Size(456, 447);

            //Mapeamos la variable del combobox de mes
            string resultadoComboMes;
            resultadoComboMes = cbox2.GetItemText(cbox2.SelectedItem);
            //MessageBox.Show(resultadoComboMes);

            //Mapeamos la variable del combobox de año
            string resultadoComboAño;
            resultadoComboAño = cbox3.GetItemText(cbox3.SelectedItem);

            //Ejecutamos la consulta para sacar el idmes
            string query = "SELECT IDMES FROM MESES WHERE MES = '" + resultadoComboMes + "'";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            string idmes = Convert.ToString(consulta.ExecuteScalar());
            //Ejecutamos la consulta para sacar el nombre del año
            string query2 = "SELECT AÑO FROM AÑOS WHERE AÑO = " + resultadoComboAño;
            MySqlCommand consulta2 = new MySqlCommand(query2, conexionBD);
            string nombreAño = Convert.ToString(consulta2.ExecuteScalar());

            //Ejecutamos la consulta para sacar el id del año
            string query3 = "SELECT idaño FROM AÑOS WHERE AÑO = " + resultadoComboAño;
            MySqlCommand consulta3 = new MySqlCommand(query3, conexionBD);
            string idAño = Convert.ToString(consulta3.ExecuteScalar());

            updateDiaMes(idmes);
            string query4 = "UPDATE pruebas SET IDMES = " + idmes + ", IDAÑO= " + idAño + " WHERE FECHA BETWEEN '" + nombreAño + "-" + idmes + "-01' AND '" + nombreAño + "-" + idmes + "-31'";
            rtxt1.Text = "VAS A EJECUTAR LA SIGUIENTE CONSULTA :" +
                "\n" + query4;

            //MySqlCommand consulta3 = new MySqlCommand(query3, conexionBD);


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnUpdate1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                //Mapeamos la variable del combobox de mes
                string resultadoComboMes;
                resultadoComboMes = cbox2.GetItemText(cbox2.SelectedItem);
                //MessageBox.Show(resultadoComboMes);

                //Mapeamos la variable del combobox de año
                string resultadoComboAño;
                resultadoComboAño = cbox3.GetItemText(cbox3.SelectedItem);

                //Ejecutamos la consulta para sacar el idmes
                string query = "SELECT IDMES FROM MESES WHERE MES = '" + resultadoComboMes + "'";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);
                string idmes = Convert.ToString(consulta.ExecuteScalar());

                //Ejecutamos la consulta para sacar el nombre del año
                string query2 = "SELECT AÑO FROM AÑOS WHERE AÑO = " + resultadoComboAño;
                MySqlCommand consulta2 = new MySqlCommand(query2, conexionBD);
                string nombreAño = Convert.ToString(consulta2.ExecuteScalar());

                //Ejecutamos la consulta para sacar el id del año
                string query3 = "SELECT idaño FROM AÑOS WHERE AÑO = " + resultadoComboAño;
                MySqlCommand consulta3 = new MySqlCommand(query3, conexionBD);
                string idAño = Convert.ToString(consulta3.ExecuteScalar());

                string query4 = "UPDATE pruebas SET IDMES = " + idmes + ", IDAÑO= " + idAño + " WHERE FECHA BETWEEN '" + nombreAño + "-" + idmes + "-01' AND '" + nombreAño + "-" + idmes + "-31'";
                MySqlCommand consulta4 = new MySqlCommand(query4, conexionBD);
                MessageBox.Show("Se ha realizado el update");
            }

            

            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un problema al hacer el update");
            }
        }

        public void updateDiaMes(string mes)
        {
            mes = Convert.ToInt32();
           
            if (mes == 2)
            {
                dia = 28;
               
            }
            //
        }
    }
    
}
