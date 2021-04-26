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
            NesneiletisimBilgileri.İletisimBilgileriEkle(mail, telefon, konum, instagram, facebook, whatsapp);
            Label2.Text = "Ekleme Başarılı";
            Listele();
        }
    }
}