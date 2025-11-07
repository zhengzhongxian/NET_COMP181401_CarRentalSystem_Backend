namespace NET_CarRentalSystem.Application.Interfaces.Services;

public interface ICacheService
{
    Task SetStringAsync(string key, string value, DateTime absoluteExpiry, CancellationToken ct);

    Task<string?> GetStringAsync(string key, CancellationToken ct);
    
    Task RemoveAsync(string key, CancellationToken ct);

}