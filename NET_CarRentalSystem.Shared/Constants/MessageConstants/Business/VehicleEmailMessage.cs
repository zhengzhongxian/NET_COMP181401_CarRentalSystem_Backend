namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class VehicleEmailMessage
{
    public static class SendPromotion
    {
        public const string Success = "Gửi email quảng cáo xe thành công";
        public const string Error = "Có lỗi xảy ra khi gửi email quảng cáo xe";
        public const string VehicleNotFound = "Không tìm thấy xe";
        public const string EmptyEmailList = "Danh sách email không được để trống";
        public const string InvalidEmails = "Danh sách email chứa email không hợp lệ";
    }
}
