using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configuration;

public class JwtSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.JwtSettings;
    
    public string Key { get; set; } = string.Empty;
    
    public string Issuer { get; set; } = string.Empty;
    
    public string Audience { get; set; } = string.Empty;
    
    public int AccessTokenDurationInMinutes { get; set; }
    
    public int RefreshTokenDurationInDays { get; set; }
}