using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Locations.Consumers;

public class LocationReadFlatUpdatedConsumer(
    ILogger<LocationReadFlatUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<LocationUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "locations";
    
    protected override string IdColumn => "location_id";

    protected override string UpdateSetClause =>
        "name = @Name, address = @Address, city = @City, phone_number = @PhoneNumber, opening_hours = @OpeningHours, latitude = @Latitude, longitude = @Longitude, description = @Description, updated_at = @UpdatedAt, updated_by = @UpdatedBy";

    protected override object CreateParameters(LocationUpdatedEvent message) => new
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
        message.UpdatedAt,
        message.UpdatedBy
    };
}