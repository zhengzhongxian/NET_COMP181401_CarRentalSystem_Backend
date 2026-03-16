using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserStatusCommand;

public class UpdateUserStatusCommand : ICommand<(bool Success, string Message)>
{
    public Guid UserId { get; set; }
    
    public UserStatus? Status { get; set; }
    
    public bool? IsIdentityVerified { get; set; }
    
    public bool? IsPhoneVerified { get; set; }
    
    public bool? IsDriverLicenseVerified { get; set; }
}

public class UpdateUserStatusCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<UpdateUserStatusCommand, (bool Success, string Message)>
{
    private const string PermissionClaimType = "Permission";

    public async Task<(bool Success, string Message)> Handle(UpdateUserStatusCommand request, CancellationToken cancellationToken)
    {
        var userRepo = unitOfWork.GetWriteRepository<User>();
        var customerRepo = unitOfWork.GetWriteRepository<Customer>();
        var userClaimRepo = unitOfWork.GetWriteRepository<UserClaim>();

        var user = await userRepo.GetByIdAsync(request.UserId, cancellationToken);
        if (user == null)
        {
            return (false, UserMessage.NotFound);
        }
        
        if (request.Status.HasValue)
        {
            user.Status = request.Status.Value;
            userRepo.Update(user);
        }
        
        if (request.IsIdentityVerified.HasValue || request.IsPhoneVerified.HasValue || request.IsDriverLicenseVerified.HasValue)
        {
            var customer = await customerRepo.GetFirstOrDefaultAsync(
                c => c.UserId == request.UserId,
                cancellationToken);

            if (customer != null)
            {
                if (request.IsIdentityVerified.HasValue)
                {
                    customer.IsIdentityVerified = request.IsIdentityVerified.Value;

                    if (request.IsIdentityVerified.Value)
                    {
                        await AddUserClaimIfNotExistsAsync(
                            userClaimRepo,
                            request.UserId,
                            PermissionConstants.Ekyc.IdentityVerified,
                            cancellationToken);
                    }
                    else
                    {
                        await RemoveUserClaimAsync(
                            userClaimRepo,
                            request.UserId,
                            PermissionConstants.Ekyc.IdentityVerified,
                            cancellationToken);
                    }
                }
                
                if (request.IsPhoneVerified.HasValue)
                {
                    customer.IsPhoneVerified = request.IsPhoneVerified.Value;

                    if (request.IsPhoneVerified.Value)
                    {
                        await AddUserClaimIfNotExistsAsync(
                            userClaimRepo,
                            request.UserId,
                            PermissionConstants.Ekyc.PhoneVerified,
                            cancellationToken);
                    }
                    else
                    {
                        await RemoveUserClaimAsync(
                            userClaimRepo,
                            request.UserId,
                            PermissionConstants.Ekyc.PhoneVerified,
                            cancellationToken);
                    }
                }
                
                if (request.IsDriverLicenseVerified.HasValue)
                {
                    customer.IsDriverLicenseVerified = request.IsDriverLicenseVerified.Value;

                    if (request.IsDriverLicenseVerified.Value)
                    {
                        await AddUserClaimIfNotExistsAsync(
                            userClaimRepo,
                            request.UserId,
                            PermissionConstants.Ekyc.DriverLicenseVerified,
                            cancellationToken);
                    }
                    else
                    {
                        await RemoveUserClaimAsync(
                            userClaimRepo,
                            request.UserId,
                            PermissionConstants.Ekyc.DriverLicenseVerified,
                            cancellationToken);
                    }
                }
                
                // Check if fully verified (all 3 factors)
                if (customer.IsIdentityVerified && customer.IsPhoneVerified && customer.IsDriverLicenseVerified)
                {
                    await AddUserClaimIfNotExistsAsync(
                        userClaimRepo,
                        request.UserId,
                        PermissionConstants.Ekyc.FullyVerified,
                        cancellationToken);
                }
                else
                {
                    await RemoveUserClaimAsync(
                        userClaimRepo,
                        request.UserId,
                        PermissionConstants.Ekyc.FullyVerified,
                        cancellationToken);
                }

                customerRepo.Update(customer);
            }
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.UpdateStatusSuccess);
    }

    private static async Task AddUserClaimIfNotExistsAsync(
        IWriteRepository<UserClaim> userClaimRepo,
        Guid userId,
        string claimValue,
        CancellationToken cancellationToken)
    {
        var existingClaim = await userClaimRepo.GetFirstOrDefaultAsync(
            uc => uc.UserId == userId && uc.ClaimValue == claimValue,
            cancellationToken);

        if (existingClaim == null)
        {
            var newClaim = new UserClaim
            {
                UserId = userId,
                ClaimType = PermissionClaimType,
                ClaimValue = claimValue
            };

            await userClaimRepo.AddAsync(newClaim, cancellationToken);
        }
    }

    private static async Task RemoveUserClaimAsync(
        IWriteRepository<UserClaim> userClaimRepo,
        Guid userId,
        string claimValue,
        CancellationToken cancellationToken)
    {
        var existingClaim = await userClaimRepo.GetFirstOrDefaultAsync(
            uc => uc.UserId == userId && uc.ClaimValue == claimValue,
            cancellationToken);

        if (existingClaim != null)
        {
            userClaimRepo.Remove(existingClaim, hardDelete: true);
        }
    }
}