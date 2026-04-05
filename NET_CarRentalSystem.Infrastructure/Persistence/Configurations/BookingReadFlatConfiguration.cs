using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class BookingReadFlatConfiguration : IEntityTypeConfiguration<BookingReadFlat>
{
    public void Configure(EntityTypeBuilder<BookingReadFlat> builder)
    {
        builder.ToTable("booking_read_flat");
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .HasColumnName("booking_id")
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(b => b.BookingId)
            .HasColumnName("booking_id_src");

        builder.Property(b => b.CustomerId)
            .HasColumnName("customer_id");

        builder.Property(b => b.CustomerName)
            .HasColumnName("customer_name")
            .HasMaxLength(255);

        builder.Property(b => b.CustomerEmail)
            .HasColumnName("customer_email")
            .HasMaxLength(256);

        builder.Property(b => b.CustomerPhone)
            .HasColumnName("customer_phone")
            .HasMaxLength(500);

        builder.Property(b => b.VehicleId)
            .HasColumnName("vehicle_id");

        builder.Property(b => b.VehiclePricePerHour)
            .HasColumnName("vehicle_price_per_hour")
            .HasColumnType("decimal(18, 2)");

        builder.Property(b => b.VehicleModelId)
            .HasColumnName("vehicle_model_id");

        builder.Property(b => b.PickupLocationId)
            .HasColumnName("pickup_location_id");

        builder.Property(b => b.PickupLocationName)
            .HasColumnName("pickup_location_name")
            .HasMaxLength(255);

        builder.Property(b => b.ReturnLocationId)
            .HasColumnName("return_location_id");

        builder.Property(b => b.ReturnLocationName)
            .HasColumnName("return_location_name")
            .HasMaxLength(255);

        builder.Property(b => b.NumberPlate)
            .HasColumnName("number_plate")
            .HasMaxLength(50);

        builder.Property(b => b.VehicleStatus)
            .HasColumnName("vehicle_status")
            .HasMaxLength(50);


        builder.Property(b => b.Status)
            .HasColumnName("status")
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(b => b.StartDate)
            .HasColumnName("start_date");

        builder.Property(b => b.EndDate)
            .HasColumnName("end_date");

        builder.Property(b => b.ActualEndDate)
            .HasColumnName("actual_end_date");

        builder.Property(b => b.TotalPrice)
            .HasColumnName("total_price")
            .HasColumnType("decimal(18, 2)");

        builder.Property(b => b.DepositRatio)
            .HasColumnName("deposit_ratio")
            .HasColumnType("decimal(18, 4)");
        
        builder.Property(b => b.DiscountRate)
            .HasColumnName("discount_rate")
            .HasColumnType("decimal(18, 4)");

        builder.Property(b => b.LatePenaltyRatio)
            .HasColumnName("late_penalty_ratio")
            .HasColumnType("decimal(18, 4)");

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
            .HasColumnName("condition_notes")
            .HasMaxLength(1000);

        builder.Property(b => b.Description)
            .HasColumnName("description")
            .HasMaxLength(1000);

        builder.Property(b => b.SwapReason)
            .HasColumnName("swap_reason")
            .HasMaxLength(500);

        builder.Property(b => b.CancellationReason)
            .HasColumnName("cancellation_reason")
            .HasMaxLength(1000);
        
        builder.Property(c => c.FileName)
            .HasColumnName("file_name")
            .HasMaxLength(1000);

        builder.Property(b => b.BookingImagesJson)
            .HasColumnName("booking_images_json");

        builder.Property(b => b.BookingViolationsJson)
            .HasColumnName("booking_violations_json");

        builder.Property(b => b.ReturnImagesJson)
            .HasColumnName("return_images_json");

        builder.Property(b => b.Metadata)
            .HasColumnName("metadata");

        builder.Property(b => b.DepositRefundScheduledAt)
            .HasColumnName("deposit_refund_scheduled_at");

        builder.HasIndex(b => b.BookingId)
            .HasDatabaseName("IX_booking_read_flat_booking_id");

        builder.HasIndex(b => b.CustomerId)
            .HasDatabaseName("IX_booking_read_flat_customer_id");

        builder.HasIndex(b => b.VehicleId)
            .HasDatabaseName("IX_booking_read_flat_vehicle_id");

        builder.HasIndex(b => b.StartDate)
            .HasDatabaseName("IX_booking_read_flat_start_date");
        
        builder.HasQueryFilter(b => !b.IsDeleted);
    }
}
