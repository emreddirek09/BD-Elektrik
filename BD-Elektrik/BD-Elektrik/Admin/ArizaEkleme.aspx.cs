using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Proje.Business.ArizaKategori arizaKategoriBussines = new Proje.Business.ArizaKategori();
        Proje.Business.Arizalar Nesne_arizalar = new Proje.Business.Arizalar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                verigetir();
                Listele();
            }           
            
        }   
        private void Sil()
        {
            int id = Convert.ToInt32(Katid.Value);
            Nesne_arizalar.VeriSil(id);
            Label3.Text = "Silme Başarılı";
        }
        private void verigetir()
        {
            //for (int i = 1; i <= arizaKategoriBussines.ArizaKategoriCount(); i++)  
            foreach (var item in arizaKategoriBussines.Listele())                      
            {
                var i = item.Kategori_id;
                int index = Nesne_arizalar.KategoriCek(i).Kategori_id;
                string value = Nesne_arizalar.KategoriCek(i).Kategori_Ad;
                DropDownListKategori.Items.Add(new ListItem(value, index.ToString()));
            }

        }
        protected void Ekle_Click(object sender, EventArgs e)
        {
            //ArızaKategoriEkleme
            string KatIsim;            
            KatIsim = txt_Kategori.Value;
            arizaKategoriBussines.ArizaKatEkle(KatIsim);
            Label1.Text = "Kategori Ekleme Başarılı";           
            txt_Kategori.Value = "";      
            

        }

        protected void ArizaEkle_Click(object sender, EventArgs e)
        {
            //ArızaİçerikEkleme
            int id;
            string ad, icerik, resim;
            string filename;
            if (Resim.HasFile)
            {
                try
                {

                    filename = Path.GetFileName(Resim.FileName);
                    if (filename != "")
                    {
                        Resim.SaveAs(Server.MapPath("../Admin/img/Arizalar/") + filename);
                        HiddenFieldResim.Value = filename;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            id =Convert.ToInt32(DropDownListKategori.SelectedValue);
            ad = txt_ArizaAdi.Value;
            icerik = txt_Arizaicerik.Value;
            resim= "../Admin/img/Arizalar/" + HiddenFieldResim.Value;
            Nesne_arizalar.ArizaEkle(id, ad, icerik, resim);
            Listele();
            DropDownListKategori.SelectedValue = "-1";
            txt_ArizaAdi.Value = "";
            txt_Arizaicerik.Value = "";


        }
        private void Listele()
        {
            GridView1.DataSource = Nesne_arizalar.ArizaListele();
            GridView1.DataBind();
        }

        protected void sil_Click(object sender, EventArgs e)
        {
            Sil();
            Listele();
            Katid.Value = "";
        }
    }
}