using NET_CarRentalSystem.Domain.Entities;
namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class RoleClaimSeeder
{
    public static IEnumerable<RoleClaim> Seed()
    {
        var rolePermissionMappings = RolePermissions.GetMappings();
        
        var allRoleClaims = rolePermissionMappings
            .SelectMany(pair => 
            {
                var roleId = pair.Key;
                var permissions = pair.Value;
                
                return permissions.Select(permissionValue => new RoleClaim
                {
                    Id = Guid.NewGuid(),
                    RoleId = roleId,
                    ClaimType = "Permission",
                    ClaimValue = permissionValue
                });
            });

        return allRoleClaims;
    }
}