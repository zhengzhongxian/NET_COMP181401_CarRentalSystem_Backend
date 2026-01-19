using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class BookingInsuranceConfiguration : IEntityTypeConfiguration<BookingInsurance>
{
    public void Configure(EntityTypeBuilder<BookingInsurance> builder)
    {
        builder.ToTable("booking_insurances");
        builder.HasKey(bi => bi.Id);

        builder.Property(bi => bi.Id)
            .HasColumnName("booking_insurance_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(bi => bi.BookingId)
            .HasColumnName("booking_id")
            .IsRequired();

        builder.Property(bi => bi.InsurancePackageId)
            .HasColumnName("insurance_package_id")
            .IsRequired();

        builder.Property(bi => bi.Price)
            .HasColumnName("price")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(bi => bi.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(bi => bi.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(bi => bi.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(bi => bi.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(bi => bi.IsDeleted)
            .HasColumnName("is_deleted")
            .IsRequired();

        builder.Property(bi => bi.DeletedBy)
            .HasColumnName("deleted_by");

        builder.Property(bi => bi.DeletedAt)
            .HasColumnName("deleted_at");

        builder.HasOne(bi => bi.Booking)
            .WithMany(b => b.BookingInsurances)
            .HasForeignKey(bi => bi.BookingId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(bi => bi.InsurancePackage)
            .WithMany(ip => ip.BookingInsurances)
            .HasForeignKey(bi => bi.InsurancePackageId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(bi => !bi.IsDeleted);
    }
}

