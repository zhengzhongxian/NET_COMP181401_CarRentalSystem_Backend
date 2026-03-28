namespace NET_CarRentalSystem.Application.Interfaces.Services.Caching;

public interface ICacheService
{
    Task SetStringAsync(string key, string value, DateTime absoluteExpiry, CancellationToken ct);

    Task<string?> GetStringAsync(string key, CancellationToken ct);
    
    Task RemoveAsync(string key, CancellationToken ct);
    
    /// <summary>
    /// Acquire distributed lock với timeout
    /// </summary>
    /// <param name="lockKey">Key của lock</param>
    /// <param name="lockValue">Value unique để identify lock owner</param>
    /// <param name="expiry">Thời gian lock tự động hết hạn</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>True nếu acquire thành công, False nếu lock đã bị giữ bởi process khác</returns>
    Task<bool> AcquireLockAsync(string lockKey, string lockValue, TimeSpan expiry, CancellationToken ct);
    
    /// <summary>
    /// Release distributed lock (chỉ release nếu lockValue khớp)
    /// </summary>
    /// <param name="lockKey">Key của lock</param>
    /// <param name="lockValue">Value để verify ownership</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>True nếu release thành công</returns>
    Task<bool> ReleaseLockAsync(string lockKey, string lockValue, CancellationToken ct);
    
    /// <summary>
    /// Publish message to a Redis Pub/Sub channel
    /// </summary>
    /// <param name="channel">Channel name</param>
    /// <param name="message">JSON message payload</param>
    /// <param name="ct">Cancellation token</param>
    Task PublishAsync(string channel, string message, CancellationToken ct);
}