using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        Proje.Business.MüsteriYorumlari müsteriYorumlari = new Proje.Business.MüsteriYorumlari();
        protected void Page_Load(object sender, EventArgs e)
        {
            Listele();
        }
        protected void Listele()
        {
            var sonuc = müsteriYorumlari.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }

        protected void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Katid.Value);
            müsteriYorumlari.VeriSil(id);
            Label3.Text = "Silme Başarılı";
            Listele();
            Katid.Value = "";

        }
    }
}