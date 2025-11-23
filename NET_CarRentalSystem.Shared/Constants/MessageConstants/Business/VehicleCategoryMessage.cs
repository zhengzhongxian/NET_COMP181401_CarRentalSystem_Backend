namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class VehicleCategoryMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách loại xe thành công.";
        public const string NotFound = "Không tìm thấy loại xe này.";
        public const string Error = "Đã xảy ra lỗi khi lấy danh sách loại xe.";
    }

    public static class Create
    {
        public const string Success = "Tạo mới loại xe thành công.";
        public const string Error = "Lỗi trong quá trình tạo mới loại xe.";
    }

    public static class Update
    {
        public const string Success = "Cập nhật loại xe thành công.";
        public const string Error = "Lỗi trong quá trình cập nhật loại xe.";
        public const string NotFound = "Không tìm thấy loại xe.";
    }

    public static class Delete
    {
        public const string Success = "Xóa loại xe thành công.";
        public const string Error = "Lỗi trong quá trình xóa loại xe.";
        public const string NotFound = "Không tìm thấy loại xe.";
    }
}
