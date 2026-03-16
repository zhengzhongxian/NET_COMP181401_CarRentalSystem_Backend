using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.ToTable("bookings");
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .HasColumnName("booking_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(b => b.CustomerId)
            .HasColumnName("customer_id")
            .IsRequired();

        builder.Property(b => b.VehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(b => b.VehicleModelId)
            .HasColumnName("vehicle_model_id")
            .IsRequired();

        builder.Property(b => b.PickupLocationId)
            .HasColumnName("pickup_location_id")
            .IsRequired();

        builder.Property(b => b.ReturnLocationId)
            .HasColumnName("return_location_id");

        builder.Property(b => b.Status)
            .HasColumnName("status")
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

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

        builder.Property(b => b.DepositRefundScheduledAt)
            .HasColumnName("deposit_refund_scheduled_at");

        builder.Property(b => b.TotalPrice)
            .HasColumnName("total_price")
            .HasColumnType("decimal(18, 2)");

        builder.Property(b => b.MileageStart)
            .HasColumnName("mileage_start");

        builder.Property(b => b.MileageEnd)
            .HasColumnName("mileage_end");

        builder.Property(b => b.FuelLevelStart)
            .HasColumnName("fuel_level_start");

        builder.Property(b => b.FuelLevelEnd)
            .HasColumnName("fuel_level_end");

        builder.Property(b => b.FuelPrice)
            .HasColumnName("fuel_price")
            .HasColumnType("decimal(18, 2)");

        builder.Property(b => b.ConditionNotes)
            .HasColumnName("condition_notes");

        builder.Property(c => c.Description)
            .HasColumnName("description");

        builder.Property(c => c.SwapReason)
            .HasColumnName("swap_reason")
            .HasMaxLength(500);

        builder.Property(c => c.CancellationReason)
            .HasColumnName("cancellation_reason")
            .HasMaxLength(1000);

        builder.Property(c => c.AcceptedTermsVersion)
            .HasColumnName("accepted_terms_version")
            .HasMaxLength(50);

        builder.Property(c => c.AcceptedTermsAt)
            .HasColumnName("accepted_terms_at");

        builder.Property(c => c.FileName)
            .HasColumnName("file_name")
            .HasMaxLength(1000);

        builder.HasOne(b => b.Vehicle)
            .WithMany(v => v.Bookings)
            .HasForeignKey(b => b.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.VehicleModel)
            .WithMany(vm => vm.Bookings)
            .HasForeignKey(b => b.VehicleModelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Customer)
            .WithMany(c => c.Bookings)
            .HasForeignKey(b => b.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.PickupLocation)
            .WithMany()
            .HasForeignKey(b => b.PickupLocationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.ReturnLocation)
            .WithMany()
            .HasForeignKey(b => b.ReturnLocationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(b => !b.Vehicle.IsDeleted);
    }
}
