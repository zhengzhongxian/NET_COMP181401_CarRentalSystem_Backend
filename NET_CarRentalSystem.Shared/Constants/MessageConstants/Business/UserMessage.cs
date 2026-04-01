namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class UserMessage
{
    public const string NotFound = "Không tìm thấy người dùng";
    public const string UpdateStatusSuccess = "Cập nhật trạng thái người dùng thành công";
    public const string UpdateStatusError = "Có lỗi xảy ra khi cập nhật trạng thái người dùng";
    public const string NotAllowedToBlockAdmin = "Không thể khóa tài khoản quản trị viên";
    public const string UpdatePhoneError = "Số điện thoại này đã được sử dụng bởi người dùng khác";

    public static class Get
    {
        public const string Success = "Lấy danh sách người dùng thành công.";
        public const string DetailSuccess = "Lấy thông tin người dùng thành công.";
        public const string Error = "Có lỗi xảy ra khi lấy danh sách người dùng.";
    }

    public static class Phone
    {
        public const string UpdateSuccess = "Cập nhật số điện thoại thành công.";
        public const string AlreadyExists = "Số điện thoại đã được sử dụng bởi tài khoản khác.";
    }

    public static class Avatar
    {
        public const string UpdateSuccess = "Cập nhật ảnh đại diện thành công.";
    }

    public static class Profile
    {
        public const string UpdateSuccess = "Cập nhật hồ sơ thành công.";
        public const string UpdateError = "Có lỗi xảy ra khi cập nhật hồ sơ.";
    }

    public static class Role
    {
        public const string AddSuccess = "Thêm vai trò cho người dùng thành công.";
        public const string RemoveSuccess = "Xóa vai trò của người dùng thành công.";
        public const string AlreadyHasRole = "Người dùng đã có vai trò này.";
        public const string DoesNotHaveRole = "Người dùng không có vai trò này.";
        public const string RoleNotFound = "Không tìm thấy vai trò.";
        public const string CannotRemoveLastAdminRole = "Không thể xóa vai trò Admin cuối cùng.";
    }

    public static class Claim
    {
        public const string AddSuccess = "Thêm quyền cho người dùng thành công.";
        public const string RemoveSuccess = "Xóa quyền của người dùng thành công.";
        public const string AlreadyHasClaim = "Người dùng đã có quyền này.";
        public const string DoesNotHaveClaim = "Người dùng không có quyền này.";
        public const string InvalidPermission = "Quyền không hợp lệ.";
        public const string EkycPermissionNotAllowed = "Không được phép thay đổi quyền eKYC qua API này.";
    }
}
