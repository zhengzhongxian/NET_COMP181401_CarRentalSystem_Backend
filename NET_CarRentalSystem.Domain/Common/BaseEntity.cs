using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Domain.Common;

public abstract class BaseEntity
{
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public bool IsDeleted { get; set; } = false;
}