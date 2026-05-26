namespace NET_CarRentalSystem.Application.Interfaces.Services.Security;

public interface ICryptographyService
{
    string HashPassword(string password);

    bool VerifyPassword(string password, string hashedPassword);

    string Encrypt(string plainText);

    string Decrypt(string cipherText);

    string EncryptAes(string plainText);
    
    string DecryptAes(string cipherText);
    
    string? SafeDecryptAes(string? encryptedValue);
    
    string ComputeHmac(string data, string key);
}

