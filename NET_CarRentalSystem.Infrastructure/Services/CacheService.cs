using Microsoft.Extensions.Caching.Distributed;
using NET_CarRentalSystem.Application.Interfaces.Services;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class CacheService(IDistributedCache cache) : ICacheService
{
    public Task SetStringAsync(string key, string value, DateTime absoluteExpiry, CancellationToken ct)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpiration = absoluteExpiry
        };
        return cache.SetStringAsync(key, value, options, ct);
    }

    public Task<string?> GetStringAsync(string key, CancellationToken ct)
    {
        return cache.GetStringAsync(key, ct);
    }

    public Task RemoveAsync(string key, CancellationToken ct)
    {
        return cache.RemoveAsync(key, ct);
    }
}