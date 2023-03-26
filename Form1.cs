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
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=ServicioCheques;integrated security=true");


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 80, 168);
            TBC.BackColor = Color.FromArgb(157, 162, 184);
            TBU.BackColor = Color.FromArgb(157, 162, 184);
            button2.BackColor= Color.FromArgb(213, 216, 231);
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String user = "", contra = "",uscaj= "CMarquez", concaj= "caja1";
                Form2 y = new Form2();
                Form6 f1= new Form6();
                user = TBU.Text.ToString();
                contra = TBC.Text.ToString();
                SqlCommand cmd = new SqlCommand("  SELECT * FROM usuarios WHERE usuario=@usuario", conexion);
                cmd.Parameters.AddWithValue("@usuario", TBU.Text);
                conexion.Open();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {

                    TBU.Text = registro["usuario"].ToString();
                    TBC.Text = registro["password"].ToString();

                    if (TBU.Text == uscaj && TBC.Text ==concaj)
                    {
                        MessageBox.Show("Acceso Concedido Cajera");
                        this.Visible = false;
                        this.Enabled = false;
                        f1.Show();
                    }
                    else
                    {

                        if (TBU.Text == user && TBC.Text == contra)
                        {
                            MessageBox.Show("Acceso Concedido");
                            this.Visible = false;
                            this.Enabled = false;
                            y.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o Contraseña incorrecto ");
                        }
                    }
                    
                    if (TBU.Text == "" && TBC.Text == "")
                    {
                        MessageBox.Show("No hay nada escrito");
                    }

                }
                conexion.Close();
            }catch (Exception ex) { }
        }

        private void TBU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
