using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class UserRoleSeeder
{
	public static IEnumerable<UserRole> Seed()
	{
		return
		[
			new() { UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"), RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1") },
			new() { UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"), RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2") },
			new() { UserId = Guid.Parse("33333333-3333-3333-3333-333333333333"), RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
			new() { UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"), RoleId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") }
		];
	}
}


