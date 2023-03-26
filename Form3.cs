using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEQ
{
    public partial class Form3 : Form
    {
        
        SqlConnection conexion = new SqlConnection("server=localhost; database=ServicioCheques;integrated security=true");
        public int s = 0;
        public Form3()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 80, 168);
            TBX.BackColor = Color.FromArgb(157, 162, 184);
            BTREG.BackColor = Color.FromArgb(213, 216, 231);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            if (s == 5)
            {
                this.Width = 1000;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label56.Visible = true;

                MessageBox.Show("Aqui se busca infomacion de Estado financiero");
            }
            else
            {
                this.Width = 700;
            }
            TBX.Visible = true;
            TBX.Enabled = true;
            if (s == 1)
            {
                label1.Text = "Usuario";
            }
            else if (s == 2)
            {
                label1.Text = "Monto";
            }
            else if (s == 3)
            {
                MessageBox.Show("Formato de fecha: año-mes-dia");
                label1.Text = "Fecha";
                

            }
            else if (s == 4)
            {
                label1.Text = "Folio";

            }
            else if (s == 5)
            {
                label1.Text = "Estado financiero";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (s == 1)
            {
                label1.Text = "Usuario";
                String query = "SELECT * FROM cheques WHERE id_beneficiario='" + TBX.Text+"' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data=new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();
            }
            else if (s == 2)
            {

                label1.Text = "Monto";

                
                String query = "SELECT * FROM cheques WHERE cantidad='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();

            }
            else if(s == 3)
            {
                
                label1.Text = "Fecha";
                MessageBox.Show("Ingresar la fecha : año-mes-dia");

                 String query = "SELECT * FROM cheques WHERE fecha='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();
               
            }else if(s == 4)
            {   
                label1.Text = "Folio";
                String query = "SELECT * FROM cheques WHERE folio='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;

                conexion.Close();
            }
            else if(s == 5)
            {

                label1.Text = "Estado financiero";


                String query = "SELECT * FROM beneficiaros WHERE NomBeneficiaro='" + TBX.Text + "' ";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DGVMOS.DataSource = tabla;
                label56.Text = TBX.Text;


                
                conexion.Close();

            }
        }

        private void BTREG_Click(object sender, EventArgs e)
        {
            Form2 h = new Form2();
            h.Visible= true;
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (s == 1)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (s == 2) { 
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // Permitir solo un punto decimal
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            else if (s == 4)
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (s == 5)
            {
                // Permitir solo letras
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void LS_Click(object sender, EventArgs e)
        {

        }
    }
}
