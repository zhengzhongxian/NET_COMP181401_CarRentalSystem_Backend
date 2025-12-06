namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class VehicleMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách phương tiện thành công.";
        public const string DetailSuccess = "Lấy chi tiết phương tiện thành công.";
        public const string NotFound = "Xe không tồn tại";
        public const string Error = "Đã xảy ra lỗi khi lấy danh sách phương tiện.";
    }

    public static class Create
    {
        public const string Success = "Tạo phương tiện thành công.";
        public const string Error = "Đã xảy ra lỗi khi tạo phương tiện.";
    }

    public static class Update
    {
        public const string Success = "Cập nhật phương tiện thành công.";
        public const string NotFound = "Xe không tồn tại";
        public const string Error = "Đã xảy ra lỗi khi cập nhật phương tiện.";
    }

    public static class Delete
    {
        public const string Success = "Xóa phương tiện thành công.";
        public const string NotFound = "Xe không tồn tại";
        public const string Error = "Đã xảy ra lỗi khi xóa phương tiện.";
    }

    public static class UpdateImage
    {
        public const string Success = "Cập nhật ảnh xe thành công";
        public const string Error = "Đã xảy ra lỗi khi cập nhật ảnh xe";
        public const string NotFound = "Không tìm thấy xe để cập nhật ảnh";
    }

    public static class AddImages
    {
        public const string Success = "Thêm danh sách ảnh xe thành công";
        public const string Error = "Đã xảy ra lỗi khi thêm danh sách ảnh xe";
        public const string NotFound = "Không tìm thấy xe để thêm ảnh";
    }
    
    public static class AddAttributes
    {
        public const string Success = "Thêm thuộc tính xe thành công.";
        public const string Error = "Có lỗi xảy ra khi thêm thuộc tính xe.";
        public const string NotFound = "Không tìm thấy xe để thêm thuộc tính.";
    }
    public static class DeleteImages
    {
        public const string Success = "Xóa danh sách ảnh xe thành công";
        public const string Error = "Đã xảy ra lỗi khi xóa danh sách ảnh xe";
        public const string NotFound = "Không tìm thấy xe hoặc ảnh để xóa";
    }

    public static class UpdateAttribute
    {
        public const string Success = "Cập nhật thuộc tính xe thành công";
        public const string Error = "Đã xảy ra lỗi khi cập nhật thuộc tính xe";
        public const string NotFound = "Không tìm thấy xe hoặc thuộc tính để cập nhật";
    }

    public static class DeleteAttribute
    {
        public const string Success = "Xóa thuộc tính xe thành công";
        public const string Error = "Đã xảy ra lỗi khi xóa thuộc tính xe";
        public const string NotFound = "Không tìm thấy xe hoặc thuộc tính để xóa";
    }
}

