using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatImagesUpdatedConsumer(
    ILogger<VehicleReadFlatImagesUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<VehicleImagesUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";
    protected override string IdColumn => "vehicle_id";

    protected override string UpdateSetClause => """

                                                         images_json = @ImagesJson,
                                                         updated_at = @UpdatedAt,
                                                         updated_by = @UpdatedBy
                                                 """;

    protected override object CreateParameters(VehicleImagesUpdatedEvent msg)
    {
        return new
        {
            msg.Id,
            msg.ImagesJson,
            msg.UpdatedAt,
            msg.UpdatedBy
        };
    }
}