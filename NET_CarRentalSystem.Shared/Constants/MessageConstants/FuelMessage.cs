namespace NET_CarRentalSystem.Shared.Constants.MessageConstants;

public static class FuelMessage
{
    
    public static class Get
    {
        public const string Success = "Lấy danh sách nhiên liệu thành công.";
        public const string NotFound = "Không tìm thấy loại nhiên liệu này.";
        public const string Error = "Đã xảy ra lỗi khi lấy danh sách nhiên liệu.";
    }

    public static class Post
    {
        public const string Success = "Tạo mới loại nhiên liệu thành công.";
        public const string Error = "Lỗi trong quá trình tạo mới nhiên liệu.";
    }

    public static class Update
    {
        public const string Success = "Cập nhật loại nhiên liệu thành công.";
        public const string Error = "Lỗi trong quá trình cập nhật nhiên liệu.";
        public const string NotFound = "Không tìm thấy loại nhiên liệu.";
    }

    public static class Delete
    {
        public const string Success = "Xóa loại nhiên liệu thành công.";
        public const string Failed = "Xóa loại nhiên liệu thất bại.";
        public const string Error = "Lỗi trong quá trình xóa nhiên liệu.";
        public const string NotFound = "Không tìm thấy loại nhiên liệu.";
    }
}
