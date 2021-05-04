using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class MüsteriGiris
    {
        public string KullaniciAdi { get; set; }
        public string MüsteriSifre { get; set; }

        string kul, sif, kulisim;
        int SessionLog;

        DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        Business.Login login = new Business.Login();
        public Boolean Login(string username, string password)
        {
            var user = from k in entities.MüsteriKayıt where k.mail == username && k.sifre == password select k;
            foreach (var item in user)
            {
                kul = item.mail;
                sif = item.sifre;
                kulisim = item.isim;
                SessionLog = item.id;                
            }

            if (username == kul && password == sif)
            {
                SessionKontrol();
                login.LogKayit(SessionLog);
                return true;
                              

            }            
            return false;
        }
        public int SessionKontrol()
        {
            
            var kontrol = SessionLog;

            return kontrol;
        }
        public List<Proje.DataAccess.Login> Listele()
        {
            var sonuc = entities.Login.ToList();

            return sonuc;
        }

    }
}
