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
    
    public partial class Zaiyatlar
    {
        public int SiparisID { get; set; }
        public Nullable<int> YemekID { get; set; }
        public Nullable<int> MenuID { get; set; }
        public System.DateTime ZaiyatTarihi { get; set; }
        public int PersonelID { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Menuler Menuler { get; set; }
        public virtual Personeller Personeller { get; set; }
        public virtual Siparisler Siparisler { get; set; }
        public virtual Yemekler Yemekler { get; set; }
    }
}
