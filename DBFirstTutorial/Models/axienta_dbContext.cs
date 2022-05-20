using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstTutorial.Models
{
    public partial class axienta_dbContext : DbContext
    {
        public axienta_dbContext()
        {
        }

        public axienta_dbContext(DbContextOptions<axienta_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=axienta_db;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.ToTable("InvoiceLine");

                entity.Property(e => e.Discount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineTotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Stock)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uom)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Isactive)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
