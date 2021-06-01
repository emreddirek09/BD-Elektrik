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
        public List<Proje.DataAccess.Galeri> Listele()
        {
            var sonuc = entities.Galeri.ToList();
            return sonuc;

        }
        public int VeriSil(int i)
        {
            var stud = (from s1 in entities.Galeri
                        where s1.id == i
                        select s1).SingleOrDefault();
            entities.Galeri.Remove(stud);
            entities.SaveChanges();
            return 1;
        }
    }
}
