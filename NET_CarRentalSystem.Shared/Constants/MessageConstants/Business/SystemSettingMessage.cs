namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class SystemSettingMessage
{
    public static class Get
    {
        public const string Success = "Lấy cài đặt hệ thống thành công";
        public const string NotFound = "Không tìm thấy cài đặt hệ thống";
        public const string Error = "Lỗi khi lấy cài đặt hệ thống";
    }
    
    public static class UpdateAll
    {
        public const string Success = "Cập nhật tất cả cài đặt hệ thống thành công";
        public const string Error = "Lỗi khi cập nhật cài đặt hệ thống";
    }
}

