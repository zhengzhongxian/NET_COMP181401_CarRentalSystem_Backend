using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Locations.Consumers;

public class LocationCreatedConsumer(
    ILogger<LocationCreatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityCreatedConsumerBase<LocationCreatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "locations";

    protected override string InsertColumns =>
        "location_id, name, address, city, phone_number, opening_hours, latitude, longitude, description, public_id, thumbnail, created_at, created_by, updated_at, updated_by, is_deleted";

    protected override string InsertValues =>
        "@Id, @Name, @Address, @City, @PhoneNumber, @OpeningHours, @Latitude, @Longitude, @Description, @PublicId, @Thumbnail, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy, 0";

    protected override object CreateParameters(LocationCreatedEvent message) => new
    {
        message.Id,
        message.Name,
        message.Address,
        message.City,
        message.PhoneNumber,
        message.OpeningHours,
        message.Latitude,
        message.Longitude,
        message.Description,
        message.PublicId,
        message.Thumbnail,
        message.CreatedAt,
        message.CreatedBy,
        message.UpdatedAt,
        message.UpdatedBy
    };
}