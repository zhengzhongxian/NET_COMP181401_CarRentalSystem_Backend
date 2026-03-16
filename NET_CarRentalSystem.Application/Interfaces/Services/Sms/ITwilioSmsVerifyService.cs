namespace NET_CarRentalSystem.Application.Interfaces.Services.Sms;

/// <summary>
/// Interface cho dịch vụ xác thực SMS qua Twilio Verify API
/// </summary>
public interface ITwilioSmsVerifyService
{
    /// <summary>
    /// Gửi mã OTP tới số điện thoại
    /// </summary>
    /// <param name="phoneNumber">Số điện thoại (định dạng quốc tế, VD: +84901234567)</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>Trạng thái gửi (pending nếu thành công)</returns>
    Task<string> SendCodeAsync(string phoneNumber, CancellationToken ct = default);
    
    Task<bool> VerifyCodeAsync(string phoneNumber, string code, CancellationToken ct = default);
}

