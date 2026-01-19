using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleReadFlatConfiguration : IEntityTypeConfiguration<VehicleReadFlat>
{
    public void Configure(EntityTypeBuilder<VehicleReadFlat> builder)
    {
        builder.ToTable("vehicle_read_flat");

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
            .HasPrecision(18, 2);

        builder.Property(v => v.Thumbnail)
            .HasColumnName("thumbnail");

        builder.Property(v => v.Description)
            .HasColumnName("description");

        builder.Property(v => v.Rating)
            .HasColumnName("rating");

        builder.Property(v => v.VehicleCategoryId)
            .HasColumnName("vehicle_category_id");

        builder.Property(v => v.CategoryName)
            .HasColumnName("category_name")
            .HasMaxLength(100);

        builder.Property(v => v.FuelId)
            .HasColumnName("fuel_id");

        builder.Property(v => v.FuelName)
            .HasColumnName("fuel_name")
            .HasMaxLength(100);

        builder.Property(v => v.TransmissionId)
            .HasColumnName("transmission_id");

        builder.Property(v => v.TransmissionName)
            .HasColumnName("transmission_name")
            .HasMaxLength(50);

        builder.Property(v => v.AvailableCount)
            .HasColumnName("available_count")
            .HasDefaultValue(0);

        builder.Property(v => v.VehicleModelsJson)
            .HasColumnName("vehicle_models_json")
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.ImagesJson)
            .HasColumnName("images_json")
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.AttributesJson)
            .HasColumnName("attributes_json")
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.Metadata)
            .HasColumnName("metadata")
            .HasColumnType("nvarchar(max)");

        builder.Property(v => v.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(v => v.CreatedBy)
            .HasColumnName("created_by")
            .HasMaxLength(255);

        builder.Property(v => v.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(v => v.UpdatedBy)
            .HasColumnName("updated_by")
            .HasMaxLength(255);

        builder.Property(v => v.IsDeleted)
            .HasColumnName("is_deleted");

        builder.Property(v => v.DeletedAt)
            .HasColumnName("deleted_at");

        builder.Property(v => v.DeletedBy)
            .HasColumnName("deleted_by")
            .HasMaxLength(255);
        
        builder.HasIndex(v => v.VehicleCategoryId);
        builder.HasIndex(v => v.UpdatedAt);
        builder.HasIndex(v => v.IsDeleted);
    }
}

