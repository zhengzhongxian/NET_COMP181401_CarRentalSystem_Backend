using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class RefundRequest : BaseEntity<Guid>
{
    public Guid BookingId { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public decimal Amount { get; set; }
    
    public RefundStatus Status { get; set; }
    
    public string? Reason { get; set; }
    
    public string? AdminNotes { get; set; }
    
    public Guid? ApprovedBy { get; set; }
    
    public DateTime? ApprovedAt { get; set; }
    
    public DateTime? ProcessedAt { get; set; }
}

