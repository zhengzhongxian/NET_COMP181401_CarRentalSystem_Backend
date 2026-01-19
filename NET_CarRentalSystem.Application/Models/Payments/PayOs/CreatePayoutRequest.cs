namespace NET_CarRentalSystem.Application.Models.Payments.PayOs;

/// <summary>
/// Request model để tạo yêu cầu chi hộ (Payout) qua PayOS
/// Dùng để refund tiền cho khách hàng
/// </summary>
public class CreatePayoutRequest
{
    /// <summary>
    /// ID tham chiếu (Reference ID) để tracking, nên dùng RefundRequestId
    /// </summary>
    public required string ReferenceId { get; set; }

    /// <summary>
    /// Số tiền chi hộ (VND)
    /// </summary>
    public required long Amount { get; set; }

    /// <summary>
    /// Mô tả giao dịch (VD: "Hoàn tiền đơn đặt xe #ABC123")
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// Mã ngân hàng người nhận tiền (VD: "970415" cho Vietinbank)
    /// </summary>
    public required string ToBin { get; set; }

    /// <summary>
    /// Số tài khoản người nhận tiền
    /// </summary>
    public required string ToAccountNumber { get; set; }

    /// <summary>
    /// Transaction code để lấy thông tin tài khoản đã thanh toán (optional)
    /// </summary>
    public long? TransactionCode { get; set; }
}

