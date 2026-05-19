using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.Application.Features.Audit.Queries;
using NET_CarRentalSystem.Shared.Constants;

using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.API.Attributes;

namespace NET_CarRentalSystem.API.Controllers;

[Route("api/audit-logs")]
[ApiController]
[ValidateUserExists(Roles = RoleConstants.Admin)]
public class AuditLogsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAuditLogs([FromQuery] GetAuditLogsQuery query)
    {
        var result = await mediator.Send(query);
        return Ok(result);
    }
}
