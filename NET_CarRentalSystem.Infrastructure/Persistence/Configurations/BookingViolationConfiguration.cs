using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class BookingViolationConfiguration : IEntityTypeConfiguration<BookingViolation>
{
    public void Configure(EntityTypeBuilder<BookingViolation> builder)
    {
        builder.ToTable("booking_violations");
        builder.HasKey(bv => bv.Id);

        builder.Property(bv => bv.Id)
            .HasColumnName("violation_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(bv => bv.BookingId)
            .HasColumnName("booking_id")
            .IsRequired();

        builder.Property(bv => bv.ViolationType)
            .HasColumnName("violation_type")
            .HasConversion<string>()
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(bv => bv.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(bv => bv.Amount)
            .HasColumnName("amount")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(bv => bv.Description)
            .HasColumnName("description")
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(bv => bv.Details)
            .HasColumnName("details")
            .HasMaxLength(2000);

        builder.Property(bv => bv.ResolvedAt)
            .HasColumnName("resolved_at");

        builder.Property(bv => bv.ResolvedBy)
            .HasColumnName("resolved_by");

        builder.Property(bv => bv.PaymentTransactionId)
            .HasColumnName("payment_transaction_id");

        builder.HasOne(bv => bv.Booking)
            .WithMany(b => b.Violations)
            .HasForeignKey(bv => bv.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(bv => bv.PaymentTransaction)
            .WithOne(pt => pt.ViolationPayment)
            .HasForeignKey<BookingViolation>(bv => bv.PaymentTransactionId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
