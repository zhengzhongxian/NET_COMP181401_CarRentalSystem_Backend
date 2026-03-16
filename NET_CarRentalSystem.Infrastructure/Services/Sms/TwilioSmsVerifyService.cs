using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Sms;
using NET_CarRentalSystem.Domain.Exceptions.Twilio;
using Twilio;
using Twilio.Exceptions;
using Twilio.Rest.Verify.V2.Service;

namespace NET_CarRentalSystem.Infrastructure.Services.Sms;

public class TwilioSmsVerifyService : ITwilioSmsVerifyService
{
    private readonly TwilioSettings _settings;
    private readonly ILogger<TwilioSmsVerifyService> _logger;
    private bool _isInitialized;

    public TwilioSmsVerifyService(
        IOptions<TwilioSettings> settings,
        ILogger<TwilioSmsVerifyService> logger)
    {
        _settings = settings.Value;
        _logger = logger;
        
        InitializeTwilioClient();
    }

    private void InitializeTwilioClient()
    {
        if (_isInitialized) return;
        
        if (string.IsNullOrEmpty(_settings.AccountSid) || 
            string.IsNullOrEmpty(_settings.AuthToken) ||
            string.IsNullOrEmpty(_settings.ServiceSid))
        {
            _logger.LogWarning("[Twilio] AccountSid, AuthToken or ServiceSid is not configured");
            return;
        }
        
        TwilioClient.Init(_settings.AccountSid, _settings.AuthToken);
        _isInitialized = true;
        _logger.LogInformation("[Twilio] Client initialized successfully");
    }
    
    public async Task<string> SendCodeAsync(string phoneNumber, CancellationToken ct = default)
    {
        EnsureInitialized();

        try
        {
            _logger.LogInformation("[Twilio] Sending verification code to {PhoneNumber}", 
                MaskPhoneNumber(phoneNumber));

            var verification = await VerificationResource.CreateAsync(
                to: phoneNumber,
                channel: "sms",
                pathServiceSid: _settings.ServiceSid
            );

            _logger.LogInformation("[Twilio] Verification sent, status: {Status}", 
                verification.Status);

            return verification.Status;
        }
        catch (ApiException ex)
        {
            _logger.LogError(ex, "[Twilio] API error sending verification code to {PhoneNumber}. Code: {Code}", 
                MaskPhoneNumber(phoneNumber), ex.Code);
            
            throw new TwilioBusinessException(
                $"Failed to send verification code: {ex.Message}", 
                ex.Code.ToString());
        }
        catch (Exception ex) when (ex is not TwilioBusinessException and not TwilioTechnicalException)
        {
            _logger.LogError(ex, "[Twilio] Technical error sending verification code to {PhoneNumber}", 
                MaskPhoneNumber(phoneNumber));
            
            throw new TwilioTechnicalException(
                $"Failed to send verification code due to technical error: {ex.Message}", 
                ex);
        }
    }
    
    public async Task<bool> VerifyCodeAsync(string phoneNumber, string code, CancellationToken ct = default)
    {
        EnsureInitialized();

        try
        {
            _logger.LogInformation("[Twilio] Verifying code for {PhoneNumber}", 
                MaskPhoneNumber(phoneNumber));

            var verificationCheck = await VerificationCheckResource.CreateAsync(
                to: phoneNumber,
                code: code,
                pathServiceSid: _settings.ServiceSid
            );

            var isApproved = verificationCheck.Status == "approved";
            
            _logger.LogInformation("[Twilio] Verification check status: {Status}, approved: {IsApproved}", 
                verificationCheck.Status, isApproved);

            return isApproved;
        }
        catch (ApiException ex)
        {
            _logger.LogError(ex, "[Twilio] API error verifying code for {PhoneNumber}. Code: {Code}", 
                MaskPhoneNumber(phoneNumber), ex.Code);
            
            if (ex.Code != 20404) 
                throw new TwilioBusinessException(
                    $"Failed to verify code: {ex.Message}",
                    ex.Code.ToString());
            _logger.LogWarning("[Twilio] Verification not found or expired for {PhoneNumber}", 
                MaskPhoneNumber(phoneNumber));
            return false;

        }
        catch (Exception ex) when (ex is not TwilioBusinessException and not TwilioTechnicalException)
        {
            _logger.LogError(ex, "[Twilio] Technical error verifying code for {PhoneNumber}", 
                MaskPhoneNumber(phoneNumber));
            
            throw new TwilioTechnicalException(
                $"Failed to verify code due to technical error: {ex.Message}", 
                ex);
        }
    }
    
    private void EnsureInitialized()
    {
        if (!_isInitialized)
        {
            throw new TwilioNotConfiguredException();
        }
    }
    
    private static string MaskPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 6)
            return "***";
        
        return phoneNumber[..3] + "****" + phoneNumber[^3..];
    }
}

