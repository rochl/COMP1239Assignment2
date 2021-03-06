// <auto-generated />
using System;
using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations.Product
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment1.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("productPrice")
                        .HasColumnType("float");

                    b.HasKey("productId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = 1,
                            DateAdded = new DateTime(2021, 2, 17, 8, 10, 59, 294, DateTimeKind.Local).AddTicks(6071),
                            productName = "Computer Mouse",
                            productPrice = 29.989999999999998
                        },
                        new
                        {
                            productId = 2,
                            DateAdded = new DateTime(2021, 2, 17, 8, 10, 59, 296, DateTimeKind.Local).AddTicks(7924),
                            productName = "Computer Headset",
                            productPrice = 49.990000000000002
                        },
                        new
                        {
                            productId = 3,
                            DateAdded = new DateTime(2021, 2, 17, 8, 10, 59, 296, DateTimeKind.Local).AddTicks(7959),
                            productName = "Computer Montior 28'",
                            productPrice = 129.99000000000001
                        },
                        new
                        {
                            productId = 4,
                            DateAdded = new DateTime(2021, 2, 17, 8, 10, 59, 296, DateTimeKind.Local).AddTicks(7964),
                            productName = "Computer Keyboard",
                            productPrice = 59.990000000000002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
