using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using TrackingStation.DataAccess.Entity;

namespace TrackingStation.DataAccess.Context
{
    public partial class VesselContext : DbContext
    {
        public VesselContext() { }

        public VesselContext(DbContextOptions<VesselContext> options) : base(options) { }

        public virtual DbSet<Vessel> Vessel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Body>(entity =>
            {
                //entity.Property(e => e.name).UseIdentityColumn().Metadata.SetBeforeSaveBehaviour(PropertySaveBehavior.Ignore);

                //entity.HasConstraintName("FK_Body_Body");
            });

            modelBuilder.Entity<Vessel>(entity =>
            {
                entity.Property(v => v.name).IsRequired();

                entity.HasOne(b => b.refBody)
                .WithMany(v => v.Vessel);

                //entity.HasConstraintName("FK_Vessel_Body");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
