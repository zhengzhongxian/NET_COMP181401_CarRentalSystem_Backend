namespace NET_CarRentalSystem.Domain.Common;

/// <summary>
/// Represents an audit log entry capturing entity changes.
/// Stored in Elasticsearch via Serilog — NOT persisted in SQL Server.
/// </summary>
public class AuditLog
{
    public string? UserId { get; set; }
    
    public string? UserEmail { get; set; }
    
    /// <summary>
    /// The type of action: Create, Update, Delete
    /// </summary>
    public required string Action { get; set; }
    
    /// <summary>
    /// The entity type name (e.g., "Booking", "Customer")
    /// </summary>
    public required string EntityName { get; set; }
    
    /// <summary>
    /// The primary key of the affected entity
    /// </summary>
    public required string EntityId { get; set; }
    
    /// <summary>
    /// JSON snapshot of old values (for Update/Delete)
    /// </summary>
    public string? OldValues { get; set; }
    
    /// <summary>
    /// JSON snapshot of new values (for Create/Update)
    /// </summary>
    public string? NewValues { get; set; }
    
    /// <summary>
    /// Comma-separated list of changed property names (for Update)
    /// </summary>
    public string? ChangedProperties { get; set; }
    
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    
    public string? IpAddress { get; set; }
    
    public string? RequestPath { get; set; }
}
