using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToTable("vehicles");

        builder.HasKey(v => v.Id);

        builder.Property(v => v.Id)
            .HasColumnName("vehicle_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(v => v.Manufacturer)
            .HasColumnName("manufacturer")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(v => v.Model)
            .HasColumnName("model")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(v => v.Color)
            .HasColumnName("color")
            .HasMaxLength(50);

        builder.Property(v => v.PricePerHour)
            .HasColumnName("price_per_hour")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(v => v.Thumbnail)
            .HasColumnName("thumbnail");

        builder.Property(v => v.Description)
            .HasColumnName("description");

        builder.Property(v => v.Rating)
            .HasColumnName("rating");

        builder.Property(v => v.Metadata)
            .HasColumnName("metadata")
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.AvailableCount)
            .HasColumnName("available_count")
            .HasDefaultValue(0);

        builder.Property(v => v.VehicleCategoryId)
            .HasColumnName("vehicle_category_id");

        builder.Property(v => v.FuelId)
            .HasColumnName("fuel_id");

        builder.Property(v => v.TransmissionId)
            .HasColumnName("transmission_id");

        builder.Property(v => v.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(v => v.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(v => v.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(v => v.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(v => v.IsDeleted)
            .HasColumnName("is_deleted");

        builder.Property(v => v.DeletedBy)
            .HasColumnName("deleted_by");

        builder.Property(v => v.DeletedAt)
            .HasColumnName("deleted_at");

        builder.Property(v => v.RowVersion)
            .HasColumnName("row_version")
            .IsRowVersion()
            .ValueGeneratedOnAddOrUpdate();

        // Relationships
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

        builder.HasMany(v => v.VehicleModels)
            .WithOne(vm => vm.Vehicle)
            .HasForeignKey(vm => vm.VehicleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(v => v.VehicleImages)
            .WithOne(vi => vi.Vehicle)
            .HasForeignKey(vi => vi.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(v => v.VehicleAttributes)
            .WithOne(va => va.Vehicle)
            .HasForeignKey(va => va.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(v => v.Bookings)
            .WithOne(b => b.Vehicle)
            .HasForeignKey(b => b.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

