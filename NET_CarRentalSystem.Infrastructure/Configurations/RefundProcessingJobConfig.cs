using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class RefundProcessingJobConfig
{
    public static string SectionName => KeyConstants.ConfigurationSections.RefundProcessingJob;
    
    public string JobName { get; set; } = "Refund Processing";
    
    public string CronExpression { get; set; } = "0 0 * * * ?"; 
    
    public bool Enabled { get; set; } = true;
    
    public int MaxRetryAttempts { get; set; } = 3;
    
    public int RetryDelayMs { get; set; } = 2000;
    
    public int BatchSize { get; set; } = 10;
}

