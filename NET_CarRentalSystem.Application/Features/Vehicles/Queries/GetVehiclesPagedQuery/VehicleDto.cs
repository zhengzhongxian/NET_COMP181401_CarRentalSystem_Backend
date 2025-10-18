using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class VehicleDto
{
    public Guid VehicleId { get; set; }

    public string NumberPlate { get; set; } = string.Empty;

    public string Manufacturer { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string? Color { get; set; }

    public int Mileage { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public DateTime? LastCheckoutAt { get; set; }

    public float Rating { get; set; }

    public VehicleStatus Status { get; set; }

    public string? ConditionNotes { get; set; }

    public string? RealTimeLocation { get; set; }

    public Guid? LocationId { get; set; }

    public string? Metadata { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? TransmissionId { get; set; }
    
    public string? VehicleCategoryCode { get; set; }

    public string? FuelName { get; set; }

    public string? TransmissionName { get; set; }
}
