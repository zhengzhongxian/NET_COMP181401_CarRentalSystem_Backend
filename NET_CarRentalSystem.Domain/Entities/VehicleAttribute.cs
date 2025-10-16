namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleAttribute
{
    public Guid AttributeId { get; set; }

    public string AttributeKey { get; set; }

    public string AttributeValue { get; set; }

    public Guid VehicleId { get; set; }

    public virtual Vehicle Vehicle { get; set; }
}
