using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Location : BaseEntity
{
    public Guid LocationId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string? PhoneNumber { get; set; }

    public string? OpeningHours { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = [];

    public virtual ICollection<Booking> PickupsFromLocation { get; set; } = [];

    public virtual ICollection<Booking> ReturnsToLocation { get; set; } = [];
}