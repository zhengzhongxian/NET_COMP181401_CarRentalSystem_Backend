using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class ImpersonationSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.ImpersonationSettings;
    
    public bool Enabled { get; set; }
    
    public int MinDurationMinutes { get; set; } = 5;
    
    public int MaxDurationMinutes { get; set; } = 120;
    
    public string TokenSecretKey { get; set; } = string.Empty;
}
