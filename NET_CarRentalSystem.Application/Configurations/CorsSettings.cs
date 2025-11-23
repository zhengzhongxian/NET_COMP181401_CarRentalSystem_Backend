using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class CorsPolicyConfig
{
    public string[]? Origins { get; set; } = default!;

    public string[]? Methods { get; set; } = default!;

    public string[]? Headers { get; set; } = default!;
    
    public bool AllowCredentials { get; set; } = false;
}

public class CorsSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.CorsSettings;
    
    public Dictionary<string, CorsPolicyConfig> Policies { get; set; } = new();
}