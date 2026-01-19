namespace NET_CarRentalSystem.Application.Features.Payments.Events;

public record RefundEmailEvent
{
    public Guid RefundRequestId { get; init; }
    
    public Guid BookingId { get; init; }
    
    public Guid CustomerId { get; init; }
    
    public decimal Amount { get; init; }
    
    public string? Reason { get; init; }
    
    public RefundEmailType EmailType { get; init; }
    
    public DateTime CreatedAt { get; init; }
}

public enum RefundEmailType
{
    Notification,
    Success     
}

