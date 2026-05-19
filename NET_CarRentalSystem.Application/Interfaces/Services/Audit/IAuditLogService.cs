using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Audit;

/// <summary>
/// Service for publishing audit log entries to Elasticsearch via structured Serilog logging.
/// </summary>
public interface IAuditLogService
{
    void PublishAuditLogs(IEnumerable<AuditLog> auditLogs);
}
