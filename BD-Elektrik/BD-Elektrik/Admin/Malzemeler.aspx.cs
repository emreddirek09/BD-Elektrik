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
        Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();
        Proje.Business.MalzemeKategoriler MalzemeKategoriNesne = new Proje.Business.MalzemeKategoriler();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string isim = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            //SqlConnection baglan = new SqlConnection(isim);
            //baglan.Open();
            //SqlCommand sqlCommand = new SqlCommand("Select * from MalzemeKategoriler",baglan);
            //SqlDataReader read = sqlCommand.ExecuteReader();
            //int i = 0;
            //while (read.Read())
            //{
            //    DropDownListKategori.Items.Add(new ListItem(read["MalzemeKategariAdi"].ToString(), read["id"].ToString()));
            //    i++;
            //}
            //baglan.Close();
            VeriÇek();                       
        }


        public void VeriÇek()
        {
            for (int i = 1; i <= MalzemeKategoriNesne.MalzemeKategoriCount(); i++)
            {
                string KatAdi = nesne.KategoriCek(i).MalzemeKategariAdi.ToString();
                int  Katid = nesne.KategoriCek(i).id;
                DropDownListKategori.Items.Add(new ListItem(KatAdi, Katid.ToString()));
                
            }
        }


        public List<Proje.DataAccess.Malzemeler> Listele()
        {
            Proje.DataAccess.BDElektrikEntities ent = new Proje.DataAccess.BDElektrikEntities();
            var sonuc = ent.Malzemeler.OrderByDescending(p => p.id).ToList();
            return sonuc;
        }

        protected void Ekle_Click1(object sender, EventArgs e)
        {
            string ürünAdi, ürünAciklama, ürünResim;
            int ürünFiyat , secilen;

            Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();
            string filename;
            if (Resim.HasFile)
            {
                try
                {

                    filename = Path.GetFileName(Resim.FileName);
                    if (filename != "")
                    {
                        Resim.SaveAs(Server.MapPath("../Admin/img/Malzemeler/") + filename);
                        HiddenFieldResim.Value = filename;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            secilen = DropDownListKategori.SelectedIndex;
            ürünAdi = txt_ürünAdi.Value;
            ürünAciklama = txt_ürünAciklama.Value;
            ürünResim = "../Admin/img/Malzemeler/" + HiddenFieldResim.Value;
            ürünFiyat = Convert.ToInt32(txt_ürünFiyat.Value);
            var deger = nesne.MalzemeEkle(secilen, ürünAdi, ürünAciklama, ürünFiyat, ürünResim);

        }              

        protected void Entty_Click(object sender, EventArgs e)
        {
            var sonuc = nesne.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }

        protected void GetByMalzemeler_Click(object sender, EventArgs e)
        {
            Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();            
            var sonuc = nesne.GetByMalzemeler("Esene");
           // var sonuc1 = nesne.KategoriCek("Anahtar").MalzemeKategariAdi;
            GridView1.DataSource = sonuc;
            GridView1.DataBind();

        }
    }
}