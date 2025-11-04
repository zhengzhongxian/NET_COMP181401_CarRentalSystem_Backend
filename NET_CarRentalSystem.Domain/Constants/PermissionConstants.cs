using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Domain.Constants;

public static class PermissionConstants
{
    public static class Vehicles
    {
        public const string View = "Permissions.Vehicles.View";
        public const string Create = "Permissions.Vehicles.Create";
        public const string Edit = "Permissions.Vehicles.Edit";
        public const string Delete = "Permissions.Vehicles.Delete";
    }
    
    public static class Bookings
    {
        public const string View = "Permissions.Bookings.View";
        public const string Create = "Permissions.Bookings.Create";
        public const string Edit = "Permissions.Bookings.Edit";
        public const string Delete = "Permissions.Bookings.Delete";
    }

    public static class Fuels
    {
        public const string View = "Permissions.Fuels.View";
        public const string Create = "Permissions.Fuels.Create";
        public const string Edit = "Permissions.Fuels.Edit";
        public const string Delete = "Permissions.Fuels.Delete";
    }
    
    public static List<string> GetAllPermissions()
    {
        return ReflectionHelper.GetConstants<string>(typeof(PermissionConstants));
    }
}