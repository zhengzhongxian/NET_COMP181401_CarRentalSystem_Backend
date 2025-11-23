using System.Security.Cryptography;

namespace NET_CarRentalSystem.Shared.CoreHelpers;

public static class TokenHelper
{
    public static string GenerateSecureToken(int byteLength = 32)
    {
        var tokenBytes = RandomNumberGenerator.GetBytes(byteLength);
        var base64Token = Convert.ToBase64String(tokenBytes);
        var urlSafeToken = base64Token
            .Replace('+', '-')
            .Replace('/', '_');
        
        return urlSafeToken.TrimEnd('=');
    }
}