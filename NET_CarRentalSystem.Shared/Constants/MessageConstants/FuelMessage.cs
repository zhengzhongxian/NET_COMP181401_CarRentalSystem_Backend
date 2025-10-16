namespace NET_CarRentalSystem.Shared.Constants.MessageConstants;

public static class FuelMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách nhiên liệu thành công.";
        public const string NotFound = "Không tìm thấy loại nhiên liệu này.";
    }

    public static class Post
    {
        public const string Success = "Tạo mới loại nhiên liệu thành công.";
        public const string Failed = "Tạo mới loại nhiên liệu thất bại.";
    }
}
