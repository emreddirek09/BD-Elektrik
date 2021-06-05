using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class ArizaKategori
    {
        public string Kategori_Ad { get; set; }

        DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
        DataAccess.ArizaKategori yeni = new DataAccess.ArizaKategori();
        
        public string ArizaKatEkle(string KatAdi)
        {
            yeni.Kategori_Ad = KatAdi;
            entities.ArizaKategori.Add(yeni);
            entities.SaveChanges();

            return "1";
        }
        
        public int ArizaKategoriCount()
        {
            int count = entities.ArizaKategori.Count();
            return count;
        }
        public List<Proje.DataAccess.ArizaKategori> Listele()
        {
            var sonuc = entities.ArizaKategori.ToList();
            return sonuc;

        }
    }
}
