namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class RoleMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách vai trò thành công.";
        public const string NotFound = "Không tìm thấy vai trò.";
        public const string Error = "Có lỗi xảy ra khi lấy danh sách vai trò.";
    }

    public static class Create
    {
        public const string Success = "Tạo vai trò thành công.";
        public const string AlreadyExists = "Vai trò đã tồn tại.";
        public const string Error = "Có lỗi xảy ra khi tạo vai trò.";
    }

    public static class Update
    {
        public const string Success = "Cập nhật vai trò thành công.";
        public const string NotFound = "Không tìm thấy vai trò.";
        public const string AlreadyExists = "Tên vai trò đã tồn tại.";
        public const string Error = "Có lỗi xảy ra khi cập nhật vai trò.";
    }

    public static class Delete
    {
        public const string Success = "Xóa vai trò thành công.";
        public const string NotFound = "Không tìm thấy vai trò.";
        public const string HasUsers = "Không thể xóa vai trò vì có người dùng đang sử dụng.";
        public const string HasClaims = "Không thể xóa vai trò vì có quyền đang gán. Vui lòng xóa quyền trước.";
        public const string Error = "Có lỗi xảy ra khi xóa vai trò.";
    }

    public static class Claim
    {
        public const string GetSuccess = "Lấy danh sách quyền thành công.";
        public const string CreateSuccess = "Thêm quyền thành công.";
        public const string UpdateSuccess = "Cập nhật quyền thành công.";
        public const string DeleteSuccess = "Xóa quyền thành công.";
        public const string NotFound = "Không tìm thấy quyền.";
        public const string AlreadyExists = "Quyền đã tồn tại cho vai trò này.";
        public const string InvalidPermission = "Quyền không hợp lệ.";
        public const string Error = "Có lỗi xảy ra khi xử lý quyền.";
    }

    public static class Permission
    {
        public const string GetSuccess = "Lấy danh sách permission thành công.";
        public const string Error = "Có lỗi xảy ra khi lấy danh sách permission.";
    }
}

