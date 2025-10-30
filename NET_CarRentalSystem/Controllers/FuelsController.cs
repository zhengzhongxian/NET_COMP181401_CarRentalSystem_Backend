using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Request.Fuels;
using NET_CarRentalSystem.API.Models.Response.Fuels;
using NET_CarRentalSystem.Application.DTOs.FuelDTOs.Get;
using NET_CarRentalSystem.Application.Features.Fuels.Commands.CreateFuel;
using NET_CarRentalSystem.Application.Features.Fuels.Commands.DeleteFuel;
using NET_CarRentalSystem.Application.Features.Fuels.Commands.UpdateFuel;
using NET_CarRentalSystem.Application.Features.Fuels.Queries.GetAllFuelsQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Wrapper;
namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuelsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetAllFuelsQuery();

            var result = await sender.Send(query, cancellationToken);

            var apiResponse = ApiResponse<IEnumerable<GetFuelDto>>.SuccessResult(
                result,
                FuelMessage.Get.Success
            );

            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<IEnumerable<GetFuelDto>>.ErrorResult(
                FuelMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message] 
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateFuelRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new CreateFuelCommand(request.Name, request.Description);
            var newId = await sender.Send(command, cancellationToken);

            var apiResponse = ApiResponse<Guid>.SuccessResult(newId, FuelMessage.Post.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<Guid>.ErrorResult(FuelMessage.Post.Error, StatusCodes.Status500InternalServerError, [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateFuelRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateFuelCommand
            {
                FuelId = id,
                Name = request.Name,
                Description = request.Description
            };

            var (message, updateFuelDto) = await sender.Send(command, cancellationToken);

            if (updateFuelDto == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = mapper.Map<UpdateFuelResponse>(updateFuelDto);
            var apiResponse = ApiResponse<UpdateFuelResponse>.SuccessResult(response, message);
            
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<object>.ErrorResult(FuelMessage.Update.Error, 
                StatusCodes.Status500InternalServerError, 
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
        
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var command = new DeleteFuelCommand(id);
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
            var errorResponse = ApiResponse<object>.ErrorResult(
                FuelMessage.Delete.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}
