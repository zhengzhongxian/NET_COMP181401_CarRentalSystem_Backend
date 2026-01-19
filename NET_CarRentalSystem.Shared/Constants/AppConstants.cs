namespace NET_CarRentalSystem.Shared.Constants;

public static class AppConstants
{
    public static class EmailTemplates
    {
        public const string Otp = "OtpEmail.html";
        public const string ResetPassword = "ResetPasswordEmail.html";
        public const string SyncTransactionError = "SyncTransactionErrorEmail.html";
        public const string DepositPaymentSuccess = "DepositPaymentSuccessEmail.html";
        public const string FullPaymentSuccess = "FullPaymentSuccessEmail.html";
        public const string VehiclePromotion = "VehiclePromotionEmail.html";
        public const string RefundNotification = "RefundNotificationEmail.html";
        public const string RefundSuccess = "RefundSuccessEmail.html";
        public const string RefundProcessingFailureAlert = "RefundProcessingFailureAlertEmail.html";
        public const string PendingTransactionsRefundNotice = "PendingTransactionsRefundNoticeEmail.html";
        public const string ViolationNotification = "ViolationNotificationEmail.html";
    }

    public static class Pagination
    {
        public const int MinPageSize = 10;
        public const int MaxPageSize = 500;
    }

    public static class Architecture
    {
        public const string ApplicationLayer = "NET_CarRentalSystem.Application";
        public const string ApiLayer = "NET_CarRentalSystem.API";
    }

    public static class CorsPolicy
    {
        public const string DefaultCorsPolicy = "DefaultCorsPolicy";
    }
}