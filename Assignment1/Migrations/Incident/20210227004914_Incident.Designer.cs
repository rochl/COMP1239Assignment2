﻿// <auto-generated />
using System;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations.Incident
{
    [DbContext(typeof(IncidentContext))]
    [Migration("20210227004914_Incident")]
    partial class Incident
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment1.Models.Incident", b =>
                {
                    b.Property<int>("incidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("incidentCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("incidentDes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("incidentProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("incidentTech")
                        .HasColumnType("int");

                    b.Property<string>("incidentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("incidentId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            incidentId = 1,
                            DateClosed = new DateTime(2021, 2, 26, 19, 49, 14, 266, DateTimeKind.Local).AddTicks(9295),
                            DateOpened = new DateTime(2021, 2, 26, 19, 49, 14, 264, DateTimeKind.Local).AddTicks(4130),
                            incidentCustomer = "Gindy Raz",
                            incidentDes = "Des for id 1",
                            incidentProduct = "Computer Mouse",
                            incidentTech = 1,
                            incidentTitle = "Could not install 1"
                        },
                        new
                        {
                            incidentId = 2,
                            DateClosed = new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(658),
                            DateOpened = new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(637),
                            incidentCustomer = "Kailtyn Anothini",
                            incidentDes = "Des for id 2",
                            incidentProduct = "Computer Mouse",
                            incidentTech = 3,
                            incidentTitle = "Error"
                        },
                        new
                        {
                            incidentId = 3,
                            DateClosed = new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(764),
                            DateOpened = new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(761),
                            incidentCustomer = "Katty Brown",
                            incidentDes = "Des for id 3",
                            incidentProduct = "Computer Headset edit 3",
                            incidentTech = 2,
                            incidentTitle = "Could not install 3"
                        },
                        new
                        {
                            incidentId = 4,
                            DateClosed = new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(770),
                            DateOpened = new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(768),
                            incidentCustomer = "Maya Kavi",
                            incidentDes = "Des for id 4",
                            incidentProduct = "Computer Keyboardd not install 4",
                            incidentTech = 1,
                            incidentTitle = "Error 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}