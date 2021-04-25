using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class Malzemeler
    {
        public string ÜrünAdi { get; set; }
        public string ÜrünAciklama { get; set; }
        public string Fiyat { get; set; }
        public string Resim { get; set; }

        
        
        public string MalzemeEkle(int secilen, string ürünAdi, string aciklama, int fiyat, string resim)
        {
            Proje.DataAccess.BDElektrikEntities Ekleme = new Proje.DataAccess.BDElektrikEntities();
            Proje.DataAccess.Malzemeler yeni = new Proje.DataAccess.Malzemeler();
            yeni.MalzemeFK = secilen;
            yeni.ÜrünAdi = ürünAdi;
            yeni.ÜrünAciklama = aciklama;
            yeni.Fiyat = Convert.ToInt32(fiyat);
            yeni.Resim = resim;
            Ekleme.Malzemeler.Add(yeni);
            Ekleme.SaveChanges();
            return "1";
        }


        public Proje.DataAccess.MalzemeKategoriler KategoriCek(int idd)
        {
            Proje.DataAccess.BDElektrikEntities ent = new DataAccess.BDElektrikEntities();
            var sonuc = ent.MalzemeKategoriler.Where(p =>p.id==idd);      
            return sonuc.FirstOrDefault();
        }
        
        public List<Proje.DataAccess.Malzemeler> Listele()

        {
            Proje.DataAccess.BDElektrikEntities ent = new DataAccess.BDElektrikEntities();
            ent.Database.Connection.Open();
            var sonuc = ent.Malzemeler.ToList();  //Malzemeler tablosundaki tüm datayı çekiyor.
            return sonuc;
        }

        public Proje.DataAccess.Malzemeler GetByMalzemeler(string ÜrünAdi)
        {
            Proje.DataAccess.BDElektrikEntities ent = new DataAccess.BDElektrikEntities();
            var sonuc = ent.Malzemeler.Where(p=>p.ÜrünAdi==ÜrünAdi);
            return sonuc.FirstOrDefault();
        }
    }
}
