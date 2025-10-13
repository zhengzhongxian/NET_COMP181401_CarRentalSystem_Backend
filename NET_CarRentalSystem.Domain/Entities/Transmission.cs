namespace NET_CarRentalSystem.Domain.Entities;

public class Transmission
{
    public Guid TransmissionId { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = [];
}