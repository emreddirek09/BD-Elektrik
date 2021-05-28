using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Proje.Business.Galeri galeri = new Proje.Business.Galeri();
            var liste = galeri.Listele();
            Repeater2.DataSource = liste;
            Repeater2.DataBind();
        }

    }
}