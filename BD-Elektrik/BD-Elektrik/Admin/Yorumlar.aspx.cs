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
          var sonuc= müsteriYorumlari.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }
    }
}