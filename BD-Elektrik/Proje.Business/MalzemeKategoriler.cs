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


        public string MalzemeKategoriEkle( string KatgIsim)
        {
            Proje.DataAccess.BDElektrikEntities Ekleme = new DataAccess.BDElektrikEntities();
            Proje.DataAccess.MalzemeKategoriler yeni = new DataAccess.MalzemeKategoriler();

            yeni.MalzemeKategariAdi = KatgIsim;

            Ekleme.MalzemeKategoriler.Add(yeni);
            Ekleme.SaveChanges();
            //var veriÇek = Listele();
            return "1";
        }

        public int MalzemeKategoriCount()
        {
            Proje.DataAccess.BDElektrikEntities ent = new DataAccess.BDElektrikEntities();
            int count = ent.MalzemeKategoriler.Count();
            return count; 
        }

        public List<Proje.DataAccess.MalzemeKategoriler> Listele()
        {
            Proje.DataAccess.BDElektrikEntities ent = new DataAccess.BDElektrikEntities();
            ent.Database.Connection.Open();
            var sonuc = ent.MalzemeKategoriler.ToList();
            return sonuc;
        }


    }
}
