namespace NET_CarRentalSystem.Domain.Exceptions.Common;

public abstract class ExternalServiceException(string serviceName, string message, int statusCode = 502)
    : Exception(message)
{
    public string ServiceName { get; } = serviceName;
    
    public int StatusCode { get; } = statusCode; 
}