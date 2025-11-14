using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class FuelSeeder
{
	public static IEnumerable<Fuel> Seed()
	{
		var now = DateTime.UtcNow;
		return
		[
			new()
			{
				Id = Guid.Parse("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
				Name = "Gasoline",
				Description = "Sử dụng xăng",
				CreatedAt = now,
				UpdatedAt = now
			},
			new()
			{
				Id = Guid.Parse("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
				Name = "Diesel",
				Description = "Sử dụng dầu Diesel",
				CreatedAt = now,
				UpdatedAt = now
			},
			new()
			{
				Id = Guid.Parse("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
				Name = "Electric",
				Description = "Sử dụng năng lượng điện",
				CreatedAt = now,
				UpdatedAt = now
			}
		];
	}
}

