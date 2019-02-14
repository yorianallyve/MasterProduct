using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MasterProduct.DataAccess.SQL.Model
{
    public partial class MasterProductContext : DbContext
    {
        public MasterProductContext()
        {
        }

        public MasterProductContext(DbContextOptions<MasterProductContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-N3F06T4\\SQLEXPRESS;Database=MasterProduct;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview.19074.3");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.Property(e => e.Cost)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageProduct).HasMaxLength(50);

                entity.Property(e => e.ManufacturerEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameProduct)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Properties)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.SoldUnits)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitsAvailable)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.NameUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(50);
            });
        }
    }
}
