using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleReturnImageConfiguration : IEntityTypeConfiguration<VehicleReturnImage>
{
    public void Configure(EntityTypeBuilder<VehicleReturnImage> builder)
    {
        builder.ToTable("vehicle_return_images");
        builder.HasKey(vri => vri.Id);

        builder.Property(vri => vri.Id)
            .HasColumnName("return_image_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(vri => vri.BookingId)
            .HasColumnName("booking_id")
            .IsRequired();

        builder.Property(vri => vri.ImageUrl)
            .HasColumnName("image_url")
            .IsRequired();

        builder.Property(vri => vri.PublicId)
            .HasColumnName("public_id");

        builder.Property(vri => vri.DisplayOrder)
            .HasColumnName("display_order")
            .IsRequired();

        builder.Property(vri => vri.Description)
            .HasColumnName("description")
            .HasMaxLength(500);
        
        builder.HasOne(vri => vri.Booking)
            .WithMany(b => b.VehicleReturnImages)
            .HasForeignKey(vri => vri.BookingId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

