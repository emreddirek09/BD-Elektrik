using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proje.Business
{
    public class WebServisDeneme
    {
        
        public IList<string> ServisGetir()
        {
            var servis = new BD_Elektrik.WebServis.WebService1().AdlariListele(15);
            return servis;
        }

        public string DateTime ()
        {
            return System.DateTime.Now.ToString();
        }
    }
}
