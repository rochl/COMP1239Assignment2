using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class IncidentContext : DbContext
    {
        public IncidentContext(DbContextOptions<IncidentContext> options)
        
            : base(options)
        { }
        public DbSet<Incident> Incidents{ get;set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    incidentId = 1,
                    incidentCustomer = "Gindy Raz",
                    incidentProduct = "Computer Mouse",
                    incidentTitle = "Could not install 1",
                    incidentDes = "Des for id 1",
                    incidentTech = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now

                },
                new Incident
                {
                    incidentId = 2,
                    incidentCustomer = "Kailtyn Anothini",
                    incidentProduct = "Computer Mouse",
                    incidentTitle = "Error",
                    incidentDes = "Des for id 2",
                    incidentTech = 3,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now

                },
                new Incident
                {
                    incidentId = 3,
                    incidentCustomer = "Katty Brown",
                    incidentProduct = "Computer Headset edit 3",
                    incidentTitle = "Could not install 3",
                    incidentDes = "Des for id 3",
                    incidentTech = 2,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now

                },
                new Incident
                {
                    incidentId = 4,
                    incidentCustomer = "Maya Kavi",
                    incidentProduct = "Computer Keyboardd not install 4",
                    incidentTitle = "Error 2",
                    incidentDes = "Des for id 4",
                    incidentTech = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = DateTime.Now

                }
                );
        }
        
    }
}

