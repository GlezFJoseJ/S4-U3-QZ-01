using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEQ
{
    public partial class Form2 : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=ServicioCheques;integrated security=true"); Form3 r=new Form3();
        Form1 d = new Form1();
        Form5 g=new Form5();
        public int consulta = 0;
        //Funcion para limpiar campos
        public void lim() {
            TBNOB.Clear();
            TBD.Clear();
            TBF.Clear();
            TBP.Clear();
            TBFOL.Clear();
            TBB.Clear();
        }
        public Form2()
        {
            InitializeComponent();
            DGVIN.ReadOnly= true;
            //Se crea un objeto para poder pasar a otra ventana y ocultar esta
            // la cual es obligatoria
            Form1 y1 = new Form1();
            //Ya no es visible esta ventana
            y1.Visible = false;
            d.Visible= false;
            d.Enabled=false;
            this.BackColor = Color.FromArgb(39,80,168);
            textBox1.Visible=false;
            TBD.BackColor= Color.FromArgb(157, 162, 184);
            TDPFDP.CalendarMonthBackground= Color.FromArgb(39, 80, 168);
            TBNOB.BackColor = Color.FromArgb(157, 162, 184);
            TBP.BackColor = Color.FromArgb(157, 162, 184);
            TBF.BackColor = Color.FromArgb(157, 162, 184);
            TBFOL.BackColor = Color.FromArgb(157, 162, 184);
            carga();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Funcion para limpiar campos
            lim(); 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = TXEST.Text;




                if (TBNOB.Text == "" && TDPFDP.Text == "" && TBP.Text == "")
                {
                    MessageBox.Show("No hay nada que registrar");
                }
                String query = "INSERT INTO cheques (folio,id_banco,fecha,id_beneficiario,cantidad,firma,estado) Values (@folio,@id_banco,@fecha,@id_beneficiario,@cantidad,@firma,@estado)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@folio", TBFOL.Text);
                comando.Parameters.AddWithValue("@id_banco", TBNOB.Text);
                comando.Parameters.AddWithValue("@fecha", TDPFDP.Value.ToShortTimeString());
                comando.Parameters.AddWithValue("@id_beneficiario", TBP.Text);
                comando.Parameters.AddWithValue("@cantidad", TBD.Text);
                comando.Parameters.AddWithValue("@firma", TBF.Text);
                comando.Parameters.AddWithValue("@estado", textBox1.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Guardado");

                TBFOL.Clear();
                TBNOB.Clear();
                TBP.Clear();
                TBF.Clear();
                TBD.Clear();

                conexion.Close();
                carga();
            }catch(Exception ex) { }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.s = 1;
            this.Visible= false;
            r.Show();
        }

        private void montoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.s = 2;
            this.Visible = false;
            r.Show();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.s = 3;
            this.Visible = false;
            r.Show();
        }

        private void folioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.s = 4;
            this.Visible = false;
            r.Show();
        }

        private void estadoFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r.s = 5;
            this.Visible = false;
            r.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 d= new Form4();
            this.Visible = false;
            d.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("19460716@gmail.com", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = TXEST.Text;

                TBFOL.ReadOnly = true;
                TBFOL.Clear();


                if (TBNOB.Text == "" && TDPFDP.Text == "" && TBP.Text == "")
                {
                    MessageBox.Show("No hay nada que registrar");
                }
                String query = "UPDATE cheques SET id_banco=@id_banco,fecha=@fecha,cantidad=@cantidad,firma=@firma,estado=@estado WHERE id_beneficiario=@id_beneficiario";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@id_banco", TBNOB.Text);
                comando.Parameters.AddWithValue("@fecha", TDPFDP.Value.ToShortTimeString());
                comando.Parameters.AddWithValue("@id_beneficiario", TBP.Text);
                comando.Parameters.AddWithValue("@cantidad", TBD.Text);
                comando.Parameters.AddWithValue("@firma", TBF.Text);
                comando.Parameters.AddWithValue("@estado", textBox1.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Actualizado");
                TBF.Clear();
                TBFOL.Clear();
                TBNOB.Clear();
                TBP.Clear();
                TBD.Clear();
                TBF.Clear();

                conexion.Close();
                carga();
            }
            catch (Exception ex) { }
        }

        private void TBNOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres alfanuméricos
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBFOL_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres alfanuméricos
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            g.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            carga();

        }

        private void TDPFDP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TBF_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
        public void carga() {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(" SELECT * FROM cheques", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DGVIN.DataSource = tabla;
                conexion.Close();
            }catch(Exception ex) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM cheques WHERE folio='" + TXBFF.Text + "' ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DGVIN.DataSource = tabla;

            conexion.Close();
        }

        private void TBB_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
