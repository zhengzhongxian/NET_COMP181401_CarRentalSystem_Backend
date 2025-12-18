using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Models.Request.Locations;
using NET_CarRentalSystem.API.Models.Response.Locations;
using NET_CarRentalSystem.Application.Features.Locations.Commands.CreateLocationCommand;
using NET_CarRentalSystem.Application.Features.Locations.Commands.DeleteLocationCommand;
using NET_CarRentalSystem.Application.Features.Locations.Commands.UpdateLocationCommand;
using NET_CarRentalSystem.Application.Features.Locations.Commands.UpdateLocationThumbnailCommand;
using NET_CarRentalSystem.Application.Features.Locations.Queries.GetLocationByIdQuery;
using NET_CarRentalSystem.Application.Features.Locations.Queries.GetLocationsPagedQuery;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LocationsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllPaged([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetLocationsPagedQuery
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            var pagedLocations = await sender.Send(query, cancellationToken);

            var response = new GetLocationsPagedResponse
            {
                Items = mapper.Map<List<GetLocationResponse>>(pagedLocations.Items),
                CurrentPage = pagedLocations.CurrentPage,
                TotalPages = pagedLocations.TotalPages,
                PageSize = pagedLocations.PageSize,
                TotalCount = pagedLocations.TotalCount,
                HasPrevious = pagedLocations.HasPrevious,
                HasNext = pagedLocations.HasNext
            };

            var apiResponse = ApiResponse.SuccessResult(
                response,
                LocationMessage.Get.Success
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                LocationMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetLocationByIdQuery { LocationId = id };
            var location = await sender.Send(query, cancellationToken);

            if (location == null)
            {
                var errorResponse = ApiResponse.ErrorResult(LocationMessage.Get.NotFound);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = mapper.Map<GetLocationResponse>(location);
            var apiResponse = ApiResponse.SuccessResult(
                response,
                LocationMessage.Get.Success
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                LocationMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost]
    [ValidateUserExists(Policy = PermissionConstants.Locations.Create)]
    public async Task<IActionResult> Create([FromForm] CreateLocationRequest request, CancellationToken cancellationToken)
    {
        try
        {
            using var stream = request.ThumbnailFile.OpenReadStream();
            var fileModel = new FileModel
            {
                Content = stream,
                FileName = request.ThumbnailFile.FileName,
                ContentType = request.ThumbnailFile.ContentType
            };

            var command = new CreateLocationCommand
            {
                Name = request.Name,
                Address = request.Address,
                City = request.City,
                PhoneNumber = request.PhoneNumber,
                OpeningHours = request.OpeningHours,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                Description = request.Description,
                ThumbnailFile = fileModel
            };

            var newId = await sender.Send(command, cancellationToken);

            var apiResponse = ApiResponse.SuccessResult(newId, LocationMessage.Create.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                LocationMessage.Create.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPut("{id:guid}")]
    [ValidateUserExists(Policy = PermissionConstants.Locations.Edit)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateLocationRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateLocationCommand
            {
                LocationId = id,
                Name = request.Name,
                Address = request.Address,
                City = request.City,
                PhoneNumber = request.PhoneNumber,
                OpeningHours = request.OpeningHours,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                Description = request.Description
            };

            var (message, updateLocationDto) = await sender.Send(command, cancellationToken);

            if (updateLocationDto == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = mapper.Map<UpdateLocationResponse>(updateLocationDto);
            var apiResponse = ApiResponse.SuccessResult(
                response,
                message
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                LocationMessage.Update.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPut("{id:guid}/thumbnail")]
    [ValidateUserExists(Policy = PermissionConstants.Locations.Edit)]
    public async Task<IActionResult> UpdateThumbnail(Guid id, [FromForm] UpdateLocationThumbnailRequest request, CancellationToken cancellationToken)
    {
        try
        {
            using var stream = request.ThumbnailFile.OpenReadStream();
            var fileModel = new FileModel
            {
                Content = stream,
                FileName = request.ThumbnailFile.FileName,
                ContentType = request.ThumbnailFile.ContentType
            };

            var command = new UpdateLocationThumbnailCommand
            {
                LocationId = id,
                ThumbnailFile = fileModel
            };

            var (message, thumbnailUrl) = await sender.Send(command, cancellationToken);

            if (thumbnailUrl == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(thumbnailUrl, message);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                LocationMessage.Update.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpDelete("{id:guid}")]
    [ValidateUserExists(Policy = PermissionConstants.Locations.Delete)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var command = new DeleteLocationCommand { LocationId = id };
            var (message, result) = await sender.Send(command, cancellationToken);

            if (!result)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                LocationMessage.Delete.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}