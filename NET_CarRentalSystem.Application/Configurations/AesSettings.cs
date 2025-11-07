using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class AesSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.AesSettings;
    public string Key { get; set; } = string.Empty;
    public string IV { get; set; } = string.Empty;
}

