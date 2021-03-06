using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BD_Elektrik.WebServis
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<string> AdlariListele(int sayac)
        {
            List<string> Veri = new List<string>();
            for (int i = 0; i < sayac; i++)
            {
                Veri.Add(i.ToString());

            }
            return Veri;
        }
        [WebMethod]
        public string WebServiceDeneme(string parametre)
        {
            return parametre + "Direk";
        }
    }
}
