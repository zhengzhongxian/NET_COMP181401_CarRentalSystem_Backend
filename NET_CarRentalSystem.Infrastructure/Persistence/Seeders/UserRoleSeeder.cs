using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class UserRoleSeeder
{
    public static IEnumerable<UserRole> Seed()
    {
        return
        [
            new UserRole
            {
                UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                RoleId = RoleSeeder.AdminRoleId
            },
            new UserRole
            {
                UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                RoleId = RoleSeeder.ManagerRoleId
            },
            new UserRole
            {
                UserId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                RoleId = RoleSeeder.StaffRoleId
            },
            new UserRole
            {
                UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                RoleId = RoleSeeder.CustomerRoleId
            }
        ];
    }
}