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
    
    public partial class MenuDetay
    {
        public int MenuID { get; set; }
        public int YemekID { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public int KullaniciID { get; set; }
        public bool AktifMi { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Menuler Menuler { get; set; }
        public virtual Yemekler Yemekler { get; set; }
    }
}
