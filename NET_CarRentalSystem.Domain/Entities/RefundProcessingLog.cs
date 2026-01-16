using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

/// <summary>
/// Lưu trữ log xử lý hoàn tiền cho mục đích audit, retry tracking, và manual intervention
/// </summary>
#pragma warning disable CS8618
public class RefundProcessingLog : BaseEntity<Guid>
{
    /// <summary>FK đến RefundRequest</summary>
    public Guid RefundRequestId { get; set; }

    /// <summary>Chi tiết lỗi khi xử lý</summary>
    public string ErrorMessage { get; set; } = string.Empty;

    /// <summary>Stack trace để debug</summary>
    public string? StackTrace { get; set; }

    /// <summary>Số lần đã retry</summary>
    public int RetryCount { get; set; }

    /// <summary>Trạng thái xử lý (RetryScheduled, ManualInterventionRequired, ResolvedManually, Cancelled)</summary>
    public RefundProcessingLogStatus Status { get; set; }

    /// <summary>Lần xử lý cuối cùng</summary>
    public DateTime LastAttemptAt { get; set; }

    /// <summary>Admin notes khi resolve thủ công</summary>
    public string? ResolutionNotes { get; set; }

    /// <summary>Admin ID nếu được resolve thủ công</summary>
    public Guid? ResolvedBy { get; set; }

    /// <summary>Thời gian resolve</summary>
    public DateTime? ResolvedAt { get; set; }

    // Navigation
    public RefundRequest? RefundRequest { get; set; }
}
#pragma warning restore CS8618




