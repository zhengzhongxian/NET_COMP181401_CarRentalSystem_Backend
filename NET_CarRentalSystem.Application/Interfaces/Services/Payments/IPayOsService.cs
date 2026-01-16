using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Payments;

public interface IPayOsService
{
    Task<PayOsCreateResponse> CreatePaymentAsync(PayOsCreateRequest payOsCreateRequest);
    
    Task<PayOsGetPaymentLinkResponse> GetPaymentLinkInformationAsync(long orderCode);
    
    Task<PayOsWebhookData?> VerifyWebhookAsync(PayOsWebhook webhook);

    /// <summary>
    /// Thực hiện chi hộ (Payout) qua PayOS để hoàn tiền cho khách
    /// </summary>
    Task<CreatePayoutResponse> RefundPaymentAsync(CreatePayoutRequest payoutData);
}