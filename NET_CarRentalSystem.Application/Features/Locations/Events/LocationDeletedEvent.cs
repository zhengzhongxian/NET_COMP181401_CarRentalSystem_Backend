using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Locations.Events;

public record LocationDeletedEvent : EntityDeletedEvent<Guid>;