using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class ReturnDeadlineReminderJobConfig
{
    public static string SectionName => KeyConstants.ConfigurationSections.ReturnDeadlineReminderJob;
    
    public string JobName { get; set; } = "ReturnDeadlineReminder";
    
    public string CronExpression { get; set; } = "0 */5 * * * ?";
    
    public bool Enabled { get; set; } = true;
    
    public int ReminderMinutesBefore { get; set; } = 15;
    
    public int ToleranceMinutes { get; set; } = 5;
}
