namespace NET_CarRentalSystem.Domain.Enums;

public enum TransactionType
{
    Deposit = 1,           // Tiền đặt cọc (thường là 30%)
    FinalPayment = 2,      // Thanh toán phần còn lại khi nhận/trả xe
    Penalty = 3,           // Phí phạt phát sinh (muộn giờ, hỏng hóc, thiếu xăng)
    Refund = 4,            // Giao dịch hoàn tiền
    ViolationPayment = 5,  // Thanh toán vi phạm (nhiên liệu, trả xe muộn)
    DepositRefund = 6      // Hoàn tiền cọc (sau 30 ngày kể từ khi trả xe)
}