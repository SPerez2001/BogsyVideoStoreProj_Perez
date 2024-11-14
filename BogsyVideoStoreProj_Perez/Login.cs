using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStoreProj_Perez
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Enabled = true;

            this.Hide();
            sign.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpass.Text;
            string check = SignClass.Login( username, password);
            if (check == "ADMIN")
            {
                AdminHome ad = new AdminHome();
                ad.Enabled = true;

                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
            else if (check == "USER")
            {
                MessageBox.Show("There's already an Account with this email", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("none this account isnt in the database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
