//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeNight.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMesaj
    {
        public int gondericiID { get; set; }
        public int aliciID { get; set; }
        public string mesaj { get; set; }
        public System.DateTime tarih { get; set; }
    
        public virtual tblKullanici tblKullanici { get; set; }
        public virtual tblKullanici tblKullanici1 { get; set; }
    }
}
