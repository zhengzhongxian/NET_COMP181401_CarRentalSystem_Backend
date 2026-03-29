using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Users.Queries.GetUserProfileQuery;

public record GetUserProfileQuery : IQuery<GetUserDto>;

public class GetUserProfileQueryHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    ILogger<GetUserProfileQueryHandler> logger) : IRequestHandler<GetUserProfileQuery, GetUserDto>
{
    public async Task<GetUserDto> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId()!.Value;
        
        var user = await unitOfWork.GetReadRepository<User>().GetByIdAsync(userId, cancellationToken);
        var customer = await unitOfWork.GetReadRepository<Customer>().GetFirstOrDefaultAsync(c => c.UserId == userId, cancellationToken: cancellationToken);

        var userDto = new GetUserDto
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = customer?.FirstName,
            LastName = customer?.LastName,
            PhoneNumber = customer?.PhoneNumber,
            Address = customer?.Address,
            Dob = customer?.Dob,
            CccdNumber = customer?.CccdNumber,
            CccdIssueDate = customer?.CccdIssueDate,
            CccdIssuePlace = customer?.CccdIssuePlace,
            CccdFrontUrl = customer?.CccdFrontUrl,
            CccdBackUrl = customer?.CccdBackUrl,
            DriverLicenseId = customer?.DriverLicenseId,
            DriverLicenseExpiry = customer?.DriverLicenseExpiry,
            DriverLicenseClass = customer?.DriverLicenseClass,
            DriverLicenseFrontUrl = customer?.DriverLicenseFrontUrl,
            DriverLicenseBackUrl = customer?.DriverLicenseBackUrl,
            IsPhoneVerified = customer?.IsPhoneVerified ?? false,
            IsIdentityVerified = customer?.IsIdentityVerified ?? false,
            IsDriverLicenseVerified = customer?.IsDriverLicenseVerified ?? false,
            AvatarUrl = customer?.AvatarUrl,
            LoyaltyPoints = customer?.LoyaltyPoints ?? 0
        };

        return userDto;
    }
}
