using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class CloudinarySettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.CloudinarySettings;
    
    public string CloudName { get; set; } = string.Empty;
    
    public string ApiKey { get; set; } = string.Empty;
    
    public string ApiSecret { get; set; } = string.Empty;
}
