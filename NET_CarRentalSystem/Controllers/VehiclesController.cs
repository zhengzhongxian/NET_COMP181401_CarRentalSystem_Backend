using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Vehicles;
using NET_CarRentalSystem.API.Models.Response.Vehicles;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleAttributesCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleImagesCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.CreateVehicleCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleAttributeCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleImagesCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleAttributeCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleThumbnailCommand;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleDetailsQuery;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
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

    [HttpGet("{vehicleId}")]
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
                NumberPlate = request.NumberPlate,
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Color = request.Color,
                Mileage = request.Mileage,
                PricePerHour = request.PricePerHour,
                Thumbnail = thumbnailFileModel,
                Description = request.Description,
                Rating = request.Rating,
                ConditionNotes = request.ConditionNotes,
                RealTimeLocation = request.RealTimeLocation,
                LocationId = request.LocationId,
                VehicleCategoryId = request.VehicleCategoryId,
                FuelId = request.FuelId,
                TransmissionId = request.TransmissionId,
                Metadata = request.Metadata
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
                NumberPlate = request.NumberPlate,
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Color = request.Color,
                Mileage = request.Mileage,
                PricePerHour = request.PricePerHour,
                Thumbnail = request.Thumbnail,
                Description = request.Description,
                Rating = request.Rating,
                Status = request.Status,
                ConditionNotes = request.ConditionNotes,
                RealTimeLocation = request.RealTimeLocation,
                LocationId = request.LocationId,
                VehicleCategoryId = request.VehicleCategoryId,
                FuelId = request.FuelId,
                TransmissionId = request.TransmissionId,
                Metadata = request.Metadata
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
                Thumbnail = fileModel
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.UpdateImage.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.UpdateImage.Success);
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
                Images = fileModels
            };

            var success = await sender.Send(command, cancellationToken);

            if (!success)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    VehicleMessage.AddImages.NotFound,
                    StatusCodes.Status404NotFound);

                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(success, VehicleMessage.AddImages.Success);

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
}
