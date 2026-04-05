using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleModelsStatusCommand;

public class UpdateVehicleModelsStatusCommand : ICommand<(bool Success, string Message)>
{
    public required Guid VehicleId { get; init; }
    public required Guid VehicleModelId { get; init; }
    public required VehicleStatus Status { get; init; }
}

public class UpdateVehicleModelsStatusCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    ILogger<UpdateVehicleModelsStatusCommandHandler> logger) : IRequestHandler<UpdateVehicleModelsStatusCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(UpdateVehicleModelsStatusCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return (false, VehicleMessage.UpdateVehicleModels.NotFound);

            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetFirstAsync(x => x.Id == request.VehicleModelId && x.VehicleId == request.VehicleId, ct);

            vehicleModel.Status = request.Status;
            
            if (request.Status == VehicleStatus.Available)
            {
                vehicleModel.LastAvailableAt = DateTime.UtcNow;
            }

            unitOfWork.GetWriteRepository<VehicleModel>().Update(vehicleModel);
            
            await unitOfWork.SaveChangesAsync(ct);
            
            var allModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);
            
            vehicle.AvailableCount = allModels.Count(x => x.Status == VehicleStatus.Available);
            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);

            var modelsJson = await BuildVehicleModelsJson(allModels, ct);

            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ =>
                new VehicleModelsUpdatedEvent
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

            logger.LogInformation("[UpdateVehicleModelStatus] VehicleModel {Id} status changed to {Status}", request.VehicleModelId, request.Status);
            return (true, "Cập nhật trạng thái xe thành công.");
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

