using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToTable("vehicles");

        builder.HasKey(v => v.VehicleId);

        builder.Property(v => v.VehicleId)
            .HasColumnName("vehicle_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(v => v.NumberPlate)
            .HasColumnName("number_plate")
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(v => v.Manufacturer)
            .HasColumnName("manufacturer")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(v => v.Model)
            .HasColumnName("model")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(v => v.Status)
            .HasColumnName("status")
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(v => v.PricePerHour)
            .HasColumnName("price_per_hour")
            .HasColumnType("decimal(18, 2)");

        builder.Property(v => v.Color)
            .HasColumnName("color")
            .HasMaxLength(50);

        builder.Property(v => v.Mileage)
            .HasColumnName("mileage");
        builder.Property(v => v.Thumbnail)
            .HasColumnName("thumbnail");

        builder.Property(v => v.LastCheckoutAt)
            .HasColumnName("last_checkout_at");

        builder.Property(v => v.Rating)
            .HasColumnName("rating");
        builder.Property(v => v.ConditionNotes)
            .HasColumnName("condition_notes");

        builder.Property(v => v.RealTimeLocation)
            .HasColumnName("real_time_location");

        builder.Property(v => v.LocationId)
            .HasColumnName("location_id");

        builder.Property(v => v.Metadata).HasColumnName("metadata").
            HasColumnType("nvarchar(max)");

        builder.Property(v => v.VehicleCategoryId)
            .HasColumnName("vehicle_category_id");

        builder.Property(v => v.FuelId)
            .HasColumnName("fuel_id");
        builder.Property(v => v.TransmissionId)
            .HasColumnName("transmission_id");

        builder.Property(c => c.Description)
            .HasColumnName("description");

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(c => c.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(c => c.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(c => c.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(c => c.IsDeleted)
            .HasColumnName("is_deleted");

        builder.HasIndex(v => v.NumberPlate).IsUnique();

        builder.HasOne(v => v.VehicleCategory)
            .WithMany(vc => vc.Vehicles)
            .HasForeignKey(v => v.VehicleCategoryId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(v => v.Fuel)
            .WithMany(f => f.Vehicles)
            .HasForeignKey(v => v.FuelId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(v => v.Transmission)
            .WithMany(t => t.Vehicles)
            .HasForeignKey(v => v.TransmissionId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(v => v.Location) 
            .WithMany(l => l.Vehicles)
            .HasForeignKey(v => v.LocationId) 
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasData(VehicleSeeder.Seed());
    }
}