using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class PaymentTransaction : BaseEntity<Guid>, IRowVersion
{
    public long TransactionCode { get; set; }
    
    public Guid BookingId { get; set; }
    
    public decimal Amount { get; set; }
    
    public DateTime PaymentDate { get; set; }
    
    public PaymentMethod PaymentMethod { get; set; }
    
    public TransactionType Type { get; set; }
    
    public TransactionStatus Status { get; set; } 
    
    public string? ExternalTransactionId { get; set; }

    public string? Note { get; set; }

    public byte[] RowVersion { get; set; } = [];

    public virtual Booking Booking { get; set; } = default!;

    public virtual ICollection<TransactionProcessingLog> ProcessingLogs { get; set; } = new List<TransactionProcessingLog>();

    public virtual BookingViolation? ViolationPayment { get; set; }
}