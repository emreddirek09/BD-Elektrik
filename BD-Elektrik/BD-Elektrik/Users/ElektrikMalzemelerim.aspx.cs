using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Users
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Malzemeler();
        }
        protected void Malzemeler()
        {
            Proje.Business.Malzemeler malzemeler = new Proje.Business.Malzemeler();
            var liste = malzemeler.Listele();
            Repeater1.DataSource = liste;
            Repeater1.DataBind();
        }
    }
}