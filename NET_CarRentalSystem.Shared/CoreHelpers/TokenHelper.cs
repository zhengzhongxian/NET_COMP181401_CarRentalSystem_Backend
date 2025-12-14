using System.Security.Cryptography;

namespace NET_CarRentalSystem.Shared.CoreHelpers;

public static class TokenHelper
{
    public static string GenerateSecureToken(int byteLength = 64)
    {
        var tokenBytes = RandomNumberGenerator.GetBytes(byteLength);
        var base64Token = Convert.ToBase64String(tokenBytes);
        return ToUrlSafeBase64(base64Token);
    }
    
    public static string ToUrlSafeBase64(string base64String)
    {
        return base64String
            .Replace('+', '-')
            .Replace('/', '_')
            .TrimEnd('=');
    }
    
    public static string FromUrlSafeBase64(string urlSafeBase64)
    {
        var base64 = urlSafeBase64
            .Replace('-', '+')
            .Replace('_', '/');
        switch (base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }
        
        return base64;
    }
}