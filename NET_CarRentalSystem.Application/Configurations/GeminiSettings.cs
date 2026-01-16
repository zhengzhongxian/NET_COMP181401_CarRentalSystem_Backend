using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class GeminiSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.GeminiSettings;
    
    public string ApiKey { get; set; } = string.Empty;
    
    public string ModelName { get; set; } = "gemini-2.0-flash-exp";
}