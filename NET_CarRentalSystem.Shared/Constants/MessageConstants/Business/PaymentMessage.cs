namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class PaymentMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách phương thức thanh toán thành công";
        public const string Error = "Có lỗi xảy ra trong quá trình lấy phương thức thanh toán";
    }
    
    public static class CreateQr
    {
        public const string Success = "Tạo mã QR thanh toán thành công";
        public const string Error = "Không thể tạo mã QR thanh toán";
    }
}