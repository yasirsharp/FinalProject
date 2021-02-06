using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : DB tabloları ile projeleri bağlamak.
    public class NorthwindContext:DbContext
    {
        //projeni hangi veri tabanı ile ilişkilendirmek istiyorsak burda belirtiriz..
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //veri tabanı yolu
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}