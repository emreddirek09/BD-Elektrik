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

        string kul, sif, kulisim,Resim;
        int SessionLog;

        DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
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
                Resim = item.Resim;
            }

            if (username == kul && password == sif)
            {
                SessionKontrol();
                aa(kulisim, Resim);
                login.LogKayit(SessionLog);
                return true;
            }            
            return false;
        }
        public string aa(string isim, string resim)
        {
            List<string> girisyapan = new List<string>();
            girisyapan.Add(isim);
            girisyapan.Add(resim);
            return girisyapan.ToString();
        }
        public string SessionResim()
        {
            var kontrol = Resim;
            return kontrol;
        }
        public string Sessionisim()
        {
            var kontrol = kulisim;
            return kontrol;
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
