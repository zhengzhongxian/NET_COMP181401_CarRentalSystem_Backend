using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtp;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogupCommand;

public class LogupCommand : ICommand<(string, bool)>
{
    public required LogupDto LogupDto { get; set; }
}

public class LogupCommandHandler(
    ICacheService cacheService,
    IUnitOfWork unitOfWork,
    ISecurityService securityService) : IRequestHandler<LogupCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(LogupCommand request, CancellationToken cancellationToken)
    {
        var key = $"otp_{request.LogupDto.Email}";
        var cachedOtpDetailsJson = await cacheService.GetStringAsync(key, cancellationToken);

        if (cachedOtpDetailsJson == null)
        {
            return (AuthMessage.Otp.Invalid, false);
        }

        var cachedOtpDetails = cachedOtpDetailsJson.FromJson<OtpDetailsDto>()!;

        if (cachedOtpDetails.Otp != request.LogupDto.Otp)
        {
            return (AuthMessage.Otp.Invalid, false);
        }

        if (cachedOtpDetails.ExpiryTime < DateTime.UtcNow)
        {
            return (AuthMessage.Otp.Expired, false);
        }

        if (cachedOtpDetails.UserName != request.LogupDto.UserName)
        {
            return (AuthMessage.Otp.Invalid, false);
        }

        var userRepository = unitOfWork.GetRepository<User>();
        var existingUser = await userRepository.GetFirstOrDefaultAsync(u => u.UserName == request.LogupDto.UserName || u.Email == request.LogupDto.Email, cancellationToken: cancellationToken);
        if (existingUser != null)
        {
            return (AuthMessage.Logup.UserExists, false);
        }

        var roleRepository = unitOfWork.GetRepository<Role>();
        var customerRole = await roleRepository.GetFirstAsync(r => r.Name == RoleConstants.Customer, cancellationToken: cancellationToken);

        var userId = Guid.NewGuid();

        var customer = new Customer
        {
            CustomerId = userId,
            FirstName = request.LogupDto.FirstName,
            LastName = request.LogupDto.LastName,
            Dob = request.LogupDto.Dob,
            PhoneNumber = request.LogupDto.PhoneNumber,
            Address = request.LogupDto.Address
        };

        var user = new User
        {
            UserId = userId,
            UserName = request.LogupDto.UserName,
            Email = request.LogupDto.Email,
            Password = securityService.HashPassword(request.LogupDto.Password),
            IsVerified = true,
            Status = UserStatus.Active,
            Customer = customer
        };

        var userRole = new UserRole
        {
            UserId = user.UserId,
            RoleId = customerRole.RoleId
        };

        await userRepository.AddAsync(user, cancellationToken);
        await unitOfWork.GetRepository<Customer>().AddAsync(customer, cancellationToken);
        await unitOfWork.GetRepository<UserRole>().AddAsync(userRole, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        await cacheService.RemoveAsync(key, cancellationToken);

        return (AuthMessage.Logup.Success, true);
    }
}
