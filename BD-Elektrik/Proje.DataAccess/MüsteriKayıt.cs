//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MüsteriKayıt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MüsteriKayıt()
        {
            this.MüsteriYorumları = new HashSet<MüsteriYorumları>();
        }
    
        public int id { get; set; }
        public string isim { get; set; }
        public string mail { get; set; }
        public string sifre { get; set; }
        public string sifreOnay { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string Resim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MüsteriYorumları> MüsteriYorumları { get; set; }
    }
}
