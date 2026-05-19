namespace NET_CarRentalSystem.Application.Features.Payments.Events;

public class PaymentSyncEvent
{
    public Guid TransactionId { get; set; }
    public long TransactionCode { get; set; }
}
