using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;
using WebProje.DataAccess;

namespace BD_Elektrik.Users
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Proje.Business.Malzemeler malzemeler = new Proje.Business.Malzemeler();
            //string value = Request.QueryString["id"].ToString();
            //var liste = malzemeler.DetayMalzeme(Convert.ToInt32(value));
            //Repeater1.DataSource = liste;
            //Repeater1.DataBind();

            DBConnection connection = new DBConnection();
            SqlConnection baglanti = connection.Baglan();
            try
            {
                string value = Request.QueryString["id"].ToString();
                SqlCommand com = new SqlCommand("SELECT * FROM Malzemeler WHERE id =" + value, baglanti);
                SqlDataReader reader;
                reader = com.ExecuteReader();
                Repeater1.DataSource = reader;
                Repeater1.DataBind();
                reader.Close();

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert(" + ex.Message + ");</script>");
            }

            baglanti.Close();

        }
    }
}