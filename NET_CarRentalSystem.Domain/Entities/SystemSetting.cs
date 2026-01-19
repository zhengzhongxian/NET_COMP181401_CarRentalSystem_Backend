using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class SystemSetting : BaseEntity<Guid>
{
    public string SettingKey { get; set; } = default!;

    public string? SettingValue { get; set; }
    
    public string? Description { get; set; }
}