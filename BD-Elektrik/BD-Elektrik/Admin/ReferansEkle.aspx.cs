using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm5 : System.Web.UI.Page
    { 
        Proje.Business.Referanslar Busines_referanslar = new Proje.Business.Referanslar();
        protected void Page_Load(object sender, EventArgs e)
        {
            Listele();
        }
        //Proje.DataAccess.Referanslar Nesne_referanslar = new Proje.DataAccess.Referanslar();
       
        protected void Listele()
        {
            GridView1.DataSource = Busines_referanslar.Listele();
            GridView1.DataBind();
        }
        protected void Ekle_Click(object sender, EventArgs e)
        {
            string RefAdi,RefResim;
            string filename;
            if (Resim.HasFile)
            {
                try
                {

                    filename = Path.GetFileName(Resim.FileName);
                    if (filename != "")
                    {
                        Resim.SaveAs(Server.MapPath("../Admin/img/Referanslar/") + filename);
                        HiddenFieldResim.Value = filename;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            RefAdi = txt_Ref.Value;
            RefResim = "../Admin/img/Referanslar/" + HiddenFieldResim.Value;
            Busines_referanslar.ReferansEkle(RefAdi, RefResim);
            Label2.Text = "Ekleme Başarılı";
            Listele();
            txt_Ref.Value = "";


        }

        protected void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Katid.Value);
            Busines_referanslar.VeriSil(id);
            Label3.Text = "Silme Başarılı";
            Listele();
            Katid.Value = "";
        }
    }
}