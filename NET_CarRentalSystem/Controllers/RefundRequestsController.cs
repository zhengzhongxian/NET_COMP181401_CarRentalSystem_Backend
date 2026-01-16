using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Models.Request.RefundRequests;
using NET_CarRentalSystem.API.Models.Response.RefundRequests;
using NET_CarRentalSystem.Application.Features.RefundRequests.Commands.ApproveRefundRequestCommand;
using NET_CarRentalSystem.Application.Features.RefundRequests.Commands.RejectRefundRequestCommand;
using NET_CarRentalSystem.Application.Features.RefundRequests.Queries.GetPendingRefundRequestsQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class RefundRequestsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet("pending")]
    [ValidateUserExists(Policy = PermissionConstants.RefundRequests.View)]
    public async Task<IActionResult> GetPendingRefundRequests([FromQuery] GetPendingRefundRequestsRequest request, CancellationToken ct)
    {
        try
        {
            var queryParams = mapper.Map<GetPendingRefundRequestsQueryParams>(request);
            var query = new GetPendingRefundRequestsQuery
            {
                RequestParams = queryParams
            };
            
            var result = await sender.Send(query, ct);
            var pagedResponse = mapper.Map<PagedResponse<GetPendingRefundRequestsResponse>>(result);
            
            var apiResponse = ApiResponse.SuccessResult(pagedResponse, RefundRequestMessage.Get.Success);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                RefundRequestMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
    
    [HttpPost("{refundRequestId:guid}/approve")]
    [ValidateUserExists(Policy = PermissionConstants.RefundRequests.Approve)]
    public async Task<IActionResult> ApproveRefundRequest(
        Guid refundRequestId,
        [FromBody] ApproveRefundRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new ApproveRefundRequestCommand
            {
                RefundRequestId = refundRequestId,
                AdminNotes = request.AdminNotes
            };
            
            var (success, message) = await sender.Send(command, ct);
            
            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status400BadRequest, []);
                return StatusCode(StatusCodes.Status400BadRequest, errorResponse);
            }
            
            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                RefundRequestMessage.Approve.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    [HttpPost("{refundRequestId:guid}/reject")]
    [ValidateUserExists(Policy = PermissionConstants.RefundRequests.Reject)]
    public async Task<IActionResult> RejectRefundRequest(
        Guid refundRequestId,
        [FromBody] RejectRefundRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new RejectRefundRequestCommand
            {
                RefundRequestId = refundRequestId,
                AdminNotes = request.AdminNotes
            };
            
            var (success, message) = await sender.Send(command, ct);
            
            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status400BadRequest, []);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }
            
            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                RefundRequestMessage.Reject.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}

