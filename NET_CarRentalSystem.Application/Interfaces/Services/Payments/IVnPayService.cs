namespace NET_CarRentalSystem.Application.Interfaces.Services.Payments;

public interface IVnPayService
{
    Task<string> GeneratePaymentQrCodeAsync(decimal amount, string description);
}