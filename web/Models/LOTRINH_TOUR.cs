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
    
    public partial class LOTRINH_TOUR
    {
        public string MA_TOUR { get; set; }
        public string MA_NOIDI { get; set; }
        public string MA_NOIDEN { get; set; }
        public Nullable<int> SONGAY { get; set; }
        public Nullable<int> SONGAYDI_PT { get; set; }
        public string LOAI_PT { get; set; }
        public string LOAI_KS { get; set; }
    
        public virtual LO_TRINH LO_TRINH { get; set; }
        public virtual TOUR TOUR { get; set; }
    }
}
