namespace NET_CarRentalSystem.API.Models.Response.Payments;

public class CreatePaymentQrResponse
{
    public string QrCodeUrl { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}