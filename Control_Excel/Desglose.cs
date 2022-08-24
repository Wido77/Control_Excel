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


namespace Control_Excel
{
    public partial class Desglose : Form
    {
        public Desglose(string resultadoTipo, string resultadoCombo)
        {
            InitializeComponent();
            llenarConcepto(dgvDesglose, resultadoTipo, resultadoCombo);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para cambiar el color del boton cerrar cuando pasas el cursor por encima
        private void OnMouseEnterbtnCerrar(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red; 
        }

        private void OnMouseLeavebtnCerrar(object sender, EventArgs e)
        {
            btnCerrar.BackColor = SystemColors.ButtonFace;
        }

        public void llenarConcepto(DataGridView grid, string resultadoTipo, string resultadoCombo)
        {
            //Se abre la conexion con la base de datos
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            //Consulta que hacemos a la base de datos para llenar el grid
            string query = "SELECT fecha, gastos.Concepto, Importe, Movimiento FROM gastos INNER JOIN tipos ON gastos.idtipo = tipos.idtipo INNER JOIN meses ON gastos.idmes = meses.idmes WHERE tipos.concepto = '" + resultadoTipo + "' AND meses.Mes = '" + resultadoCombo + "'";
            MySqlCommand consulta = new MySqlCommand(query, conexionBD);
            

            MySqlDataAdapter da = new MySqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);

            grid.DataSource = dt;
            conexionBD.Close();
        }
    }
}
