using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleAttributesCommand;

public class AddVehicleAttributesCommand : ICommand<bool>
{
    public Guid VehicleId { get; set; }
    public List<VehicleAttributeParams> Attributes { get; set; } = [];
}

public class AddVehicleAttributesCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<AddVehicleAttributesCommand, bool>
{
    public async Task<bool> Handle(AddVehicleAttributesCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;

            var existingAttributes = await unitOfWork.GetWriteRepository<VehicleAttribute>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);

            var newAttributes = request.Attributes.Select(a => new VehicleAttribute
            {
                VehicleId = vehicle.Id,
                AttributeKey = a.Key,
                AttributeValue = a.Value
            }).ToList();

            if (newAttributes.Count > 0)
            {
                await unitOfWork.GetWriteRepository<VehicleAttribute>().AddRangeAsync(newAttributes, ct);
                await unitOfWork.SaveChangesAsync(ct);
            }

            var allAttributes = existingAttributes.Concat(newAttributes).Select(a => new
            {
                a.AttributeKey,
                a.AttributeValue
            }).ToList();

            var attributesJson = allAttributes.ToJson();

            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleAttributesUpdatedEvent, Guid>(_ => new VehicleAttributesUpdatedEvent
            {
                AttributesJson = attributesJson,
                Id = default,
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
