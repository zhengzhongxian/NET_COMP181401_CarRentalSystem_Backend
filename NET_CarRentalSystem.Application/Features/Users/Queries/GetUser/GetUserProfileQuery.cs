using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Users.Queries.GetUser;

public record GetUserProfileQuery : IQuery<UserDto>;

public class GetUserProfileQueryHandler(
    IUnitOfWork unitOfWork,
    ISecurityService securityService,
    ICurrentUserService currentUserService) : IRequestHandler<GetUserProfileQuery, UserDto>
{
    public async Task<UserDto> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId()!.Value;
        
        var user = await unitOfWork.GetRepository<User>().GetFirstAsync(u => u.UserId == userId, cancellationToken: cancellationToken);
        var customer = await unitOfWork.GetRepository<Customer>().GetFirstOrDefaultAsync(c => c.UserId == userId, cancellationToken: cancellationToken);

        var userDto = new UserDto
        {
            Id = user.UserId,
            Email = user.Email,
        };

        if (customer == null) return userDto;
        
        userDto.FirstName = customer.FirstName;
        userDto.LastName = customer.LastName;
        userDto.PhoneNumber = customer.PhoneNumber;
        userDto.Address = customer.Address;
        userDto.Dob = customer.Dob;
        userDto.CccdNumber = !string.IsNullOrEmpty(customer.CccdNumber) ? securityService.DecryptAes(customer.CccdNumber) : null;
        userDto.CccdIssueDate = customer.CccdIssueDate;
        userDto.CccdIssuePlace = customer.CccdIssuePlace;
        userDto.CccdFrontUrl = customer.CccdFrontUrl;
        userDto.CccdBackUrl = customer.CccdBackUrl;
        userDto.DriverLicenseId = customer.DriverLicenseId;
        userDto.DriverLicenseExpiry = customer.DriverLicenseExpiry;
        userDto.DriverLicenseFrontUrl = customer.DriverLicenseFrontUrl;
        userDto.DriverLicenseBackUrl = customer.DriverLicenseBackUrl;
        userDto.AvatarUrl = customer.AvatarUrl;

        return userDto;
    }
}

