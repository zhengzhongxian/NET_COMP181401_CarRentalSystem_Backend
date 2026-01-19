using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class TransactionProcessingLog
{
    public Guid Id { get; set; }
    
    public Guid PaymentTransactionId { get; set; }
    
    public string? TransactionCode { get; set; }
    
    public string? ErrorMessage { get; set; }
    
    public string? StackTrace { get; set; }
    
    public int RetryCount { get; set; }
    
    public DateTime LastAttemptAt { get; set; }
    
    public TransactionLogStatus Status { get; set; }
    
    public ErrorCategory? ErrorCategory { get; set; }
    
    public string? RawResponse { get; set; }
    
    public virtual PaymentTransaction PaymentTransaction { get; set; } = default!;
}