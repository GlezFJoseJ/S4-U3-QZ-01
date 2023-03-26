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
    public partial class Form5 : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=ServicioCheques;integrated security=true");
        public Form5()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 80, 168);
            TBDIN.BackColor = Color.FromArgb(157, 162, 184);
            TBDOM.BackColor = Color.FromArgb(157, 162, 184);
            TBEST.BackColor = Color.FromArgb(157, 162, 184);
            TBFIR.BackColor = Color.FromArgb(157, 162, 184);
            TBID.BackColor = Color.FromArgb(157, 162, 184);
            TBNOM.BackColor = Color.FromArgb(157, 162, 184);
            TBTEL.BackColor = Color.FromArgb(157, 162, 184);
            contra.BackColor = Color.FromArgb(157, 162, 184);
            //button2.BackColor = Color.FromArgb(213, 216, 231);
            //button1.BackColor = Color.FromArgb(213, 216, 231);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fo= new Form2();
            fo.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBDIN.Clear();
            TBDOM.Clear();
            TBEST.Clear();
            TBFIR.Clear();
            TBID.Clear();
            TBNOM.Clear();
            TBTEL.Clear();
        }

        private void TBID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO beneficiaros (id_beneficiario,NomBeneficiaro,domicilio,telefono,estatus,firma,plata,contraseña,nombreBanco) VALUES (@id_beneficiario,@NomBeneficiaro,@domicilio,@telefono,@estatus,@firma,@plata,@contraseña,@nombreBanco)";

                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@id_beneficiario", TBID.Text);
                comando.Parameters.AddWithValue("@NomBeneficiaro", TBNOM.Text);
                comando.Parameters.AddWithValue("@domicilio", TBDOM.Text);
                comando.Parameters.AddWithValue("@telefono", TBTEL.Text);
                comando.Parameters.AddWithValue("@estatus", TBEST.Text);
                comando.Parameters.AddWithValue("@firma", TBFIR.Text);
                comando.Parameters.AddWithValue("@plata", TBDIN.Text);
                comando.Parameters.AddWithValue("@contraseña", contra.Text);
                comando.Parameters.AddWithValue("@nombreBanco", textBox1.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Insertado");
                conexion.Close();
            }catch (Exception ex) { }
        }

        private void TBDIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
