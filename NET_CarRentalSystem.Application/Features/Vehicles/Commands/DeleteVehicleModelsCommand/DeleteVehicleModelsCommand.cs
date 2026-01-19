using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleModelsCommand;

public class DeleteVehicleModelsCommand : ICommand<bool>
{
    public required Guid VehicleId { get; init; }
    public required Guid VehicleModelId { get; init; }
}

public class DeleteVehicleModelsCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteVehicleModelsCommand, bool>
{
    public async Task<bool> Handle(DeleteVehicleModelsCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;

            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetFirstAsync(x => x.Id == request.VehicleModelId && x.VehicleId == request.VehicleId, ct);

            unitOfWork.GetWriteRepository<VehicleModel>().Remove(vehicleModel, hardDelete: true);
            
            vehicle.AvailableCount = Math.Max(0, vehicle.AvailableCount - 1);
            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
            
            await unitOfWork.SaveChangesAsync(ct);

            var remainingModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);

            var modelsJson = remainingModels.Select(m => new
            {
                m.Id,
                m.NumberPlate,
                m.Mileage,
                m.Status,
                m.ConditionNotes,
                m.LocationId
            }).ToList().ToJson();

            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ => new VehicleModelsUpdatedEvent
            {
                VehicleModelsJson = modelsJson,
                AvailableCount = vehicle.AvailableCount,
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

