using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ECDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Veritabanı tablolarınız oluşturulurken onlara müdehale edebiliriz.

            //OrderDetails tablosunda bir composite key oluşturulacak.
            modelBuilder.Entity<OrderDetail>()
                .HasKey(o => new { o.OrderID, o.ProductID });

            //OrderDetails tablosunda Id alınını oluşturulmayacak.
            modelBuilder.Entity<OrderDetail>().Ignore(o => o.Id);
        }
    }
}
