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
    
    public partial class SubeYemekleri
    {
        public int SubeYemeklerID { get; set; }
        public int SubeID { get; set; }
        public Nullable<int> YemeklD { get; set; }
        public Nullable<int> MenuID { get; set; }
    
        public virtual Menuler Menuler { get; set; }
        public virtual Subeler Subeler { get; set; }
        public virtual Yemekler Yemekler { get; set; }
    }
}
