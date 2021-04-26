using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Proje.Business.Hakkimizda Nesne_Hakkimizda = new Proje.Business.Hakkimizda();
        protected void Ekle_Click(object sender, EventArgs e)
        {
            string icerik = txt_paragraf1.Value;
            string icerik2 = txt_paragraf2.Value;
            string ÖzlüSöz1 = txt_söz1.Value;
            string ÖzlüSöz2 = txt_söz2.Value;

            Nesne_Hakkimizda.HakkimizdaEkle(icerik, icerik2, ÖzlüSöz1, ÖzlüSöz2);
            Label2.Text = "Ekleme Başarılı";
            
        }
    }
}