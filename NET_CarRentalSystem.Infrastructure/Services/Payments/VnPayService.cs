using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Http;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.Payments.VnPay;
using NET_CarRentalSystem.Domain.Exceptions.VNPay;

namespace NET_CarRentalSystem.Infrastructure.Services.Payments;

public class VnPayService(IOptions<VnPaySettings> config, IApiClient apiClient) : IVnPayService
{
    private readonly VnPaySettings _settings = config.Value;

    public async Task<string> GeneratePaymentQrCodeAsync(decimal amount, string description)
    {
        var requestBody = new VietQrRequest
        {
            AccountNo = _settings.AccountNumber,
            AccountName = _settings.AccountName,
            AcqId = _settings.BankCode,
            Amount = amount,
            AddInfo = description,
            Format = "text",
            Template = _settings.Template
        };

        var headers = new Dictionary<string, string>
        {
            { "x-client-id", _settings.ClientId },
            { "x-api-key", _settings.ApiKey }
        };

        var result = await apiClient.PostAsync<VietQrRequest, VietQrResponse>(
            _settings.ApiUrl,
            requestBody,
            headers
        );

        if (result == null)
        {
            throw new VnPayTechnicalException("Received null response from VNPay API.");
        }

        if (result.Code != "00")
        {
            throw new VnPayBusinessException(result.Desc, result.Code);
        }

        return string.IsNullOrEmpty(result.Data?.QrDataUrl) ? throw new VnPayTechnicalException("QR data URL is null or empty in the successful response.") : result.Data.QrDataUrl;
    }
}