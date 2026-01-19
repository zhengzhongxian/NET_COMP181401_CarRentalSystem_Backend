using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Vehicle : BaseEntity<Guid>, IRowVersion
{
    public string Manufacturer { get; set; } = default!;

    public string Model { get; set; } = default!;

    public string? Color { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }
    
    public string? Description { get; set; }

    public float Rating { get; set; }

    public string? Metadata { get; set; }

    public int AvailableCount { get; set; }

    public byte[] RowVersion { get; set; } = [];

    // Foreign Keys
    public Guid? VehicleCategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? TransmissionId { get; set; }

    // Navigation Properties
    public virtual VehicleCategory? VehicleCategory { get; set; }

    public virtual Fuel? Fuel { get; set; }

    public virtual Transmission? Transmission { get; set; }

    public virtual ICollection<VehicleImage> VehicleImages { get; set; } = [];

    public virtual ICollection<Booking> Bookings { get; set; } = [];

    public virtual ICollection<VehicleAttribute> VehicleAttributes { get; set; } = [];

    public virtual ICollection<VehicleModel> VehicleModels { get; set; } = [];
}