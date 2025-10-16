using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Booking : BaseEntity
{
    public Guid BookingId { get; set; }

    public Guid CustomerId { get; set; }

    public Guid VehicleId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    public decimal LatePenaltyRatio { get; set; }

    public decimal DepositRatio { get; set; }

    public decimal TotalPrice { get; set; }

    public int MileageStart { get; set; }

    public int? FuelLevelEnd { get; set; }

    public decimal? FuelPrice { get; set; }

    public string? ConditionNotes { get; set; }

    public Guid PickupLocationId { get; set; }

    public Guid? ReturnLocationId { get; set; }

    public virtual Vehicle Vehicle { get; set; }

    public virtual Location PickupLocation { get; set; }

    public virtual Location? ReturnLocation { get; set; }
}
