using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProje.DataAccess
{
    public class DBConnection
    {
        public SqlConnection Baglan()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=89.252.181.210\MSSQLSERVER2019; Initial Catalog=bdelekti_BDElektrik; User ID=denemeEmre; Password=1f*2y9bP");            
            //SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-J9OEKO6; Database=BDElektrik; Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
