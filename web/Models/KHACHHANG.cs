//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        public string MA_KH { get; set; }
        public string HOTEN_KH { get; set; }
        public string DIACHI { get; set; }
        public string DT { get; set; }
        public string MA_PHIEU { get; set; }
    
        public virtual PHIEU_DK PHIEU_DK { get; set; }
    }
}
