using NET_CarRentalSystem.Application.Common.Interfaces.Configurations;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations.ApiClientSettings;

public class MyApiSettings : IApiClientSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.MyApiSettings;
    
    public string BaseUrl { get; set; } = default!;
    
    public int DefaultTimeout { get; set; }
}