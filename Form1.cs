using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDEL_VinceLeonardoG._BSIT_2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] userCredentials =
        {
            {"justinevince", "roksi", "Sipatero Boys!"}
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                textBox1.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                textBox2.Focus();
                return;
            }

            bool loginSuccess = false;

            for (int x = 0; x < userCredentials.GetLength(0); x++)
            {
                if (username == userCredentials[x, 0] && password == userCredentials[x, 1])
                {
                    MessageBox.Show("Welcome " + userCredentials[x, 2]);
                    frmHome home = new frmHome();
                    home.Show();
                    this.Hide();
                    loginSuccess = true;
                    break;
                }
            }

            if (!loginSuccess)
            {
                MessageBox.Show("Invalid Username/Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}