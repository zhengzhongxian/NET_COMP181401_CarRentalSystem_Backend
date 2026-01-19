using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Events;

public record VehicleModelsUpdatedEvent : EntityUpdatedEvent<Guid>
{
    public string? VehicleModelsJson { get; init; }
    
    public int AvailableCount { get; init; }
}

