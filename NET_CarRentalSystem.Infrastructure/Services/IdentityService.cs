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

    public Task<bool> CheckPasswordSignInAsync(User user, string password)
    {
        var result = BC.Verify(password, user.Password);
        return Task.FromResult(result);
    }
}