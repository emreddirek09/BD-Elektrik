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
        public int id { get; set; }
        public string ÜrünAdi { get; set; }
        public string ÜrünAciklama { get; set; }
        public string Fiyat { get; set; }
        public string Resim { get; set; }        
        
        public string MalzemeEkle(int secilen, string ürünAdi, string aciklama, int fiyat, string resim)
        {
            Proje.DataAccess.BDElektrikEntities2 Ekleme = new Proje.DataAccess.BDElektrikEntities2();
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
            Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
            var sonuc = ent.MalzemeKategoriler.Where(p =>p.id==idd);      
            return sonuc.FirstOrDefault();
        }        
        public List<Proje.DataAccess.Malzemeler> Listele()
        {
            Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
            var sonuc = ent.Malzemeler.ToList();
            return sonuc;
        }
        public Proje.DataAccess.Malzemeler GetByMalzemeler(string ÜrünAdi)
        {
            Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
            var sonuc = ent.Malzemeler.Where(p=>p.ÜrünAdi==ÜrünAdi);
            return sonuc.FirstOrDefault();
        }
        public Proje.DataAccess.Malzemeler DetayMalzeme(int idd)
        {
            Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
            var sonuc = ent.Malzemeler.Where(p => p.id == idd);
            return sonuc.FirstOrDefault();
        }
        public int VeriSil(int i)
        {
            Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
            var stud = (from s1 in ent.Malzemeler
                        where s1.id == i
                        select s1).SingleOrDefault();
            ent.Malzemeler.Remove(stud);
            ent.SaveChanges();
            return 1;
        }
    }
}
