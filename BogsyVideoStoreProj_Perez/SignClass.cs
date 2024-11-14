using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BogsyVideoStoreProj_Perez
{
    internal class SignClass
    {
        public static string Sign(string email, string username, string password) 
        {
            Database con = new Database();
            con.con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(Id) from useracc where email = '" + email + "'", con.con);
            string number = cmd.ExecuteScalar().ToString();
            con.con.Close();
            if (number == "")
            {
                string save = SignUp(email, username, password);
                return save;
            }
            return "notsaved";
        }

        public static string SignUp(string email, string username, string password)
        {
            Database con = new Database();
            con.con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into useracc (username, email, pass, role) Values('" + username + "'" +
                " ,'" + email + "', '" + password + "', 'USER')", con.con);
            cmd1.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Video Item Saved");
            con.con.Close();
            return "saved";
        }

        public static string Login(string username, string password)
        {
            Database con = new Database();
            con.con.Open();
            SqlCommand cmd = new SqlCommand("Select role from useracc where username = '" + username + "' AND pass = '" + password + "'", con.con);
            object check = cmd.ExecuteScalar();
            con.con.Close();
            if (check != null)
            {
                string role = check.ToString();
                return role;
            }    
            return "none";
        }
    }
}
