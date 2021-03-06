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

        Proje.DataAccess.BDElektrikEntities2 entities = new DataAccess.BDElektrikEntities2();
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
        public int VeriSil(int i)
        {
            var stud = (from s1 in entities.MüsteriYorumları
                        where s1.id == i
                        select s1).SingleOrDefault();
            entities.MüsteriYorumları.Remove(stud);
            entities.SaveChanges();
            return 1;
        }
    }
}
