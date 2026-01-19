namespace NET_CarRentalSystem.API.Models.Response.Violations;

public class CreateViolationPaymentResponse
{
    public Guid TransactionId { get; set; }
    
    public long TransactionCode { get; set; } = default!;
    
    public decimal Amount { get; set; }
    
    public string? PaymentUrl { get; set; }
    
    public string? QrCode { get; set; }
    
    public DateTime ExpireDate { get; set; }
}

