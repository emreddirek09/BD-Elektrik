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
    
    public partial class Arizalar
    {
        public int id { get; set; }
        public int ArizaKatFK { get; set; }
        public string ArizaAdi { get; set; }
        public string Arizaiçerik { get; set; }
        public string Resim { get; set; }
    
        public virtual ArizaKategori ArizaKategori { get; set; }
    }
}
