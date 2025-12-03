using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Fuels.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Fuels.Consumers;

public class FuelCreatedConsumer(
    ILogger<FuelCreatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityCreatedConsumerBase<FuelCreatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "fuels";

    protected override string InsertColumns =>
        "fuel_id, name, description, created_at, created_by, updated_at, updated_by, is_deleted";

    protected override string InsertValues =>
        "@Id, @Name, @Description, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy, 0";

    protected override object CreateParameters(FuelCreatedEvent message) => new
    {
        message.Id,
        message.Name,
        message.Description,
        message.CreatedAt,
        message.CreatedBy,
        message.UpdatedAt,
        message.UpdatedBy
    };
}