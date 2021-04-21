using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace BD_Elektrik.Admin
{
   
    public partial class WebForm2 : System.Web.UI.Page
    {
        static public List<Proje.Business.Malzemeler> malzemelersList = new List<Proje.Business.Malzemeler>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }       

            //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-J9OEKO6;Initial Catalog=BDElektrik;Integrated Security=True");
            //string isim = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            //SqlConnection baglan = new SqlConnection(isim);
            //baglan.Open();
        
        public List<Proje.DataAccess.Malzemeler> Listele()
        {
            Proje.DataAccess.BDElektrikEntities ent = new Proje.DataAccess.BDElektrikEntities();
            var sonuc = ent.Malzemeler.OrderByDescending(p => p.id).ToList();
            return sonuc;
        }
        protected void Ekle_Click1(object sender, EventArgs e)
        {
            string ürünAdi, ürünAciklama, ürünResim;
            int ürünFiyat;
            Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();

            //malzemeler.ÜrünAdi = txt_ürünAdi.Value;
            //malzemeler.ÜrünAciklama = txt_ürünAciklama.Value;
            //malzemeler.Resim = txt_Resim.Value;
            //malzemeler.Fiyat = txt_ürünFiyat.Value;
            //malzemelersList.Add(malzemeler);
            //Label1.Text = malzemeler.ÜrünAciklama;
            string filename;
            if (Resim.HasFile)
            {
                try
                {

                    filename = Path.GetFileName(Resim.FileName);
                    if (filename != "")
                    {
                        Resim.SaveAs(Server.MapPath("img/Malzemeler/") + filename);
                        lblDurum.Text = filename;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            
            ürünAdi = txt_ürünAdi.Value;
            ürünAciklama = txt_ürünAciklama.Value;
            ürünResim = "img / Malzemeler/" + lblDurum.Text;
            ürünFiyat = Convert.ToInt32(txt_ürünFiyat.Value);
            var deger = nesne.MalzemeEkle(ürünAdi, ürünAciklama, ürünFiyat, ürünResim);

        }
               

        protected void Entty_Click(object sender, EventArgs e)
        {
            Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();
            var sonuc = nesne.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }

        protected void GetByMalzemeler_Click(object sender, EventArgs e)
        {
            Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();
            var sonuc = nesne.GetByMalzemeler("Lamba");
            GridView1.DataSource = sonuc;
            GridView1.DataBind();

        }
    }
}