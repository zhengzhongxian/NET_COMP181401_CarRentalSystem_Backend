using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using BCrypt.Net;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class UserSeeder
{
	public static IEnumerable<User> Seed()
	{
		var now = DateTime.UtcNow;
		return
		[
			new()
			{
				UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
				UserName = "admin",
				Password = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
				Email = "admin@example.com",
				IsVerified = true,
				Status = UserStatus.Active,
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
				UserName = "staff1",
				Password = BCrypt.Net.BCrypt.HashPassword("Staff1@123"),
				Email = "staff1@example.com",
				IsVerified = true,
				Status = UserStatus.Active,
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				UserId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
				UserName = "customer1",
				Password = BCrypt.Net.BCrypt.HashPassword("Customer1@123"),
				Email = "customer1@example.com",
				IsVerified = true,
				Status = UserStatus.Active,
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
				UserName = "customer2",
				Password = BCrypt.Net.BCrypt.HashPassword("Customer2@123"),
				Email = "customer2@example.com",
				IsVerified = true,
				Status = UserStatus.Active,
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			}
		];
	}
}


