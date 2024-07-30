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
    [Migration("20240729110649_add adhar number property")]
    partial class addadharnumberproperty
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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
                            AdharNumber = "397788000234",
                            DOB = "12-11-1989",
                            Email = "ekansh123@gmail.com",
                            FirstName = "Ekansh",
                            LastName = "Chandra",
                            Name = "Ekansh Chandra",
                            ServiceNumber = 3692581470L,
                            SimNumber = 1472583690963L
                        },
                        new
                        {
                            Id = 2,
                            Address = "Ghaziabad",
                            AdharNumber = "397788000235",
                            DOB = "12-11-1990",
                            Email = "pankaj123@gmail.com",
                            FirstName = "Pankaj",
                            LastName = "Pandey",
                            Name = "Pankaj Pandey",
                            ServiceNumber = 3692581471L,
                            SimNumber = 1472583690964L
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ghaziabad",
                            AdharNumber = "397788000236",
                            DOB = "12-11-1990",
                            Email = "maulina123@gmail.com",
                            FirstName = "Maulina",
                            LastName = "Sharma",
                            Name = "Maulina Sharma",
                            ServiceNumber = 3692581472L,
                            SimNumber = 1472583690965L
                        },
                        new
                        {
                            Id = 4,
                            Address = "Noida",
                            AdharNumber = "397788000237",
                            DOB = "12-11-1987",
                            Email = "rajesh123@gmail.com",
                            FirstName = "Rajesh",
                            LastName = "Verma",
                            Name = "Rajesh Verma",
                            ServiceNumber = 3692581473L,
                            SimNumber = 1472583690966L
                        },
                        new
                        {
                            Id = 5,
                            Address = "Delhi",
                            AdharNumber = "397788000238",
                            DOB = "12-11-1988",
                            Email = "sarthak123@gmail.com",
                            FirstName = "Sarthak",
                            LastName = "Tiwari",
                            Name = "Sarthak Tiwari",
                            ServiceNumber = 3692581474L,
                            SimNumber = 1472583690966L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}