namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class LocationMessage
{
    public static class Get
    {
        public const string Success = "Lấy thông tin địa điểm thành công";
        public const string Error = "Lấy thông tin địa điểm thất bại";
        public const string NotFound = "Không tìm thấy địa điểm";
    }
    
    public static class Create
    {
        public const string Success = "Tạo địa điểm thành công";
        public const string Error = "Tạo địa điểm thất bại";
    }

    public static class Update
    {
        public const string Success = "Cập nhật địa điểm thành công";
        public const string Error = "Cập nhật địa điểm thất bại";
        public const string NotFound = "Không tìm thấy địa điểm";
    }

    public static class Delete
    {
        public const string Success = "Xóa địa điểm thành công";
        public const string Error = "Xóa địa điểm thất bại";
        public const string NotFound = "Không tìm thấy địa điểm";
        public const string HasVehicles = "Không thể xóa địa điểm đang có xe";
    }
}