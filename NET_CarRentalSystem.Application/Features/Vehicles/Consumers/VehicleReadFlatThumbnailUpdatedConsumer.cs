using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatThumbnailUpdatedConsumer(
    ILogger<VehicleReadFlatThumbnailUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<VehicleThumbnailUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";
    protected override string IdColumn => "vehicle_id";
    protected override string UpdateSetClause => """

                                                         thumbnail = @Thumbnail,
                                                         updated_at = @UpdatedAt,
                                                         updated_by = @UpdatedBy
                                                 """;

    protected override object CreateParameters(VehicleThumbnailUpdatedEvent msg)
    {
        return new 
        { 
            msg.Id, 
            msg.Thumbnail, 
            msg.UpdatedAt, 
            msg.UpdatedBy 
        };
    }
}