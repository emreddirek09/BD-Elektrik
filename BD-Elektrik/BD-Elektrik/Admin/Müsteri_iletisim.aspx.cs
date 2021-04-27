using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Proje.Business.iletisim nesne = new Proje.Business.iletisim();
            var listele = nesne.Müsteri_iletisimListele();
            GridView1.DataSource = listele;
            GridView1.DataBind();


        }
    }
}