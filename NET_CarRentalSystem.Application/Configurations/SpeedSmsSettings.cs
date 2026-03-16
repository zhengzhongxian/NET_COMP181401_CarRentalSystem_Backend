using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class SpeedSmsSettings
{
    public const string SectionName = KeyConstants.ConfigurationSections.SpeedSmsSettings;

    public string BaseUrl { get; set; } = "https://api.speedsms.vn/index.php";

    public string AccessToken { get; set; } = string.Empty;

    public int OtpExpiryMinutes { get; set; } = 5;

    public int MaxSendPerDay { get; set; } = 5;
    
    public int SmsType { get; set; } = 2;

    public string Sender { get; set; } = string.Empty;
}
