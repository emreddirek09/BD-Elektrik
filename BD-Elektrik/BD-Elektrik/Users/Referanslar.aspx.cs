using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Proje.Business.Referanslar referanslar = new Proje.Business.Referanslar();
            var liste = referanslar.Listele();
            Repeater2.DataSource = liste;
            Repeater2.DataBind();
        }
    }
}