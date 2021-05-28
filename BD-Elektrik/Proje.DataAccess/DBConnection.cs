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
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-J9OEKO6; Database=BDElektrik; Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
