using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleImageConfiguration : IEntityTypeConfiguration<VehicleImage>
{
    public void Configure(EntityTypeBuilder<VehicleImage> builder)
    {
        builder.ToTable("vehicle_images");

        builder.HasKey(vi => vi.ImageId);

        builder.Property(vi => vi.ImageId)
            .HasColumnName("image_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(vi => vi.Order)
            .HasColumnName("order")
            .IsRequired();

        builder.Property(vi => vi.ImageUrl)
            .HasColumnName("image_url")
            .IsRequired();

        builder.Property(vi => vi.AltText)
            .HasColumnName("alt_text");

        builder.Property(vi => vi.Caption)
            .HasColumnName("caption");

        builder.Property(vi => vi.PublicId)
            .HasColumnName("public_id");

        builder.Property(vi => vi.VehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.HasOne(vi => vi.Vehicle)
            .WithMany(v => v.VehicleImages)
            .HasForeignKey(vi => vi.VehicleId);

        builder.HasQueryFilter(vi => !vi.Vehicle.IsDeleted);

        builder.HasData(VehicleImageSeeder.Seed());
    }
}

