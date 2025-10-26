namespace NET_CarRentalSystem.Shared.Constants.MessageConstants;

public static class VehicleMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách phương tiện thành công.";
        public const string NotFound = "Không tìm thấy phương tiện này.";
        public const string Error = "Đã xảy ra lỗi khi lấy danh sách phương tiện.";
    }

    public static class Post
    {
        public const string Success = "Tạo mới phương tiện thành công.";
        public const string Failed = "Tạo mới phương tiện thất bại.";
    }
}
