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
    
    public partial class Malzemeler
    {
        public int id { get; set; }
        public int MalzemeFK { get; set; }
        public string ÜrünAdi { get; set; }
        public string ÜrünAciklama { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public string Resim { get; set; }
    
        public virtual MalzemeKategoriler MalzemeKategoriler { get; set; }
    }
}