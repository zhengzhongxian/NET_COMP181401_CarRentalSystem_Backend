using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class ResetPasswordSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.ResetPasswordSettings;
    
    public int TokenExpiryMinutes { get; set; }
    
    public int MaxTokenAttempts {get; set;}
    
    public int KeyExpiryHours { get; set; }
    
    public string? ClientUrl { get; set; }
}