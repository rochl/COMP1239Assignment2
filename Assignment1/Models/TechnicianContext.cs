using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class TechnicianContext : DbContext
    {
        public TechnicianContext(DbContextOptions<TechnicianContext> options)

            : base(options)
    { }
        public DbSet<Technician> Technicians { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    techId = 1,
                    techName = "Mike",
                    techEmail = "mike@gmail.com",
                    techPhone = "555-777-5533"
                   
                },
                new Technician
                {
                    techId = 2,
                    techName = "Mike2",
                    techEmail = "mike@gmail.com",
                    techPhone = "555-777-5533"

                },
                new Technician
                {
                    techId = 3,
                    techName = "Mike3",
                    techEmail = "mike@gmail.com",
                    techPhone = "555-777-5533"

                }


                );
        }
    }
}
