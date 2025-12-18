using NET_CarRentalSystem.Application.Common.Events;

namespace NET_CarRentalSystem.Application.Features.Locations.Events;

public record LocationThumbnailUpdatedEvent : EntityUpdatedEvent<Guid>
{
    public required string PublicId { get; init; }
    public required string Thumbnail { get; init; }
}