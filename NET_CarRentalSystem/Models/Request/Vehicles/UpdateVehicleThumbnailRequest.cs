namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class UpdateVehicleThumbnailRequest
{
    public required IFormFile Thumbnail { get; set; } = default!;
    
    public bool EnableAiVerification { get; set; } = true;
}