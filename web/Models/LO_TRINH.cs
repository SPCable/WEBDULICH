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
    
    public partial class LO_TRINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LO_TRINH()
        {
            this.CT_DIEM_DUNG_CHAN = new HashSet<CT_DIEM_DUNG_CHAN>();
            this.LOTRINH_TOUR = new HashSet<LOTRINH_TOUR>();
        }
    
        public string MA_NOIDI { get; set; }
        public string MA_NOIDEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DIEM_DUNG_CHAN> CT_DIEM_DUNG_CHAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOTRINH_TOUR> LOTRINH_TOUR { get; set; }
    }
}
