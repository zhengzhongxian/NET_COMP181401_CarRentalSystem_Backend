namespace NET_CarRentalSystem.Shared.Constants;

public static class KeyConstants
{
    public static class ConnectionStrings
    {
        public const string RenticarWriteDbContext = "RenticarWriteDbContext";
        public const string RenticarReadDbContext = "RenticarReadDbContext";
        public const string Redis = "Redis";
    }

    public static class ConfigurationSections
    {
        public const string CloudinarySettings = "CloudinarySettings";
        public const string MinioSettings = "MinioSettings";
        public const string JwtSettings = "Authentication:JwtSettings";
        public const string GoogleSettings = "Authentication:GoogleSettings";
        public const string SyncDataToolSettings = "SyncDataToolSettings";
        public const string EmailSettings = "Notifications:EmailSettings";
        public const string OtpSettings = "Security:OtpSettings";
        public const string RsaSettings = "Security:RsaSettings";
        public const string AesSettings = "Security:AesSettings";
        public const string CorsSettings = "CorsSettings";
        public const string ResetPasswordSettings = "Security:ResetPasswordSettings";
        public const string MyApiSettings = "ApiClient:MyApiSettings";
        public const string VnPaySettings = "Payment:VnPaySettings";
        public const string GmailApiSettings = "Notifications:GmailApiSettings";
        public const string PayOsSettings = "Payment:PayOsSettings";
        public const string PaymentSyncJob = "Quartz:PaymentSyncJob";
        public const string RefundProcessingJob = "Quartz:RefundProcessingJob";
        public const string ReturnDeadlineReminderJob = "Quartz:ReturnDeadlineReminderJob";
        public const string OverdueBookingJob = "Quartz:OverdueBookingJob";
        public const string VnptEkycSettings = "Authentication:Ekyc:VnptEkycSettings";
        public const string SpeedSmsSettings = "Authentication:Sms:SpeedSmsSettings";
        public const string TwilioSettings = "Authentication:Sms:TwilioSettings";
        public const string GrpcServices = "GrpcServices";
        public const string CheckToolAlive = "Quartz:CheckToolAlive";
        public const string DepositRefundJob = "Quartz:DepositRefundJob";
        public const string FileValidationSettings = "FileValidationSettings";
    }

    public static class DatabaseInitializationSettings
    {
        public const string MaxRetries = "DatabaseInitializationSettings:MaxRetries";
        public const string RetryInterval = "DatabaseInitializationSettings:DbRetryDelayInSeconds";
    }

    public static class RabbitMq
    {
        public const string Host = "RabbitMQ:Host";
        public const string Port = "RabbitMQ:Port";
        public const string VirtualHost = "RabbitMQ:VirtualHost";
        public const string Username = "RabbitMQ:Username";
        public const string Password = "RabbitMQ:Password";
    }

    public static class FinalPaymentSettings
    {
        public const string MaxImageWidth = "Payment:FinalPayment:MaxImageWidth";
        public const string MaxImageHeight = "Payment:FinalPayment:MaxImageHeight";
        public const string ImageQuality = "Payment:FinalPayment:ImageQuality";
    }
    
    public static string EmailRedirectUrl => "EmailRedirectUrl";

    public static class QrReturnVehicleUrl
    {
        public const string ExpireInSecond = "QrReturnVehicleUrl:ExpireInSecond";
        public const string BaseUrl = "QrReturnVehicleUrl:BaseUrl";
    }

    public static class TaskQueueSettings
    {
        public const string CreateBookingMaxWorkers = "TaskQueue:CreateBooking:MaxWorkers";
        public const string CreateBookingMaxQueue = "TaskQueue:CreateBooking:MaxQueue";
    }
}
