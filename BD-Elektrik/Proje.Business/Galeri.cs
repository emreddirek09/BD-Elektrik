using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Galeri
    {
        public string GaleriBaslik { get; set; }
        public string GaleriResim { get; set; }
        public string GaleriYazi { get; set; }
        public string OlusturmaTarihi { get; set; }

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.Galeri Nesne_Galeri = new DataAccess.Galeri();
        public string GaleriEkle(string GaleriBaslik, string GaleriYazi, string resim)
        {
            
            Nesne_Galeri.GaleriBaslik = GaleriBaslik;
            Nesne_Galeri.GaleriYazi = GaleriYazi;
            Nesne_Galeri.GaleriResim = resim;
            Nesne_Galeri.OlusturmaTarihi = System.DateTime.Now;
            entities.Galeri.Add(Nesne_Galeri);
            entities.SaveChanges();

            return "1";
        }
    }
}
