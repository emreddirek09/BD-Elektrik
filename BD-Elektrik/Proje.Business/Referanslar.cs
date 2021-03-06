using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Referanslar
    {
        public string ReferansAdi { get; set; }
        public string Resim { get; set; }

        DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
        DataAccess.Referanslar Nesne_referanslar = new DataAccess.Referanslar();

        public string ReferansEkle(string RefAdi, string Resim)
        {
            Nesne_referanslar.ReferansAdi = RefAdi;
            Nesne_referanslar.Resim = Resim;
            entities.Referanslar.Add(Nesne_referanslar);
            entities.SaveChanges();

            return "1";
        }
        public List<Proje.DataAccess.Referanslar> Listele()
        {
            var sonuc = entities.Referanslar.ToList();
            return sonuc;
        }
        public int VeriSil(int i)
        {
            var stud = (from s1 in entities.Referanslar
                        where s1.id == i
                        select s1).SingleOrDefault();
            entities.Referanslar.Remove(stud);
            entities.SaveChanges();
            return 1;
        }
    }
}
