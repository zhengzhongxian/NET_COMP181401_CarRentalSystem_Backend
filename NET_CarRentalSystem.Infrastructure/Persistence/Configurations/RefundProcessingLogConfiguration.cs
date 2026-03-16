using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class RefundProcessingLogConfiguration : IEntityTypeConfiguration<RefundProcessingLog>
{
    public void Configure(EntityTypeBuilder<RefundProcessingLog> builder)
    {
        builder.ToTable("refund_processing_logs");
        
        builder.HasKey(x => x.Id);
        
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

        // Relationships
        builder.HasOne(x => x.RefundRequest)
            .WithMany()
            .HasForeignKey(x => x.RefundRequestId)
            .HasConstraintName("FK_refund_processing_logs_refund_requests_refund_request_id")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasIndex(x => x.RefundRequestId)
            .HasDatabaseName("IX_refund_processing_logs_refund_request_id");

        builder.HasIndex(x => x.Status)
            .HasDatabaseName("IX_refund_processing_logs_status");

        builder.HasIndex(x => x.CreatedAt)
            .HasDatabaseName("IX_refund_processing_logs_created_at");
    }
}

