using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Queries;

public class GetDevLogsQuery : PagedRequest, IQuery<PagedList<DevLogDto>>
{
    public string? LogLevel { get; set; }
    
    public string? StartDate { get; set; }
    
    public string? EndDate { get; set; }
}

public class DevLogDto
{
    public string? Timestamp { get; set; }
    public string? Level { get; set; }
    public string? MessageTemplate { get; set; }
    public string? RenderedMessage { get; set; }
    public string? Exception { get; set; }
    public string? SourceContext { get; set; }
    public string? RequestPath { get; set; }
    public string? ActionName { get; set; }
    public string? MachineName { get; set; }
    public string? ThreadId { get; set; }
    public string? Properties { get; set; }
}
