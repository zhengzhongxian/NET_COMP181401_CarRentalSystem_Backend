using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleReadFlat : BaseEntity<Guid>, IReadEntity
{
    public string NumberPlate { get; set; } = string.Empty;

    public string Manufacturer { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string? Color { get; set; }

    public int Mileage { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public string? Description { get; set; }

    public DateTime? LastCheckoutAt { get; set; }

    public float Rating { get; set; }

    public VehicleStatus Status { get; set; }
    
    public string? ConditionNotes { get; set; }

    public string? RealTimeLocation { get; set; }

    public Guid? LocationId { get; set; }

    public string? LocationName { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public Guid? FuelId { get; set; }

    public string? FuelName { get; set; }

    public Guid? TransmissionId { get; set; }

    public string? TransmissionName { get; set; }

    /// <summary>
    /// JSON array chứa toàn bộ thông tin của VehicleImages liên quan
    /// </summary>
    public string? ImagesJson { get; set; }

    /// <summary>
    /// JSON array chứa toàn bộ thông tin của VehicleAttributes liên quan
    /// </summary>
    public string? AttributesJson { get; set; }

    /// <summary>
    /// Metadata JSON của Vehicle
    /// </summary>
    public string? Metadata { get; set; }
}

