using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;

public class GetVehicleModelsInventoryDto
{
    public Guid VehicleId { get; set; }
    
    public string VehicleName { get; set; } = default!;
    
    public int TotalCount { get; set; }
    
    public List<GetVehicleModelsByStatusDto> ByStatus { get; set; } = [];

    public List<GetVehicleModelsByLocationDto> ByLocation { get; set; } = [];
}

public class GetVehicleModelsByStatusDto
{
    public VehicleStatus Status { get; set; }
    
    public int Count { get; set; }
}

public class GetVehicleModelsByLocationDto
{
    public Guid LocationId { get; set; }
    
    public string? LocationName { get; set; }
    
    public string? Address { get; set; }
    
    public int Count { get; set; }
    
    public List<GetVehicleModelDto> Models { get; set; } = [];
}
