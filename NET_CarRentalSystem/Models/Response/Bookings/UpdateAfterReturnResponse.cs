namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class UpdateAfterReturnResponse
{
    public bool Success { get; set; }
    
    public string Message { get; set; } = default!;
    
    public int ViolationCount { get; set; }
    
    public List<ViolationInfo>? Violations { get; set; }
}

public class ViolationInfo
{
    public Guid ViolationId { get; set; }
    
    public string ViolationType { get; set; } = default!;
    
    public string Description { get; set; } = default!;
    
    public decimal Amount { get; set; }
    
    public string Status { get; set; } = default!;
}

