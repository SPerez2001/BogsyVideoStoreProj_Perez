using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStoreProj_Perez
{
    internal class Database
    {
       
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\BogsyVideoStoreProj_Perez\BogsyVideoStoreProj_Perez\bogsyvs.mdf;Integrated Security=True");
        
    }
}
