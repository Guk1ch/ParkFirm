﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkFirm.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParkEntities : DbContext
    {
        public ParkEntities()
            : base("name=ParkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Decorator> Decorator { get; set; }
        public virtual DbSet<Firm> Firm { get; set; }
        public virtual DbSet<Firm_Employers> Firm_Employers { get; set; }
        public virtual DbSet<Plant> Plant { get; set; }
        public virtual DbSet<Plant_Area> Plant_Area { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<Type_Plant> Type_Plant { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Wardenn> Wardenn { get; set; }
        public virtual DbSet<Watering> Watering { get; set; }
        public virtual DbSet<Watering_Mode> Watering_Mode { get; set; }
    }
}
