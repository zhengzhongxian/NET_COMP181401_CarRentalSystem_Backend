namespace NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Update;

public class UpdateLocationDto
{
    public required Guid LocationId { get; init; }
    public required string Name { get; init; }
    public required string Address { get; init; }
    public required string City { get; init; }
    public string? PhoneNumber { get; init; }
    public string? OpeningHours { get; init; }
    public double? Latitude { get; init; }
    public double? Longitude { get; init; }
    public string? Description { get; init; }
}