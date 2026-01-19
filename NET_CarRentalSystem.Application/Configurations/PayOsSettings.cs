using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class PayOsSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.PayOsSettings;

    /// <summary>
    /// PayOS Client ID (từ PayOS dashboard)
    /// </summary>
    public string ClientId { get; set; } = default!;

    /// <summary>
    /// PayOS API Key (từ PayOS dashboard)
    /// </summary>
    public string ApiKey { get; set; } = default!;

    /// <summary>
    /// PayOS CheckSum Key (từ PayOS dashboard) - dùng để verify signature
    /// </summary>
    public string CheckSumKey { get; set; } = default!;

    /// <summary>
    /// URL trả về sau khi thanh toán thành công
    /// </summary>
    public string ReturnUrl { get; set; } = default!;

    /// <summary>
    /// URL trả về khi người dùng hủy thanh toán
    /// </summary>
    public string CancelUrl { get; set; } = default!;
    
    /// <summary>
    /// Thời gian hết hạn của payment link (tính bằng phút)
    /// </summary>
    public int ExpiryMinutes { get; set; } = 15;
}