using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Hakkimizda
    {
        public string icerik { get; set; }
        public string icerik2 { get; set; }
        public string ÖzlüSöz1 { get; set; }
        public string ÖzlüSöz2 { get; set; }
        public string date { get; set; }

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.Hakkimizda Nesne_Hakkimizda = new DataAccess.Hakkimizda();

        public string HakkimizdaEkle(string icerik, string icerik2, string ÖzlüSöz1, string ÖzlüSöz2)
        {
            Nesne_Hakkimizda.icerik = icerik;
            Nesne_Hakkimizda.icerik2 = icerik2;
            Nesne_Hakkimizda.ÖzlüSöz1 = ÖzlüSöz1;
            Nesne_Hakkimizda.ÖzlüSöz2 = ÖzlüSöz2;
            Nesne_Hakkimizda.date = System.DateTime.Now;
            entities.Hakkimizda.Add(Nesne_Hakkimizda);
            entities.SaveChanges();

            return "1";
        }
        public List<Proje.DataAccess.Hakkimizda> Listele()
        {
            var sonuc = entities.Hakkimizda.ToList();
            return sonuc;

        }
        public int VeriSil(int i)
        {
            var stud = (from s1 in entities.Hakkimizda
                        where s1.id == i
                        select s1).SingleOrDefault();
            entities.Hakkimizda.Remove(stud);
            entities.SaveChanges();
            return 1;
        }

    }
}
