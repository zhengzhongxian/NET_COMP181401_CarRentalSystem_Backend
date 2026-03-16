using NET_CarRentalSystem.Application.Models.Sms;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Sms;

/// <summary>
/// Interface cho dịch vụ gửi SMS qua SpeedSMS
/// </summary>
public interface ISpeedSmsService
{
    /// <summary>
    /// Gửi SMS tới một hoặc nhiều số điện thoại
    /// </summary>
    /// <param name="phoneNumbers">Danh sách số điện thoại</param>
    /// <param name="content">Nội dung tin nhắn</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>Kết quả gửi SMS</returns>
    Task<SpeedSmsSendResponse> SendSmsAsync(
        string[] phoneNumbers, 
        string content, 
        CancellationToken ct = default);

    /// <summary>
    /// Kiểm tra trạng thái tin nhắn đã gửi
    /// </summary>
    /// <param name="tranId">Mã giao dịch</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>Trạng thái tin nhắn</returns>
    Task<SpeedSmsStatusResponse> GetSmsStatusAsync(
        string tranId, 
        CancellationToken ct = default);

    /// <summary>
    /// Lấy thông tin tài khoản (số dư, email)
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>Thông tin tài khoản</returns>
    Task<SpeedSmsUserInfoResponse> GetUserInfoAsync(CancellationToken ct = default);
}
