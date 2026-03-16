using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class FileValidationSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.FileValidationSettings;
    
    public int MaxFileSizeMb { get; set; } = 10;
    
    /// <summary>
    /// Get max file size in bytes
    /// </summary>
    public long MaxFileSizeBytes => MaxFileSizeMb * 1024L * 1024L;
}
