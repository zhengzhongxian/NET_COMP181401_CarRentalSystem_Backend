using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogupCommand;

public class LogupCommand : ICommand<(string, bool)>
{
    public required LogupCommandParams LogupCommandParams { get; set; }
}

public class LogupCommandHandler(
    ICacheService cacheService,
    IUnitOfWork unitOfWork,
    ISecurityService securityService) : IRequestHandler<LogupCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(LogupCommand request, CancellationToken cancellationToken)
    {
        var logupDto = request.LogupCommandParams;

        var key = CacheKeyHelper.GetOtpKey(logupDto.Email);
        var cachedOtpDetailsJson = await cacheService.GetStringAsync(key, cancellationToken);

        if (cachedOtpDetailsJson == null)
        {
            return (AuthMessage.Otp.Invalid, false);
        }

        var cachedOtpDetails = cachedOtpDetailsJson.FromJson<OtpDetailsDto>()!;

        if (cachedOtpDetails.Otp != logupDto.Otp)
        {
            return (AuthMessage.Otp.Invalid, false);
        }

        if (cachedOtpDetails.ExpiryTime < DateTime.UtcNow)
        {
            return (AuthMessage.Otp.Expired, false);
        }

        if (cachedOtpDetails.UserName != logupDto.UserName)
        {
            return (AuthMessage.Otp.Invalid, false);
        }

        var userRepository = unitOfWork.GetRepository<User>();
        var existingUser = await userRepository.GetFirstOrDefaultAsync(
            u => u.UserName == logupDto.UserName || u.Email == logupDto.Email, 
            cancellationToken: cancellationToken);
        
        if (existingUser != null)
        {
            return (AuthMessage.Logup.UserExists, false);
        }
        
        var encryptedPhone = securityService.EncryptAes(logupDto.PhoneNumber);
        
        var customerRepository = unitOfWork.GetRepository<Customer>();
        var existingCustomerByPhone = await customerRepository.GetFirstOrDefaultAsync(
            c => c.PhoneNumber == encryptedPhone, 
            cancellationToken: cancellationToken);
        
        if (existingCustomerByPhone != null)
        {
            return (AuthMessage.Logup.PhoneNumberExists, false);
        }

        var roleRepository = unitOfWork.GetRepository<Role>();
        var customerRole = await roleRepository.GetFirstAsync(
            r => r.Name == RoleConstants.Customer, 
            cancellationToken: cancellationToken);

        var userId = Guid.NewGuid();

        var customer = new Customer
        {
            UserId = userId,
            FirstName = logupDto.FirstName,
            LastName = logupDto.LastName,
            Dob = logupDto.Dob,
            PhoneNumber = securityService.EncryptAes(logupDto.PhoneNumber),
            Address = logupDto.Address
        };

        var user = new User
        {
            Id = userId,
            UserName = logupDto.UserName,
            Email = logupDto.Email,
            Password = securityService.HashPassword(logupDto.Password),
            IsVerified = true,
            Status = UserStatus.Active,
            Customer = customer
        };

        var userRole = new UserRole
        {
            UserId = user.Id,
            RoleId = customerRole.Id
        };

        var userLogin = new UserLogin
        {
            LoginProvider = AppConstants.LoginProvider.Local,
            ProviderKey = userId.ToString(),
            ProviderDisplayName = AppConstants.LoginProvider.Local,
            UserId = user.Id
        };

        await userRepository.AddAsync(user, cancellationToken);
        await customerRepository.AddAsync(customer, cancellationToken);
        await unitOfWork.GetRepository<UserRole>().AddAsync(userRole, cancellationToken);
        await unitOfWork.GetRepository<UserLogin>().AddAsync(userLogin, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        await cacheService.RemoveAsync(key, cancellationToken);

        return (AuthMessage.Logup.Success, true);
    }
}