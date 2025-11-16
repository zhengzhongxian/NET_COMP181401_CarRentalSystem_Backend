using System.Security.Cryptography;

namespace NET_CarRentalSystem.Shared.CoreHelpers;

public static class OtpHelper
{
    public static string GenerateOtp()
    {
        return RandomNumberGenerator.GetInt32(100000, 999999).ToString();
    }
}