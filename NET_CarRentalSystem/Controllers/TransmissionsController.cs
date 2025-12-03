using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Transmissions;
using NET_CarRentalSystem.API.Models.Response.Transmissions;
using NET_CarRentalSystem.Application.Features.Transmissions.Commands.CreateTransmissionCommand;
using NET_CarRentalSystem.Application.Features.Transmissions.Commands.DeleteTransmissionCommand;
using NET_CarRentalSystem.Application.Features.Transmissions.Commands.UpdateTransmissionCommand;
using NET_CarRentalSystem.Application.Features.Transmissions.Queries.GetAllTransmissionsQuery;
using NET_CarRentalSystem.Application.Features.Transmissions.Queries.GetTransmissionByIdQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransmissionsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    [ValidateUserExists(Policy = PermissionConstants.Transmissions.View)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetAllTransmissionsQuery();
            var result = await sender.Send(query, cancellationToken);
            var mappedResult = mapper.Map<IEnumerable<GetTransmissionResponse>>(result);

            var apiResponse = ApiResponse.SuccessResult(
                mappedResult,
                TransmissionMessage.Get.Success
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                TransmissionMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpGet("{id:guid}")]
    [ValidateUserExists(Policy = PermissionConstants.Transmissions.View)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetTransmissionByIdQuery { Id = id };
            var result = await sender.Send(query, cancellationToken);

            if (result == null)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    TransmissionMessage.Get.NotFound,
                    StatusCodes.Status404NotFound
                );
                return StatusCode(notFoundResponse.StatusCode, notFoundResponse);
            }

            var mappedResult = mapper.Map<GetTransmissionResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(mappedResult, TransmissionMessage.Get.Success);
            
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                TransmissionMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost]
    [ValidateUserExists(Policy = PermissionConstants.Transmissions.Create)]
    public async Task<IActionResult> Create([FromBody] CreateTransmissionRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new CreateTransmissionCommand
            {
                Name = request.Name,
                Code = request.Code,
                Description = request.Description
            };
            var newId = await sender.Send(command, cancellationToken);

            var response = new CreateTransmissionResponse { TransmissionId = newId };
            var apiResponse = ApiResponse.SuccessResult(response, TransmissionMessage.Create.Success, StatusCodes.Status201Created);
            
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                TransmissionMessage.Create.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPut("{id:guid}")]
    [ValidateUserExists(Policy = PermissionConstants.Transmissions.Edit)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTransmissionRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateTransmissionCommand
            {
                Id = id,
                Name = request.Name,
                Code = request.Code,
                Description = request.Description
            };

            var updatedDto = await sender.Send(command, cancellationToken);

            if (updatedDto == null)
            {
                var errorResponse = ApiResponse.ErrorResult(TransmissionMessage.Update.NotFound, StatusCodes.Status404NotFound);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = mapper.Map<UpdateTransmissionResponse>(updatedDto);
            var apiResponse = ApiResponse.SuccessResult(response, TransmissionMessage.Update.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(TransmissionMessage.Update.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpDelete("{id:guid}")]
    [ValidateUserExists(Policy = PermissionConstants.Transmissions.Delete)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var result = await sender.Send(new DeleteTransmissionCommand { Id = id }, cancellationToken);

            if (!result)
            {
                var errorResponse = ApiResponse.ErrorResult(TransmissionMessage.Delete.NotFound, StatusCodes.Status404NotFound);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(result, TransmissionMessage.Delete.Success);
            
            return StatusCode(apiResponse.StatusCode,  apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                TransmissionMessage.Delete.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}