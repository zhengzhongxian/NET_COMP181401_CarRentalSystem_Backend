using NET_CarRentalSystem.Domain.Constants;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders
{
    public static class RolePermissions
    {
        public static Dictionary<Guid, List<string>> GetMappings()
        {
            return new Dictionary<Guid, List<string>>
            {
                [RoleSeeder.AdminRoleId] = PermissionConstants.GetAllPermissions(),
                
                [RoleSeeder.ManagerRoleId] =
                [
                    PermissionConstants.Vehicles.View,
                    PermissionConstants.Vehicles.Create,
                    PermissionConstants.Vehicles.Edit,
                    PermissionConstants.Bookings.View,
                    PermissionConstants.Bookings.Edit,
                    PermissionConstants.Fuels.Create,
                    PermissionConstants.Fuels.Edit,
                    PermissionConstants.Fuels.View,
                    PermissionConstants.Fuels.Delete
                ],
                
                [RoleSeeder.StaffRoleId] =
                [
                    PermissionConstants.Vehicles.View,
                    PermissionConstants.Bookings.View,
                    PermissionConstants.Bookings.Create
                ],
                
                [RoleSeeder.CustomerRoleId] =
                [
                    PermissionConstants.Bookings.Create,
                    PermissionConstants.Bookings.View
                ]
            };
        }
    }
}