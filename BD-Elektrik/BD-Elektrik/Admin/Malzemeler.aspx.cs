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
            if (!IsPostBack)
            {
            VeriÇek();
            VeriListele();
            }
            
        }
        protected void VeriListele()
        {          
            
            GridView1.DataSource = nesne.Listele();
            GridView1.DataBind();
        }


        public void VeriÇek()
        {
            foreach (var item in MalzemeKategoriNesne.Listele())
            {
                var i = item.id;
                string KatAdi = nesne.KategoriCek(i).MalzemeKategariAdi;
                int Katid = nesne.KategoriCek(i).id;
                DropDownListKategori.Items.Add(new ListItem(KatAdi, Katid.ToString()));
            }

            //for (int i = 1; i <= MalzemeKategoriNesne.MalzemeKategoriCount(); i++)
            //{               
                
            //}
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
            
                if (DropDownListKategori.SelectedValue == "-1" && txt_ürünAdi.Value == "" && txt_ürünAciklama.Value == "" && HiddenFieldResim.Value == "" && txt_ürünFiyat.Value == "")
                {
                    Label1.Text = "Boş yerleri kontrol ediniz.";
                }
                else
                {
                try
                {
                    secilen = Convert.ToInt32(DropDownListKategori.SelectedValue);
                    ürünAdi = txt_ürünAdi.Value;
                    ürünAciklama = txt_ürünAciklama.Value;
                    ürünResim = "../Admin/img/Malzemeler/" + HiddenFieldResim.Value;
                    ürünFiyat = Convert.ToInt32(txt_ürünFiyat.Value);
                    nesne.MalzemeEkle(secilen, ürünAdi, ürünAciklama, ürünFiyat, ürünResim);
                    DropDownListKategori.SelectedValue = "-1";
                    txt_ürünAdi.Value = "";
                    txt_ürünAciklama.Value = "";
                    Label1.Text = "";
                    txt_ürünFiyat.Value = "";
                    VeriListele();
                }
                catch (Exception ex)
                {

                    Label1.Text = ex.Message +" Açıklama için 50 karakter sınırı vardır.";
                }
                    
                }
            
           
        }

        protected void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Katid.Value);
            nesne.VeriSil(id);
            Label3.Text = "Silme Başarılı";
            VeriListele();
            Katid.Value = "";
            txt_ürünFiyat.Value = "";
        }

        //protected void Entty_Click(object sender, EventArgs e)
        //{
        //    var sonuc = nesne.Listele();
        //    GridView1.DataSource = sonuc;
        //    GridView1.DataBind();
        //}

        //protected void GetByMalzemeler_Click(object sender, EventArgs e)
        //{
        //    Proje.Business.Malzemeler nesne = new Proje.Business.Malzemeler();            
        //    var sonuc = nesne.GetByMalzemeler("Esene");
        //   // var sonuc1 = nesne.KategoriCek("Anahtar").MalzemeKategariAdi;
        //    GridView1.DataSource = sonuc;
        //    GridView1.DataBind();

        //}
    }
}