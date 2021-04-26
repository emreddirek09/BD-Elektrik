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

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.Referanslar Nesne_referanslar = new DataAccess.Referanslar();

        public string ReferansEkle(string RefAdi, string Resim)
        {
            Nesne_referanslar.ReferansAdi = RefAdi;
            Nesne_referanslar.Resim = Resim;
            entities.Referanslar.Add(Nesne_referanslar);
            entities.SaveChanges();

            return "1";
        }
    }
}
