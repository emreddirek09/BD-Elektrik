using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        string girisYapan;
        protected void Page_Load(object sender, EventArgs e)
        {
            girisYapan = Session["LogUser"].ToString();

            isim.Text = Session["SessionIsim"].ToString();
            resim.Src = Session["SessionResim"].ToString();
        }

        Proje.Business.MüsteriYorumlari müsteriYorumlariNesne = new Proje.Business.MüsteriYorumlari();
        protected void YorumGönder_Click1(object sender, EventArgs e)
        {

            müsteriYorumlariNesne.YorumEkle( Convert.ToInt32(girisYapan), TextArea1.Value);
            TextArea1.Value = "";
            Label1.Text = "Yorum Eklemesi Başarılı.";           
        }

        protected void cikis_Click1(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");

        }
    }
}