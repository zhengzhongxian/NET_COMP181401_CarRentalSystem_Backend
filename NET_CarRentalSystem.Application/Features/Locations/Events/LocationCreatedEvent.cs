using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Locations.Events;

public record LocationCreatedEvent : EntityCreatedEvent<Guid>
{
    public required string Name { get; init; }
    public required string Address { get; init; }
    public required string City { get; init; }
    public string? PhoneNumber { get; init; }
    public string? OpeningHours { get; init; }
    public double? Latitude { get; init; }
    public double? Longitude { get; init; }
    public string? Description { get; init; }
    public string? PublicId { get; init; }
    public string? Thumbnail { get; init; }
}