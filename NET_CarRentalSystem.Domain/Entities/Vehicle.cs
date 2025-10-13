using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Domain.Entities;

public class Vehicle : BaseEntity
{
    public Guid VehicleId { get; set; }

    public string NumberPlate { get; set; }

    public string Manufacturer { get; set; }

    public string Model { get; set; }

    public string? Color { get; set; }

    public int Mileage { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public DateTime? LastCheckoutAt { get; set; }

    public float Rating { get; set; }

    public VehicleStatus Status { get; set; }

    public string? ConditionNotes { get; set; }

    public string? RealTimeLocation { get; set; }

    public int? LocationId { get; set; }

    public string? Metadata { get; set; }

    // Foreign Keys
    public Guid? VehicleCategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? TransmissionId { get; set; }

    // Navigation Properties
    public virtual VehicleCategory? VehicleCategory { get; set; }

    public virtual Fuel? Fuel { get; set; }

    public virtual Transmission? Transmission { get; set; }
}