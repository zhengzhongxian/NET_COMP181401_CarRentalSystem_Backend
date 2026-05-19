using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Audit;
using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Infrastructure.Services.Audit;

/// <summary>
/// Publishes audit log entries as structured Serilog logs.
/// Serilog's Elasticsearch sink automatically ships these to Elasticsearch.
/// </summary>
public class AuditLogService(ILogger<AuditLogService> logger) : IAuditLogService
{
    public void PublishAuditLogs(IEnumerable<AuditLog> auditLogs)
    {
        foreach (var audit in auditLogs)
        {
            logger.LogInformation(
                "[AuditLog] Action={Action} Entity={EntityName} EntityId={EntityId} " +
                "UserId={UserId} ChangedProperties={ChangedProperties} " +
                "OldValues={OldValues} NewValues={NewValues} " +
                "IpAddress={IpAddress} RequestPath={RequestPath} Timestamp={Timestamp}",
                audit.Action,
                audit.EntityName,
                audit.EntityId,
                audit.UserId ?? "System",
                audit.ChangedProperties,
                audit.OldValues,
                audit.NewValues,
                audit.IpAddress,
                audit.RequestPath,
                audit.Timestamp);
        }
    }
}
