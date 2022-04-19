using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JWT_roles_lab.Models
{
    public partial class FCTEST_ENTITY_FRAMFIRSTDBMDFContext : DbContext
    {
        public FCTEST_ENTITY_FRAMFIRSTDBMDFContext()
        {
        }

        public FCTEST_ENTITY_FRAMFIRSTDBMDFContext(DbContextOptions<FCTEST_ENTITY_FRAMFIRSTDBMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\c#\\test_entity_fram\\FirstDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Files>(entity =>
            {
                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateAppcent).HasColumnType("datetime");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Schooling).HasMaxLength(50);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry_date")
                    .HasColumnType("date");

                entity.Property(e => e.Token).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshToken)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RefreshToken_User");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Roles).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
