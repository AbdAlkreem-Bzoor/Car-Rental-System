using Car_Rental.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Rental.Db.Data.Configurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            ConfigurePK(builder);

            ConfigureCarIdFK(builder);

            ConfigureUserIdFK(builder);

            ConfigureStartDate(builder);

            ConfigureEndDate(builder);

            ConfigureTotalAmount(builder);

            ConfigureStatus(builder);

            UserOne_To_ManyRentals(builder);

            CarOne_To_ManyRentals(builder);

            builder.ToTable("Rentals");
        }
        private void CarOne_To_ManyRentals(EntityTypeBuilder<Rental> builder)
        {
            builder.HasOne(x => x.Car)
                   .WithMany(x => x.Rentals)
                   .HasForeignKey(x => x.CarId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
        private void UserOne_To_ManyRentals(EntityTypeBuilder<Rental> builder)
        {
            builder.HasOne(x => x.User)
                   .WithMany(x => x.Rentals)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureStatus(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(x => x.Status)
                   .HasConversion
                   (
                       x => x.ToString(),
                       x => (RentalStatus)Enum.Parse(typeof(RentalStatus), x)
                   );
        }

        private void ConfigureTotalAmount(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(x => x.TotalAmount)
                   .HasColumnType("DECIMAL(18, 2)")
                   .HasColumnName("Total Amount")
                   .IsRequired();
        }

        private void ConfigureStartDate(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(x => x.StartDate)
                   .HasColumnName("Start Date")
                   .HasColumnType("DATE")
                   .IsRequired();
        }
        private void ConfigureEndDate(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(x => x.EndDate)
                   .HasColumnName("End Date")
                   .HasColumnType("DATE")
                   .IsRequired();
        }
        private void ConfigureUserIdFK(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(x => x.UserId)
                   .IsRequired();
        }

        private void ConfigureCarIdFK(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(x => x.CarId)
                   .IsRequired();
        }

        private void ConfigurePK(EntityTypeBuilder<Rental> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
