using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Sms;
using NET_CarRentalSystem.Application.Models.Sms;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services.Sms;

public class SpeedSmsService : ISpeedSmsService
{
    private readonly HttpClient _httpClient;
    private readonly SpeedSmsSettings _settings;
    private readonly ILogger<SpeedSmsService> _logger;

    public SpeedSmsService(
        HttpClient httpClient,
        IOptions<SpeedSmsSettings> settings,
        ILogger<SpeedSmsService> logger)
    {
        _httpClient = httpClient;
        _settings = settings.Value;
        _logger = logger;

        ConfigureHttpClient();
    }

    private void ConfigureHttpClient()
    {
        var baseUrl = _settings.BaseUrl;
        if (!baseUrl.EndsWith("/"))
        {
            baseUrl += "/";
        }
        
        _httpClient.BaseAddress = new Uri(baseUrl);
        _httpClient.DefaultRequestHeaders.Clear();
        
        var authBytes = Encoding.UTF8.GetBytes($"{_settings.AccessToken}:x");
        var authBase64 = Convert.ToBase64String(authBytes);
        _httpClient.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Basic", authBase64);
    }

    public async Task<SpeedSmsSendResponse> SendSmsAsync(
        string[] phoneNumbers,
        string content,
        CancellationToken ct = default)
    {
        var smsType = _settings.SmsType;
        var sender = _settings.Sender;
        
        // If SmsType is 2 (CSKH), sender should be empty string if not provided or if it's the placeholder
        if (smsType == 2 && (string.IsNullOrEmpty(sender) || sender == "YOUR_SENDER_NAME"))
        {
            sender = "";
        }

        var requestBody = new
        {
            to = phoneNumbers,
            content,
            sms_type = smsType,
            sender
        };

        var jsonBody = requestBody.ToJson();
        _logger.LogInformation("[SpeedSMS] Request Body: {Body}", jsonBody);

        var httpContent = new StringContent(
            jsonBody,
            Encoding.UTF8,
            "application/json");

        // Remove leading slash to make it relative to BaseAddress path (index.php/)
        var response = await _httpClient.PostAsync("sms/send", httpContent, ct);
        _logger.LogInformation("[SpeedSMS] url : {url}", _httpClient.BaseAddress + "sms/send");
        
        var json = await response.Content.ReadAsStringAsync(ct);

        _logger.LogInformation("[SpeedSMS] Send SMS response: {Response}", json);

        return json.FromJson<SpeedSmsSendResponse>() ?? new SpeedSmsSendResponse();
    }

    public async Task<SpeedSmsStatusResponse> GetSmsStatusAsync(
        string tranId,
        CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync($"sms/status/{tranId}", ct);
        var json = await response.Content.ReadAsStringAsync(ct);

        _logger.LogInformation("[SpeedSMS] SMS status response: {Response}", json);

        return json.FromJson<SpeedSmsStatusResponse>() ?? new SpeedSmsStatusResponse();
    }

    public async Task<SpeedSmsUserInfoResponse> GetUserInfoAsync(CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync("user/info", ct);
        var json = await response.Content.ReadAsStringAsync(ct);

        _logger.LogInformation("[SpeedSMS] User info response: {Response}", json);

        return json.FromJson<SpeedSmsUserInfoResponse>() ?? new SpeedSmsUserInfoResponse();
    }
}
