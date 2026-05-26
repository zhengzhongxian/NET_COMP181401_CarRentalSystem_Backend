namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class ImpersonationMessage
{
    public static class Grant
    {
        public const string Success = "Đã tạo phiên điều khiển từ xa thành công.";
        public const string Error = "Có lỗi xảy ra khi tạo phiên điều khiển từ xa.";
        public const string FeatureDisabled = "Tính năng điều khiển từ xa hiện đang tắt.";
    }

    public static class Activate
    {
        public const string Success = "Kích hoạt phiên điều khiển thành công.";
        public const string Error = "Có lỗi xảy ra khi kích hoạt phiên điều khiển.";
        public const string InvalidToken = "Token điều khiển không hợp lệ hoặc đã hết hạn.";
        public const string TokenExpired = "Token điều khiển đã hết hạn.";
    }

    public static class Revoke
    {
        public const string Success = "Đã thu hồi quyền điều khiển từ xa thành công.";
        public const string Error = "Có lỗi xảy ra khi thu hồi quyền điều khiển.";
        public const string NotFound = "Không tìm thấy phiên điều khiển này.";
    }

    public static class DevLogs
    {
        public const string Error = "Có lỗi xảy ra khi truy vấn nhật ký hệ thống.";
    }

    public static class User
    {
        public const string InvalidAdmin = "Không xác định được người dùng quản trị hiện tại.";
    }

    public static class DevCode
    {
        public const string Success = "Tạo mã developer thành công.";
        public const string UserNotFound = "Không tìm thấy thông tin định danh người dùng.";
        public const string CodeExists = "Bạn đã có một mã developer đang hoạt động. Hãy xóa mã cũ trước.";
        public const string DeleteSuccess = "Đã xóa mã developer thành công.";
        public const string NotFound = "Không tìm thấy mã developer đang hoạt động.";
        public const string Invalid = "Mã developer không tồn tại hoặc đã hết hạn.";
        public const string InvalidData = "Dữ liệu mã developer không hợp lệ.";
        public const string GenerateError = "Không thể tạo mã developer.";
        public const string DeleteError = "Không thể xóa mã developer.";
        public const string GetError = "Không thể lấy thông tin mã developer.";
        public const string GetSuccess = "Lấy thông tin mã developer thành công.";
    }

    public static class Session
    {
        public const string ActiveExists = "Bạn đã có một phiên điều khiển đang hoạt động. Vui lòng thu hồi nó trước khi tạo mới.";
        public const string GetError = "Không thể lấy thông tin phiên điều khiển hoạt động.";
        public const string GetSuccess = "Lấy thông tin phiên điều khiển thành công.";
        public const string ActiveNotFound = "Không có phiên điều khiển nào đang hoạt động.";
    }
}
