using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleCategory : BaseEntity
{
    public Guid CategoryId { get; set; }

    public string CategoryCode { get; set; }

    public int Seat { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = [];
}
