using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class CorsPolicyConfig
{
    public string[]? Origins { get; set; }
    
    public string[]? Methods { get; set; }
    
    public string[]? Headers { get; set; }
    
    public bool AllowCredentials { get; set; } = false;
}

public class CorsSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.CorsSettings;
    
    public Dictionary<string, CorsPolicyConfig> Policies { get; set; } = new();
}