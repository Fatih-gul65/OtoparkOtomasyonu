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
    
    public partial class Abonelikler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Abonelikler()
        {
            this.AracCikis = new HashSet<AracCikis>();
        }
    
        public int AboneID { get; set; }
        public string AbonePlaka { get; set; }
        public Nullable<System.DateTime> AbonelikBaslangicTarihi { get; set; }
        public Nullable<System.DateTime> AbonelikBitisTarihi { get; set; }
        public string AbonelikTipi { get; set; }
        public Nullable<int> AboneUcretID { get; set; }
        public Nullable<decimal> AbonelikUcreti { get; set; }
        public string OdemeYontemi { get; set; }
    
        public virtual AboneUcret AboneUcret { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracCikis> AracCikis { get; set; }
    }
}
