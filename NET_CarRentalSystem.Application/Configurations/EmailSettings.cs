using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class EmailSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.EmailSettings;

    public required SmtpSettings Smtp { get; set; }
    
    public required string FromEmailAddress { get; set; }
    
    public required string FromDisplayName { get; set; }
}

public class SmtpSettings
{
    public required string Host { get; set; }
    
    public int Port { get; set; }
    
    public required string EmailAddress { get; set; }
    
    public required string Password { get; set; }
    
    public bool EnableSsl { get; set; }
    
    public bool UseCredential { get; set; }
}

