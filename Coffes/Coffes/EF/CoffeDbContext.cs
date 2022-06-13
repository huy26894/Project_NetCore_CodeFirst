using Coffes.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffes.EF
{
    public class CoffeDbContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<BillDetail> BillDetail { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<TableCoffees> TableCoffees { get; set; }
        public DbSet<Unit> Unit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=NDHUY-PC;database=TestDB;user=sa;password=123456a@");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableCoffees>()
                .HasOne<Area>(t => t.Area)
                .WithMany(a => a.TableCoffees)
                .HasForeignKey(s => s.AreaId);             
        }
    }
}
