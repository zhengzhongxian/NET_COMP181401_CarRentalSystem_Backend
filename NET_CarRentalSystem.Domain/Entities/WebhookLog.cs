using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class WebhookLog : BaseEntity<Guid>
{
    public WebhookEventType EventType { get; set; }
    
    public string Payload { get; set; } = string.Empty;
    
    public long OrderCode { get; set; }
    
    public string? Reference { get; set; }
    
    public long Amount { get; set; }
    
    public WebhookLogStatus Status { get; set; } = WebhookLogStatus.Pending;
    
    public WebhookErrorCode? ErrorCode { get; set; }
    
    public DateTime? ProcessedAt { get; set; }
    
    public string? ProcessedBy { get; set; }
}

