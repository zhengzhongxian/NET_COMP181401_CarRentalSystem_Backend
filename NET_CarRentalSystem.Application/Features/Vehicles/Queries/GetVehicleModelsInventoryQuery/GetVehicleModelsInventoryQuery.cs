using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleModelsInventoryQuery;

public class GetVehicleModelsInventoryQuery : IQuery<GetVehicleModelsInventoryDto>
{
    public required Guid VehicleId { get; set; }
    
    public VehicleStatus? StatusFilter { get; set; }
}

public class GetVehicleModelsInventoryQueryHandler(
    IUnitOfWork unitOfWork) : IRequestHandler<GetVehicleModelsInventoryQuery, GetVehicleModelsInventoryDto>
{
    public async Task<GetVehicleModelsInventoryDto> Handle(GetVehicleModelsInventoryQuery request, CancellationToken cancellationToken)
    {
        var vehicleFlat = await unitOfWork.GetReadRepository<VehicleReadFlat>()
            .GetByIdAsync(request.VehicleId, cancellationToken);

        if (vehicleFlat == null)
        {
            return new GetVehicleModelsInventoryDto
            {
                VehicleId = request.VehicleId,
                VehicleName = "",
                TotalCount = 0,
                ByStatus = [],
                ByLocation = []
            };
        }
        
        var allModels = string.IsNullOrEmpty(vehicleFlat.VehicleModelsJson)
            ? []
            : vehicleFlat.VehicleModelsJson.FromJson<List<GetVehicleModelDto>>() ?? [];
        
        var filteredModels = request.StatusFilter.HasValue
            ? allModels.Where(vm => vm.Status == request.StatusFilter.Value).ToList()
            : allModels;
        var byStatus = Enum.GetValues<VehicleStatus>()
            .Select(status => new GetVehicleModelsByStatusDto
            {
                Status = status,
                Count = allModels.Count(vm => vm.Status == status)
            })
            .Where(s => s.Count > 0)
            .ToList();
        
        var byLocation = filteredModels
            .Where(vm => vm.LocationId.HasValue)
            .GroupBy(vm => vm.LocationId!.Value)
            .Select(group =>
            {
                var firstInGroup = group.First();
                return new GetVehicleModelsByLocationDto
                {
                    LocationId = group.Key,
                    LocationName = firstInGroup.LocationName ?? "N/A",
                    Address = firstInGroup.Address ?? "N/A",
                    Count = group.Count(),
                    Models = group.ToList()
                };
            })
            .ToList();

        return new GetVehicleModelsInventoryDto
        {
            VehicleId = request.VehicleId,
            VehicleName = $"{vehicleFlat.Manufacturer} {vehicleFlat.Model}",
            TotalCount = filteredModels.Count,
            ByStatus = byStatus,
            ByLocation = byLocation
        };
    }
}
