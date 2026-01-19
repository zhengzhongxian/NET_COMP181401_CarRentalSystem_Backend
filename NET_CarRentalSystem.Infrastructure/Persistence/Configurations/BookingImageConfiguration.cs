using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class BookingImageConfiguration : IEntityTypeConfiguration<BookingImage>
{
    public void Configure(EntityTypeBuilder<BookingImage> builder)
    {
        builder.ToTable("booking_images");
        builder.HasKey(bi => bi.Id);

        builder.Property(bi => bi.Id)
            .HasColumnName("image_id")
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(bi => bi.BookingId)
            .HasColumnName("booking_id")
            .IsRequired();

        builder.Property(bi => bi.ImageUrl)
            .HasColumnName("image_url")
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(bi => bi.PublicId)
            .HasColumnName("public_id")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(bi => bi.Description)
            .HasColumnName("description")
            .HasMaxLength(500);

        builder.Property(bi => bi.DisplayOrder)
            .HasColumnName("display_order")
            .HasDefaultValue(0);

        builder.Property(bi => bi.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(bi => bi.CreatedBy)
            .HasColumnName("created_by")
            .HasMaxLength(255);

        builder.Property(bi => bi.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(bi => bi.UpdatedBy)
            .HasColumnName("updated_by")
            .HasMaxLength(255);

        builder.Property(bi => bi.IsDeleted)
            .HasColumnName("is_deleted")
            .HasDefaultValue(false);
        
        builder.HasOne(bi => bi.Booking)
            .WithMany(b => b.BookingImages)
            .HasForeignKey(bi => bi.BookingId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasIndex(bi => bi.BookingId)
            .HasDatabaseName("IX_booking_images_booking_id");

        builder.HasIndex(bi => bi.PublicId)
            .HasDatabaseName("IX_booking_images_public_id");
        
        builder.HasQueryFilter(bi => !bi.IsDeleted);
    }
}
