using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Proje.Business.Arizalar arizalar = new Proje.Business.Arizalar();
            var liste = arizalar.ArizaListele();
            Repeater2.DataSource = liste;
            Repeater2.DataBind();
        }
    }
}