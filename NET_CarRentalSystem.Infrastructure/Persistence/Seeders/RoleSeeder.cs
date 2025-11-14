using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class RoleSeeder
{
	public static readonly Guid AdminRoleId = Guid.Parse("71af4b53-dcd0-4498-af4b-53dcd0249826");
	public static readonly Guid ManagerRoleId = Guid.Parse("1e46a445-4351-4d0a-86a4-454351dd0aa6");
	public static readonly Guid StaffRoleId = Guid.Parse("2fd185ee-d561-4b48-9185-eed5617b4881"); 
	public static readonly Guid CustomerRoleId = Guid.Parse("7a908619-1c82-4d16-9086-191c82fd1671"); 
	
	public static IEnumerable<Role> Seed()
	{
		return
		[
			new Role
			{
				Id = AdminRoleId,
				Name = RoleConstants.Admin,
				NormalizedName = RoleConstants.Admin.ToUpper()
			},
			new Role
			{
				Id = ManagerRoleId,
				Name = RoleConstants.Manager,
				NormalizedName = RoleConstants.Manager.ToUpper()
			},
			new Role
			{
				Id = StaffRoleId,
				Name = RoleConstants.Staff,
				NormalizedName = RoleConstants.Staff.ToUpper()
			},
			new Role
			{
				Id = CustomerRoleId,
				Name = RoleConstants.Customer,
				NormalizedName = RoleConstants.Customer.ToUpper()
			}
		];
	}
}


