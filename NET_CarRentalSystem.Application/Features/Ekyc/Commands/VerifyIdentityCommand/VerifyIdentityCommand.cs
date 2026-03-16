using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Ekyc;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Models.Ekyc;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Ekyc.Commands.VerifyIdentityCommand;

public class VerifyIdentityCommand : ICommand<(bool Success, string Message, EkycVerificationResult? Result)>
{
    public FileModel FrontImage { get; set; } = null!;

    public FileModel BackImage { get; set; } = null!;

    public FileModel SelfieImage { get; set; } = null!;
}

public class VerifyIdentityCommandHandler(
    IVnptEkycService ekycService,
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    ICryptographyService cryptographyService,
    ILogger<VerifyIdentityCommandHandler> logger) : IRequestHandler<VerifyIdentityCommand, (bool Success, string Message, EkycVerificationResult? Result)>
{
    public async Task<(bool Success, string Message, EkycVerificationResult? Result)> Handle(
        VerifyIdentityCommand request,
        CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        if (userId == null)
        {
            return (false, EkycMessage.Verify.UserNotFound, null);
        }

        var existingVerification = await unitOfWork.GetWriteRepository<UserVerification>()
            .GetFirstOrDefaultAsync(
                v => v.UserId == userId.Value && v.Status == VerificationStatus.Verified,
                cancellationToken: cancellationToken);

        if (existingVerification != null)
        {
            return (false, EkycMessage.Verify.AlreadyVerified, null);
        }

        var result = await ekycService.VerifyIdentityAsync(
            request.FrontImage.Content,
            request.FrontImage.FileName,
            request.BackImage.Content,
            request.BackImage.FileName,
            request.SelfieImage.Content,
            request.SelfieImage.FileName,
            cancellationToken);

        if (!result.IsSuccess)
        {
            logger.LogWarning("[eKYC] CCCD verification failed for user {UserId}: {Message}", userId, result.Message);
            return (false, result.Message, result);
        }

        var encryptedIdNumber = cryptographyService.EncryptAes(result.IdNumber);

        // Prevent DB unique-index crash and return a clear business message.
        var duplicateCccdCustomer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.CccdNumber == encryptedIdNumber && c.UserId != userId.Value,
                cancellationToken: cancellationToken);

        if (duplicateCccdCustomer != null)
        {
            return (false, EkycMessage.Verify.CccdAlreadyUsed, null);
        }

        var verification = new UserVerification
        {
            UserId = userId.Value,
            IdNumber = encryptedIdNumber,
            FullName = result.FullName,
            DateOfBirth = DateTimeHelper.ParseDate(result.DateOfBirth),
            Gender = result.Gender,
            Address = result.Address,
            Hometown = result.Hometown,
            IssueDate = result.IssueDate,
            IssuePlace = result.IssuePlace,
            ValidDate = result.ValidDate,
            FaceMatchScore = result.FaceMatchScore,
            IsCardLivenessPass = result.IsCardLivenessPass,
            IsFaceLivenessPass = result.IsFaceLivenessPass,
            IsFaceMatch = result.IsFaceMatch,
            Status = VerificationStatus.Verified,
            VerifiedAt = DateTime.UtcNow,
            FrontImageHash = result.FrontImageHash,
            BackImageHash = result.BackImageHash,
            SelfieHash = result.SelfieHash
        };

        await unitOfWork.GetWriteRepository<UserVerification>().AddAsync(verification, cancellationToken);

        var userClaim = new UserClaim
        {
            UserId = userId.Value,
            ClaimType = "Permission",
            ClaimValue = PermissionConstants.Ekyc.IdentityVerified
        };

        await unitOfWork.GetWriteRepository<UserClaim>().AddAsync(userClaim, cancellationToken);
        
        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.UserId == userId.Value,
                cancellationToken: cancellationToken);

        if (customer != null)
        {
            customer.IsIdentityVerified = true;
            
            customer.CccdNumber = encryptedIdNumber;
            
            var dob = DateTimeHelper.ParseDate(result.DateOfBirth);
            if (dob.HasValue)
            {
                customer.Dob = dob.Value;
            }
            
            customer.CccdIssueDate = DateTimeHelper.ParseDate(result.IssueDate);
            customer.CccdIssuePlace = result.IssuePlace;
            
            unitOfWork.GetWriteRepository<Customer>().Update(customer);
            
            if (customer.IsPhoneVerified && customer.IsDriverLicenseVerified)
            {
                var existingClaim = await unitOfWork.GetWriteRepository<UserClaim>()
                    .GetFirstOrDefaultAsync(
                        uc => uc.UserId == userId.Value && uc.ClaimValue == PermissionConstants.Ekyc.FullyVerified,
                        cancellationToken: cancellationToken);

                if (existingClaim == null)
                {
                    var fullyVerifiedClaim = new UserClaim
                    {
                        UserId = userId.Value,
                        ClaimType = "Permission",
                        ClaimValue = PermissionConstants.Ekyc.FullyVerified
                    };
                    await unitOfWork.GetWriteRepository<UserClaim>().AddAsync(fullyVerifiedClaim, cancellationToken);
                }
            }
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        logger.LogInformation("[eKYC] User {UserId} CCCD verified successfully", userId);

        return (true, EkycMessage.Verify.Success, result);
    }
}

