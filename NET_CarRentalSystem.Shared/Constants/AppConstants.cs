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
        public const string DomainLayer = "NET_CarRentalSystem.Domain";
        public const string InfrastructureLayer = "NET_CarRentalSystem.Infrastructure";
        public const string SharedLayer = "NET_CarRentalSystem.Shared";
        public const string Apiayer = "NET_CarRentalSystem.API";
    }

    public static class CorsPolicy
    {
        public const string DefaultCorsPolicy = "DefaultCorsPolicy";
    }

    public static class LoginProvider
    {
        public const string Google = "Google";
        public const string Microsoft = "Microsoft";
        public const string Facebook = "Facebook";
        public const string Local = "Local";
    }
}