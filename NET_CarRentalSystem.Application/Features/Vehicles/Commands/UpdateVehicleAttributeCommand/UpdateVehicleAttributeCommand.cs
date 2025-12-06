using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleAttributeCommand;

public class UpdateVehicleAttributeCommand : ICommand<bool>
{
    public required Guid VehicleId { get; init; }
    public required Guid AttributeId { get; init; }
    public required string Key { get; init; }
    public required string Value { get; init; }
}

public class UpdateVehicleAttributeCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateVehicleAttributeCommand, bool>
{
    public async Task<bool> Handle(UpdateVehicleAttributeCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;

            var attribute = await unitOfWork.GetWriteRepository<VehicleAttribute>()
                .GetFirstAsync(x => x.AttributeId == request.AttributeId && x.VehicleId == request.VehicleId, ct);
            
            attribute.AttributeKey = request.Key;
            attribute.AttributeValue = request.Value;

            unitOfWork.GetWriteRepository<VehicleAttribute>().Update(attribute);
            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
            await unitOfWork.SaveChangesAsync(ct);

            var allAttributes = await unitOfWork.GetWriteRepository<VehicleAttribute>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);

            var attributesJson = allAttributes.Select(a => new
            {
                a.AttributeId,
                a.AttributeKey,
                a.AttributeValue
            }).ToList().ToJson();

            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleAttributesUpdatedEvent, Guid>(_ => new VehicleAttributesUpdatedEvent
            {
                AttributesJson = attributesJson,
                Id = vehicle.Id,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(evt, ct);
            await unitOfWork.SaveChangesAsync(ct);
            return true;
        }, cancellationToken);
    }
}