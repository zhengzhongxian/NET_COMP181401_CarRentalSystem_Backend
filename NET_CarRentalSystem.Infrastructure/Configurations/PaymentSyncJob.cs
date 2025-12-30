using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class PaymentSyncJob
{
    public static string SectionName => KeyConstants.ConfigurationSections.PaymentSyncJob;
    
    public string? JobName { get; set; }
    
    public string? CronExpression { get; set; }
    
    public bool Enabled { get; set; }
    
    public int MaxRetry { get; set; }
    
    public int TimeoutInSeconds { get; set; }
}