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
        Proje.Business.Hakkimizda Nesne_Hakkimizda = new Proje.Business.Hakkimizda();
        protected void Page_Load(object sender, EventArgs e)
        {
            Listele();
        }
        Proje.DataAccess.Hakkimizda hakkimizdaEnt = new Proje.DataAccess.Hakkimizda();
        protected void Listele()
        {
            GridView1.DataSource = Nesne_Hakkimizda.Listele();
            GridView1.DataBind();
        }
        
        protected void Ekle_Click(object sender, EventArgs e)
        {
            string icerik = txt_paragraf1.Value;
            string icerik2 = txt_paragraf2.Value;
            string ÖzlüSöz1 = txt_söz1.Value;
            string ÖzlüSöz2 = txt_söz2.Value;
            if (hakkimizdaEnt.icerik == "")
            {
                Nesne_Hakkimizda.HakkimizdaEkle(icerik, icerik2, ÖzlüSöz1, ÖzlüSöz2);
                Label2.Text = "Ekleme Başarılı";
            }
            else
            {
                Label2.Text = "Mevcut İçerik Varken Ekleme Yapamazsınız. Güncelleme adımlarını takip ediniz.";
            }
            
           
            
        }

        protected void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Katid.Value);
            Nesne_Hakkimizda.VeriSil(id);
            Label3.Text = "Silme Başarılı";
            Listele();
            Katid.Value = "";
        }
    }
}