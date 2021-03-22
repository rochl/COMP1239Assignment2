using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)

            : base(options)
        { }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(


                new Customer
                {
                    customerId = 1,
                    customerFirstName = "Kailtyn",
                    customerLastName = "Anothini",
                    customerAddress = "763 Bay St",
                    customerCity = "Toronto",
                    customerState = "ON",
                    customerPostalCode = "M5G2R3",
                    customerCountry = "Canada",
                    customerPhone = "444-444-2224",
                    customerEmail = "k.anothini@gmail.com"
                },


                 new Customer
                 {
                     customerId = 2,
                     customerFirstName = "Maya",
                     customerLastName = "Kavi",
                     customerAddress = "555 College St",
                     customerCity = "San francico",
                     customerState = "CA",
                     customerPostalCode = "M6G5G4",
                     customerCountry = "USA",
                     customerPhone = "111-224-1111",
                     customerEmail = "maya.kavi@gmail.com"
                 },


                new Customer
                {
                    customerId = 3,
                    customerFirstName = "Katty",
                    customerLastName = "Brown",
                    customerAddress = "789 Rome St",
                    customerCity = "Los Angeles",
                    customerState = "BC",
                    customerPostalCode = "M6G5K4",
                    customerCountry = "USA",
                    customerPhone = "333-2224-1111",
                    customerEmail = "k.brown@gmail.com"
                },
                 new Customer
                 {
                     customerId = 4,
                     customerFirstName = "Gindy",
                     customerLastName = "Raz",
                     customerAddress = "666 Bay St",
                     customerCity = "Toronto",
                     customerState = "ON",
                     customerPostalCode = "M5G2R4",
                     customerCountry = "Canada",
                     customerPhone = "444-2242-4777",
                     customerEmail = "g.raz@gmail.com"
                 }


                );
        }
    }
    }
