using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class BookingViolation : BaseEntity<Guid>, IRowVersion
{
    public Guid BookingId { get; set; }
    
    public ViolationType ViolationType { get; set; }
    
    public ViolationStatus Status { get; set; } = ViolationStatus.Pending;
    
    public decimal Amount { get; set; }
    
    public string Description { get; set; } = default!;
    
    public string? Details { get; set; }
    
    public DateTime? ResolvedAt { get; set; }
    
    public string? ResolvedBy { get; set; }
    
    public Guid? PaymentTransactionId { get; set; }
    
    public byte[] RowVersion { get; set; } = [];
    
    public virtual Booking Booking { get; set; } = default!;
    
    public virtual PaymentTransaction? PaymentTransaction { get; set; }
}

