using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class MalzemeKategoriler
    {
        public string MalzemeKategariAdi { get; set; }

        Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
        public string MalzemeKategoriEkle( string KatgIsim)
        {
            Proje.DataAccess.BDElektrikEntities2 Ekleme = new DataAccess.BDElektrikEntities2();
            Proje.DataAccess.MalzemeKategoriler yeni = new DataAccess.MalzemeKategoriler();

            yeni.MalzemeKategariAdi = KatgIsim;

            Ekleme.MalzemeKategoriler.Add(yeni);
            Ekleme.SaveChanges();
            //var veriÇek = Listele();
            return "1";
        }

        public int MalzemeKategoriCount()
        {
           
            int count = ent.MalzemeKategoriler.Count();
            return count; 
        }

        public Proje.DataAccess.MalzemeKategoriler KategoriCek(int idd)
        {
            var sonuc = ent.MalzemeKategoriler.Where(p => p.id == idd);
            return sonuc.FirstOrDefault();

        }
        public List<Proje.DataAccess.MalzemeKategoriler> Listele()
        {
            Proje.DataAccess.BDElektrikEntities2 ent = new DataAccess.BDElektrikEntities2();
            ent.Database.Connection.Open();
            var sonuc = ent.MalzemeKategoriler.ToList();
            return sonuc;
        }


    }
}
