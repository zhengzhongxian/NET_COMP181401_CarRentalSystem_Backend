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
        public const string SendEmail = "Permissions.Vehicles.SendEmail";
    }
    
    public static class Bookings
    {
        public const string View = "Permissions.Bookings.View";
        public const string ViewDetail = "Permissions.Bookings.ViewDetail";
        public const string Create = "Permissions.Bookings.Create";
        public const string Edit = "Permissions.Bookings.Edit";
        public const string SwapVehicleModel = "Permissions.Bookings.SwapVehicleModel";
        public const string Cancel = "Permissions.Bookings.Cancel";
        public const string GenerateContract = "Permissions.Bookings.GenerateContract";
        public const string ExportContract = "Permissions.Bookings.ExportContract";
        public const string UpdateFinalPayment = "Permissions.Bookings.UpdateFinalPayment";
        public const string CreateFinalPayment = "Permissions.Bookings.CreateFinalPayment";
    }

    public static class Fuels
    {
        public const string View = "Permissions.Fuels.View";
        public const string Create = "Permissions.Fuels.Create";
        public const string Edit = "Permissions.Fuels.Edit";
        public const string Delete = "Permissions.Fuels.Delete";
    }

    public static class Transmissions
    {
        public const string View = "Permissions.Transmissions.View";
        public const string Create = "Permissions.Transmissions.Create";
        public const string Edit = "Permissions.Transmissions.Edit";
        public const string Delete = "Permissions.Transmissions.Delete";
    }

    public static class VehicleCategory
    {
        public const string View = "Permissions.VehicleCategory.View";
        public const string Create = "Permissions.VehicleCategory.Create";
        public const string Edit = "Permissions.VehicleCategory.Edit";
        public const string Delete = "Permissions.VehicleCategory.Delete";
    }
    public static class Locations
    {
        public const string View = "Permissions.Locations.View";
        public const string Create = "Permissions.Locations.Create";
        public const string Edit = "Permissions.Locations.Edit";
        public const string Delete = "Permissions.Locations.Delete";
    }
    
    public static class RefundRequests
    {
        public const string View = "Permissions.RefundRequests.View";
        public const string Approve = "Permissions.RefundRequests.Approve";
        public const string Reject = "Permissions.RefundRequests.Reject";
    }

    public static class Violations
    {
        public const string View = "Permissions.Violations.View";
        public const string Resolve = "Permissions.Violations.Resolve";
    }

    public static class Ekyc
    {
        public const string IdentityVerified = "Permissions.Ekyc.IdentityVerified";
        public const string PhoneVerified = "Permissions.Ekyc.PhoneVerified";
        public const string DriverLicenseVerified = "Permissions.Ekyc.DriverLicenseVerified";
        public const string FullyVerified = "Permissions.Ekyc.FullyVerified";
    }

    public static List<string> GetAllPermissions()
    {
        return ReflectionHelper.GetConstants<string>(typeof(PermissionConstants));
    }
}