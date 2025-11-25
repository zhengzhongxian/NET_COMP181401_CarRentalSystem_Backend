namespace NET_CarRentalSystem.API.Models.Request.Payments;

public class CreatePaymentQrRequest
{
    public decimal Amount { get; set; }
    public required string Description { get; set; }
}