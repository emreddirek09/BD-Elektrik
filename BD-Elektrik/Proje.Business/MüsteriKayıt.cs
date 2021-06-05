 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class MüsteriKayıt
    {
        public string isim { get; set; }
        public string mail { get; set; }
        public string sifre { get; set; }
        public string sifreOnay { get; set; }
        public string Resim { get; set; }

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.MüsteriKayıt müsteriKayıtNesne = new DataAccess.MüsteriKayıt();
        public string MüsteriEkleme(string isimm, string maill, string sifree, string sifreOnayy, string Resimm)
        {
            
            müsteriKayıtNesne.isim = isimm;
            müsteriKayıtNesne.mail = maill;
            müsteriKayıtNesne.sifre = sifree;
            müsteriKayıtNesne.sifreOnay = sifreOnayy;
            müsteriKayıtNesne.Resim = Resimm;
            müsteriKayıtNesne.date = System.DateTime.Now;
            if (sifree == sifreOnayy)
            {
                entities.MüsteriKayıt.Add(müsteriKayıtNesne);
                entities.SaveChanges();
            }
            else
            {
                return "Şifre Eşleşmiyor";
            }
            return "Kayıt Başarılı";
        }
        public int KayıtListeCount()
        {
            int count = entities.MüsteriKayıt.Count();
            return count;
        }
        public List<Proje.DataAccess.MüsteriKayıt> Listele()
        {
            var sonuc = entities.MüsteriKayıt.ToList();

            return sonuc;
        }
    }
}
