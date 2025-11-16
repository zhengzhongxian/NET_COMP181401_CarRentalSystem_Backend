namespace NET_CarRentalSystem.Application.Interfaces.Services;

public interface ISecurityService
{
    string HashPassword(string password);

    bool VerifyPassword(string password, string hashedPassword);

    string Encrypt(string plainText);

    string Decrypt(string cipherText);

    string EncryptAes(string plainText);
    
    string DecryptAes(string cipherText);
}

