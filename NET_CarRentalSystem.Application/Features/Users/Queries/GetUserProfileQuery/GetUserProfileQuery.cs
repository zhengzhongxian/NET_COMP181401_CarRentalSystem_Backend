using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Users.Queries.GetUserProfileQuery;

public record GetUserProfileQuery : IQuery<GetUserDto>;

public class GetUserProfileQueryHandler(
    IUnitOfWork unitOfWork,
    ICryptographyService cryptographyService,
    ICurrentUserService currentUserService) : IRequestHandler<GetUserProfileQuery, GetUserDto>
{
    public async Task<GetUserDto> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId()!.Value;
        
        var user = await unitOfWork.GetReadRepository<User>().GetFirstAsync(u => u.Id == userId, cancellationToken: cancellationToken);
        var customer = await unitOfWork.GetReadRepository<Customer>().GetFirstOrDefaultAsync(c => c.UserId == userId, cancellationToken: cancellationToken);

        var userDto = new GetUserDto
        {
            Id = user.Id,
            Email = user.Email,
        };

        if (customer == null) return userDto;

        userDto.PhoneNumber = cryptographyService.SafeDecryptAes(customer.PhoneNumber);
        userDto.IsPhoneVerified = customer.IsPhoneVerified;
        userDto.IsDriverLicenseVerified = customer.IsDriverLicenseVerified;
        userDto.AvatarUrl = customer.AvatarUrl;
        
        userDto.DriverLicenseId = cryptographyService.SafeDecryptAes(customer.DriverLicenseId);
        userDto.DriverLicenseExpiry = customer.DriverLicenseExpiry;
        userDto.DriverLicenseClass = customer.DriverLicenseClass;
        userDto.DriverLicenseFrontUrl = customer.DriverLicenseFrontUrl;
        userDto.DriverLicenseBackUrl = customer.DriverLicenseBackUrl;
        
        // Get all data from customers table
        userDto.FirstName = customer.FirstName;
        userDto.LastName = customer.LastName;
        userDto.Address = customer.Address;
        userDto.Dob = customer.Dob;
        userDto.CccdNumber = cryptographyService.SafeDecryptAes(customer.CccdNumber);
        userDto.CccdIssueDate = customer.CccdIssueDate;
        userDto.CccdIssuePlace = customer.CccdIssuePlace;
        userDto.IsIdentityVerified = customer.IsIdentityVerified;
        userDto.LoyaltyPoints = customer.LoyaltyPoints;

        userDto.CccdFrontUrl = null;
        userDto.CccdBackUrl = null;

        return userDto;
    }
}