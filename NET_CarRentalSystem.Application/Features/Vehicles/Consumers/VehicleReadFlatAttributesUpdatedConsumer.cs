using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatAttributesUpdatedConsumer(
    ILogger<VehicleReadFlatAttributesUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<VehicleAttributesUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";
    protected override string IdColumn => "vehicle_id";

    protected override string UpdateSetClause => """

                                                         attributes_json = @AttributesJson,
                                                         updated_at = @UpdatedAt,
                                                         updated_by = @UpdatedBy
                                                 """;

    protected override object CreateParameters(VehicleAttributesUpdatedEvent msg)
    {
        return new
        {
            msg.Id,
            msg.AttributesJson,
            msg.UpdatedAt,
            msg.UpdatedBy
        };
    }
}

