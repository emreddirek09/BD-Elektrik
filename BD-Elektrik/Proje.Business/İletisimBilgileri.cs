using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class İletisimBilgileri
    {
        public string mail { get; set; }
        public string telefon { get; set; }
        public string konum { get; set; }
        public string instagram { get; set; }
        public string facebook { get; set; }
        public string whatsapp { get; set; }

        DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
        DataAccess.İletisimBilgileri Nesne_iletisimBilgileri = new DataAccess.İletisimBilgileri();

        public string İletisimBilgileriEkle(string mail, string telefon, string konum, string instagram, string facebook, string whatsapp)
        {
            Nesne_iletisimBilgileri.mail = mail;
            Nesne_iletisimBilgileri.telefon = telefon;
            Nesne_iletisimBilgileri.konum = konum;
            Nesne_iletisimBilgileri.instagram = instagram;
            Nesne_iletisimBilgileri.facebook = facebook;
            Nesne_iletisimBilgileri.whatsapp = whatsapp;
            entities.İletisimBilgileri.Add(Nesne_iletisimBilgileri);
            entities.SaveChanges();

            return "1";
        }
        public List<DataAccess.İletisimBilgileri> iletisimBilgileriListele()
        {
            var sonuc = entities.İletisimBilgileri.ToList();
            return sonuc;
        }
        public void VeriGüncelle(int idd, string maill, string telefonn, string konumm, string instagramm, string facebookk, string whatsappp)
        {
            
                var güncelle = entities.İletisimBilgileri.First(a => a.id == idd);
                güncelle.mail = maill;
                güncelle.telefon = telefonn;
                güncelle.konum = konumm;
                güncelle.instagram = instagramm;
                güncelle.facebook = facebookk;
                güncelle.whatsapp = whatsappp;
                entities.SaveChanges();
                        
        }

    }
}
