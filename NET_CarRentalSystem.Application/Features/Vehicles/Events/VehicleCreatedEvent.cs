using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Events;

public record VehicleCreatedEvent : EntityCreatedEvent<Guid>
{
    public required string NumberPlate { get; init; }

    public required string Manufacturer { get; init; }

    public required string Model { get; init; }

    public string? Color { get; init; }

    public int Mileage { get; init; }

    public decimal PricePerHour { get; init; }

    public string? Thumbnail { get; init; }

    public string? Description { get; init; }

    public DateTime? LastCheckoutAt { get; init; }

    public float Rating { get; init; }

    public required string Status { get; init; }

    public string? ConditionNotes { get; init; }

    public string? RealTimeLocation { get; init; }

    public Guid? LocationId { get; init; }

    public string? LocationName { get; init; }

    public Guid? VehicleCategoryId { get; init; }

    public string? CategoryName { get; init; }

    public Guid? FuelId { get; init; }

    public string? FuelName { get; init; }

    public Guid? TransmissionId { get; init; }

    public string? TransmissionName { get; init; }

    public string? ImagesJson { get; init; }

    public string? AttributesJson { get; init; }

    public string? Metadata { get; init; }
}

