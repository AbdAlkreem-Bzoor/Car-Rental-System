using Car_Rental.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Db.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            ConfigurePK(builder);

            ConfigureName(builder);

            ConfigureEmail(builder);

            ConfigurePassword(builder);

            ConfigurePhoneNumber(builder);

            ConfigureDateOfBirth(builder);

            ConfigureAddressLines(builder);

            ConfigureCity(builder);

            ConfigureCountry(builder);

            ConfigureDriversLicenseNumber(builder);

            builder.ToTable("Users");
        }

        private void ConfigureCountry(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Country)
                   .HasConversion
                   (
                     x => x.ToString(),
                     x => (Countries)Enum.Parse(typeof(Countries), x)
                   );
        }

        private void ConfigureDriversLicenseNumber(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.DriversLicenseNumber)
                               .HasColumnName("Driver's License Number")
                               .HasColumnType("VARCHAR")
                               .HasMaxLength(20)
                               .IsRequired();
        }

        private void ConfigureCity(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.City)
                   .HasConversion
                   (
                       x => x.ToString(),
                       x => (Cities)Enum.Parse(typeof(Cities), x)
                   )
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(100)
                   .IsRequired();
        }

        private void ConfigureAddressLines(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.AddressLine1)
                   .HasColumnName("Address Line 1")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(x => x.AddressLine2)
                   .HasColumnName("Address Line 2")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(200)
                   .IsRequired(false);
        }

        private void ConfigureDateOfBirth(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.DateOfBirth)
                   .HasColumnName("Date of Birth")
                   .HasColumnType("DATE");
        }

        private void ConfigurePhoneNumber(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.PhoneNumber)
                   .HasColumnType("VARCHAR")
                   .HasColumnName("Phone Number")
                   .HasMaxLength(15)
                   .IsRequired();
        }

        private void ConfigurePassword(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Password)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(30)
                   .IsRequired();
        }

        private void ConfigureEmail(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(320)
                   .IsRequired();

            builder.HasIndex(x => x.Email)
                   .IsUnique();
        }

        private void ConfigureName(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName)
                   .HasColumnType("VARCHAR")
                   .HasColumnName("First Name")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.LastName)
                   .HasColumnType("VARCHAR")
                   .HasColumnName("Last Name")
                   .HasMaxLength(50)
                   .IsRequired();
        }

        private void ConfigurePK(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
