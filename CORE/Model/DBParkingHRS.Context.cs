﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
            Configuration.ProxyCreationEnabled = false;
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
