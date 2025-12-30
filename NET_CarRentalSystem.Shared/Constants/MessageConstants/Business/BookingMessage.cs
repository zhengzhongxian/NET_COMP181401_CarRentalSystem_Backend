namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class BookingMessage
{
    public static class Create
    {
        public const string Success = "Tạo đơn đặt xe thành công.";
        public const string Failed = "Tạo đơn đặt xe thất bại.";
        public const string VehicleNotFound = "Không tìm thấy xe yêu cầu.";
        public const string VehicleNotAvailable = "Xe hiện không khả dụng để cho thuê.";
        public const string InvalidDate = "Thời gian thuê không hợp lệ.";
    }
}
