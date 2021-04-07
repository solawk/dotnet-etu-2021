using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.DataAccess.Entity;

namespace TrackingStation.DataAccess.Context
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
            Database.EnsureCreated();
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TrackingStationDB;Trusted_Connection=True;");
        }

        public virtual DbSet<BodyEntity> Body { get; set; }
        public virtual DbSet<VesselEntity> Vessel { get; set; }
    }
}
