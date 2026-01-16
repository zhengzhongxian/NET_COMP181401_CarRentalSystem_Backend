using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleAvailabilityQuery;

public class GetVehicleAvailabilityQuery : IQuery<GetVehicleAvailabilityDto>
{
    public required Guid VehicleId { get; set; }
}

public class GetVehicleAvailabilityQueryHandler(
    IUnitOfWork unitOfWork) : IRequestHandler<GetVehicleAvailabilityQuery, GetVehicleAvailabilityDto>
{
    public async Task<GetVehicleAvailabilityDto> Handle(GetVehicleAvailabilityQuery request, CancellationToken cancellationToken)
    {
        var vehicleFlat = await unitOfWork.GetReadRepository<VehicleReadFlat>()
            .GetByIdAsync(request.VehicleId, cancellationToken);

        if (vehicleFlat == null)
        {
            return new GetVehicleAvailabilityDto
            {
                VehicleId = request.VehicleId,
                VehicleName = "",
                TotalAvailable = 0,
                ByLocation = []
            };
        }
        
        var vehicleModels = string.IsNullOrEmpty(vehicleFlat.VehicleModelsJson)
            ? []
            : vehicleFlat.VehicleModelsJson.FromJson<List<GetVehicleModelDto>>() ?? [];
        // Filter chỉ available models
        var availableModels = vehicleModels
            .Where(vm => vm.Status == VehicleStatus.Available)
            .ToList();

        if (availableModels.Count == 0)
        {
            return new GetVehicleAvailabilityDto
            {
                VehicleId = request.VehicleId,
                VehicleName = $"{vehicleFlat.Manufacturer} {vehicleFlat.Model}",
                TotalAvailable = 0,
                ByLocation = []
            };
        }
        
        var byLocation = (from @group in availableModels.Where(vm => vm.LocationId.HasValue).GroupBy(vm => vm.LocationId!.Value)
        let firstInGroup = @group.First()
        let models = @group.ToList()
        select new GetVehicleAvailabilityByLocationDto
        {
            LocationId = @group.Key,
            LocationName = firstInGroup.LocationName ?? "N/A",
            Address = firstInGroup.Address ?? "N/A",
            AvailableCount = models.Count,
            Models = models
        }).ToList();

        return new GetVehicleAvailabilityDto
        {
            VehicleId = request.VehicleId,
            VehicleName = $"{vehicleFlat.Manufacturer} {vehicleFlat.Model}",
            TotalAvailable = availableModels.Count,
            ByLocation = byLocation
        };
    }
}






