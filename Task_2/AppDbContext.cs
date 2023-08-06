using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Product> products {  get; set; }
        public DbSet<Error> errors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDB_Task_2;Trusted_Connection=True;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => new { p.Id, p.ProductAlterId });
            modelBuilder.Ignore<Error>();
        }


    }
}
