using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Response.Terms;
using NET_CarRentalSystem.Application.Features.Terms.Queries.GetActiveBookingTerms;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TermsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet("booking")]
    [AllowAnonymous]
    public async Task<IActionResult> GetActiveBookingTerms(CancellationToken cancellationToken)
    {
        var query = new GetActiveBookingTermsQuery();
        var result = await sender.Send(query, cancellationToken);
        
        if (result == null)
        {
            var errorResponse = ApiResponse.ErrorResult(
                TermsMessage.Get.NotFound,
                StatusCodes.Status404NotFound);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
        
        var response = mapper.Map<GetTermsResponse>(result);
        var apiResponse = ApiResponse.SuccessResult(response, TermsMessage.Get.Success);
        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
}

