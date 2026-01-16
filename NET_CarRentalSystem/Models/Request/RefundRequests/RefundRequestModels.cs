namespace NET_CarRentalSystem.API.Models.Request.RefundRequests;

public class ApproveRefundRequest
{
    public string? AdminNotes { get; set; }
}

public class RejectRefundRequest
{
    public required string AdminNotes { get; set; }
}

