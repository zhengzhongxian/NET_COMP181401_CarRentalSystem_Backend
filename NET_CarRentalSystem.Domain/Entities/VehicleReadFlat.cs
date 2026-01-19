using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleReadFlat : BaseEntity<Guid>, IReadEntity
{
    public string Manufacturer { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string? Color { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public string? Description { get; set; }

    public float Rating { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public Guid? FuelId { get; set; }

    public string? FuelName { get; set; }

    public Guid? TransmissionId { get; set; }

    public string? TransmissionName { get; set; }

    public int AvailableCount { get; set; }

    public string? VehicleModelsJson { get; set; }
    
    public string? ImagesJson { get; set; }
    
    public string? AttributesJson { get; set; }
    
    public string? Metadata { get; set; }
}

