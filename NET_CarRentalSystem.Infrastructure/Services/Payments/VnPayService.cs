using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Http;

namespace NET_CarRentalSystem.Infrastructure.Services.Payments;

public class VnPayService : IVnPayService
{
    private readonly VnPaySettings _settings;
    private readonly IApiClient _apiClient;

    public VnPayService(IOptions<VnPaySettings> config, IApiClient apiClient)
    {
        _settings = config.Value;
        _apiClient = apiClient;
    }

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

        var result = await _apiClient.PostAsync<VietQrRequest, VietQrResponse>(
            _settings.ApiUrl,
            requestBody,
            headers
        );

        if (result?.Data?.QrDataUrl == null)
        {
            throw new Exception($"Failed to generate QR code. Error: {result?.Desc ?? "Unknown error"}");
        }

        return result.Data.QrDataUrl;
    }

    // Request model
    private class VietQrRequest
    {
        public string AccountNo { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;
        public string AcqId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string AddInfo { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public string Template { get; set; } = string.Empty;
    }

    // Response models
    private class VietQrResponse
    {
        public string Code { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public VietQrData? Data { get; set; }
    }

    private class VietQrData
    {
        public string QrDataUrl { get; set; } = string.Empty;
    }
}