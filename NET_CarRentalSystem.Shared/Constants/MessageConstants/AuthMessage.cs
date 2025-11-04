namespace NET_CarRentalSystem.Shared.Constants.MessageConstants;

public static class AuthMessage
{
    public static class Login
    {
        public const string Error = "Có lỗi xảy ra khi đăng nhập";
        public const string Failed = "Tên đăng nhập hoặc mật khẩu không đúng";
        public const string Success = "Đăng nhập thành công";
        public const string LogoutSuccess = "Đăng xuất thành công.";
        public const string Banned = "Tài khoản của bạn đã bị cấm.";

    }

    public static class Logout
    {
        public const string Success = "Đăng xuất thành công";
        public const string Error = "Có lỗi xảy ra khi đăng xuất";
    }

    public static class RefreshToken
    {
        public const string Error = "Có lỗi xảy ra khi làm mới access token";
        public const string Invalid = "Refresh token không hợp lệ hoặc đã hết hạn.";
        public const string Success = "Access token đã được làm mới thành công.";
    }

    public static class LogoutSession
    {
        public const string Success = "Phiên đã được đăng xuất thành công.";
        public const string NotFound = "Không tìm thấy phiên đăng nhập.";
        public const string Error = "Có lỗi khi đăng xuất phiên";
    }

    public static class Authorization
    {
        public const string Unauthorized = "Truy cập không được phép.";
    }


    public static class LogoutAllOtherSessions
    {
        public const string Success = "Đăng xuất khỏi tất cả các thiết bị khác thành công.";
        public const string Error = "Lỗi khi đăng xuất khỏi các thiết bị khác.";
    }


    public static class GetSessions
    {
        public const string Success = "Lấy danh sách phiên hoạt động thành công.";
        public const string Error = "Lỗi khi lấy danh sách phiên hoạt động.";
    }

    public static class User
    {
        public const string NotValid = "Thông tin người dùng không hợp lệ";
    }
}