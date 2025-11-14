using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleCategory : BaseEntity<Guid>
{
    public string CategoryCode { get; set; }
    
    public string? Description { get; set; }
    
    public int Seat { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = [];
}
