namespace NET_CarRentalSystem.Application.Features.Payments.Events;

public record RefundProcessingFailedEvent
{
    public Guid RefundRequestId { get; init; }
    
    public Guid BookingId { get; init; }
    
    public decimal Amount { get; init; }
    
    public string FailureReason { get; init; } = string.Empty;
    
    public string? StackTrace { get; init; }
    
    public int RetryAttempts { get; init; }
    
    public DateTime FailedAt { get; init; }
}

