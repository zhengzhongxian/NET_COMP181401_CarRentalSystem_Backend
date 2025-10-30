using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Interfaces.Services;

public interface IIdentityService
{
    Task<User?> FindUserAsync(string usernameOrEmail);
    
    Task<bool> CheckPasswordSignInAsync(User user, string password);
}