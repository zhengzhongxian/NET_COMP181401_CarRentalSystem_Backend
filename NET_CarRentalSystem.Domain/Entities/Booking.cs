using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Booking : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public Guid PickupLocationId { get; set; }
    
    public Guid? ReturnLocationId { get; set; }

    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public DateTime? ActualEndDate { get; set; }

    public decimal TotalPrice { get; set; }
    
    public decimal DepositRatio { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }

    public int MileageStart { get; set; }
    
    public int? FuelLevelEnd { get; set; }
    
    public decimal? FuelPrice { get; set; }

    public string? ConditionNotes { get; set; }
    
    public string? Description { get; set; }

    public byte[] RowVersion { get; set; } = [];
    
    public virtual Customer Customer { get; set; } = default!;
    
    public virtual Vehicle Vehicle { get; set; } = default!;
    
    public virtual Location PickupLocation { get; set; } = default!;
    
    public virtual Location? ReturnLocation { get; set; }
    
    public virtual ICollection<PaymentTransaction> Transactions { get; set; } = new List<PaymentTransaction>();
}