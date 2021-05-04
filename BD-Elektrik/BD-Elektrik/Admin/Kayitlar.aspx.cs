using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        Proje.Business.MüsteriKayıt müsteriKayıt = new Proje.Business.MüsteriKayıt();
        protected void Page_Load(object sender, EventArgs e)
        {
            var sonuc = müsteriKayıt.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }
    }
}