using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Events;

public record VehicleImagesUpdatedEvent : EntityUpdatedEvent<Guid>
{
    public required string ImagesJson { get; init; }
}