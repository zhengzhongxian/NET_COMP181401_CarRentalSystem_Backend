using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class RefundRequestConfiguration : IEntityTypeConfiguration<RefundRequest>
{
    public void Configure(EntityTypeBuilder<RefundRequest> builder)
    {
        builder.ToTable("refund_requests");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Id)
            .HasColumnName("refund_request_id")
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(r => r.BookingId)
            .HasColumnName("booking_id")
            .IsRequired();

        builder.Property(r => r.CustomerId)
            .HasColumnName("customer_id")
            .IsRequired();

        builder.Property(r => r.Amount)
            .HasColumnName("amount")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(r => r.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(r => r.Reason)
            .HasColumnName("reason")
            .HasMaxLength(500);

        builder.Property(r => r.AdminNotes)
            .HasColumnName("admin_notes")
            .HasMaxLength(1000);

        builder.Property(r => r.IsDepositRefund)
            .HasColumnName("is_deposit_refund")
            .HasDefaultValue(false);

        builder.Property(r => r.ScheduledAt)
            .HasColumnName("scheduled_at");

        builder.Property(r => r.ReadyToProcessAt)
            .HasColumnName("ready_to_process_at");

        builder.Property(r => r.ApprovedBy)
            .HasColumnName("approved_by");

        builder.Property(r => r.ApprovedAt)
            .HasColumnName("approved_at");

        builder.Property(r => r.ProcessedAt)
            .HasColumnName("processed_at");

        builder.HasQueryFilter(r => !r.IsDeleted);

    }
}

