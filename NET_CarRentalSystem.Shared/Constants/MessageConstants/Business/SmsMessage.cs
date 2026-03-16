namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class SmsMessage
{
    public static class SendOtp
    {
        public const string Success = "Mã OTP đã được gửi tới số điện thoại của bạn";

        public const string Error = "Có lỗi xảy ra khi gửi mã OTP";

        public const string MaxAttemptsReached = "Bạn đã vượt quá số lần gửi OTP trong ngày. Vui lòng thử lại sau";

        public const string InvalidPhoneNumber = "Số điện thoại không hợp lệ";

        public const string AlreadyVerified = "Số điện thoại đã được xác thực";

        public const string UserNotFound = "Không tìm thấy thông tin người dùng";
    }

    public static class VerifyOtp
    {
        public const string Success = "Xác thực số điện thoại thành công";

        public const string Error = "Có lỗi xảy ra khi xác thực OTP";

        public const string InvalidOtp = "Mã OTP không đúng";

        public const string ExpiredOtp = "Mã OTP đã hết hạn";

        public const string OtpNotFound = "Không tìm thấy mã OTP, vui lòng gửi lại";
    }
}
