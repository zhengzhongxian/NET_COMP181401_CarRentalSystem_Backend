namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class TransmissionMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách hộp số thành công.";
        public const string NotFound = "Không tìm thấy loại hộp số.";
        public const string Error = "Đã xảy ra lỗi khi lấy danh sách hộp số.";
    }

    public static class Create
    {
        public const string Success = "Tạo mới loại hộp số thành công.";
        public const string Error = "Lỗi trong quá trình tạo mới loại hộp số.";
    }

    public static class Update
    {
        public const string Success = "Cập nhật loại hộp số thành công.";
        public const string Error = "Lỗi trong quá trình cập nhật loại hộp số.";
        public const string NotFound = "Không tìm thấy loại hộp số.";
    }

    public static class Delete
    {
        public const string Success = "Xóa loại hộp số thành công.";
        public const string Error = "Lỗi trong quá trình xóa loại hộp số.";
        public const string NotFound = "Không tìm thấy loại hộp số.";
    }
}

