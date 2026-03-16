using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

/// <summary>
/// Cấu hình cho Twilio Verify API
/// </summary>
public class TwilioSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.TwilioSettings;
    
    public string AccountSid { get; set; } = string.Empty;
    
    public string AuthToken { get; set; } = string.Empty;
    
    public string ServiceSid { get; set; } = string.Empty;
}

