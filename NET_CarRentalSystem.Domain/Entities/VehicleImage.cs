namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleImage
{
    public Guid ImageId { get; set; }

    public int Order { get; set; }

    public string ImageUrl { get; set; }

    public string? AltText { get; set; }

    public string? Caption { get; set; }

    public string? PublicId { get; set; }

    public Guid VehicleId { get; set; }

    public virtual Vehicle Vehicle { get; set; }
}
