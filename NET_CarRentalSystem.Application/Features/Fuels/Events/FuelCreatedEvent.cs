using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Fuels.Events;

public record FuelCreatedEvent : EntityCreatedEvent<Guid>
{
    public required string Name { get; init; }
    
    public string? Description { get; init; }
}