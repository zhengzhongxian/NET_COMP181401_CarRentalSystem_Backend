namespace NET_CarRentalSystem.Domain.Enums;

public enum VehicleStatus
{
    Available,      // Sẵn sàng cho thuê
    Rented,         // Đang được thuê
    InMaintenance,  // Đang bảo trì
    Unavailable     // Không khả dụng (vì lý do khác)
}