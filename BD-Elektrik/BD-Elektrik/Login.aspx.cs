using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Giris_Click(object sender, EventArgs e)
        {
            Proje.Business.MüsteriGiris Bussines_müsteriGiris = new Proje.Business.MüsteriGiris();
            string KullaniciAdi = KulAdi.Value;
            string KullaniciSifre = KulSifre.Value;

            if (Bussines_müsteriGiris.Login(KullaniciAdi, KullaniciSifre) == true)
            {
                int log = Bussines_müsteriGiris.SessionKontrol();
                Session.Add("Giris", log);
                if (Session["Giris"] != null)
                {
                    Response.Redirect("Admin/AdminDefault.aspx");
                }
                else
                {
                    Label1.Text = "Giriş Başarısız.";
                }
            }
            else
            {
                Label1.Text = "Giriş Başarısız.";
            }

        }
    }
}