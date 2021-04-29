using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class MüsteriGiris
    {
        public string KullaniciAdi { get; set; }
        public string MüsteriSifre { get; set; }

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.MüsteriKayıt müsteriKayıtData = new DataAccess.MüsteriKayıt();
        public string GirisKontrol(string KullaniciAdi, string KullaniciSifre)
        {
            string VtKullaniciAdi = müsteriKayıtData.mail;



            return "1";
        }
    }
}
