using NET_CarRentalSystem.Application.Models.Payments.PayOs;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Payments;

public interface IPayOsService
{
    Task<PayOsCreateResponse> CreatePaymentAsync(PayOsCreateRequest payOsCreateRequest);
    
    Task<PayOsGetPaymentLinkResponse> GetPaymentLinkInformationAsync(long orderCode);
}