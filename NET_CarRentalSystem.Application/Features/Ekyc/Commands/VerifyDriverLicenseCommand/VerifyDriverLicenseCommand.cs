using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Ekyc;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Ekyc.Commands.VerifyDriverLicenseCommand;

public class VerifyDriverLicenseCommand : ICommand<(bool Success, string Message, DriverLicenseVerificationResult? Result)>
{
    public FileModel FrontImage { get; set; } = null!;

    public FileModel BackImage { get; set; } = null!;
}

public class VerifyDriverLicenseCommandHandler(
    IVnptEkycService ekycService,
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    ICryptographyService cryptographyService,
    ILogger<VerifyDriverLicenseCommandHandler> logger) 
    : IRequestHandler<VerifyDriverLicenseCommand, (bool Success, string Message, DriverLicenseVerificationResult? Result)>
{
    public async Task<(bool Success, string Message, DriverLicenseVerificationResult? Result)> Handle(
        VerifyDriverLicenseCommand request,
        CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        if (userId == null)
        {
            return (false, EkycMessage.Verify.UserNotFound, null);
        }
        
        var userVerification = await unitOfWork.GetWriteRepository<UserVerification>()
            .GetFirstOrDefaultAsync(
                v => v.UserId == userId.Value && v.Status == VerificationStatus.Verified,
                cancellationToken: cancellationToken);

        if (userVerification == null)
        {
            return (false, EkycMessage.DriverLicense.IdentityNotVerified, null);
        }
        
        if (userVerification.IsDriverLicenseVerified)
        {
            return (false, EkycMessage.DriverLicense.AlreadyVerified, null);
        }

        var result = new DriverLicenseVerificationResult();
        var clientSession = $"WEB_CarRental_DL_{Guid.NewGuid():N}";
        
        var uploadFront = await ekycService.UploadFileAsync(
            request.FrontImage.Content,
            request.FrontImage.FileName,
            "GPLX Front",
            "GPLX mat truoc",
            cancellationToken);

        if (!uploadFront.IsSuccess || uploadFront.Object == null)
        {
            logger.LogWarning("[eKYC-GPLX] Failed to upload front image for user {UserId}", userId);
            return (false, EkycMessage.DriverLicense.UploadFailed, null);
        }
        result.FrontImageHash = uploadFront.Object.Hash;
        
        var uploadBack = await ekycService.UploadFileAsync(
            request.BackImage.Content,
            request.BackImage.FileName,
            "GPLX Back",
            "GPLX mat sau",
            cancellationToken);

        if (!uploadBack.IsSuccess || uploadBack.Object == null)
        {
            logger.LogWarning("[eKYC-GPLX] Failed to upload back image for user {UserId}", userId);
            return (false, EkycMessage.DriverLicense.UploadFailed, null);
        }
        result.BackImageHash = uploadBack.Object.Hash;
        
        var ocrResult = await ekycService.ExtractDriverLicenseInfoAsync(
            result.FrontImageHash,
            result.BackImageHash,
            clientSession,
            cancellationToken);

        if (!ocrResult.IsSuccess || ocrResult.Object == null)
        {
            logger.LogWarning("[eKYC-GPLX] OCR extraction failed for user {UserId}", userId);
            return (false, EkycMessage.DriverLicense.OcrFailed, null);
        }

        result.DriverLicenseNumber = ocrResult.Object.Id;
        result.DriverLicenseExpiry = ocrResult.Object.ValidDate;
        result.DriverLicenseClass = ParseLicenseClass(ocrResult.Object.CardType);
        
        if (string.IsNullOrEmpty(userVerification.SelfieHash))
        {
            logger.LogWarning("[eKYC-GPLX] No selfie hash found for user {UserId}", userId);
            return (false, EkycMessage.DriverLicense.NoSelfieFound, null);
        }

        var faceCompare = await ekycService.CompareFaceAsync(
            result.FrontImageHash,
            userVerification.SelfieHash,
            clientSession,
            cancellationToken);

        if (faceCompare is not { IsSuccess: true, Object: not null } || faceCompare.Object.Prob < 70)
        {
            var score = faceCompare.Object?.Prob ?? 0;
            logger.LogWarning("[eKYC-GPLX] Face comparison failed for user {UserId}. Score: {Score}%", userId, score);
            return (false, EkycMessage.DriverLicense.FaceComparisonFailed, null);
        }

        result.FaceMatchScore = faceCompare.Object.Prob;
        result.IsSuccess = true;
        result.Message = EkycMessage.DriverLicense.Success;

        // Step 5: Update UserVerification with GPLX info
        userVerification.DriverLicenseNumber = cryptographyService.EncryptAes(result.DriverLicenseNumber);
        userVerification.DriverLicenseClass = result.DriverLicenseClass;
        userVerification.DriverLicenseExpiry = result.DriverLicenseExpiry;
        userVerification.DriverLicenseFrontHash = result.FrontImageHash;
        userVerification.DriverLicenseBackHash = result.BackImageHash;
        userVerification.IsDriverLicenseVerified = true;

        unitOfWork.GetWriteRepository<UserVerification>().Update(userVerification);
        
        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.UserId == userId.Value,
                cancellationToken: cancellationToken);

        if (customer != null)
        {
            customer.IsDriverLicenseVerified = true;
            customer.DriverLicenseId = cryptographyService.EncryptAes(result.DriverLicenseNumber);
            
            if (result.DriverLicenseClass.HasValue)
            {
                customer.DriverLicenseClass = result.DriverLicenseClass;
            }
            
            if (!string.IsNullOrEmpty(result.DriverLicenseExpiry))
            {
                customer.DriverLicenseExpiry = DateTimeHelper.ParseDate(result.DriverLicenseExpiry);
            }

            unitOfWork.GetWriteRepository<Customer>().Update(customer);
            
            var existingDlClaim = await unitOfWork.GetReadRepository<UserClaim>()
                .GetFirstOrDefaultAsync(
                    uc => uc.UserId == userId.Value && uc.ClaimValue == PermissionConstants.Ekyc.DriverLicenseVerified,
                    cancellationToken: cancellationToken);

            if (existingDlClaim == null)
            {
                var driverLicenseClaim = new UserClaim
                {
                    UserId = userId.Value,
                    ClaimType = "Permission",
                    ClaimValue = PermissionConstants.Ekyc.DriverLicenseVerified
                };
                await unitOfWork.GetWriteRepository<UserClaim>().AddAsync(driverLicenseClaim, cancellationToken);
            }
            
            if (customer.IsIdentityVerified && customer.IsPhoneVerified)
            {
                var existingClaim = await unitOfWork.GetReadRepository<UserClaim>()
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

        logger.LogInformation("[eKYC-GPLX] User {UserId} driver license verified successfully. Face match: {Score}%", 
            userId, result.FaceMatchScore);

        return (true, EkycMessage.DriverLicense.Success, result);
    }

    private static int? ParseLicenseClass(string? cardType)
    {
        if (string.IsNullOrEmpty(cardType)) return null;

        var classStr = cardType.ToUpperInvariant().Trim();
        
        if (classStr.Contains('-'))
        {
            classStr = classStr.Split('-').Last().Trim();
        }

        return classStr switch
        {
            "A1" => (int)LicenseClass.A1,
            "A2" => (int)LicenseClass.A2,
            "B1" => (int)LicenseClass.B1,
            "B2" => (int)LicenseClass.B2,
            "C" => (int)LicenseClass.C,
            "D" => (int)LicenseClass.D,
            "E" => (int)LicenseClass.E,
            "F" => (int)LicenseClass.F,
            _ => null
        };
    }
}

