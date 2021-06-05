using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class iletisim
    {
        public string isim { get; set; }
        public string mail { get; set; }
        public string konu { get; set; }
        public string mesaj { get; set; }
        public string date { get; set; }

        DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
        DataAccess.iletisim Nesne_iletisim = new DataAccess.iletisim();

        public string İletisimEkle(string isim, string mail, string konu, string mesaj)
        {
            Nesne_iletisim.mail = mail;
            Nesne_iletisim.isim = isim;
            Nesne_iletisim.konu = konu;
            Nesne_iletisim.mesaj = mesaj;
            Nesne_iletisim.date = System.DateTime.Now;
            entities.iletisim.Add(Nesne_iletisim);
            entities.SaveChanges();

            return "1";
        }
        public List<DataAccess.iletisim> Müsteri_iletisimListele()
        {
            var sonuc = entities.iletisim.ToList();
            return sonuc;
        }
    }
}
