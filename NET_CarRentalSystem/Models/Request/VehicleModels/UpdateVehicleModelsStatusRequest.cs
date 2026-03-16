using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Request.VehicleModels;

public class UpdateVehicleModelsStatusRequest
{
    public VehicleStatus Status { get; set; }
}
