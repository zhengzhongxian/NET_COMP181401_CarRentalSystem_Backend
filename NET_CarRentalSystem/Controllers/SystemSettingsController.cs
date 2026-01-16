using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.SystemSettings;
using NET_CarRentalSystem.API.Models.Response.SystemSettings;
using NET_CarRentalSystem.Application.Features.SystemSettings.Commands.UpdateSystemSettingsCommand;
using NET_CarRentalSystem.Application.Features.SystemSettings.Queries.GetAllSystemSettingsQuery;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SystemSettingsController(
    ISender sender,
    IMapper mapper) : ControllerBase
{
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllSystemSettings(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetAllSystemSettingsQuery();
            var result = await sender.Send(query, cancellationToken);

            var response = mapper.Map<AllSystemSettingsResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, SystemSettingMessage.Get.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                SystemSettingMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
    
    [HttpPut]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> UpdateAllSystemSettings(
        [FromBody] UpdateAllSystemSettingsRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = mapper.Map<UpdateAllSystemSettingsCommand>(request);
            var result = await sender.Send(command, cancellationToken);

            if (result)
            {
                var successResponse = ApiResponse.SuccessResult( SystemSettingMessage.UpdateAll.Success);
                return StatusCode(successResponse.StatusCode, successResponse);
            }

            var failResponse = ApiResponse.ErrorResult(
                SystemSettingMessage.UpdateAll.Error,
                StatusCodes.Status500InternalServerError);

            return StatusCode(StatusCodes.Status500InternalServerError, failResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                SystemSettingMessage.UpdateAll.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}



