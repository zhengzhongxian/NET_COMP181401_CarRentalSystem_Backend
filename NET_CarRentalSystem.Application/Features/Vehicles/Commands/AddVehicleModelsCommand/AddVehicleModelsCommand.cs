using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleModelsCommand;

public class AddVehicleModelsCommand : ICommand<bool>
{
    public Guid VehicleId { get; set; }
    public List<VehicleModelParams> VehicleModels { get; set; } = [];
}

public class AddVehicleModelsCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<AddVehicleModelsCommand, bool>
{
    public async Task<bool> Handle(AddVehicleModelsCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;

            var existingModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);

            var newModels = request.VehicleModels.Select(m => new VehicleModel
            {
                VehicleId = vehicle.Id,
                NumberPlate = m.NumberPlate,
                Mileage = m.Mileage,
                Status = VehicleStatus.Available,
                ConditionNotes = m.ConditionNotes,
                LocationId = m.LocationId,
                RealTimeLocation = null
            }).ToList();

            if (newModels.Count > 0)
            {
                await unitOfWork.GetWriteRepository<VehicleModel>().AddRangeAsync(newModels, ct);

                vehicle.AvailableCount += newModels.Count;
                unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);

                await unitOfWork.SaveChangesAsync(ct);
            }

            var allModels = existingModels.Concat(newModels).ToList();

            var modelsJson = await BuildVehicleModelsJson(allModels, ct);

            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ =>
                new VehicleModelsUpdatedEvent
                {
                    VehicleModelsJson = modelsJson,
                    AvailableCount = vehicle.AvailableCount,
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

    private async Task<string> BuildVehicleModelsJson(List<VehicleModel> models, CancellationToken ct)
    {
        var jsonModels = new List<CreateJsonVehicleModelDto>();

        foreach (var model in models)
        {
            Location? location = null;
            if (model.LocationId.HasValue)
            {
                location = await unitOfWork.GetReadRepository<Location>()
                    .GetByIdAsync(model.LocationId.Value, ct);
            }

            jsonModels.Add(new CreateJsonVehicleModelDto
            {
                Id = model.Id,
                NumberPlate = model.NumberPlate,
                Mileage = model.Mileage,
                Status = model.Status,
                ConditionNotes = model.ConditionNotes,
                LastAvailableAt = model.LastAvailableAt,
                LocationId = model.LocationId,
                LocationName = location?.Name,
                Address = location?.Address
            });
        }

        return jsonModels.ToJson();
    }
}

