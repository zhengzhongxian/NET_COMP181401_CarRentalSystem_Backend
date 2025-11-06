using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using BC = BCrypt.Net.BCrypt;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class IdentityService(IUnitOfWork unitOfWork) : IIdentityService
{
    public async Task<User?> FindUserAsync(string usernameOrEmail)
    {
        var user = await unitOfWork.GetRepository<User>().GetFirstOrDefaultAsync(
            u => u.Email == usernameOrEmail || u.UserName == usernameOrEmail
        );

        return user;
    }

    public async Task<User?> FindUserByIdAsync(string userId)
    {
        if (Guid.TryParse(userId, out var userGuid))
        {
            return await unitOfWork.GetRepository<User>().GetByIdAsync(userGuid);
        }
        return null;
    }

    public async Task<bool> UserExistsAsync(string userId)
    {
        if (Guid.TryParse(userId, out var userGuid))
        {
            return await unitOfWork.GetRepository<User>().ExistsAsync(u => u.UserId == userGuid);
        }

        return false;
    }
}