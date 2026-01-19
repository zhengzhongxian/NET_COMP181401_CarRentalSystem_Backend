namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class BookingMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách đơn đặt xe thành công.";
        public const string Error = "Lỗi khi lấy danh sách đơn đặt xe.";
        public const string DetailSuccess = "Lấy chi tiết đơn đặt xe thành công.";
        public const string NotFound = "Không tìm thấy đơn đặt xe.";
    }
    
    public static class Create
    {
        public const string Success = "Tạo đơn đặt xe thành công.";
        public const string Failed = "Tạo đơn đặt xe thất bại.";
        public const string VehicleNotFound = "Không tìm thấy xe yêu cầu.";
        public const string VehicleNotAvailable = "Xe hiện không khả dụng để cho thuê.";
        public const string InvalidDate = "Thời gian thuê không hợp lệ.";
        public const string CustomerNotFound = "Không tìm thấy thông tin khách hàng.";
        public const string CustomerNotExists = "Khách hàng không tồn tại trong hệ thống.";
        public const string InvalidLocation = "Địa điểm lấy xe không hợp lệ.";
        public const string NoVehicleAtLocation = "Không còn xe available tại chi nhánh này.";
        public const string AlreadyHasActiveBooking = "Bạn đã có đơn đặt xe đang hoạt động. Vui lòng hoàn tất đơn hiện tại trước khi đặt xe mới.";
        public const string MustAcceptTerms = "Bạn phải đọc và chấp nhận điều khoản sử dụng trước khi đặt xe.";
        public const string InvalidInsurance = "Một hoặc nhiều gói bảo hiểm không hợp lệ.";
        public const string PaymentBeingProcessed = "Giao dịch thanh toán của bạn đang được xử lý. Vui lòng thử lại sau ít phút.";
    }
    
    public static class FinalPayment
    {
        public const string Success = "Tạo thanh toán phần còn lại thành công.";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe.";
        public const string BookingCancelled = "Đơn đặt xe đã bị hủy. Không thể tiếp tục thanh toán.";
        public const string InvalidBookingStatus = "Đơn đặt xe không ở trạng thái chờ nhận xe (phải đã thanh toán cọc).";
    }
    
    public static class SwapVehicleModel
    {
        public const string Success = "Đổi xe thành công.";
        public const string Error = "Lỗi khi đổi xe.";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe.";
        public const string InvalidBookingStatus = "Chỉ có thể đổi xe khi đơn đặt xe ở trạng thái đã thanh toán cọc.";
        public const string VehicleModelNotFound = "Không tìm thấy xe model mới.";
        public const string VehicleModelNotAvailable = "Xe model mới không khả dụng.";
        public const string VehicleModelNotSameVehicle = "Xe model mới phải cùng loại xe với xe đã đặt.";
        public const string OldVehicleModelNotFound = "Không tìm thấy xe model cũ.";
    }

    public static class Cancel
    {
        public const string Success = "Hủy đơn đặt xe thành công.";
        public const string SuccessWithRefundRequest = "Hủy đơn đặt xe thành công. Yêu cầu hoàn tiền đã được gửi đến admin để xét duyệt.";
        public const string SuccessNoRefund = "Hủy đơn đặt xe thành công. Do đã quá thời hạn hoàn tiền, tiền cọc sẽ không được hoàn trả.";
        public const string Error = "Lỗi khi hủy đơn đặt xe.";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe.";
        public const string NotYourBooking = "Bạn không có quyền hủy đơn đặt xe này.";
        public const string InvalidBookingStatus = "Chỉ có thể hủy đơn đặt xe ở trạng thái đã thanh toán cọc.";
        public const string AlreadyCancelled = "Đơn đặt xe đã bị hủy trước đó.";
        public const string CancellationReasonRequired = "Vui lòng cung cấp lý do hủy đơn.";
        public const string MaxCancellationsReached = "Bạn đã vượt quá số lần hủy tối đa trong tháng ({0} lần). Vui lòng thử lại vào tháng sau.";
    }
    
    public static class CreateWithCancellationLimit
    {
        public const string MaxCancellationsReached = "Bạn đã vượt quá số lần hủy tối đa trong tháng. Không thể tạo đơn đặt xe mới.";
    }

    public static class GenerateContract
    {
        public const string Success = "Hợp đồng đã được tạo thành công.";
        public const string Error = "Lỗi khi tạo hợp đồng.";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe.";
        public const string InvalidStatus = "Chỉ có thể tạo hợp đồng cho đơn đặt xe đã đặt cọc.";
        public const string AlreadyGenerated = "Hợp đồng đã được tạo trước đó.";
    }

    public static class ExportContract
    {
        public const string Success = "Xuất hợp đồng thành công.";
        public const string Error = "Lỗi khi xuất hợp đồng.";
        public const string FileNotFound = "Không tìm thấy file hợp đồng.";
        public const string InvalidFileName = "Tên file không hợp lệ.";
    }

    public static class UpdateFinalPayment
    {
        public const string Success = "Cập nhật thành công";
        public const string Error = "Có lỗi xảy ra trong quá trình cập nhật";
    }

    public static class Return
    {
        public const string InvalidToken = "Mã QR không hợp lệ.";
        public const string Unauthorized = "Bạn chưa đăng nhập.";
        public const string Expired = "Mã QR đã hết hạn.";
        public const string CustomerNotFound = "Không tìm thấy khách hàng.";
        public const string BookingNotFound = "Không tìm thấy lịch thuê đang chạy.";
        public const string Success = "Trả xe thành công.";
    }

    public static class UpdateAfterReturn
    {
        public const string Success = "Cập nhật thông tin xe sau khi trả thành công";
        public const string SuccessWithViolations = "Cập nhật thông tin xe thành công. Phát hiện {0} vi phạm. Email thông báo đã được gửi đến khách hàng.";
        public const string Error = "Có lỗi xảy ra khi cập nhật thông tin xe";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe";
        public const string InvalidStatus = "Đơn đặt xe không ở trạng thái đã trả xe";
        public const string AlreadyUpdated = "Thông tin xe đã được cập nhật trước đó";
        public const string InvalidFuelLevel = "Mức nhiên liệu không hợp lệ";
        public const string InvalidMileage = "Số km không hợp lệ";
        public const string MileageLessThanStart = "Số km kết thúc phải lớn hơn số km bắt đầu";
        public const string ImagesRequired = "Vui lòng tải lên ít nhất 4 ảnh xe khi trả";
    }

    public static class CompleteBooking
    {
        public const string Success = "Hoàn thành đơn đặt xe thành công. Khách hàng đã được cộng {0} điểm thưởng.";
        public const string Error = "Có lỗi xảy ra khi hoàn thành đơn đặt xe";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe";
        public const string InvalidStatus = "Đơn đặt xe không ở trạng thái đã trả xe";
        public const string HasUnresolvedViolations = "Không thể hoàn thành đơn đặt xe khi còn vi phạm chưa giải quyết";
        public const string AlreadyCompleted = "Đơn đặt xe đã được hoàn thành trước đó";
    }
}
