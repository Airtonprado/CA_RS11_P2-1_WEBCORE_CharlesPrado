using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CA_RS11_P2_1_WEBCORE_CharlesPrado.Models;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Data
{
    public class RSGYMDBContext_Connect : DbContext
    {
        public RSGYMDBContext_Connect()
        {
        }

        public RSGYMDBContext_Connect(DbContextOptions<RSGYMDBContext_Connect> options) : base(options) { }

        // DbSets for each table
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da tabela Payments
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.AmountPaid)
                      .HasColumnType("decimal(18,2)");

                // Relacionamento com Customer (Foreign Key com SET NULL)
                entity.HasOne(d => d.Customer)
                      .WithMany(p => p.Payments)
                      .HasForeignKey(d => d.CustomerId)
                      .OnDelete(DeleteBehavior.SetNull);

                // Relacionamento com Service (Foreign Key com SET NULL)
                entity.HasOne(d => d.Service)
                      .WithMany(p => p.Payments)
                      .HasForeignKey(d => d.ServiceId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // Configuração da tabela Services
            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Value)
                      .HasColumnType("decimal(18,2)");
            });
        }
    }
}