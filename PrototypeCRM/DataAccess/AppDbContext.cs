using Microsoft.EntityFrameworkCore;
using PrototypeCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCRM.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CRMComSaller.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(
                        new Client { Id = 1, Name = "Client 1" },
                        new Client { Id = 2, Name = "Client 2" });

            modelBuilder.Entity<Employer>().HasData(
                        new Employer { Id = 1, Name = "Saller" });


            modelBuilder.Entity<Product>().HasData(
                            new Product { Id = 1, Name = "Notebook 1", Price = 10 },
                            new Product { Id = 2, Name = "PC 1", Price = 20 },
                            new Product { Id = 3, Name = "PC 2", Price = 25 },
                            new Product { Id = 4, Name = "PC 3", Price = 15 },
                            new Product { Id = 5, Name = "Notebook 2", Price = 25 });




            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Employer)
                .WithMany(e => e.Sales)
                .HasForeignKey(s => s.EmployerId);

            modelBuilder.Entity<Sale>()
               .HasOne(s => s.Client)
               .WithMany(e => e.Sales)
               .HasForeignKey(s => s.ClientId);

            modelBuilder.Entity<Sale>()
               .HasOne(s => s.Product)
               .WithMany(e => e.Sales)
               .HasForeignKey(s => s.ProductId);

        }

        public AppDbContext() : base() { }
    }
    
}
