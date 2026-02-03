using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDEL_VinceLeonardoG._BSIT_2D
{
    public partial class Form1 : Form
    {
        private object tbUsername;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter username!","Validation");
                textBox1.Focus();
            }
            else if (textBox2.Text == " ")
            {
                MessageBox.Show("Please enter Password!","Validation");
                textBox2.Focus();
            }
               
        }
                private void textBox2_TextChanged(object sender, EventArgs e)
                {

                }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
