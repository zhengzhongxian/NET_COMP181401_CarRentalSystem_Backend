namespace NET_CarRentalSystem.Application.Models.DTOs.PaymentDTOs.Create;

public class CreatePaymentQrLinkDto
{
    public string QrCodeUrl { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}