using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Arizalar
    {
        public int ArizaKatFK { get; set; }
        public string ArizaAdi { get; set; }
        public string Arizaicerik { get; set; }
        public string Resim { get; set; }

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.Arizalar Nesne_arizalar = new DataAccess.Arizalar();
        public string ArizaEkle(int fkid, string ArizaAd, string icerik, string resim)
        {
            Nesne_arizalar.ArizaKatFK = fkid;
            Nesne_arizalar.ArizaAdi = ArizaAd;
            Nesne_arizalar.Arizaiçerik = icerik;
            Nesne_arizalar.Resim = resim;
            entities.Arizalar.Add(Nesne_arizalar);
            entities.SaveChanges();

            return "1";
        }

        public Proje.DataAccess.ArizaKategori KategoriCek(int idd)
        {
            var sonuc = entities.ArizaKategori.Where(p => p.Kategori_id == idd);
            return sonuc.FirstOrDefault();
        }

        public List<Proje.DataAccess.Arizalar> ArizaListele()
        {
           var sonuc = entities.Arizalar.ToList();

            return sonuc;

        }
    }
}
