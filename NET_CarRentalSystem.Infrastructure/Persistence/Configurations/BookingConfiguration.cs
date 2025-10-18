using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("bookings");
        builder.HasKey(b => b.BookingId);

        builder.Property(b => b.BookingId)
            .HasColumnName("booking_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(b => b.CustomerId)
            .HasColumnName("customer_id")
            .IsRequired();

        builder.Property(b => b.VehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(b => b.StartDate)
            .HasColumnName("start_date")
            .IsRequired();

        builder.Property(b => b.EndDate)
            .HasColumnName("end_date")
            .IsRequired();

        builder.Property(b => b.ActualEndDate)
            .HasColumnName("actual_end_date");

        builder.Property(b => b.LatePenaltyRatio)
            .HasColumnName("late_penalty_ratio")
            .HasColumnType("decimal(5, 2)");

        builder.Property(b => b.DepositRatio)
            .HasColumnName("deposit_ratio")
            .HasColumnType("decimal(5, 2)");

        builder.Property(b => b.TotalPrice)
            .HasColumnName("total_price")
            .HasColumnType("decimal(18, 2)");

        builder.Property(b => b.MileageStart)
            .HasColumnName("mileage_start");

        builder.Property(b => b.FuelLevelEnd)
            .HasColumnName("fuel_level_end");

        builder.Property(b => b.FuelPrice)
            .HasColumnName("fuel_price")
            .HasColumnType("decimal(18, 2)");

        builder.Property(b => b.ConditionNotes)
            .HasColumnName("condition_notes");

        builder.Property(b => b.PickupLocationId)
            .HasColumnName("pickup_location_id")
            .IsRequired();

        builder.Property(b => b.ReturnLocationId)
            .HasColumnName("return_location_id");

        builder.Property(c => c.Description)
            .HasColumnName("description");

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(c => c.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(c => c.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(c => c.IsDeleted)
            .HasColumnName("is_deleted")
            .IsRequired();

        builder.HasOne(b => b.Vehicle)
            .WithMany(v => v.Bookings)
            .HasForeignKey(b => b.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.PickupLocation)
            .WithMany(l => l.PickupsFromLocation)
            .HasForeignKey(b => b.PickupLocationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.ReturnLocation)
            .WithMany(l => l.ReturnsToLocation)
            .HasForeignKey(b => b.ReturnLocationId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(b => b.Customer)
            .WithMany(c => c.Bookings)
            .HasForeignKey(b => b.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(BookingSeeder.Seed());
    }
}

