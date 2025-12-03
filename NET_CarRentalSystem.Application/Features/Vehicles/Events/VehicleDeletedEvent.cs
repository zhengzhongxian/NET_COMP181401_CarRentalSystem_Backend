using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Events;

public record VehicleDeletedEvent : EntityDeletedEvent<Guid>;

