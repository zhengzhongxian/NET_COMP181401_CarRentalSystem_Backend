using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class RsaSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.RsaSettings;
    
    public string PublicKey { get; set; } = string.Empty;
    
    public string PrivateKey { get; set; } = string.Empty;
}