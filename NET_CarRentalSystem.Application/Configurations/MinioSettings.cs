using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class MinioSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.MinioSettings;
    
    public required string Endpoint { get; set; }
    
    public string? PublicUrl { get; set; }

    public required string AccessKey { get; set; }
    
    public required string SecretKey { get; set; }
    
    public required string DefaultBucket { get; set; }
    
    public bool UseSsL { get; set; }
    
    public string? Region { get; set; }
    
    public int PresignedUrlExpiryMinutes { get; set; } = 60;
}
