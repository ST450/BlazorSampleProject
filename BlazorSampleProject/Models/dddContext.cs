using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorSampleProject.Models
{
    public partial class dddContext : DbContext
    {
        public dddContext()
        {
        }

        public dddContext(DbContextOptions<dddContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<Weather> Weathers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=d:\\sqlite\\ddd.db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Weather>(entity =>
            {
                entity.HasKey(e => new { e.AreaId, e.DataDate });

                entity.ToTable("Weather");

                entity.Property(e => e.DataDate).HasColumnType("DATETIME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
