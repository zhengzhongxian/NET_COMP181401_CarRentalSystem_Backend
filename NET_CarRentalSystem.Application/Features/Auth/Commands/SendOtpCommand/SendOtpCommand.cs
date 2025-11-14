using MediatR;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtpCommand;

public class SendOtpCommand : ICommand<(string, bool)>
{
    public required SendOtpParams SendOtpParams { get; set; }
}

public class SendOtpCommandHandler(
    ICacheService cacheService,
    IEmailService emailService,
    IOptions<OtpSettings>  otpSettings,
    IUnitOfWork unitOfWork) : IRequestHandler<SendOtpCommand, (string, bool)>
{
    private readonly OtpSettings _otpSettings = otpSettings.Value;
    
    public async Task<(string, bool)> Handle(SendOtpCommand request, CancellationToken cancellationToken)
    {
        var userRepository = unitOfWork.GetRepository<User>();
        var existingUser = await userRepository.GetFirstOrDefaultAsync(
            u => u.UserName == request.SendOtpParams.UserName || u.Email == request.SendOtpParams.Email, 
            cancellationToken: cancellationToken);
        
        if (existingUser != null)
        {
            return (AuthMessage.Logup.UserExists, false);
        }

        var key = CacheKeyHelper.GetOtpKey(request.SendOtpParams.Email);
        var cachedOtpDetailsJson = await cacheService.GetStringAsync(key, cancellationToken);

        if (cachedOtpDetailsJson == null) return await CreateAndSendOtp(request, key, cancellationToken);
        var cachedOtpDetails = cachedOtpDetailsJson.FromJson<OtpDetailsDto>()!;
        if (cachedOtpDetails.AttemptCount < _otpSettings.MaxOtpAttempts)
            return await UpdateAndSendOtp(request, key, cachedOtpDetails, cancellationToken);

        var remainingTime = cachedOtpDetails.KeyExpiresAt - DateTime.UtcNow;
        var hoursRemaining = Math.Ceiling(remainingTime.TotalHours);
        if (hoursRemaining < 0) hoursRemaining = 0;

        var message = string.Format(AuthMessage.Otp.MaxAttempts, hoursRemaining.ToString("F0"));

        return (message, false);
    }

    private async Task<(string, bool)> CreateAndSendOtp(SendOtpCommand request, string key, CancellationToken cancellationToken)
    {
        var otp = OtpHelper.GenerateOtp();
        var absoluteExpiration = DateTime.UtcNow.AddHours(_otpSettings.KeyExpiryHours);

        var otpDetails = new OtpDetailsDto
        {
            Otp = otp,
            UserName = request.SendOtpParams.UserName,
            AttemptCount = 1,
            ExpiryTime = DateTime.UtcNow.AddMinutes(_otpSettings.OtpExpiryMinutes),
            KeyExpiresAt = absoluteExpiration
        };

        await cacheService.SetStringAsync(key, otpDetails.ToJson(), absoluteExpiration, cancellationToken);
        await SendOtpEmail(request.SendOtpParams.Email, request.SendOtpParams.Name, otp, cancellationToken);

        return (AuthMessage.Otp.SentSuccess, true);
    }

    private async Task<(string, bool)> UpdateAndSendOtp(SendOtpCommand request, string key, OtpDetailsDto existingDetails, CancellationToken cancellationToken)
    {
        var otp = OtpHelper.GenerateOtp();

        var otpDetails = new OtpDetailsDto
        {
            Otp = otp,
            UserName = request.SendOtpParams.UserName,
            AttemptCount = existingDetails.AttemptCount + 1,
            ExpiryTime = DateTime.UtcNow.AddMinutes(_otpSettings.OtpExpiryMinutes),
            KeyExpiresAt = existingDetails.KeyExpiresAt
        };

        await cacheService.SetStringAsync(key, otpDetails.ToJson(), existingDetails.KeyExpiresAt, cancellationToken);
        await SendOtpEmail(request.SendOtpParams.Email, request.SendOtpParams.Name, otp, cancellationToken);

        return (AuthMessage.Otp.SentSuccess, true);
    }

    private async Task SendOtpEmail(string email, string name, string otp, CancellationToken cancellationToken)
    {
        const string templateName = AppConstants.EmailTemplates.Otp;

        var placeholders = new Dictionary<string, string>
        {
            { "{Name}", name },
            { "{Otp}", otp },
            { "{ExpiryTime}", _otpSettings.OtpExpiryMinutes.ToString() }
        };

        await emailService.SendTemplateEmailAsync(email, "Mã xác thực Renticar", templateName, placeholders, cancellationToken);
    }
}