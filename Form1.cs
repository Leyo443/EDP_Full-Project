using MySql.Data.MySqlClient;
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
        MyDatabase db = new MyDatabase();

        public Form1()
        {
            InitializeComponent();
        }

        string[,] userCredentials =
        {
            { "admin", "admin", "Vince Leonardo Midel" },
            { "cashier", "password", "roksi" },
        };

        private object tbUsername;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected to Database");
            }
            else
            {
                MessageBox.Show("Database Connection Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Username!", "Validation");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Password!", "Validation");
                textBox2.Focus();
            }
            else
            {
                DataTable dt = db.ExecuteReturnQuery(
                    "SELECT * from tblLoginCredentials WHERE user_username = @uname and user_password = @pword;",
                    new MySqlParameter("@uname", textBox1.Text),
                    new MySqlParameter("@pword", textBox2.Text)
                );

                if (dt.Rows.Count == 1)
                {
                    frmHome frm = new frmHome();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
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

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}