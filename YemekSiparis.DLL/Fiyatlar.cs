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
    
    public partial class Fiyatlar
    {
        public int FiyatlarID { get; set; }
        public decimal Fiyat { get; set; }
        public System.DateTime FiyatBaslangicTarihi { get; set; }
        public Nullable<System.DateTime> FiyatBitisTarihi { get; set; }
        public string FiyatListesiAdi { get; set; }
        public string FiyatListesiTuru { get; set; }
        public int YemekID { get; set; }
    
        public virtual Yemekler Yemekler { get; set; }
    }
}
