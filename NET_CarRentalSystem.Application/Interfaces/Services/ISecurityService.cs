namespace NET_CarRentalSystem.Application.Interfaces.Services;

public interface ISecurityService
{
    string HashPassword(string password);
    
    bool VerifyPassword(string password, string hashedPassword);
}

