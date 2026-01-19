namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class ViolationMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách vi phạm thành công";
        public const string DetailSuccess = "Lấy chi tiết vi phạm thành công";
        public const string NotFound = "Không tìm thấy vi phạm";
        public const string Error = "Có lỗi xảy ra khi lấy danh sách vi phạm";
    }

    public static class Create
    {
        public const string Success = "Tạo vi phạm thành công";
        public const string Error = "Có lỗi xảy ra khi tạo vi phạm";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe";
        public const string InvalidBookingStatus = "Trạng thái đơn đặt xe không hợp lệ để tạo vi phạm";
    }

    public static class CreatePaymentLink
    {
        public const string Success = "Tạo link thanh toán vi phạm thành công";
        public const string Error = "Có lỗi xảy ra khi tạo link thanh toán vi phạm";
        public const string ViolationNotFound = "Không tìm thấy vi phạm";
        public const string InvalidViolationType = "Loại vi phạm không hỗ trợ thanh toán online";
        public const string InvalidStatus = "Trạng thái vi phạm không hợp lệ để tạo link thanh toán";
        public const string AlreadyPaid = "Vi phạm đã được thanh toán";
    }

    public static class Resolve
    {
        public const string Success = "Giải quyết vi phạm thành công";
        public const string Error = "Có lỗi xảy ra khi giải quyết vi phạm";
        public const string NotFound = "Không tìm thấy vi phạm";
        public const string InvalidStatus = "Trạng thái vi phạm không hợp lệ để giải quyết";
        public const string UnpaidViolations = "Còn vi phạm chưa thanh toán";
    }

    public static class Email
    {
        public const string SendSuccess = "Gửi email thông báo vi phạm thành công";
        public const string SendError = "Có lỗi xảy ra khi gửi email thông báo vi phạm";
    }
}

