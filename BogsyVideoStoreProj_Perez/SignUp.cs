using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStoreProj_Perez
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            //Database con = new Database();
            //con.con.Open();
            //int num = 1;
            //SqlCommand cmd = new SqlCommand("Select username from useracc where Id = " + num + "", con.con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //txtusername.Text = cmd.ExecuteScalar().ToString();
            //con.con.Close();

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string username = txtusername.Text;
            string password = txtpass.Text;
            string check = SignClass.Sign(email, username, password);
            if (check == "saved")
            {
                Login log = new Login();
                log.Enabled = true;

                this.Hide();
                log.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("There's already an Account with this email", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Enabled = true;

            this.Hide();
            log.ShowDialog();
            this.Close();
            //HomePage hp = new HomePage();
            //hp.Enabled = true;

            //this.Hide();

            //HomePage.instance.id2.Text = cmd1.ExecuteScalar().ToString();
            //HomePage.instance.name2.Text = cmd2.ExecuteScalar().ToString();

            //conn.Close();
            //hp.ShowDialog(this);
            //this.Close();
        }
    }
}
