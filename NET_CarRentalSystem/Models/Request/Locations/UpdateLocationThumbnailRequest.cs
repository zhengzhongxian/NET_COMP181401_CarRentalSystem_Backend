namespace NET_CarRentalSystem.API.Models.Request.Locations;

public class UpdateLocationThumbnailRequest
{
    public required IFormFile ThumbnailFile { get; set; }
}