using System.Text.RegularExpressions;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Interfaces.Services.Sms;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.VerifyPhoneOtpCommand;

public class VerifyPhoneOtpCommand : ICommand<(bool Success, string Message)>
{
    public string Otp { get; set; } = string.Empty;
}

public class VerifyPhoneOtpCommandHandler(
    ITwilioSmsVerifyService twilioSmsVerifyService,
    ICurrentUserService currentUserService,
    IUnitOfWork unitOfWork,
    ILogger<VerifyPhoneOtpCommandHandler> logger,
    ICryptographyService cryptographyService)
    : IRequestHandler<VerifyPhoneOtpCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(
        VerifyPhoneOtpCommand request,
        CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        if (userId == null)
        {
            return (false, SmsMessage.SendOtp.UserNotFound);
        }

        // Đọc từ WriteRepository để có thể update (CQRS pattern)
        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.UserId == userId.Value,
                cancellationToken: cancellationToken);

        if (customer == null)
        {
            return (false, SmsMessage.SendOtp.UserNotFound);
        }

        var decryptedPhone = cryptographyService.DecryptAes(customer.PhoneNumber);
        var internationalPhone = FormatToE164(decryptedPhone);

        logger.LogInformation("[Twilio] Verifying OTP for phone: {Phone}", MaskPhone(internationalPhone));

        // Verify OTP with Twilio
        var isApproved = await twilioSmsVerifyService.VerifyCodeAsync(
            internationalPhone, 
            request.Otp, 
            cancellationToken);

        if (!isApproved)
        {
            logger.LogWarning("[Twilio] OTP verification failed for user {UserId}", userId);
            return (false, SmsMessage.VerifyOtp.InvalidOtp);
        }

        // Update customer verification status
        customer.IsPhoneVerified = true;
        unitOfWork.GetWriteRepository<Customer>().Update(customer);

        // Kiểm tra xem claim PhoneVerified đã tồn tại chưa
        var existingClaim = await unitOfWork.GetWriteRepository<UserClaim>()
            .GetFirstOrDefaultAsync(
                c => c.UserId == userId.Value && c.ClaimValue == PermissionConstants.Ekyc.PhoneVerified,
                cancellationToken: cancellationToken);

        if (existingClaim == null)
        {
            var userClaim = new UserClaim
            {
                UserId = userId.Value,
                ClaimType = "Permission",
                ClaimValue = PermissionConstants.Ekyc.PhoneVerified
            };
            await unitOfWork.GetWriteRepository<UserClaim>().AddAsync(userClaim, cancellationToken);
        }
        
        if (customer.IsIdentityVerified && customer.IsDriverLicenseVerified)
        {
            var existingFullyClaim = await unitOfWork.GetWriteRepository<UserClaim>()
                .GetFirstOrDefaultAsync(
                    c => c.UserId == userId.Value && c.ClaimValue == PermissionConstants.Ekyc.FullyVerified,
                    cancellationToken: cancellationToken);

            if (existingFullyClaim == null)
            {
                var fullyVerifiedClaim = new UserClaim
                {
                    UserId = userId.Value,
                    ClaimType = "Permission",
                    ClaimValue = PermissionConstants.Ekyc.FullyVerified
                };
                await unitOfWork.GetWriteRepository<UserClaim>().AddAsync(fullyVerifiedClaim, cancellationToken);
            }
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        logger.LogInformation("[Twilio] Phone verified successfully for user {UserId}", userId);

        return (true, SmsMessage.VerifyOtp.Success);
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
