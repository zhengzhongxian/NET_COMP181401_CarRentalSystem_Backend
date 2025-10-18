using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class RoleSeeder
{
	public static IEnumerable<Role> Seed()
	{
		var now = DateTime.UtcNow;
		return
		[
			new()
			{
				RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
				Name = "Admin",
				NormalizedName = "ADMIN",
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"),
				Name = "Staff",
				NormalizedName = "STAFF",
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"),
				Name = "Customer",
				NormalizedName = "CUSTOMER",
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			}
		];
	}
}


