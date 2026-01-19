using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Response.Insurances;
using NET_CarRentalSystem.Application.Features.Insurances.Queries.GetActiveInsurancePackages;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InsurancesController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet("active")]
    [AllowAnonymous]
    public async Task<IActionResult> GetActiveInsurancePackages(CancellationToken cancellationToken)
    {
        var query = new GetActiveInsurancePackagesQuery();
        var result = await sender.Send(query, cancellationToken);
        
        var response = mapper.Map<List<GetInsurancePackageResponse>>(result);
        var apiResponse = ApiResponse.SuccessResult(response, InsuranceMessage.Get.Success);
        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
}

