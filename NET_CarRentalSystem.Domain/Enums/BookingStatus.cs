namespace NET_CarRentalSystem.Domain.Enums;

public enum BookingStatus
{
    Pending = 1,          // Đang chờ thanh toán cọc
    DepositPaid,          // Đã thanh toán cọc
    Confirmed,            // Đã xác nhận
    InProgress,           // Đang trong chuyến đi
    Completed,            // Hoàn thành
    Cancelled,            // Đã hủy
    Expired,              // Hết hạn thanh toán
    Returned,             // Đã trả xe  
}

