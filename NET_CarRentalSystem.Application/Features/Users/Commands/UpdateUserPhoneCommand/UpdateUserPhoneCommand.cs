using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserPhoneCommand;

public class UpdateUserPhoneCommand : ICommand<(bool Success, string Message)>
{
    public string PhoneNumber { get; set; } = string.Empty;
}

public class UpdateUserPhoneCommandHandler(
    IUnitOfWork unitOfWork,
    ICryptographyService cryptographyService,
    ICurrentUserService currentUserService)
    : IRequestHandler<UpdateUserPhoneCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(UpdateUserPhoneCommand request, CancellationToken cancellationToken)
    {
        var customerRepo = unitOfWork.GetWriteRepository<Customer>();
        var userClaimRepo = unitOfWork.GetWriteRepository<UserClaim>();

        var userId = currentUserService.GetUserId();
        if (!userId.HasValue)
        {
            return (false, UserMessage.NotFound);
        }

        var customer = await customerRepo.GetFirstOrDefaultAsync(
            c => c.UserId == userId.Value,
            cancellationToken);

        if (customer == null)
        {
            return (false, UserMessage.NotFound);
        }

        var encryptedPhone = cryptographyService.EncryptAes(request.PhoneNumber);

        var existingCustomer = await customerRepo.GetFirstOrDefaultAsync(
            c => c.PhoneNumber == encryptedPhone && c.CustomerId != customer.CustomerId,
            cancellationToken);

        if (existingCustomer != null)
        {
            return (false, UserMessage.Phone.AlreadyExists);
        }

        customer.PhoneNumber = encryptedPhone;
        customer.IsPhoneVerified = false;

        var phoneVerifiedClaim = await userClaimRepo.GetFirstOrDefaultAsync(
            uc => uc.UserId == userId.Value && uc.ClaimValue == PermissionConstants.Ekyc.PhoneVerified,
            cancellationToken);

        if (phoneVerifiedClaim != null)
        {
            userClaimRepo.Remove(phoneVerifiedClaim, hardDelete: true);
        }

        var fullyVerifiedClaim = await userClaimRepo.GetFirstOrDefaultAsync(
            uc => uc.UserId == userId.Value && uc.ClaimValue == PermissionConstants.Ekyc.FullyVerified,
            cancellationToken);

        if (fullyVerifiedClaim != null)
        {
            userClaimRepo.Remove(fullyVerifiedClaim, hardDelete: true);
        }

        customerRepo.Update(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Phone.UpdateSuccess);
    }
}

