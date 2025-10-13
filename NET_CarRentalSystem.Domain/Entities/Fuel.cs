using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Fuel : BaseEntity
{
    public Guid FuelId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = [];
}
