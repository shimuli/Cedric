using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cedric.Models
{
    public partial class portfolioDbContext : DbContext
    {
        public portfolioDbContext()
        {
        }

        public portfolioDbContext(DbContextOptions<portfolioDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Projetc> Projetcs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=DatabaseConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("imageUrl");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Images__ProjectI__267ABA7A");
            });

            modelBuilder.Entity<Projetc>(entity =>
            {
                entity.Property(e => e.Category).HasMaxLength(1000);

                entity.Property(e => e.Client).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ViewerDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
