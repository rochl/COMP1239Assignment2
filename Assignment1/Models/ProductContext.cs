using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
        
            : base(options)
        { }
         public DbSet<Product> Products{ get;set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    productId = 1,
                    productName = "Computer Mouse",
                    productPrice = 29.99,
                    DateAdded = DateTime.Now
                },
                new Product
                {
                    productId = 2,
                    productName = "Computer Headset",
                    productPrice = 49.99,
                    DateAdded = DateTime.Now
                },
                new Product
                {
                    productId = 3,
                    productName = "Computer Montior 28'",
                    productPrice = 129.99,
                    DateAdded = DateTime.Now
                },
                new Product
                {
                    productId = 4,
                    productName = "Computer Keyboard",
                    productPrice = 59.99,
                    DateAdded = DateTime.Now
                }
                );
        }
        
    }
}

