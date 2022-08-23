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
        //Clase para poder sacar la variable desde el Richtextbox al boton de ejecutar la consulta (boton dale)
        public class Consulta
        {
            public static string query;
            public static String Query { get; set; }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {



            if (cbox1.Text == "Mes + Año")
            {
                //Boton de ejecutar 
                btnEjecutar.Visible = true;
                //Etiquetas
                lblIdmes.Visible = true;
                lblTipo.Visible = false;
                lblAño.Visible = true;
                lblConcepto.Visible = false;
                //Comboboxes
                cbox4.Visible = false; //Combobox de tipo
                cbox2.Visible = true; //Combobox de mes
                cbox3.Visible = true; //Combobox de año
                cbox5.Visible = false; //Combobox de concepto
                llenarComboboxMes(cbox2);
                llenarComboboxAño(cbox3);
            }
            else if (cbox1.Text == "Tipo")
            {
                btnEjecutar.Visible = true;
                lblTipo.Visible = true;
                lblAño.Visible = false;
                lblIdmes.Visible = false;
                lblConcepto.Visible = false;
                cbox4.Visible = true;
                cbox2.Visible = false;
                cbox3.Visible = false;
                cbox5.Visible = false;
                
            }

            else if (cbox1.Text == "Concepto")
            {
                btnEjecutar.Visible = true;
                lblTipo.Visible = false;
                lblAño.Visible = false;
                lblIdmes.Visible = false;
                lblConcepto.Visible = true;
                cbox4.Visible = false;
                cbox2.Visible = false;
                cbox3.Visible = false;
                cbox5.Visible = true;
                llenarComboboxConcepto(cbox5);
               
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
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void llenarComboboxAño(ComboBox combo)
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
                MessageBox.Show(ex.Message.ToString());
            }


        }

        public void llenarComboboxConcepto(ComboBox combo)
        {
            try
            {
                //Se abre la conexion con la base de datos
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                //Consulta que hacemos a la base de datos para llenar el combobox
                string query = "SELECT Concepto FROM tipos";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);

                //Comandos para tener un datasource
                MySqlDataAdapter da = new MySqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Comandos para llenar el combobox
                cbox5.ValueMember = "idtipo";
                cbox5.DisplayMember = "concepto";
                cbox5.DataSource = dt;


            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha habido un problema al cargar el combobox");
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            Size = new Size(456, 447);

            updateDDBB();
            rtxt1.Text = "VAS A EJECUTAR LA SIGUIENTE CONSULTA :" +
                       "\n" + Consulta.query;

            // MessageBox.Show(Consulta.query);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton de "Dale" que sirve para realizar la consulta que le hemos pasado a traves de los textbox y despues de darle al boton de ejecutar.
        public void btnUpdate_Click(object sender, EventArgs e)
        {

            conexionBD.Open();
            updateDDBB();

            MessageBox.Show(Consulta.query);
            try
            {
                if (MessageBox.Show("¿Quieres ejecutar la consulta?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand consulta = new MySqlCommand(Consulta.query, conexionBD);
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Se ha realizado el update correctamente");

                }

                else
                {
                    MessageBox.Show("Le has dado a que no");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            conexionBD.Close();
        }


        //Metodo para hacer un update a los diferentes campos en la base de datos(idmes, idaño, tipo, idtipo) en funcion del combobox que se haya seleccionado
        public string updateDDBB()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            //Mapeamos la variable del combobox de campo a cambiar
            string resultadoCampoaCambiar;
            resultadoCampoaCambiar = cbox1.GetItemText(cbox1.SelectedItem);

            if (resultadoCampoaCambiar == "Tipo")
            {
                string resultadoComboTipo;
                resultadoComboTipo = cbox4.GetItemText(cbox4.SelectedItem);
                //string query = "";

                if (resultadoComboTipo == "Ingresos")
                {
                    Consulta.query = "UPDATE gastos SET Tipo= 'Ingresos' WHERE IMPORTE > 0 ";
                    //MySqlCommand consulta = new MySqlCommand(Consulta.query, conexionBD);
                //    rtxt1.Text = "VAS A EJECUTAR LA SIGUIENTE CONSULTA :" +
                //"\n" + Consulta.query;
                    conexionBD.Close();

                }

                else if (resultadoComboTipo == "Gastos")
                {
                    Consulta.query = "UPDATE gastos SET Tipo= 'Gastos' WHERE IMPORTE < 0";
                    //MySqlCommand consulta = new MySqlCommand(Consulta.query, conexionBD);
                //    rtxt1.Text = "VAS A EJECUTAR LA SIGUIENTE CONSULTA :" +
                //"\n" + Consulta.query;
                    conexionBD.Close();
                }

                return Consulta.query;
            }

            else if (resultadoCampoaCambiar == "Mes + Año")
            {

                //Mapeamos la variable del combobox de mes
                string resultadoComboMes;
                resultadoComboMes = cbox2.GetItemText(cbox2.SelectedItem);

                //Mapeamos la variable del combobox de año
                string resultadoComboAño;
                resultadoComboAño = cbox3.GetItemText(cbox3.SelectedItem);

                //Ejecutamos la consulta para sacar el idmes
                string query = "SELECT IDMES FROM MESES WHERE MES = '" + resultadoComboMes + "'";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);
                string idmes = Convert.ToString(consulta.ExecuteScalar());

                int mes = Convert.ToInt32(idmes);
                int año = Convert.ToInt32(resultadoComboAño);

                //Funcion para sacar el ultimo dia de cada mes en funcion del año
                string ultimoDiaMes = Convert.ToString(System.DateTime.DaysInMonth(año, mes));
                
                //Ejecutamos la consulta para sacar el id del año
                string query3 = "SELECT idaño FROM AÑOS WHERE AÑO = " + resultadoComboAño;
                MySqlCommand consulta3 = new MySqlCommand(query3, conexionBD);
                string idAño = Convert.ToString(consulta3.ExecuteScalar());

                Consulta.query = "UPDATE gastos SET IDMES = " + idmes + ", IDAÑO= " + idAño + " WHERE FECHA BETWEEN '" + resultadoComboAño + "-" + idmes + "-01' AND '" + resultadoComboAño + "-" + idmes + "-" + ultimoDiaMes + "'";
                //MySqlCommand consulta4 = new MySqlCommand(Consulta.query, conexionBD);
                //rtxt1.Text = "VAS A EJECUTAR LA SIGUIENTE CONSULTA :" +
                //"\n" + Consulta.query;
                conexionBD.Close();
                return Consulta.query;

                
            }

            else if (resultadoCampoaCambiar == "Concepto")
            {
                //Mapeamos la variable del combobox de ceoncepto
                string resultadoComboConcepto;
                resultadoComboConcepto = cbox5.GetItemText(cbox5.SelectedItem);

                //Ejecutamos la consulta para sacar el idtipo
                string query = "SELECT IDTIPO FROM TIPOS WHERE CONCEPTO = '" + resultadoComboConcepto + "'";
                MySqlCommand consulta = new MySqlCommand(query, conexionBD);
                int idtipo = Convert.ToInt32(consulta.ExecuteScalar());

                //Ejecutamos la consulta para hacer el udpate
                //Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipo + "";
                //rtxt1.Text = "VAS A EJECUTAR LA SIGUIENTE CONSULTA :" +
                //"\n" + Consulta.query;
                //conexionBD.Close();
                //return Consulta.query;
                switch (idtipo)
                {
                    case 1:
                        string idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;
                           
                    case 2:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'UBER%'";
                        return Consulta.query;

                    case 3:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    case 4:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'amzn%'";
                        return Consulta.query;

                    case 5:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    case 6:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    case 7:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    case 8:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    case 9:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    case 10:
                        idtipostring = Convert.ToString(idtipo);
                        Consulta.query = "UPDATE pruebas SET IDTIPO = " + idtipostring + " WHERE CONCEPTO = 'GLOVO'";
                        return Consulta.query;

                    default:
                        break;
                }
                
                conexionBD.Close();

            }
            conexionBD.Close();
            return Consulta.query;
        }
    }
}
