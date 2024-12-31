using Car_Rental.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Db.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.ConfigureWarnings(warnings =>
        //   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

        //    optionsBuilder.UseSqlServer("Server = .; Database = Car Rental System; Integrated Security = SSPI; TrustServerCertificate = True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Password = "password123",  // You should hash passwords in production
                    PhoneNumber = "123-456-7890",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    AddressLine1 = "123 Main St",
                    AddressLine2 = null,
                    City = Cities.Amman,
                    Country = Countries.Jordan,
                    DriversLicenseNumber = "A1234567"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Password = "password456",  // You should hash passwords in production
                    PhoneNumber = "987-654-3210",
                    DateOfBirth = new DateTime(1985, 7, 22),
                    AddressLine1 = "456 Oak St",
                    AddressLine2 = "Apt 7",
                    City = Cities.Cairo,
                    Country = Countries.Egypt,
                    DriversLicenseNumber = "B7654321"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    Password = "password789",  // You should hash passwords in production
                    PhoneNumber = "555-111-2222",
                    DateOfBirth = new DateTime(1995, 11, 5),
                    AddressLine1 = "789 Pine St",
                    AddressLine2 = null,
                    City = Cities.Nablus,
                    Country = Countries.Palestine,
                    DriversLicenseNumber = "C2345678"
                }
            );

            // Seeding Cars
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Manufacturer = "Toyota",
                    Model = "Camry",
                    Year = 2020,
                    Color = "Silver",
                    LicensePlate = "XYZ1234",
                    DailyRate = 50,
                    IsAvailable = true,
                    Type = CarType.Sedan
                },
                new Car
                {
                    Id = 2,
                    Manufacturer = "Honda",
                    Model = "Civic",
                    Year = 2019,
                    Color = "Black",
                    LicensePlate = "ABC5678",
                    DailyRate = 45,
                    IsAvailable = true,
                    Type = CarType.Sedan
                },
                new Car
                {
                    Id = 3,
                    Manufacturer = "Ford",
                    Model = "Mustang",
                    Year = 2021,
                    Color = "Red",
                    LicensePlate = "LMN9876",
                    DailyRate = 75,
                    IsAvailable = true,
                    Type = CarType.Coupe
                }
            );

            // Seeding Rentals
            modelBuilder.Entity<Rental>().HasData(
                new Rental
                {
                    Id = 1,
                    CarId = 1,
                    UserId = 1,
                    StartDate = DateTime.Now.AddDays(1),
                    EndDate = DateTime.Now.AddDays(7),
                    TotalAmount = 350,
                    Status = RentalStatus.Pending
                },
                new Rental
                {
                    Id = 2,
                    CarId = 2,
                    UserId = 2,
                    StartDate = DateTime.Now.AddDays(2),
                    EndDate = DateTime.Now.AddDays(5),
                    TotalAmount = 225,
                    Status = RentalStatus.Confirmed
                },
                new Rental
                {
                    Id = 3,
                    CarId = 3,
                    UserId = 3,
                    StartDate = DateTime.Now.AddDays(3),
                    EndDate = DateTime.Now.AddDays(10),
                    TotalAmount = 750,
                    Status = RentalStatus.Active
                }
            );

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}

