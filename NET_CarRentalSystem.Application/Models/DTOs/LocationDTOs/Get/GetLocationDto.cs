namespace NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Get;

public class GetLocationDto
{
    public Guid LocationId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string? PhoneNumber { get; set; }
    public string? OpeningHours { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Description { get; set; }
    public string? Thumbnail { get; set; }
}