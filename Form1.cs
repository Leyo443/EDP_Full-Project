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
        private object tbUsername;

        public Form1()
        {
            InitializeComponent();
        }

        string[,] userCredentials =
        {
            {"admin","admin","justinevince" },
            {"cashier","password","roksi" }
        };
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
                MessageBox.Show("Please enter username!", "Validation");
                textBox1.Focus();
            }
            else if (textBox2.Text == " ")
            {
                MessageBox.Show("Please enter Password!", "Validation");
                textBox2.Focus();
            }
            else
                MessageBox.Show("Welcome" + "! " + textBox1.Text);
            {
                for (int x = 0; x < userCredentials.GetLength(0); x++)
                {
                    if (textBox1.Text == userCredentials[x, 0])
                    {
                        if (textBox2.Text == userCredentials[x, 1])
                        {
                            frmHome frm = new frmHome();
                            MessageBox.Show("Welcome " + userCredentials[x, 2]);
                            this.Hide();
                            frm.Show();
                            break;
                        }

                        else
                        {
                            MessageBox.Show("Invalid Username/Password");
                            break;
                        }
                    }
                }
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

 
        
                
            

