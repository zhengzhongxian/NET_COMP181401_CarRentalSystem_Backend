using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class GmailApiSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.GmailApiSettings;
    
    public required string ClientId { get; set; }
    
    public required string ClientSecret { get; set; }
    
    public required string RefreshToken { get; set; }
    
    public required string SenderEmail { get; set; }
    
    public required string SenderName { get; set; }
}