using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Domain.Exceptions.PayOs;
using PayOS;
using PayOS.Models.V2.PaymentRequests;

namespace NET_CarRentalSystem.Infrastructure.Services.Payments;

public class PayOsService(
    IOptions<PayOsSettings> payOsSetting,
    PayOSClient payOsClient) : IPayOsService
{
    private readonly PayOsSettings _payOsSetting = payOsSetting.Value;

    public async Task<PayOsCreateResponse> CreatePaymentAsync(PayOsCreateRequest payOsCreateRequest)
    {
        var expirationTime = DateTimeOffset.UtcNow.AddMinutes(_payOsSetting.ExpiryMinutes);
        var unixTimestamp = expirationTime.ToUnixTimeSeconds();
        
        var paymentRequest = new CreatePaymentLinkRequest
        {
            OrderCode = payOsCreateRequest.TransactionCode,
            Amount = payOsCreateRequest.TotalAmount,
            Description = payOsCreateRequest.Description,
            ReturnUrl = _payOsSetting.ReturnUrl,
            CancelUrl = _payOsSetting.CancelUrl,
            BuyerName = payOsCreateRequest.TransactorName,
            BuyerEmail = payOsCreateRequest.TransactorEmail,
            BuyerPhone = payOsCreateRequest.TransactorPhone,
            ExpiredAt = unixTimestamp
        };

        try
        {
            var result = await payOsClient.PaymentRequests.CreateAsync(paymentRequest);
            
            if (result == null)
            {
                throw new PayOsTechnicalException("Received null response from PayOS API.");
            }
            
            return new PayOsCreateResponse
            {
                Bin = result.Bin,
                AccountNumber = result.AccountNumber,
                AccountName = result.AccountName,
                Amount = result.Amount,
                Description = result.Description,
                OrderCode = result.OrderCode,
                Currency = result.Currency,
                PaymentLinkId = result.PaymentLinkId,
                ExpiredAt = result.ExpiredAt,
                Status = result.Status.ToString(),
                CheckoutUrl = result.CheckoutUrl,
                QrCode = result.QrCode
            };
        }
        catch (Exception ex)
        {
            throw new PayOsBusinessException($"PayOS Error: {ex.Message}", "PAYOS_ERROR");
        }
    }

    public async Task<PayOsGetPaymentLinkResponse> GetPaymentLinkInformationAsync(long orderCode)
    {
        try
        {
            var result = await payOsClient.PaymentRequests.GetAsync(orderCode);
            
            if (result == null)
            {
                throw new PayOsTechnicalException("Received null response from PayOS API.");
            }
            
            return new PayOsGetPaymentLinkResponse
            {
                Id = result.Id,
                OrderCode = result.OrderCode,
                Amount = result.Amount,
                AmountPaid = result.AmountPaid,
                AmountRemaining = result.AmountRemaining,
                Status = result.Status.ToString(),
                CreatedAt = result.CreatedAt,
                CancellationReason = result.CancellationReason,
                CanceledAt = result.CanceledAt
            };
        }
        catch (Exception ex)
        {
            throw new PayOsBusinessException($"PayOS Error: {ex.Message}", "PAYOS_GET_ERROR");
        }
    }
}
