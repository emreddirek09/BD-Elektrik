using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class Ana : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Proje.DataAccess.BDElektrikEntities entities = new Proje.DataAccess.BDElektrikEntities();
        Proje.Business.MüsteriGiris Bussines_müsteriGiris = new Proje.Business.MüsteriGiris();
        Proje.Business.MüsteriKayıt Busines_MüsteriKayıt = new Proje.Business.MüsteriKayıt();
        protected void MüsteriKayit_Click(object sender, EventArgs e)
        {
            string isimm = Müsteri_isim.Value;
            string maill = Müsteri_mail.Value;
            string sifree = Müsteri_sifre.Value;
            string sifreOnayy = Müsteri_Sifre_Onay.Value;
            string Resimm;

            string filename;
            if (Resim.HasFile)
            {
                try
                {

                    filename = Path.GetFileName(Resim.FileName);
                    if (filename != "")
                    {
                    Resim.SaveAs(Server.MapPath("../Admin/img/Müsteri/") + filename);
                    HiddenFieldResim.Value = filename;
                    }

                }
                    catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
                Resimm = "../Admin/img/Müsteri/" + HiddenFieldResim.Value;
               var sonuc= Busines_MüsteriKayıt.MüsteriEkleme(isimm, maill, sifree, sifreOnayy, Resimm);
                 Müsteri_isim.Value="";
                 Müsteri_mail.Value = "";
                 Müsteri_sifre.Value = "";
                 Müsteri_Sifre_Onay.Value = "";
            LBLKayit.Text = sonuc;

        }

        protected void MüsteriGiris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = Müsteri_KulAdi_Giris.Value;
            string KullaniciSifre = Müsteri_sifre_Giris.Value;

            if (Bussines_müsteriGiris.Login(KullaniciAdi, KullaniciSifre) == true)
            {
                int a = Bussines_müsteriGiris.SessionKontrol();
                Session.Add("LogUser",a);
                Session.Timeout = 1;
                Response.Redirect("MüşteriSayfası.aspx");

            }
            else
            {
                GirisLabel.Text = "Giriş Başarısız.";
            }
            
        }
    }
}