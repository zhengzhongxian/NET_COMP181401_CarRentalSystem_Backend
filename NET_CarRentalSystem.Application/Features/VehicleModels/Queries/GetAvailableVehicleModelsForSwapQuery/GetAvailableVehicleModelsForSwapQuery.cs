using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.VehicleModels.Queries.GetAvailableVehicleModelsForSwapQuery;

public class GetAvailableVehicleModelsForSwapQuery : IQuery<List<GetVehicleModelDto>>
{
    public required Guid OldVehicleModelId { get; set; }
}

public class GetAvailableVehicleModelsForSwapQueryHandler(
    IUnitOfWork unitOfWork) : IRequestHandler<GetAvailableVehicleModelsForSwapQuery, List<GetVehicleModelDto>>
{
    public async Task<List<GetVehicleModelDto>> Handle(GetAvailableVehicleModelsForSwapQuery request, CancellationToken cancellationToken)
    {
        var oldVehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
            .GetFirstOrDefaultAsync(
                vm => vm.Id == request.OldVehicleModelId,
                cancellationToken: cancellationToken);

        if (oldVehicleModel == null)
            return [];

        var vehicleFlat = await unitOfWork.GetReadRepository<VehicleReadFlat>()
            .GetByIdAsync(oldVehicleModel.VehicleId, cancellationToken);

        if (vehicleFlat == null || string.IsNullOrEmpty(vehicleFlat.VehicleModelsJson))
            return [];

        var allModels = vehicleFlat.VehicleModelsJson.FromJson<List<GetVehicleModelDto>>() ?? [];

        var availableModels = allModels
            .Where(vm => vm.LocationId == oldVehicleModel.LocationId
                         && vm.Status == VehicleStatus.Available
                         && vm.Id != request.OldVehicleModelId)
            .ToList();

        return availableModels;
    }
}

