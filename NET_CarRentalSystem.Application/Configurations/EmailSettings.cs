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
    public required string Host { get; set; } = default!;

    public int Port { get; set; } = default!;

    public required string EmailAddress { get; set; } = default!;

    public required string Password { get; set; } = default!;

    public bool EnableSsl { get; set; } = default!;
    
    public bool UseCredential { get; set; }
}

