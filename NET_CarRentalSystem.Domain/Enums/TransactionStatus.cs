namespace NET_CarRentalSystem.Domain.Enums;

public enum TransactionStatus
{
    Pending = 1,    // Giao dịch mới khởi tạo, đang chờ khách quét mã/nhập thẻ
    Success = 2,    // Ngân hàng xác nhận đã nhận tiền thành công
    Failed = 3,     // Giao dịch thất bại (sai mã OTP, không đủ số dư...)
    Cancelled = 4,  // Khách hàng chủ động hủy giao dịch trên giao diện thanh toán
    Expired = 5,    // Quá thời gian thanh toán (ví dụ sau 15p khách không quét mã QR)
    Refunded = 6    // Tiền đã được hoàn lại cho khách
}