using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;

public class GetVehicleAvailabilityDto
{
    public Guid VehicleId { get; set; }
    
    public string VehicleName { get; set; } = default!;
    
    public int TotalAvailable { get; set; }
    
    public List<GetVehicleAvailabilityByLocationDto> ByLocation { get; set; } = [];
}

