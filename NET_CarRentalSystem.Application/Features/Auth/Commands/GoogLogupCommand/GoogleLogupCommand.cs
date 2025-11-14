using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.GoogLogupCommand;

public class GoogleLogupCommand : ICommand<(string ,bool)>
{
    public required GoogleLogupCommandParams GoogleLogupCommandParams { get; set; }
}

public class GoogleLogupCommandHandler(
    IUnitOfWork unitOfWork,
    ISecurityService  securityService,
    IGoogleService googleService) : IRequestHandler<GoogleLogupCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(GoogleLogupCommand request, CancellationToken cancellationToken)
    {
        var logupParams = request.GoogleLogupCommandParams;
        
        var payload = await googleService.ValidateTokenAsync(logupParams.IdToken);
        if (!payload.EmailVerified) 
        {
            return (AuthMessage.GoogleLogup.UnverifiedEmail, false);
        }
        
        var userRepository = unitOfWork.GetRepository<User>();
        
        var existingUser = await userRepository.GetFirstOrDefaultAsync(
            u => u.Email == payload.Email && u.IsVerified, 
            cancellationToken: cancellationToken);
        if (existingUser != null) 
        {
            return (AuthMessage.GoogleLogup.UserExists, false);
        }
        var encryptedPhone = securityService.EncryptAes(logupParams.PhoneNumber);
        
        var customerRepository = unitOfWork.GetRepository<Customer>();
        var existingCustomerByPhone = await customerRepository.GetFirstOrDefaultAsync(
            c => c.PhoneNumber == encryptedPhone, 
            cancellationToken: cancellationToken
        );
        
        if (existingCustomerByPhone != null)
        {
            return (AuthMessage.GoogleLogup.PhoneNumberExists, false);
        }
        
        var roleRepository = unitOfWork.GetRepository<Role>();
        var customerRole = await roleRepository.GetFirstAsync(
            r => r.Name == RoleConstants.Customer, 
            cancellationToken: cancellationToken);
        
        var userId = Guid.NewGuid();
        
        var customer = new Customer
        {
            UserId = userId,
            FirstName = logupParams.GivenName,
            LastName = logupParams.FamilyName,
            Dob = logupParams.Dob,
            PhoneNumber = securityService.EncryptAes(logupParams.PhoneNumber),
            Address = logupParams.Address,
            AvatarUrl = payload.Picture
        };

        var user = new User
        {
            Id = userId, 
            UserName = payload.Email,
            Email = payload.Email,
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
            LoginProvider = AppConstants.LoginProvider.Google,
            ProviderKey = userId.ToString(),
            ProviderDisplayName = AppConstants.LoginProvider.Google,
            UserId = user.Id
        };
        
        await userRepository.AddAsync(user, cancellationToken);
        await customerRepository.AddAsync(customer, cancellationToken);
        await unitOfWork.GetRepository<UserRole>().AddAsync(userRole, cancellationToken);
        await unitOfWork.GetRepository<UserLogin>().AddAsync(userLogin, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return (AuthMessage.GoogleLogup.Success, true);
    }
}