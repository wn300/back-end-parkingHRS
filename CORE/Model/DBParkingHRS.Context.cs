﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CORE.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBParkingHRSEntities : DbContext
    {

        public static string Connection = "name=DBParkingHRSEntities";
        public static DBParkingHRSEntities Instance
        {
            get { return new DBParkingHRSEntities(); }
        }
        public DBParkingHRSEntities()
            : base(Connection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ParkingService> ParkingService { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
    }
}