using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Locations.Consumers;

public class LocationDeletedConsumer(
    ILogger<LocationDeletedConsumer> logger,
    IDapperRepository dapperRepository) : EntityDeletedConsumerBase<LocationDeletedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "locations";
    
    protected override string IdColumn => "location_id";
}