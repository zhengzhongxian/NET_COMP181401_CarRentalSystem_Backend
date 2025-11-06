using NET_CarRentalSystem.Application.Interfaces.Services;
using BCryptNet = BCrypt.Net.BCrypt;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class SecurityService : ISecurityService
{
    public string HashPassword(string password)
    {
        return BCryptNet.HashPassword(password);
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        return BCryptNet.Verify(password, hashedPassword);
    }
}

