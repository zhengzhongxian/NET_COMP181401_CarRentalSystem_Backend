using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class GetVehicleModelsInventoryRequest
{
    public VehicleStatus? StatusFilter { get; set; }
}
