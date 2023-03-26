using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEQ
{
    public partial class Form6 : Form
    {
        Form7 d = new Form7();
        public Form6()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 80, 168);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void folioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.s = 1;
           
            this.Visible = false;
            d.Show();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.s = 2;
            this.Visible = false;
            d.Show();
        }

        private void montoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.s = 3;
            this.Visible = false;
            d.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
