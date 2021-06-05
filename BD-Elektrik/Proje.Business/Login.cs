using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Login
    {
        public string id { get; set; }
        public string KulAdi { get; set; }
        public string KulMail { get; set; }
        public string Yetki { get; set; }
        public DateTime date { get; set; }


        Proje.DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
        Proje.DataAccess.Login loginNesne = new DataAccess.Login();
        public string LogKayit(int id)
        {
            loginNesne.MüsteriFKid = id;
            loginNesne.Yetki = 1;
            loginNesne.date = System.DateTime.Now;
            entities.Login.Add(loginNesne);
            entities.SaveChanges();
            return "1";
        }
    }
}
