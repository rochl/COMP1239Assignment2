﻿// <auto-generated />
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment1.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            customerId = 1,
                            customerAddress = "763 Bay St",
                            customerCity = "Toronto",
                            customerCountry = "Canada",
                            customerEmail = "k.anothini@gmail.com",
                            customerFirstName = "Kailtyn",
                            customerLastName = "Anothini",
                            customerPhone = "444-444-2224",
                            customerPostalCode = "M5G2R3",
                            customerState = "ON"
                        },
                        new
                        {
                            customerId = 2,
                            customerAddress = "555 College St",
                            customerCity = "San francico",
                            customerCountry = "USA",
                            customerEmail = "maya.kavi@gmail.com",
                            customerFirstName = "Maya",
                            customerLastName = "Kavi",
                            customerPhone = "111-224-1111",
                            customerPostalCode = "M6G5G4",
                            customerState = "CA"
                        },
                        new
                        {
                            customerId = 3,
                            customerAddress = "789 Rome St",
                            customerCity = "Los Angeles",
                            customerCountry = "USA",
                            customerEmail = "k.brown@gmail.com",
                            customerFirstName = "Katty",
                            customerLastName = "Brown",
                            customerPhone = "333-2224-1111",
                            customerPostalCode = "M6G5K4",
                            customerState = "BC"
                        },
                        new
                        {
                            customerId = 4,
                            customerAddress = "666 Bay St",
                            customerCity = "Toronto",
                            customerCountry = "Canada",
                            customerEmail = "g.raz@gmail.com",
                            customerFirstName = "Gindy",
                            customerLastName = "Raz",
                            customerPhone = "444-2242-4777",
                            customerPostalCode = "M5G2R4",
                            customerState = "ON"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}