using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatDeletedConsumer(
    ILogger<VehicleReadFlatDeletedConsumer> logger,
    IDapperRepository dapperRepository) : EntityDeletedConsumerBase<VehicleDeletedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";
    protected override string IdColumn => "vehicle_id";
}