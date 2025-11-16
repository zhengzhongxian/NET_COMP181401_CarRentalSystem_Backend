using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

public interface IIdentityService
{
    Task<User?> FindUserAsync(string usernameOrEmail);

    Task<User?> FindUserByIdAsync(string userId);

    Task<bool> UserExistsAsync(string userId);
}