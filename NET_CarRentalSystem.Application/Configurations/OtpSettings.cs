using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class OtpSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.OtpSettings;
    
    public int OtpExpiryMinutes { get; set; }
    
    public int MaxOtpAttempts { get; set; }
    
    public int KeyExpiryHours { get; set; }
}