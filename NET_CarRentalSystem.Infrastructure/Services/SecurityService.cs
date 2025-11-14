using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services;
using System.Security.Cryptography;
using System.Text;
using BCryptNet = BCrypt.Net.BCrypt;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class SecurityService(IOptions<RsaSettings> rsaSettings, IOptions<AesSettings> aesSettings) : ISecurityService
{
    private readonly RsaSettings _rsaSettings = rsaSettings.Value;
    private readonly AesSettings _aesSettings = aesSettings.Value;
    
    public string HashPassword(string password)
    {
        return BCryptNet.HashPassword(password);
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        return BCryptNet.Verify(password, hashedPassword);
    }

    public string Encrypt(string plainText)
    {
        using var rsa = RSA.Create();
        rsa.ImportFromPem(_rsaSettings.PublicKey);
        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        var encryptedBytes = rsa.Encrypt(plainTextBytes, RSAEncryptionPadding.OaepSHA256);
        return Convert.ToBase64String(encryptedBytes);
    }

    public string Decrypt(string cipherText)
    {
        using var rsa = RSA.Create();
        rsa.ImportFromPem(_rsaSettings.PrivateKey);
        var cipherTextBytes = Convert.FromBase64String(cipherText);
        var decryptedBytes = rsa.Decrypt(cipherTextBytes, RSAEncryptionPadding.OaepSHA256);
        return Encoding.UTF8.GetString(decryptedBytes);
    }

    public string EncryptAes(string plainText)
    {
        using var aes = Aes.Create();
        aes.Key = Convert.FromBase64String(_aesSettings.Key);
        aes.IV = Convert.FromBase64String(_aesSettings.IV);

        var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

        using var msEncrypt = new MemoryStream();
        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(plainText);
            }
        }
        return Convert.ToBase64String(msEncrypt.ToArray());
    }

    public string DecryptAes(string cipherText)
    {
        using var aes = Aes.Create();
        aes.Key = Convert.FromBase64String(_aesSettings.Key);
        aes.IV = Convert.FromBase64String(_aesSettings.IV);

        var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

        using var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText));
        using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using var srDecrypt = new StreamReader(csDecrypt);
        return srDecrypt.ReadToEnd();
    }
}

