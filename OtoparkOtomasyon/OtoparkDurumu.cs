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
    
    public partial class OtoparkDurumu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OtoparkDurumu()
        {
            this.Rapor = new HashSet<Rapor>();
        }
    
        public int OtoparkID { get; set; }
        public Nullable<int> KapasiteID { get; set; }
        public Nullable<int> Doluluk { get; set; }
        public Nullable<int> BosAlan { get; set; }
    
        public virtual AracKapasitesi AracKapasitesi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rapor> Rapor { get; set; }
    }
}
