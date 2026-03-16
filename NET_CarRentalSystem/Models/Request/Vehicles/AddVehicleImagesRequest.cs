namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class AddVehicleImagesRequest
{
    public required List<IFormFile> Images { get; set; } = default!;
    
    public bool EnableAiVerification { get; set; } = true;
}