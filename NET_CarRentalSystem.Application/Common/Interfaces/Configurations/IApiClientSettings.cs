namespace NET_CarRentalSystem.Application.Common.Interfaces.Configurations;

public interface IApiClientSettings
{
    string BaseUrl { get; set; }
    
    int DefaultTimeout { get; set; }
}