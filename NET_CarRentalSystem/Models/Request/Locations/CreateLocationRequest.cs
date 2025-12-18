namespace NET_CarRentalSystem.API.Models.Request.Locations;

public class CreateLocationRequest
{
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public string? PhoneNumber { get; set; }
    public string? OpeningHours { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Description { get; set; }
    public required IFormFile ThumbnailFile { get; set; }
}