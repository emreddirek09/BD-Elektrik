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
            //database bağlantı komutumuz
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J9OEKO6;Initial Catalog=BDElektrik Integrated Security=True");
            return baglanti;
        }
    }
}
