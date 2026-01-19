namespace NET_CarRentalSystem.Domain.Enums;

public enum ViolationStatus
{
    Pending = 1,           // Chờ xử lý
    PaymentPending = 2,    // Chờ thanh toán (đã tạo link thanh toán)
    Paid = 3,              // Đã thanh toán
    Resolved = 4           // Đã giải quyết (không cần thanh toán hoặc đã xử lý xong)
}