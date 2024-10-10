using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStoreProj_Perez
{
    internal class SignUpClass
    {
        public static string Sign(string email) 
        {
            Database con = new Database();
            con.con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(Id) from useracc where email = '" + email + "'", con.con);
            string number = cmd.ExecuteScalar().ToString();
            con.con.Close();
            return number;
        }
    }
}
