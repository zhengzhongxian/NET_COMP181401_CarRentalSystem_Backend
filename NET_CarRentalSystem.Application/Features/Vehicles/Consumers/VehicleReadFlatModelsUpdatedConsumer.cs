using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatModelsUpdatedConsumer(
    ILogger<VehicleReadFlatModelsUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<VehicleModelsUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";
    
    protected override string IdColumn => "vehicle_id";

    protected override string UpdateSetClause => """
                                                         vehicle_models_json = @VehicleModelsJson,
                                                         available_count = @AvailableCount,
                                                         updated_at = @UpdatedAt,
                                                         updated_by = @UpdatedBy
                                                 """;

    protected override object CreateParameters(VehicleModelsUpdatedEvent msg)
    {
        return new
        {
            msg.Id,
            msg.VehicleModelsJson,
            msg.AvailableCount,
            msg.UpdatedAt,
            msg.UpdatedBy
        };
    }
}

