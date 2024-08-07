﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using capstone;

#nullable disable

namespace capstone.Migrations
{
    [DbContext(typeof(CapstoneDBContext))]
    [Migration("20240729053727_add two property")]
    partial class addtwoproperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("capstone.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ServiceNumber")
                        .HasColumnType("bigint");

                    b.Property<long>("SimNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Greater Noida",
                            DOB = "12-11-1989",
                            Email = "ekansh123@gmail.com",
                            Name = "Ekansh",
                            ServiceNumber = 3692581470L,
                            SimNumber = 1472583690963L
                        },
                        new
                        {
                            Id = 2,
                            Address = "Ghaziabad",
                            DOB = "12-11-1990",
                            Email = "pankaj123@gmail.com",
                            Name = "Pankaj",
                            ServiceNumber = 3692581471L,
                            SimNumber = 1472583690964L
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ghaziabad",
                            DOB = "12-11-1990",
                            Email = "maulina123@gmail.com",
                            Name = "Maulina",
                            ServiceNumber = 3692581472L,
                            SimNumber = 1472583690965L
                        },
                        new
                        {
                            Id = 4,
                            Address = "Noida",
                            DOB = "12-11-1987",
                            Email = "rajesh123@gmail.com",
                            Name = "Rajesh",
                            ServiceNumber = 3692581473L,
                            SimNumber = 1472583690966L
                        },
                        new
                        {
                            Id = 5,
                            Address = "Delhi",
                            DOB = "12-11-1988",
                            Email = "sarthak123@gmail.com",
                            Name = "Sarthak",
                            ServiceNumber = 3692581474L,
                            SimNumber = 1472583690966L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
