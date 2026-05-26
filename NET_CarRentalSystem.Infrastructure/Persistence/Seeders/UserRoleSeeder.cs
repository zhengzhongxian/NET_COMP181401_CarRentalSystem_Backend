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
                UserRoleId = Guid.NewGuid(),
                UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                RoleId = RoleSeeder.AdminRoleId
            },
            new UserRole
            {
                UserRoleId = Guid.NewGuid(),
                UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                RoleId = RoleSeeder.ManagerRoleId
            },
            new UserRole
            {
                UserRoleId = Guid.NewGuid(),
                UserId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                RoleId = RoleSeeder.StaffRoleId
            },
            new UserRole
            {
                UserRoleId = Guid.NewGuid(),
                UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                RoleId = RoleSeeder.CustomerRoleId
            },
            new UserRole
            {
                UserRoleId = Guid.Parse("a5e83a7c-28b9-a4e2-abb3-30c15d0d4b1a"),
                UserId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                RoleId = RoleSeeder.DeveloperRoleId
            }
        ];
    }
}