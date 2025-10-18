using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.Application.Features.Fuels.Queries.GetAllFuelsQuery;
namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuelsController(ISender sender) : ControllerBase
{
    private readonly ISender _sender = sender;

    [HttpGet]
    public async Task<IActionResult> GetAllFuels(CancellationToken cancellationToken)
    {
        var query = new GetAllFuelsQuery();
        var result =  await _sender.Send(query, cancellationToken);
        return Ok(result);
    }
}
