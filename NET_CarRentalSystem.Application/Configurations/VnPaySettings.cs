using NET_CarRentalSystem.Shared.Constants;


namespace NET_CarRentalSystem.Application.Configurations;

public class VnPaySettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.VnPaySettings;
    
    public string ClientId { get; set; } = string.Empty;
    
    public string ApiKey { get; set; } = string.Empty;
    
    public string BankCode { get; set; } = string.Empty;
    
    public string AccountNumber { get; set; } = string.Empty;
    
    public string AccountName { get; set; } = string.Empty;
    
    public string ApiUrl { get; set; } = string.Empty;
    
    public string Template { get; set; } = string.Empty;
}