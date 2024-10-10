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
            Database con = new Database();
            con.con.Open();
            string email = txtemail.Text;
            string check = SignUpClass.Sign(email);
            if (check == "")
            {
                MessageBox.Show("ok", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There's already an Account with this email", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.con.Close();
        }
    }
}
