using System.Text.RegularExpressions;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Interfaces.Services.Sms;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.SendPhoneVerificationOtpCommand;

public class SendPhoneVerificationOtpCommand : ICommand<(bool Success, string Message)>;

public class SendPhoneVerificationOtpCommandHandler(
    ITwilioSmsVerifyService twilioSmsVerifyService,
    ICurrentUserService currentUserService,
    IUnitOfWork unitOfWork,
    ILogger<SendPhoneVerificationOtpCommandHandler> logger,
    ICryptographyService cryptographyService) : IRequestHandler<SendPhoneVerificationOtpCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(
        SendPhoneVerificationOtpCommand request,
        CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        if (userId == null)
        {
            return (false, SmsMessage.SendOtp.UserNotFound);
        }

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.UserId == userId.Value,
                cancellationToken: cancellationToken);

        if (customer == null)
        {
            return (false, SmsMessage.SendOtp.UserNotFound);
        }

        if (customer.IsPhoneVerified)
        {
            return (false, SmsMessage.SendOtp.AlreadyVerified);
        }

        var decryptedPhone = cryptographyService.DecryptAes(customer.PhoneNumber);
        var internationalPhone = FormatToE164(decryptedPhone);
        
        logger.LogInformation("[Twilio] Sending OTP - Original: {Original}, Formatted: {Formatted}", 
            MaskPhone(decryptedPhone), MaskPhone(internationalPhone));

        var status = await twilioSmsVerifyService.SendCodeAsync(internationalPhone, cancellationToken);

        if (status != "pending")
        {
            logger.LogWarning("[Twilio] Failed to send OTP to {Phone}: Status={Status}", 
                MaskPhone(internationalPhone), status);
            return (false, SmsMessage.SendOtp.Error);
        }

        logger.LogInformation("[Twilio] OTP sent successfully to {Phone} for user {UserId}", 
            MaskPhone(internationalPhone), userId);

        return (true, SmsMessage.SendOtp.Success);
    }

    /// <summary>
    /// Chuyển đổi số điện thoại Việt Nam sang định dạng E.164 chuẩn Twilio
    /// VD: 0818998048 -> +84818998048
    /// </summary>
    private static string FormatToE164(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return phone;

        // Loại bỏ tất cả ký tự không phải số và dấu +
        var cleaned = Regex.Replace(phone.Trim(), @"[^\d+]", "");
        
        // Đã có định dạng E.164 đúng
        if (cleaned.StartsWith("+84"))
            return cleaned;
        
        // Có dấu + nhưng không phải +84 (số quốc tế khác)
        if (cleaned.StartsWith("+"))
            return cleaned;

        // Số Việt Nam bắt đầu bằng 0 -> thay bằng +84
        if (cleaned.StartsWith("0"))
            return "+84" + cleaned[1..];

        // Số bắt đầu bằng 84 (thiếu dấu +) -> thêm dấu +
        if (cleaned.StartsWith("84") && cleaned.Length >= 11)
            return "+" + cleaned;

        // Số chỉ có phần local (9 số) -> thêm +84
        if (cleaned.Length == 9 && !cleaned.StartsWith("0"))
            return "+84" + cleaned;

        return cleaned;
    }

    /// <summary>
    /// Mask số điện thoại để bảo mật trong log
    /// </summary>
    private static string MaskPhone(string phone)
    {
        if (string.IsNullOrEmpty(phone) || phone.Length < 6)
            return "***";
        return phone[..4] + "****" + phone[^3..];
    }
}
