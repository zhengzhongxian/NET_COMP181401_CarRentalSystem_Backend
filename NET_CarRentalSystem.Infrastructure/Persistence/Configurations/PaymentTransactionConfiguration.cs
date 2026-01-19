using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class PaymentTransactionConfiguration : IEntityTypeConfiguration<PaymentTransaction>
{
    public void Configure(EntityTypeBuilder<PaymentTransaction> builder)
    {
        builder.ToTable("payment_transactions");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .HasColumnName("transaction_id")
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(t => t.TransactionCode)
            .HasColumnName("transaction_code")
            .IsRequired();
        
        builder.Property(t => t.BookingId)
            .HasColumnName("booking_id");
        
        builder.Property(t => t.Amount)
            .HasColumnName("amount")
            .HasColumnType("decimal(18, 2)");

        builder.Property(t => t.PaymentDate)
            .HasColumnName("payment_date");

        builder.Property(t => t.PaymentMethod)
            .HasColumnName("payment_method")
            .HasConversion<string>()
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(t => t.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(20);
        
        builder.Property(t => t.Type)
            .HasColumnName("transaction_type")
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(t => t.ExternalTransactionId)
            .HasColumnName("external_transaction_id");
        
        builder.Property(t => t.Note)
            .HasColumnName("note");

        builder.Property(t => t.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(t => t.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(t => t.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(t => t.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(t => t.IsDeleted)
            .HasColumnName("is_deleted")
            .IsRequired();

        builder.Property(t => t.DeletedAt)
            .HasColumnName("deleted_at");

        builder.Property(t => t.DeletedBy)
            .HasColumnName("deleted_by");

        builder.Property(t => t.RowVersion)
            .HasColumnName("row_version")
            .IsRowVersion()
            .ValueGeneratedOnAddOrUpdate();
        
        builder.HasOne(t => t.Booking)
            .WithMany(b => b.Transactions)
            .HasForeignKey(t => t.BookingId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(t => t.ProcessingLogs)
            .WithOne(pl => pl.PaymentTransaction)
            .HasForeignKey(pl => pl.PaymentTransactionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}