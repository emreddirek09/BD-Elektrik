using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Proje.Business.iletisim iletisimNesne = new Proje.Business.iletisim();
        protected void Gönder_Click(object sender, EventArgs e)
        {
            string maill, isimm, konuu, mesajj;
            maill = mail.Value;
            isimm = isim.Value;
            konuu = konu.Value;
            mesajj = mesaj.Value;
            iletisimNesne.İletisimEkle(isimm, maill, konuu, mesajj);              
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert(Gönderim Başarılı);</script>");

            mail.Value = "";
            isim.Value = "";
            konu.Value = "";
            mesaj.Value = "";
        }
    }
}