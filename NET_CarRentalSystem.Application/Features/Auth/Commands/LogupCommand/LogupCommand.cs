using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
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
    ICryptographyService cryptographyService) : IRequestHandler<LogupCommand, (string, bool)>
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

        var userWriteRepository = unitOfWork.GetWriteRepository<User>();
        var existingUser = await userWriteRepository.GetFirstOrDefaultAsync(
            u => u.UserName == logupDto.UserName || u.Email == logupDto.Email, 
            cancellationToken: cancellationToken);
        
        if (existingUser != null)
        {
            return (AuthMessage.Logup.UserExists, false);
        }
        
        var encryptedPhone = cryptographyService.EncryptAes(logupDto.PhoneNumber);
        
        var customerWriteRepository = unitOfWork.GetWriteRepository<Customer>();
        var existingCustomerByPhone = await customerWriteRepository.GetFirstOrDefaultAsync(
            c => c.PhoneNumber == encryptedPhone, 
            cancellationToken: cancellationToken);
        
        if (existingCustomerByPhone != null)
        {
            return (AuthMessage.Logup.PhoneNumberExists, false);
        }

        var roleWriteRepository = unitOfWork.GetWriteRepository<Role>();
        var customerRole = await roleWriteRepository.GetFirstAsync(
            r => r.Name == RoleConstants.Customer, 
            cancellationToken: cancellationToken);

        var userId = Guid.NewGuid();

        var customer = new Customer
        {
            UserId = userId,
            FirstName = logupDto.FirstName,
            LastName = logupDto.LastName,
            Dob = logupDto.Dob,
            PhoneNumber = cryptographyService.EncryptAes(logupDto.PhoneNumber),
            Address = logupDto.Address
        };

        var user = new User
        {
            Id = userId,
            UserName = logupDto.UserName,
            Email = logupDto.Email,
            Password = cryptographyService.HashPassword(logupDto.Password),
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
            LoginProvider = LoginProvider.Local,
            ProviderKey = userId.ToString(),
            ProviderDisplayName = LoginProvider.Local.ToString(),
            UserId = user.Id
        };
        
        await unitOfWork.GetWriteRepository<User>().AddAsync(user, cancellationToken);
        await unitOfWork.GetWriteRepository<Customer>().AddAsync(customer, cancellationToken);
        await unitOfWork.GetWriteRepository<UserRole>().AddAsync(userRole, cancellationToken);
        await unitOfWork.GetWriteRepository<UserLogin>().AddAsync(userLogin, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        await cacheService.RemoveAsync(key, cancellationToken);

        return (AuthMessage.Logup.Success, true);
    }
}