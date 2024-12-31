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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            ConfigurePK(builder);

            ConfigureImagePath(builder);

            ConfigureManufacturer(builder);

            ConfigureModel(builder);

            ConfigureColor(builder);

            ConfigureLicensePlate(builder);

            ConfigureDailyRate(builder);

            ConfigureType(builder);

            ConfigureIsAvailable(builder);

            builder.ToTable("Cars");
        }

        private void ConfigureImagePath(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x => x.ImagePath)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                   .HasColumnName("Image Path")
                   .IsRequired();
        }

        private void ConfigureIsAvailable(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.IsAvailable)
                   .HasColumnName("Is Available")
                   .HasColumnType("BIT")
                   .HasDefaultValue(true);
        }

        private void ConfigureType(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Type)
                   .HasConversion
                   (
                       x => x.ToString(),
                       x => (CarType)Enum.Parse(typeof(CarType), x)
                   );
        }

        private void ConfigureDailyRate(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.DailyRate)
                   .HasColumnName("Daily Rate")
                   .HasColumnType("DECIMAL(18,2)");
        }

        private void ConfigureLicensePlate(EntityTypeBuilder<Car> builder)
        {
            builder.HasIndex(c => c.LicensePlate)
                   .IsUnique();

            builder.Property(c => c.LicensePlate)
                   .HasColumnType("VARCHAR(20)")
                   .HasColumnName("License Plate");
        }

        private void ConfigureColor(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Color)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(30);
        }

        private void ConfigureModel(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Model)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                   .IsRequired();
        }

        private void ConfigureManufacturer(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Manufacturer)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                   .IsRequired();
        }

        private void ConfigurePK(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id);
        }
    }
}
