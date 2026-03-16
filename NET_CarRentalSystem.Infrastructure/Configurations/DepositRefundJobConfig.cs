using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class DepositRefundJobConfig
{
    public static string SectionName => KeyConstants.ConfigurationSections.DepositRefundJob;
    
    public string JobName { get; set; } = "DepositRefundCheck";
    
    public string CronExpression { get; set; } = "0 0 */6 * * ?"; // Every 6 hours
    
    public bool Enabled { get; set; } = true;
    
    public int AdminOverrideHours { get; set; } = 24;
    
    public int BatchSize { get; set; } = 20;
}
