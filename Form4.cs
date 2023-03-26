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
    public partial class Form4 : Form
    {
        Form2 c=new Form2();
        SqlConnection conexion = new SqlConnection("server=localhost; database=ServicioCheques;integrated security=true");
        public Form4()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 80, 168);
            txtmonto.BackColor = Color.FromArgb(157, 162, 184);
            txtuser.BackColor = Color.FromArgb(157, 162, 184);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Visible = true;
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y punto decimal
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "UPDATE beneficiaros SET plata= plata + @ValorASumar WHERE NomBeneficiaro=@nombre";
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@ValorASumar", txtmonto.Text);
                comando.Parameters.AddWithValue("@nombre", txtuser.Text);
                comando.ExecuteNonQuery();


                MessageBox.Show("Se ha depositado");
                txtmonto.Clear();
                txtuser.Clear();
                conexion.Close();
            }catch (Exception ex) { }


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
