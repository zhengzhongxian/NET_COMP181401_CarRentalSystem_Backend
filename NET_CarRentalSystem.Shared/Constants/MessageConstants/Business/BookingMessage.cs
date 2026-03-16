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
        public const string VehicleNotFound = "Không tìm thấy xe yêu cầu.";
        public const string InvalidDate = "Thời gian thuê không hợp lệ.";
        public const string CustomerNotFound = "Không tìm thấy thông tin khách hàng.";
        public const string CustomerNotExists = "Khách hàng không tồn tại trong hệ thống.";
        public const string InvalidLocation = "Địa điểm lấy xe không hợp lệ.";
        public const string NoVehicleAtLocation = "Không còn xe available tại chi nhánh này.";
        public const string AlreadyHasActiveBooking = "Bạn đã có đơn đặt xe đang hoạt động. Vui lòng hoàn tất đơn hiện tại trước khi đặt xe mới.";
        public const string MustAcceptTerms = "Bạn phải đọc và chấp nhận điều khoản sử dụng trước khi đặt xe.";
        public const string InvalidInsurance = "Một hoặc nhiều gói bảo hiểm không hợp lệ.";
        public const string PaymentBeingProcessed = "Giao dịch thanh toán của bạn đang được xử lý. Vui lòng thử lại sau ít phút.";
        public const string DriverLicenseExpired = "Giấy phép lái xe của bạn đã hết hạn. Vui lòng cập nhật GPLX mới.";
        public const string DriverLicenseClassRequired = "Bạn cần có giấy phép lái xe để đặt loại xe này.";
        public const string DriverLicenseClassInsufficient = "Hạng giấy phép lái xe của bạn không đủ yêu cầu để đặt loại xe này.";
    }
    
    public static class FinalPayment
    {
        public const string Success = "Tạo thanh toán phần còn lại thành công.";
        public const string BookingNotFound = "Không tìm thấy đơn đặt xe.";
        public const string BookingCancelled = "Đơn đặt xe đã bị hủy. Không thể tiếp tục thanh toán.";
        public const string InvalidBookingStatus = "Đơn đặt xe không ở trạng thái chờ nhận xe (phải đã thanh toán cọc).";
        public const string TransactionNotFound = "Không tìm thấy giao dịch thanh toán cuối.";
        public const string RegenerateSuccess = "Lấy lại thông tin thanh toán thành công.";
        public const string BookingInProgress = "Không thể xuất lại QR khi đơn đặt xe đang trong quá trình thuê.";
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
        public const string MileageLessThanStart = "Số km kết thúc phải lớn hơn số km bắt đầu";
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

    public static class AiVerification
    {
        // License Plate OCR
        public const string LicensePlateMismatch = "Biển số trong ảnh ({0}) không khớp với biển số xe ({1}). Vui lòng kiểm tra lại.";
        public const string LicensePlatePickupReturnMismatch = "Biển số lúc nhận xe ({0}) không khớp với biển số lúc trả xe ({1}). Vui lòng kiểm tra lại.";
        
        // Vehicle image verification
        public const string NotVehicleImage = "Ảnh không hợp lệ: {0} không phải là ảnh xe. Vui lòng tải lên ảnh xe hợp lệ.";
        
        // Skip messages
        public const string SkipLicensePlate = "Bỏ qua xác thực biển số: {0}";
        public const string SkipDamageDetection = "Bỏ qua kiểm tra hư hỏng: {0}";
    }
}
