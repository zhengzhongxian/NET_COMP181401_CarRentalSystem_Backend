namespace NET_CarRentalSystem.Application.Models.Payments.PayOs;

/// <summary>
/// Response model từ PayOS khi tạo yêu cầu chi hộ (Payout)
/// Dựa trên PayOS.Models.V1.Payouts.Payout
/// </summary>
public class CreatePayoutResponse
{
    /// <summary>
    /// ID của yêu cầu chi hộ từ PayOS
    /// </summary>
    public string Id { get; set; } = "";

    /// <summary>
    /// ID tham chiếu
    /// </summary>
    public string ReferenceId { get; set; } = "";

    /// <summary>
    /// Danh sách transactions (chi tiết chuyển khoản)
    /// </summary>
    public List<PayoutTransactionDto>? Transactions { get; set; }

    /// <summary>
    /// Trạng thái phê duyệt (ApprovalState)
    /// </summary>
    public string ApprovalState { get; set; } = "";

    /// <summary>
    /// Thời gian tạo yêu cầu
    /// </summary>
    public string CreatedAt { get; set; } = "";
}

/// <summary>
/// Chi tiết transaction trong payout
/// </summary>
public class PayoutTransactionDto
{
    public string Id { get; set; } = "";
    
    public string ReferenceId { get; set; } = "";
    
    public long Amount { get; set; }
    
    public string Description { get; set; } = "";
    
    public string ToBin { get; set; } = "";
    
    public string ToAccountNumber { get; set; } = "";
    
    public string? ToAccountName { get; set; }
    
    public string? Reference { get; set; }
    
    public string? TransactionDatetime { get; set; }
    
    public string? ErrorMessage { get; set; }
    
    public string? ErrorCode { get; set; }
    
    public string State { get; set; } = "";
}

