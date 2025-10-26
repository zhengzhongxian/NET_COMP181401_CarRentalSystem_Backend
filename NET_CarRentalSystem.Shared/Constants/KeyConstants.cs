namespace NET_CarRentalSystem.Shared.Constants;

public static class KeyConstants
{
    public static class ConnectionStrings
    {
        public const string RenticarWriteDbContext = "RenticarWriteDbContext";
        public const string RenticarReadDbContext = "RenticarReadDbContext";
    }

    public static class ConfigurationSections
    {
        public const string CloudinarySettings = "CloudinarySettings";
    }

    public static class Quartz
    {
        public static class CheckToolAlive
        {
            public const string JobName = "Quartz:CheckToolAlive:JobName";
            public const string CronExpression = "Quartz:CheckToolAlive:CronExpression";
        }
    }
}
