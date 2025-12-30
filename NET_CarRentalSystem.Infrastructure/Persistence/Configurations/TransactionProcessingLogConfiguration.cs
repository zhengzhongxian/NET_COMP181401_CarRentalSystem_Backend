using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class TransactionProcessingLogConfiguration : IEntityTypeConfiguration<TransactionProcessingLog>
{
    public void Configure(EntityTypeBuilder<TransactionProcessingLog> builder)
    {
        builder.ToTable("transaction_processing_logs");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .HasColumnName("log_id")
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(t => t.PaymentTransactionId)
            .HasColumnName("transaction_id")
            .IsRequired();

        builder.Property(t => t.TransactionCode)
            .HasColumnName("transaction_code");

        builder.Property(t => t.ErrorMessage)
            .HasColumnName("error_message")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.StackTrace)
            .HasColumnName("stack_trace")
            .HasColumnType("nvarchar(max)");

        builder.Property(t => t.RetryCount)
            .HasColumnName("retry_count")
            .HasDefaultValue(0);

        builder.Property(t => t.LastAttemptAt)
            .HasColumnName("last_attempt_at");

        builder.Property(t => t.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(t => t.ErrorCategory)
            .HasColumnName("error_category")
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(t => t.RawResponse)
            .HasColumnName("raw_response")
            .HasColumnType("nvarchar(max)");
        
        builder.HasOne(t => t.PaymentTransaction)
            .WithMany(pt => pt.ProcessingLogs)
            .HasForeignKey(t => t.PaymentTransactionId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasIndex(t => t.PaymentTransactionId)
            .HasDatabaseName("IX_transaction_processing_logs_transaction_id");

        builder.HasIndex(t => t.TransactionCode)
            .HasDatabaseName("IX_transaction_processing_logs_transaction_code");

        builder.HasIndex(t => t.Status)
            .HasDatabaseName("IX_transaction_processing_logs_status");
    }
}

