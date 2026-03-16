using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class CheckToolAliveSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.CheckToolAlive;
    
    public string JobName { get; set; } = "CheckToolAlive";
    
    public string CronExpression { get; set; } = "0 * * * * ?";
}
