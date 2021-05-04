using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        Proje.Business.MüsteriGiris  müsteriGiris = new Proje.Business.MüsteriGiris();
        protected void Page_Load(object sender, EventArgs e)
        {
           var sonuc = müsteriGiris.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }
    }
}