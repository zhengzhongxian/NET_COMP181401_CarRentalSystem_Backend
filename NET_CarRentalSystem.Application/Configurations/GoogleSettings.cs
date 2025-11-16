using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class GoogleSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.GoogleSettings;
    
    public string ClientId { get; set; } = string.Empty;
    
    public string ClientSecret { get; set; } = string.Empty;
}