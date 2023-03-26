using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEQ
{
    public partial class Form7 : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=ServicioCheques;integrated security=true");

        public int s;
        public Form7()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 80, 168);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
            TBX.Visible = true;
            TBX.Enabled = true;
            if (s == 1)
            {
                label1.Text = "Folio";
            }
            else if (s == 2)
            {
                label1.Text = "Fecha";
                MessageBox.Show("Ingresar la fecha en formato : año-mes-dia");
            }
            else if (s == 3)
            {
                label1.Text = "Monto ";
                MessageBox.Show("Ingresar el monto en formato numerico");
            }
            
        }

        private void BTXX_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                String query = "SELECT * FROM cheques WHERE folio='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();
            }
            else if (s == 2)
            {
               

                String query = "SELECT * FROM cheques WHERE fecha='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();
            }
            else if (s == 3)
            {
                String query = "SELECT * FROM cheques WHERE cantidad='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();
            }
        }

        private void BTREG_Click(object sender, EventArgs e)
        {
            Form6 x = new Form6();
            x.Visible = true;
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
