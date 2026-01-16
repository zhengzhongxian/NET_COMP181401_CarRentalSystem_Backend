using Microsoft.Extensions.Caching.Distributed;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using StackExchange.Redis;

namespace NET_CarRentalSystem.Infrastructure.Services.Caching;

public class CacheService(IDistributedCache cache, IConnectionMultiplexer redis) : ICacheService
{
    private readonly IDatabase _redisDb = redis.GetDatabase();
    
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
    
    public async Task<bool> AcquireLockAsync(string lockKey, string lockValue, TimeSpan expiry, CancellationToken ct)
    {
        return await _redisDb.StringSetAsync(lockKey, lockValue, expiry, When.NotExists);
    }
    
    public async Task<bool> ReleaseLockAsync(string lockKey, string lockValue, CancellationToken ct)
    {
        // Lua script để đảm bảo chỉ release lock nếu lockValue khớp (atomic operation)
        const string luaScript = """
            if redis.call('get', KEYS[1]) == ARGV[1] then
                return redis.call('del', KEYS[1])
            else
                return 0
            end
            """;
        
        var result = await _redisDb.ScriptEvaluateAsync(luaScript, [lockKey], [lockValue]);
        return (int)result == 1;
    }
}