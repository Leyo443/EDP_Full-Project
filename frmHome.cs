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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmStoreStatus storeForm = new frmStoreStatus();
            storeForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmPriceBook priceForm = new frmPriceBook();
            priceForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmVendors vendorsForm = new frmVendors();
            vendorsForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers();
            usersForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmTimeClock timeForm = new frmTimeClock();
            timeForm.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}