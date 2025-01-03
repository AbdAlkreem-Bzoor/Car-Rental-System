﻿// <auto-generated />
using System;
using Car_Rental.Db.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Rental.Db.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241228090736_AddSeedData")]
    partial class AddSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Car_Rental.Db.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("DailyRate")
                        .HasColumnType("DECIMAL(18,2)")
                        .HasColumnName("Daily Rate");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Image Path");

                    b.Property<bool>("IsAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValue(true)
                        .HasColumnName("Is Available");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("License Plate");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LicensePlate")
                        .IsUnique();

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Silver",
                            DailyRate = 50m,
                            ImagePath = "",
                            IsAvailable = true,
                            LicensePlate = "XYZ1234",
                            Manufacturer = "Toyota",
                            Model = "Camry",
                            Type = "Sedan",
                            Year = 2020
                        },
                        new
                        {
                            Id = 2,
                            Color = "Black",
                            DailyRate = 45m,
                            ImagePath = "",
                            IsAvailable = true,
                            LicensePlate = "ABC5678",
                            Manufacturer = "Honda",
                            Model = "Civic",
                            Type = "Sedan",
                            Year = 2019
                        },
                        new
                        {
                            Id = 3,
                            Color = "Red",
                            DailyRate = 75m,
                            ImagePath = "",
                            IsAvailable = true,
                            LicensePlate = "LMN9876",
                            Manufacturer = "Ford",
                            Model = "Mustang",
                            Type = "Coupe",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Car_Rental.Db.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("DATE")
                        .HasColumnName("End Date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("DATE")
                        .HasColumnName("Start Date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("DECIMAL(18, 2)")
                        .HasColumnName("Total Amount");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            EndDate = new DateTime(2025, 1, 4, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3201),
                            StartDate = new DateTime(2024, 12, 29, 11, 7, 35, 466, DateTimeKind.Local).AddTicks(2328),
                            Status = "Pending",
                            TotalAmount = 350m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CarId = 2,
                            EndDate = new DateTime(2025, 1, 2, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3948),
                            StartDate = new DateTime(2024, 12, 30, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3938),
                            Status = "Confirmed",
                            TotalAmount = 225m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CarId = 3,
                            EndDate = new DateTime(2025, 1, 7, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3952),
                            StartDate = new DateTime(2024, 12, 31, 11, 7, 35, 468, DateTimeKind.Local).AddTicks(3950),
                            Status = "Active",
                            TotalAmount = 750m,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Car_Rental.Db.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Address Line 1");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Address Line 2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("DATE")
                        .HasColumnName("Date of Birth");

                    b.Property<string>("DriversLicenseNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Driver's License Number");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("First Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Last Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Phone Number");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "123 Main St",
                            City = "Amman",
                            Country = "Jordan",
                            DateOfBirth = new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriversLicenseNumber = "A1234567",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password123",
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "456 Oak St",
                            AddressLine2 = "Apt 7",
                            City = "Cairo",
                            Country = "Egypt",
                            DateOfBirth = new DateTime(1985, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriversLicenseNumber = "B7654321",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Password = "password456",
                            PhoneNumber = "987-654-3210"
                        },
                        new
                        {
                            Id = 3,
                            AddressLine1 = "789 Pine St",
                            City = "Nablus",
                            Country = "Palestine",
                            DateOfBirth = new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriversLicenseNumber = "C2345678",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Password = "password789",
                            PhoneNumber = "555-111-2222"
                        });
                });

            modelBuilder.Entity("Car_Rental.Db.Entities.Rental", b =>
                {
                    b.HasOne("Car_Rental.Db.Entities.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Car_Rental.Db.Entities.User", "User")
                        .WithMany("Rentals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Car_Rental.Db.Entities.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Car_Rental.Db.Entities.User", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
