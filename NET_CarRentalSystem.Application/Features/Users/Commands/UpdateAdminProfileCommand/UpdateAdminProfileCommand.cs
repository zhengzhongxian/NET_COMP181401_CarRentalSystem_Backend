using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.UpdateAdminProfileCommand;

public class UpdateAdminProfileCommand : ICommand<(bool Success, string Message)>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}

public class UpdateAdminProfileCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    ICryptographyService cryptographyService) 
    : IRequestHandler<UpdateAdminProfileCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(UpdateAdminProfileCommand request, CancellationToken cancellationToken)
    {
        var adminId = currentUserService.GetUserId();
        if (adminId == null)
        {
            return (false, UserMessage.NotFound);
        }

        var customerRepo = unitOfWork.GetWriteRepository<Customer>();
        
        // Admin profile data is stored in the Customer table
        var adminProfile = await customerRepo.GetFirstOrDefaultAsync(
            c => c.UserId == adminId.Value, 
            cancellationToken);

        if (adminProfile == null)
        {
            // If the admin doesn't have a profile yet, we create one. 
            // In some systems, admins might not have a Customer record initially.
            adminProfile = new Customer
            {
                UserId = adminId.Value,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = cryptographyService.EncryptAes(request.PhoneNumber),
                Dob = DateTime.UtcNow.AddYears(-18) // Default value, admins don't strictly need this but it's required in schema
            };
            await customerRepo.AddAsync(adminProfile, cancellationToken);
        }
        else
        {
            // Check if the new phone number is already used by another user
            var encryptedPhone = cryptographyService.EncryptAes(request.PhoneNumber);
            var isPhoneTaken = await customerRepo.GetFirstOrDefaultAsync(
                c => c.PhoneNumber == encryptedPhone && c.Id != adminProfile.Id,
                cancellationToken);

            if (isPhoneTaken != null)
            {
                return (false, UserMessage.UpdatePhoneError); // Phone already in use
            }

            adminProfile.FirstName = request.FirstName;
            adminProfile.LastName = request.LastName;
            adminProfile.PhoneNumber = encryptedPhone;
            
            customerRepo.Update(adminProfile);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Profile.UpdateSuccess);
    }
}
