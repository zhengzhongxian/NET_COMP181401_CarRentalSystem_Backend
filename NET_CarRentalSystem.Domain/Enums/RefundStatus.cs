namespace NET_CarRentalSystem.Domain.Enums;

public enum RefundStatus
{
    Pending,
    ReadyToProcess,   // Đã đến hạn, chờ 24h để admin can thiệp
    OnHold,           // Tạm giữ do có vi phạm chưa giải quyết
    Approved,
    Rejected,
    Processed,
    Failed
}

