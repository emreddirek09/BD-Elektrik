using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                 Listele();
            }
            
        }
        Proje.Business.İletisimBilgileri NesneiletisimBilgileri = new Proje.Business.İletisimBilgileri();
        Proje.DataAccess.İletisimBilgileri iletisimBilgileriData = new Proje.DataAccess.İletisimBilgileri();

        private void Listele()
        {
            var sonuc = NesneiletisimBilgileri.iletisimBilgileriListele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }

        protected void Ekle_Click1(object sender, EventArgs e)
        {
            string mail, telefon, konum, instagram, facebook, whatsapp;
            mail = txt_mail.Value;
            telefon = txt_Telefon.Value;
            konum = txt_konum.Value;
            instagram = txt_insta.Value;
            facebook = txt_face.Value;
            whatsapp = txt_wp.Value;
            if (iletisimBilgileriData.konum =="")
            {
                NesneiletisimBilgileri.İletisimBilgileriEkle(mail, telefon, konum, instagram, facebook, whatsapp);
                Label2.Text = "Ekleme Başarılı";
                Listele();
            }
            else
            {
                Label2.Text = "Mevcut İçerik Varken Ekleme Yapamazsınız. Güncelleme adımlarını takip ediniz.";
            }
           
        }

        protected void Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                NesneiletisimBilgileri.VeriGüncelle(Convert.ToInt32(txt_id.Value), TextMail.Value, TextTelefon.Value, TextKonum.Value, Textİnstagram.Value, TextFacebook.Value, TextWhatsapp.Value);
                Label3.Text = "Güncelleme Başarılı";               
                Listele();
                txt_id.Value = "";
                TextMail.Value = "";
                TextTelefon.Value = "";
                TextKonum.Value = "";
                Textİnstagram.Value = "";
                TextFacebook.Value = "";
                TextWhatsapp.Value = "";
            }
            catch (Exception ex)
            {
                Label3.Text = "Hata Mesajı:" + ex.Message +" Lütfen Tekrar Kontrol Ediniz.";

            }

            



        }
    }
}