﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtoparkOtomasyonEntities : DbContext
    {
        public OtoparkOtomasyonEntities()
            : base("name=OtoparkOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Abonelikler> Abonelikler { get; set; }
        public virtual DbSet<AboneUcret> AboneUcret { get; set; }
        public virtual DbSet<AracCikis> AracCikis { get; set; }
        public virtual DbSet<AracGiris> AracGiris { get; set; }
        public virtual DbSet<AracKapasitesi> AracKapasitesi { get; set; }
        public virtual DbSet<AracUcretleri> AracUcretleri { get; set; }
        public virtual DbSet<ParkYeri> ParkYeri { get; set; }
        public virtual DbSet<PersonelGirisTanimla> PersonelGirisTanimla { get; set; }
        public virtual DbSet<Rapor> Rapor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UcretsizGiris> UcretsizGiris { get; set; }
        public virtual DbSet<Yonetici> Yonetici { get; set; }
    }
}
