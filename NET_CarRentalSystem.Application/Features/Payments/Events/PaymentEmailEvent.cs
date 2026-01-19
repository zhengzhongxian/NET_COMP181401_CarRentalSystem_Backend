using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Payments.Events;

public class PaymentEmailEvent
{
    public Guid TransactionId { get; set; }
    
    public Guid BookingId { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public TransactionType TransactionType { get; set; }
    
    public decimal Amount { get; set; }
    
    public DateTime CreatedAt { get; set; }
}

