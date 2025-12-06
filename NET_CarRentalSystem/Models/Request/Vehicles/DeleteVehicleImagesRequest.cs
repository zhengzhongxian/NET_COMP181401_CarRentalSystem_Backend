namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class DeleteVehicleImagesRequest
{
    public required List<string> PublicIds { get; set; }
}
