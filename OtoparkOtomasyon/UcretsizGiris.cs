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
    
    public partial class UcretsizGiris
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UcretsizGiris()
        {
            this.AracCikis = new HashSet<AracCikis>();
            this.AracGiris = new HashSet<AracGiris>();
        }
    
        public int UcretsizGirisID { get; set; }
        public Nullable<System.DateTime> TanimlanmaTarihi { get; set; }
        public string Plaka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracCikis> AracCikis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracGiris> AracGiris { get; set; }
    }
}
