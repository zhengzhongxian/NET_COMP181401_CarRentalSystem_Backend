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

    public static string GetPhoneOtpKey(Guid userId)
    {
        return $"phone_otp:{userId}";
    }

    public static string GetPhoneOtpCountKey(Guid userId)
    {
        return $"phone_otp_count:{userId}:{DateTime.UtcNow:yyyyMMdd}";
    }
}
