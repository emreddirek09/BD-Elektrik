using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class MüsteriYorumlari
    {
        public int Müsteri_id { get; set; }
        public string Müsteri_Yorum { get; set; }

        Proje.DataAccess.BDElektrikEntities entities = new DataAccess.BDElektrikEntities();
        DataAccess.MüsteriYorumları müsteriYorumlarıNesne = new DataAccess.MüsteriYorumları();

        public string YorumEkle(int logUser, string yorum)
        {
            müsteriYorumlarıNesne.Müsteri_id = logUser;
            müsteriYorumlarıNesne.Müsteri_Yorum = yorum;
            müsteriYorumlarıNesne.date = System.DateTime.Now;
            entities.MüsteriYorumları.Add(müsteriYorumlarıNesne);
            entities.SaveChanges();

            return "Başarılı";
        }
        public List<Proje.DataAccess.MüsteriYorumları> Listele()
        {
            var sonuc = entities.MüsteriYorumları.ToList();

            return sonuc;
        }
    }
}
