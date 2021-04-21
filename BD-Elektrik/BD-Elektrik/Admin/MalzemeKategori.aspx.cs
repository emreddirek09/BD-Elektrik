using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Ekle_Click(object sender, EventArgs e)
        {
            string KatAdi;
            Proje.Business.MalzemeKategoriler nesne = new Proje.Business.MalzemeKategoriler();
            KatAdi = txt_Kategori.Value;
            var deger = nesne.MalzemeKategoriEkle(KatAdi);
            Label1.Text = deger;
        }
    }
}