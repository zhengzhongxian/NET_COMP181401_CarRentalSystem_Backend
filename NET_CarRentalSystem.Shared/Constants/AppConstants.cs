namespace NET_CarRentalSystem.Shared.Constants;

public static class AppConstants
{
    public static class EmailTemplates
    {
        public const string Otp = "OtpEmail.html";
        public const string ResetPassword = "ResetPasswordEmail.html";
    }

    public static class Pagination
    {
        public const int MinPageSize = 10;
        public const int MaxPageSize = 500;
    }

    public static class Architecture
    {
        public const string ApplicationLayer = "NET_CarRentalSystem.Application";
    }

    public static class CorsPolicy
    {
        public const string DefaultCorsPolicy = "DefaultCorsPolicy";
    }
}