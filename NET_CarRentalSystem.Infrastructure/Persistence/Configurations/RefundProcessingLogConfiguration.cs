using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class RefundProcessingLogConfiguration : IEntityTypeConfiguration<RefundProcessingLog>
{
    public void Configure(EntityTypeBuilder<RefundProcessingLog> builder)
    {
        builder.ToTable("refund_processing_logs");

        // Primary Key
        builder.HasKey(x => x.Id);

        // Properties
        builder.Property(x => x.Id)
            .HasColumnName("id")
            .ValueGeneratedNever();

        builder.Property(x => x.RefundRequestId)
            .HasColumnName("refund_request_id")
            .IsRequired();

        builder.Property(x => x.ErrorMessage)
            .HasColumnName("error_message")
            .HasMaxLength(1000)
            .IsRequired();

        builder.Property(x => x.StackTrace)
            .HasColumnName("stack_trace")
            .HasMaxLength(4000);

        builder.Property(x => x.RetryCount)
            .HasColumnName("retry_count")
            .IsRequired();

        builder.Property(x => x.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.LastAttemptAt)
            .HasColumnName("last_attempt_at")
            .IsRequired();

        builder.Property(x => x.ResolutionNotes)
            .HasColumnName("resolution_notes")
            .HasMaxLength(1000);

        builder.Property(x => x.ResolvedBy)
            .HasColumnName("resolved_by");

        builder.Property(x => x.ResolvedAt)
            .HasColumnName("resolved_at");

        // Auditable
        builder.Property(x => x.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(x => x.CreatedBy)
            .HasColumnName("created_by")
            .HasMaxLength(450);

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(x => x.UpdatedBy)
            .HasColumnName("updated_by")
            .HasMaxLength(450);

        builder.Property(x => x.IsDeleted)
            .HasColumnName("is_deleted")
            .IsRequired()
            .HasDefaultValue(false);

        // Relationships
        builder.HasOne(x => x.RefundRequest)
            .WithMany()
            .HasForeignKey(x => x.RefundRequestId)
            .HasConstraintName("FK_refund_processing_logs_refund_requests_refund_request_id")
            .OnDelete(DeleteBehavior.Cascade);

        // Indexes
        builder.HasIndex(x => x.RefundRequestId)
            .HasDatabaseName("IX_refund_processing_logs_refund_request_id");

        builder.HasIndex(x => x.Status)
            .HasDatabaseName("IX_refund_processing_logs_status");

        builder.HasIndex(x => x.CreatedAt)
            .HasDatabaseName("IX_refund_processing_logs_created_at");
    }
}

