using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Events;

public record VehicleUpdatedEvent : EntityUpdatedEvent<Guid>
{
    public required string Manufacturer { get; init; }

    public required string Model { get; init; }

    public string? Title { get; init; }

    public string? Color { get; init; }

    public decimal PricePerHour { get; init; }

    public string? Thumbnail { get; init; }

    public string? Description { get; init; }

    public float Rating { get; init; }

    public Guid? VehicleCategoryId { get; init; }

    public string? CategoryName { get; init; }

    public Guid? FuelId { get; init; }

    public string? FuelName { get; init; }

    public Guid? TransmissionId { get; init; }

    public string? TransmissionName { get; init; }

    public string? Metadata { get; init; }

    public int RequiredLicenseClass { get; init; }
}