using healthscan_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace healthscan_BE
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db", options => options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Product>().ToTable("Products", "HealthScanDB");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredients", "HealthScanDB");

            /*modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.HasIndex(e => e.Title).IsUnique();
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
            */

            base.OnModelCreating(modelBuilder);
        }


    }
}
