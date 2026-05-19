using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Audit.Queries;

public class GetAuditLogsQuery : PagedRequest, IQuery<PagedList<AuditLogDto>>
{
}

public class AuditLogDto
{
    public string? Timestamp { get; set; }
    public string? Action { get; set; }
    public string? EntityName { get; set; }
    public string? EntityId { get; set; }
    public string? UserId { get; set; }
    public string? IpAddress { get; set; }
    public string? RequestPath { get; set; }
    public string? ChangedProperties { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string? Message { get; set; }
}
