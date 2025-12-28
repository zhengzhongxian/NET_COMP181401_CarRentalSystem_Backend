namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class CreateVehicleRequest
{
    public required string NumberPlate { get; set; } = default!;

    public required string Manufacturer { get; set; } =  default!;

    public required string Model { get; set; } =  default!;

    public string? Color { get; set; } =  default!;

    public int Mileage { get; set; } =  default!;

    public decimal PricePerHour { get; set; } =  default!;

    public string? Description { get; set; } =  default!;

    public float Rating { get; set; } = default!;

    public string? ConditionNotes { get; set; } =  default!;

    public string? RealTimeLocation { get; set; } = default!;

    public Guid? LocationId { get; set; } =  default!;

    public Guid? VehicleCategoryId { get; set; } =  default!;

    public Guid? FuelId { get; set; } =  default!;

    public Guid? TransmissionId { get; set; } =  default!;

    public string? Metadata { get; set; } =  default!;

    public IFormFile? ThumbnailFile { get; set; } =  default!;
}
