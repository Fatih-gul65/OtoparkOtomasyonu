//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtoparkOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class AracUcretleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AracUcretleri()
        {
            this.AracCikis = new HashSet<AracCikis>();
        }
    
        public int AracUcretID { get; set; }
        public string AracTuru { get; set; }
        public Nullable<decimal> AracUcret03 { get; set; }
        public Nullable<decimal> AracUcret36 { get; set; }
        public Nullable<decimal> AracUcret61 { get; set; }
        public Nullable<decimal> AracUcretBirGunUzeri { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracCikis> AracCikis { get; set; }
    }
}
