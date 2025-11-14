using System.Security.Cryptography;

namespace NET_CarRentalSystem.Shared.CoreHelpers;

public static class TokenHelper
{
    public static string GenerateSecureToken(int byteLength = 32)
    {
        var tokenBytes = RandomNumberGenerator.GetBytes(byteLength);
        
        return Convert.ToBase64String(tokenBytes);
    }
}