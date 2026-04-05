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
        
        var adminProfile = await customerRepo.GetFirstOrDefaultAsync(
            c => c.UserId == adminId.Value, 
            cancellationToken);

        if (adminProfile == null)
        {
            adminProfile = new Customer
            {
                UserId = adminId.Value,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = cryptographyService.EncryptAes(request.PhoneNumber),
                Dob = DateTime.UtcNow.AddYears(-18)
            };
            await customerRepo.AddAsync(adminProfile, cancellationToken);
        }
        else
        {
            var encryptedPhone = cryptographyService.EncryptAes(request.PhoneNumber);
            var isPhoneTaken = await customerRepo.GetFirstOrDefaultAsync(
                c => c.PhoneNumber == encryptedPhone && c.Id != adminProfile.Id,
                cancellationToken);

            if (isPhoneTaken != null)
            {
                return (false, UserMessage.UpdatePhoneError);
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
