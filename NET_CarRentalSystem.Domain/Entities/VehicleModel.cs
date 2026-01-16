using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleModel : BaseEntity<Guid>, IRowVersion
{
    public int Mileage { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public VehicleStatus Status { get; set; }
    
    public DateTime? LastAvailableAt { get; set; }

    public string? ConditionNotes { get; set; }
    
    public string? RealTimeLocation { get; set; }
    
    public Guid? LocationId { get; set; }

    public Guid VehicleId { get; set; }

    public byte[] RowVersion { get; set; } = [];
    
    public virtual Vehicle Vehicle { get; set; } = default!;
    
    public virtual Location? Location { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = [];
}