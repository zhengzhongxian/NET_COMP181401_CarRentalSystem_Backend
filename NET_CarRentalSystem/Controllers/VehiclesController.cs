using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.VehicleModels;
using NET_CarRentalSystem.API.Models.Request.Vehicles;
using NET_CarRentalSystem.API.Models.Response.VehicleModels;
using NET_CarRentalSystem.API.Models.Response.Vehicles;
using NET_CarRentalSystem.Application.Features.VehicleModels.Queries.GetAvailableVehicleModelsForSwapQuery;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleAttributesCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleImagesCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.CreateVehicleCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleAttributeCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleImagesCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleAttributeCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleThumbnailCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleModelsCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleModelsCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleModelsCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.SendVehiclePromotionEmailCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleModelsStatusCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleDetailsQuery;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleAvailabilityQuery;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleModelsInventoryQuery;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetVehicles([FromQuery] GetVehiclesPagedRequest request, CancellationToken ct)
    {
        try
        {
            var queryParams = mapper.Map<GetVehiclesPagedQueryParams>(request);
            var query = new GetVehiclesPagedQuery
            {
                RequestParams = queryParams
            };

            var result = await sender.Send(query, ct);


            var pagedResponse = mapper.Map<PagedResponse<GetVehiclesPagedResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(
                pagedResponse,
                VehicleMessage.Get.Success
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("{vehicleId:guid}/details")]
    [AllowAnonymous]
    public async Task<IActionResult> GetVehicleDetails(
        Guid vehicleId,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetVehicleDetailsQuery { VehicleId = vehicleId };
            var result = await sender.Send(query, cancellationToken);

            if (result == null)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.Get.NotFound,
                    StatusCodes.Status404NotFound);
                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var response = mapper.Map<GetVehicleDetailResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, VehicleMessage.Get.DetailSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("{vehicleId:guid}/availability")]
    [AllowAnonymous]
    public async Task<IActionResult> GetVehicleAvailability(
        Guid vehicleId,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetVehicleAvailabilityQuery { VehicleId = vehicleId };
            var result = await sender.Send(query, cancellationToken);

            var response = mapper.Map<GetVehicleAvailabilityResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, "Lấy thông tin xe có sẵn thành công");

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                "Lỗi khi lấy thông tin xe có sẵn",
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("{vehicleId:guid}/inventory")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.View)]
    public async Task<IActionResult> GetVehicleModelsInventory(
        [FromRoute] Guid vehicleId,
        [FromQuery] GetVehicleModelsInventoryRequest request,
        CancellationToken ct)
    {
        try
        {
            var query = mapper.Map<GetVehicleModelsInventoryQuery>(request);
            query.VehicleId = vehicleId;

            var result = await sender.Send(query, ct);

            var response = mapper.Map<GetVehicleModelsInventoryResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, VehicleMessage.Get.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPost]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Create)]
    public async Task<IActionResult> Create([FromForm] CreateVehicleRequest request, CancellationToken ct = default)
    {
        try
        {
            FileModel? thumbnailFileModel = null;

            if (request.ThumbnailFile != null)
            {
                thumbnailFileModel = new FileModel
                {
                    Content = request.ThumbnailFile.OpenReadStream(),
                    FileName = request.ThumbnailFile.FileName,
                    ContentType = request.ThumbnailFile.ContentType
                };
            }

            var command = new CreateVehicleCommand
            {
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Title = request.Title,
                Color = request.Color,
                PricePerHour = request.PricePerHour,
                Thumbnail = thumbnailFileModel,
                Description = request.Description,
                VehicleCategoryId = request.VehicleCategoryId,
                FuelId = request.FuelId,
                TransmissionId = request.TransmissionId,
                Metadata = request.Metadata,
                RequiredLicenseClass = request.RequiredLicenseClass,
                EnableAiVerification = request.EnableAiVerification
            };

            var newVehicleId = await sender.Send(command, ct);

            var apiResponse = ApiResponse.SuccessResult(newVehicleId, VehicleMessage.Create.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.Create.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPut("{vehicleId}")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> Update(
        Guid vehicleId,
        [FromBody] UpdateVehicleRequest request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var command = new UpdateVehicleCommand
            {
                VehicleId = vehicleId,
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Title = request.Title,
                Color = request.Color,
                PricePerHour = request.PricePerHour,
                Thumbnail = request.Thumbnail,
                Description = request.Description,
                VehicleCategoryId = request.VehicleCategoryId,
                FuelId = request.FuelId,
                TransmissionId = request.TransmissionId,
                Metadata = request.Metadata,
                RequiredLicenseClass = request.RequiredLicenseClass
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.Update.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.Update.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.Update.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpDelete("{vehicleId}")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Delete)]
    public async Task<IActionResult> Delete(Guid vehicleId, CancellationToken cancellationToken = default)
    {
        try
        {
            var command = new DeleteVehicleCommand { VehicleId = vehicleId };
            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.Delete.NotFound,
                    StatusCodes.Status404NotFound);
                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.Delete.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.Delete.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPatch("{vehicleId}/thumbnail")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> UpdateThumbnail(
        Guid vehicleId,
        [FromForm] UpdateVehicleThumbnailRequest request,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var fileModel = new FileModel
            {
                Content = request.Thumbnail.OpenReadStream(),
                FileName = request.Thumbnail.FileName,
                ContentType = request.Thumbnail.ContentType
            };

            var command = new UpdateVehicleThumbnailCommand
            {
                VehicleId = vehicleId,
                Thumbnail = fileModel,
                EnableAiVerification = request.EnableAiVerification
            };

            var (success, message) = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(message ?? VehicleMessage.UpdateImage.NotFound);

                return StatusCode(StatusCodes.Status400BadRequest, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, message ?? VehicleMessage.UpdateImage.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.UpdateImage.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPost("{vehicleId}/images")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> AddImages(
        Guid vehicleId,
        [FromForm] AddVehicleImagesRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var fileModels = request.Images.Select(f => new FileModel
            {
                Content = f.OpenReadStream(),
                FileName = f.FileName,
                ContentType = f.ContentType
            }).ToList();

            var command = new AddVehicleImagesCommand
            {
                VehicleId = vehicleId,
                Images = fileModels,
                EnableAiVerification = request.EnableAiVerification
            };

            var (success, message) = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(message ?? VehicleMessage.AddImages.NotFound);

                return StatusCode(StatusCodes.Status400BadRequest, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, message ?? VehicleMessage.AddImages.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.AddImages.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
    
    [HttpPost("{vehicleId}/attributes")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> AddAttributes(
        Guid vehicleId,
        [FromBody] AddVehicleAttributesRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new AddVehicleAttributesCommand
            {
                VehicleId = vehicleId,
                Attributes = request.Attributes.Select(a => new VehicleAttributeParams
                {
                    Key = a.Key,
                    Value = a.Value
                }).ToList()
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.AddAttributes.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.AddAttributes.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.AddAttributes.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
    
    [HttpDelete("{vehicleId}/images")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> DeleteImages(
        Guid vehicleId,
        [FromBody] DeleteVehicleImagesRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new DeleteVehicleImagesCommand
            {
                VehicleId = vehicleId,
                PublicIds = request.PublicIds
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.DeleteImages.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.DeleteImages.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.DeleteImages.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPut("{vehicleId}/attributes/{attributeId}")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> UpdateAttribute(
        Guid vehicleId,
        Guid attributeId,
        [FromBody] UpdateVehicleAttributesRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateVehicleAttributeCommand
            {
                VehicleId = vehicleId,
                AttributeId = attributeId,
                Key = request.Key,
                Value = request.Value
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.UpdateAttribute.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.UpdateAttribute.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.UpdateAttribute.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpDelete("{vehicleId}/attributes/{attributeId}")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> DeleteAttribute(
        Guid vehicleId,
        Guid attributeId,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new DeleteVehicleAttributeCommand
            {
                VehicleId = vehicleId,
                AttributeId = attributeId
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.DeleteAttribute.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.DeleteAttribute.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.DeleteAttribute.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPost("{vehicleId}/vehicle-models")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> AddVehicleModels(
        Guid vehicleId,
        [FromBody] AddVehicleModelsRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new AddVehicleModelsCommand
            {
                VehicleId = vehicleId,
                VehicleModels = request.VehicleModels.Select(m => new VehicleModelParams
                {
                    NumberPlate = m.NumberPlate,
                    Mileage = m.Mileage,
                    ConditionNotes = m.ConditionNotes,
                    LocationId = m.LocationId
                }).ToList()
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.AddVehicleModels.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.AddVehicleModels.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.AddVehicleModels.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPut("{vehicleId}/vehicle-models/{vehicleModelId}")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> UpdateVehicleModels(
        Guid vehicleId,
        Guid vehicleModelId,
        [FromBody] UpdateVehicleModelsRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateVehicleModelsCommand
            {
                VehicleId = vehicleId,
                VehicleModelId = vehicleModelId,
                NumberPlate = request.NumberPlate,
                Mileage = request.Mileage,
                ConditionNotes = request.ConditionNotes,
                LocationId = request.LocationId
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.UpdateVehicleModels.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.UpdateVehicleModels.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.UpdateVehicleModels.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPatch("{vehicleId:guid}/vehicle-models/{vehicleModelId:guid}/status")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> UpdateVehicleModelStatus(
        [FromRoute] Guid vehicleId,
        [FromRoute] Guid vehicleModelId,
        [FromBody] UpdateVehicleModelsStatusRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateVehicleModelsStatusCommand
            {
                VehicleId = vehicleId,
                VehicleModelId = vehicleModelId,
                Status = request.Status
            };

            var (success, message) = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    message ?? VehicleMessage.UpdateVehicleModels.NotFound,
                    StatusCodes.Status400BadRequest);

                return StatusCode(StatusCodes.Status400BadRequest, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, message ?? VehicleMessage.UpdateVehicleModels.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.UpdateVehicleModels.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpDelete("{vehicleId}/vehicle-models/{vehicleModelId}")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.Edit)]
    public async Task<IActionResult> DeleteVehicleModels(
        Guid vehicleId,
        Guid vehicleModelId,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new DeleteVehicleModelsCommand
            {
                VehicleId = vehicleId,
                VehicleModelId = vehicleModelId
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.DeleteVehicleModels.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.DeleteVehicleModels.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.DeleteVehicleModels.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("vehicle-models/available-for-swap")]
    [AllowAnonymous]
    public async Task<IActionResult> GetAvailableVehicleModelsForSwap(
        [FromQuery] GetAvailableVehicleModelsForSwapRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var query = mapper.Map<GetAvailableVehicleModelsForSwapQuery>(request);
            var result = await sender.Send(query, cancellationToken);

            if (result.Count == 0)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.GetAvailableForSwap.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(notFoundResponse.StatusCode, notFoundResponse);
            }

            var response = mapper.Map<List<GetAvailableVehicleModelsForSwapResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, VehicleMessage.GetAvailableForSwap.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleMessage.GetAvailableForSwap.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("{vehicleId}/send-promotion-email")]
    [ValidateUserExists(Policy = PermissionConstants.Vehicles.SendEmail)]
    public async Task<IActionResult> SendPromotionEmail(
        Guid vehicleId,
        [FromBody] SendVehiclePromotionEmailRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = mapper.Map<SendVehiclePromotionEmailCommand>(request);
            command.VehicleId = vehicleId;

            var (success, message) = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);

                return StatusCode(StatusCodes.Status400BadRequest, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleEmailMessage.SendPromotion.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
