using System;
using System.Collections.Generic;
using System.Linq;
using TAXONANASTASON.Models;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace TAXONANASTASON
{
    class Context : DbContext
    {
        public Context()
         : base("DbConnection")
        { }
        public virtual DbSet<ADDRESS> ADDRESS { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<CAR> CAR { get; set; }
        public virtual DbSet<CAR_MODEL> CAR_MODEL { get; set; }
        public virtual DbSet<DRIVER_STATUS> DRIVER_STATUS { get; set; }
        public virtual DbSet<DRIVER> DRIVER { get; set; }
        public virtual DbSet<STREET> STREET { get; set; }
        public virtual DbSet<TARIF> TARIF { get; set; }
        public virtual DbSet<TRIP> TRIP { get; set; }
        public virtual DbSet<TRIP_STATUS> TRIP_STATUS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { }
    }
}
