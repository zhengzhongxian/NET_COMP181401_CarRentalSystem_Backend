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
}