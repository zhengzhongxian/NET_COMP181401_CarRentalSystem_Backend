using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Locations.Consumers;

public class LocationReadFlatThumbnailUpdatedConsumer(
    ILogger<LocationReadFlatThumbnailUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<LocationThumbnailUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "locations";
    
    protected override string IdColumn => "location_id";

    protected override string UpdateSetClause =>
        "public_id = @PublicId, thumbnail = @Thumbnail, updated_at = @UpdatedAt, updated_by = @UpdatedBy";

    protected override object CreateParameters(LocationThumbnailUpdatedEvent message) => new
    {
        message.Id,
        message.PublicId,
        message.Thumbnail,
        message.UpdatedAt,
        message.UpdatedBy
    };
}