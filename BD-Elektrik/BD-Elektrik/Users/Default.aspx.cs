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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string deger;

        protected void Page_Load(object sender, EventArgs e)
        {
            MalzemeGetir();
            ArizaGetir();
            MüsteriYorum();
        }
        protected void MalzemeGetir()
        {
            DBConnection connection = new DBConnection();
            SqlConnection baglanti = connection.Baglan();
            try
            {

                SqlCommand com = new SqlCommand("SELECT TOP(3) * from Malzemeler", baglanti);
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

            //Proje.Business.Malzemeler malzemeler = new Proje.Business.Malzemeler();
            //var liste = malzemeler.Listele();
            //Repeater1.DataSource = liste;
            //Repeater1.DataBind();
        }
        protected void ArizaGetir()
        {
            DBConnection connection = new DBConnection();
            SqlConnection baglanti = connection.Baglan();
            try
            {

                SqlCommand com = new SqlCommand("SELECT TOP(3) * from Arizalar", baglanti);
                SqlDataReader reader;
                reader = com.ExecuteReader();
                Repeater2.DataSource = reader;
                Repeater2.DataBind();
                reader.Close();

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert(" + ex.Message + ");</script>");
            }
            baglanti.Close();
        }
        protected void MüsteriYorum()
        {
            DBConnection connection = new DBConnection();
            SqlConnection baglanti = connection.Baglan();
            try
            {

                SqlCommand com = new SqlCommand("SELECT TOP(1) * " +
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

        }

    }
}