namespace NET_CarRentalSystem.Shared.CoreHelpers;

public static class CacheKeyHelper
{
    public static string GetOtpKey(string email)
    {
        return $"otp_{email}";
    }
    
    public static string GetResetPasswordKey(string token)
    {
        return $"reset_password_{token}";
    }
    
    public static string GetCancellationCacheKey(Guid customerId)
    {
        var yearMonth = DateTime.UtcNow.ToString("yyyyMM");
        return $"booking:cancellation:count:{customerId}:{yearMonth}";
    }
    
    /// <summary>
    /// Lock key cho việc xử lý payment operations của một customer
    /// Đảm bảo chỉ 1 operation tại 1 thời điểm:
    /// - CreateBooking
    /// - Webhook/SyncJob process payment
    /// Note: Transaction updates được bảo vệ bởi RowVersion
    /// </summary>
    public static string GetCustomerPaymentLockKey(Guid customerId)
    {
        return $"lock:customer:payment:{customerId}";
    }
    
    public static string GetQrReturnVehicleKey(string token)
    {
        return $"qr:return:{token}";
    }
    
    /// <summary>
    /// Redis key prefix for vehicle search documents
    /// </summary>
    public const string VehicleSearchKeyPrefix = "vehicle:";
    
    /// <summary>
    /// Redis index name for vehicle search
    /// </summary>
    public const string VehicleSearchIndexName = "idx:vehicles";
    
    /// <summary>
    /// Redis index name for vehicle vector search (HNSW)
    /// </summary>
    public const string VehicleVectorIndexName = "idx:vehicles-vector";
    
    /// <summary>
    /// Redis key prefix for vehicle vector documents
    /// </summary>
    public const string VehicleVectorKeyPrefix = "vehicle:vector:";
    
    /// <summary>
    /// Get Redis key for a vehicle document
    /// </summary>
    public static string GetVehicleSearchKey(Guid vehicleId)
    {
        return $"{VehicleSearchKeyPrefix}{vehicleId}";
    }
    
    /// <summary>
    /// Get Redis key for a vehicle vector document
    /// </summary>
    public static string GetVehicleVectorKey(Guid vehicleId)
    {
        return $"{VehicleVectorKeyPrefix}{vehicleId}";
    }
}