using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class OverdueBookingJobConfig
{
    public static string SectionName => KeyConstants.ConfigurationSections.OverdueBookingJob;
    
    public string JobName { get; set; } = "OverdueBookingCheck";
    
    public string CronExpression { get; set; } = "0 0 */4 * * ?";
    
    public bool Enabled { get; set; } = true;
    
    public int MinOverdueMinutes { get; set; } = 60;
    
    public int CriticalHours { get; set; } = 24;
}

