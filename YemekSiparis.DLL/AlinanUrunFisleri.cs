//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekSiparis.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlinanUrunFisleri
    {
        public int FislerID { get; set; }
        public int SubeID { get; set; }
        public int AlinanUrunID { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<decimal> FisTutari { get; set; }
        public Nullable<System.DateTime> FisKesimTarihi { get; set; }
        public string FisResimAdresi { get; set; }
    
        public virtual AlinanUrunler AlinanUrunler { get; set; }
        public virtual Subeler Subeler { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}