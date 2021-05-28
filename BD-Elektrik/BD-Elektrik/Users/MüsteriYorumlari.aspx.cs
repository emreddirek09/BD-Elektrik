using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProje.DataAccess;

namespace BD_Elektrik.Users
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            SqlConnection baglanti = connection.Baglan();
            try
            {

                SqlCommand com = new SqlCommand("SELECT * " +
                    "FROM MüsteriKayıt " +
                    "INNER JOIN MüsteriYorumları " +
                    "ON MüsteriKayıt.id = MüsteriYorumları.Müsteri_id order by MüsteriYorumları.Müsteri_id desc ", baglanti);
                SqlDataReader reader;
                reader = com.ExecuteReader();
                Repeater3.DataSource = reader;
                Repeater3.DataBind();
                reader.Close();

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert(" + ex.Message + ");</script>");
            }
            baglanti.Close();

            //Proje.Business.MüsteriYorumlari müsteriYorumlari = new Proje.Business.MüsteriYorumlari();
            //var liste = müsteriYorumlari.Listele();
            //Repeater3.DataSource = liste;
            //Repeater3.DataBind();
        }
    }
}