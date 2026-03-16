namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class EkycMessage
{
    public static class Verify
    {
        public const string Success = "Xác thực danh tính thành công";
        public const string UserNotFound = "Không tìm thấy thông tin người dùng";
        public const string AlreadyVerified = "Tài khoản đã được xác thực trước đó";
        public const string CccdAlreadyUsed = "CCCD đã được sử dụng bởi tài khoản khác";
        public const string UploadFrontFailed = "Upload ảnh mặt trước thất bại";
        public const string UploadBackFailed = "Upload ảnh mặt sau thất bại";
        public const string UploadSelfieFailed = "Upload ảnh chân dung thất bại";
        public const string OcrFailed = "Không thể đọc thông tin từ giấy tờ";
        public const string FaceNotMatch = "Khuôn mặt không khớp";
        public const string CardNotReal = "Giấy tờ không hợp lệ hoặc là ảnh chụp lại";
        public const string FaceNotReal = "Ảnh chân dung không hợp lệ hoặc không phải người thật";
        public const string Failed = "Xác thực không thành công";
        public const string SystemError = "Lỗi hệ thống khi xác thực";
    }

    public static class DriverLicense
    {
        public const string Success = "Xác thực giấy phép lái xe thành công";
        public const string IdentityNotVerified = "Vui lòng xác thực CCCD trước khi xác thực giấy phép lái xe";
        public const string AlreadyVerified = "Giấy phép lái xe đã được xác thực trước đó";
        public const string UploadFailed = "Upload ảnh giấy phép lái xe thất bại";
        public const string OcrFailed = "Không thể đọc thông tin từ giấy phép lái xe";
        public const string NoSelfieFound = "Không tìm thấy ảnh chân dung để so sánh";
        public const string FaceComparisonFailed = "Khuôn mặt trên GPLX không khớp với ảnh chân dung";
        public const string SystemError = "Lỗi hệ thống khi xác thực giấy phép lái xe";
    }
}
