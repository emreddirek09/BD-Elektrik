using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Proje.Business.Galeri galeriBussines = new Proje.Business.Galeri();
        protected void Ekle_Click(object sender, EventArgs e)
        {
            string filename;
            if (Resim.HasFile)
            {
                try
                {

                    filename = Path.GetFileName(Resim.FileName);
                    if (filename != "")
                    {
                        Resim.SaveAs(Server.MapPath("../Admin/img/Galeri/") + filename);
                        HiddenFieldResim.Value = filename;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            string GaleriBaslik = txt_Baslik.Value;
            string GaleriYazi = txt_Yazi.Value;
            string resim = "../Admin/img/Galeri/" + HiddenFieldResim.Value;
            galeriBussines.GaleriEkle(GaleriBaslik, GaleriYazi, resim);
            Label1.Text = "Kategori Ekleme Başarılı";
            
        }
    }
}