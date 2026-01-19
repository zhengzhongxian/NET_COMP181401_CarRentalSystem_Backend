using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Common.Extensions;

public static class SystemSettingExtensions
{
    public static int GetInt(this IEnumerable<SystemSetting> settings, string key, int defaultValue = 0)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting != null && int.TryParse(setting.SettingValue, out var val) ? val : defaultValue;
    }
    
    public static decimal GetDecimal(this IEnumerable<SystemSetting> settings, string key, decimal defaultValue = 0m)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting != null && decimal.TryParse(setting.SettingValue, out var val) ? val : defaultValue;
    }
    
    public static string GetString(this IEnumerable<SystemSetting> settings, string key, string defaultValue = "")
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting?.SettingValue ?? defaultValue;
    }
    
    public static bool GetBool(this IEnumerable<SystemSetting> settings, string key, bool defaultValue = false)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting != null && bool.TryParse(setting.SettingValue, out var val) ? val : defaultValue;
    }
    
    public static double GetDouble(this IEnumerable<SystemSetting> settings, string key, double defaultValue = 0.0)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting != null && double.TryParse(setting.SettingValue, out var val) ? val : defaultValue;
    }
}

