namespace NET_CarRentalSystem.Domain.Common;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
}