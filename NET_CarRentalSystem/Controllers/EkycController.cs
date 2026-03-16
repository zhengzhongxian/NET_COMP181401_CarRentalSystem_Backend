using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Ekyc;
using NET_CarRentalSystem.Application.Features.Ekyc.Commands.VerifyDriverLicenseCommand;
using NET_CarRentalSystem.Application.Features.Ekyc.Commands.VerifyIdentityCommand;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EkycController(ISender sender) : ControllerBase
{
    [HttpPost("verify")]
    [ValidateUserExists]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> VerifyIdentity(
        [FromForm] VerifyIdentityRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new VerifyIdentityCommand
            {
                FrontImage = new FileModel
                {
                    FileName = request.FrontImage.FileName,
                    Content = request.FrontImage.OpenReadStream(),
                    ContentType = request.FrontImage.ContentType
                },
                BackImage = new FileModel
                {
                    FileName = request.BackImage.FileName,
                    Content = request.BackImage.OpenReadStream(),
                    ContentType = request.BackImage.ContentType
                },
                SelfieImage = new FileModel
                {
                    FileName = request.SelfieImage.FileName,
                    Content = request.SelfieImage.OpenReadStream(),
                    ContentType = request.SelfieImage.ContentType
                }
            };

            var (success, message, result) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(result!, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                EkycMessage.Verify.SystemError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("verify-driver-license")]
    [ValidateUserExists]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> VerifyDriverLicense(
        [FromForm] VerifyDriverLicenseRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new VerifyDriverLicenseCommand
            {
                FrontImage = new FileModel
                {
                    FileName = request.FrontImage.FileName,
                    Content = request.FrontImage.OpenReadStream(),
                    ContentType = request.FrontImage.ContentType
                },
                BackImage = new FileModel
                {
                    FileName = request.BackImage.FileName,
                    Content = request.BackImage.OpenReadStream(),
                    ContentType = request.BackImage.ContentType
                }
            };

            var (success, message, result) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(result!, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                EkycMessage.DriverLicense.SystemError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}
