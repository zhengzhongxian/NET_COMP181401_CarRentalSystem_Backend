namespace NET_CarRentalSystem.Application.Features.Payments.Events;

public record PendingTransactionsRefundNoticeEvent
{
    public Guid CustomerId { get; init; }
    
    public string CustomerName { get; init; } = string.Empty;
    
    public string CustomerEmail { get; init; } = string.Empty;
    
    public int TransactionCount { get; init; }
    
    public decimal TotalAmount { get; init; }
    
    public List<string> TransactionCodes { get; init; } = [];
    
    public List<Guid> RefundRequestIds { get; init; } = [];
    
    public DateTime CreatedAt { get; init; }
}

