using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class WebhookLogConfiguration : IEntityTypeConfiguration<WebhookLog>
{
    public void Configure(EntityTypeBuilder<WebhookLog> builder)
    {
        builder.ToTable("webhook_logs");

        builder.HasKey(w => w.Id);
        builder.Property(w => w.Id).HasColumnName("webhook_log_id");

        builder.Property(w => w.EventType)
            .HasColumnName("event_type")
            .HasConversion<string>()
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(w => w.Payload)
            .HasColumnName("payload")
            .IsRequired();

        builder.Property(w => w.OrderCode)
            .HasColumnName("order_code")
            .IsRequired();

        builder.Property(w => w.Reference)
            .HasColumnName("reference")
            .HasMaxLength(255);

        builder.Property(w => w.Amount)
            .HasColumnName("amount")
            .IsRequired();

        builder.Property(w => w.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(w => w.ErrorCode)
            .HasColumnName("error_code")
            .HasConversion<string>()
            .HasMaxLength(50);


        builder.Property(w => w.ProcessedAt)
            .HasColumnName("processed_at");

        builder.Property(w => w.ProcessedBy)
            .HasColumnName("processed_by")
            .HasMaxLength(255);

        builder.HasQueryFilter(w => !w.IsDeleted);
    }
}

