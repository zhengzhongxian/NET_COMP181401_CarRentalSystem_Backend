using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Request.VehicleCategories;
using NET_CarRentalSystem.API.Models.Response.VehicleCategories;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.CreateVehicleCategory;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.DeleteVehicleCategory;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.UpdateVehicleCategory;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetAllVehicleCategories;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetVehicleCategoryById;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleCategoriesController : ControllerBase
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public VehicleCategoriesController(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetAllVehicleCategoriesQuery();
            var result = await _sender.Send(query, cancellationToken);
            var mappedResult = _mapper.Map<IEnumerable<GetVehicleCategoryResponse>>(result);

            var apiResponse = ApiResponse<IEnumerable<GetVehicleCategoryResponse>>.SuccessResult(
                mappedResult,
                VehicleCategoryMessage.Get.Success
            );

            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<IEnumerable<GetVehicleCategoryResponse>>.ErrorResult(
                VehicleCategoryMessage.Get.Error,
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
            var query = new GetVehicleCategoryByIdQuery { Id = id };
            var result = await _sender.Send(query, cancellationToken);

            if (result == null)
            {
                var notFoundResponse = ApiResponse<GetVehicleCategoryResponse>.ErrorResult(
                    VehicleCategoryMessage.Get.NotFound,
                    StatusCodes.Status404NotFound
                );
                return NotFound(notFoundResponse);
            }

            var mappedResult = _mapper.Map<GetVehicleCategoryResponse>(result);
            var apiResponse = ApiResponse<GetVehicleCategoryResponse>.SuccessResult(mappedResult, VehicleCategoryMessage.Get.Success);
            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<GetVehicleCategoryResponse>.ErrorResult(
                VehicleCategoryMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateVehicleCategoryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new CreateVehicleCategoryCommand
            {
                CategoryCode = request.CategoryCode,
                Seat = request.Seat
            };
            var newId = await _sender.Send(command, cancellationToken);

            var response = new CreateVehicleCategoryResponse { CategoryId = newId };
            var apiResponse = ApiResponse<CreateVehicleCategoryResponse>.SuccessResult(response, VehicleCategoryMessage.Post.Success);
            
            return CreatedAtAction(nameof(GetById), new { id = newId }, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<CreateVehicleCategoryResponse>.ErrorResult(
                VehicleCategoryMessage.Post.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateVehicleCategoryRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var command = new UpdateVehicleCategoryCommand
            {
                Id = id,
                CategoryCode = request.CategoryCode,
                Seat = request.Seat
            };

            var updatedDto = await _sender.Send(command, cancellationToken);

            if (updatedDto == null)
            {
                var errorResponse = ApiResponse.ErrorResult(VehicleCategoryMessage.Update.NotFound, StatusCodes.Status404NotFound);
                return NotFound(errorResponse);
            }

            var response = _mapper.Map<UpdateVehicleCategoryResponse>(updatedDto);
            var apiResponse = ApiResponse<UpdateVehicleCategoryResponse>.SuccessResult(response, VehicleCategoryMessage.Update.Success);

            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<UpdateVehicleCategoryResponse>.ErrorResult(VehicleCategoryMessage.Update.Error,
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
            var command = new DeleteVehicleCategoryCommand { Id = id };
            var result = await _sender.Send(command, cancellationToken);

            if (!result)
            {
                var errorResponse = ApiResponse.ErrorResult(VehicleCategoryMessage.Delete.NotFound, StatusCodes.Status404NotFound);
                return NotFound(errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(VehicleCategoryMessage.Delete.Success);
            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                VehicleCategoryMessage.Delete.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}
