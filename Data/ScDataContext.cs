using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ReportScData.Data
{
    public partial class ScDataContext : DbContext
    {
        public ScDataContext()
        {
        }

        public ScDataContext(DbContextOptions<ScDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Report> Reports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report", "Frodo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Bridge).IsRequired();

                entity.Property(e => e.CreatedAt).HasPrecision(3);

                entity.Property(e => e.EngineRoom).IsRequired();

                entity.Property(e => e.Imo).HasColumnName("IMO");

                entity.Property(e => e.ModifiedAt).HasPrecision(3);

                entity.Property(e => e.PeriodEnd).HasPrecision(3);

                entity.Property(e => e.PeriodStart).HasPrecision(3);

                entity.Property(e => e.ReceivedOnShoreAt).HasPrecision(3);

                entity.Property(e => e.ReportType)
                    .IsRequired()
                    .HasMaxLength(9);

                entity.Property(e => e.SeqNo).ValueGeneratedOnAdd();

                entity.Property(e => e.Spec)
                    .IsRequired()
                    .HasMaxLength(9);

                entity.Property(e => e.SubmittedAt).HasPrecision(3);

                entity.Property(e => e.TransferredToDatalakeAt).HasPrecision(3);

                entity.Property(e => e.Warnings)
                    .IsRequired()
                    .HasDefaultValueSql("('[]')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
