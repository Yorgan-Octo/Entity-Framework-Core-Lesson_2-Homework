using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Error> Errors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDB_Task_3;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Id).HasColumnName("ProductId");
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(p => p.WentOnSale).HasColumnType("Date");

            modelBuilder.Ignore<Error>();

        }


    }
}
