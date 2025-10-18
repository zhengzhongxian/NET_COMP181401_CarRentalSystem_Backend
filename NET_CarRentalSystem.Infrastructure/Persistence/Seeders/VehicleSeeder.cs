using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class VehicleSeeder
{
	public static IEnumerable<Vehicle> Seed()
	{
		var vehicles = new List<Vehicle>();
		var now = DateTime.UtcNow;

		var categories = new[]
		{
			Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
			Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
			Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
			Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04")
		};
		var fuels = new[]
		{
			Guid.Parse("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
			Guid.Parse("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
			Guid.Parse("a3d4e5f6-c7b8-9012-3456-7890abcdef01")
		};
		var transmissions = new[]
		{
			Guid.Parse("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
			Guid.Parse("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7")
		};
		var locations = new[]
		{
			Guid.Parse("10000000-0000-0000-0000-000000000001"),
			Guid.Parse("10000000-0000-0000-0000-000000000002"),
			Guid.Parse("10000000-0000-0000-0000-000000000003"),
			Guid.Parse("10000000-0000-0000-0000-000000000004")
		};

		for (var i = 1; i <= 200; i++)
		{
			var id = new Guid($"00000000-0000-0000-0000-{i.ToString("D12")}");
			vehicles.Add(new Vehicle
			{
				VehicleId = id,
				NumberPlate = $"{(10 + (i % 50)):D2}A-{(100 + i):D3}.{(i % 90) + 10:D2}",
				Manufacturer = (i % 4) switch { 0 => "Toyota", 1 => "Ford", 2 => "Hyundai", _ => "Kia" },
				Model = (i % 4) switch { 0 => "Vios", 1 => "Everest", 2 => "Accent", _ => "Seltos" },
				Color = (i % 5) switch { 0 => "Bạc", 1 => "Đen", 2 => "Trắng", 3 => "Đỏ", _ => "Xanh" },
				Mileage = 1000 * i,
				PricePerHour = 20 + (i % 60),
				Rating = 3.5f + (i % 15) * 0.1f,
				Status = VehicleStatus.Available,
				CreatedAt = now,
				UpdatedAt = now,
				VehicleCategoryId = categories[i % categories.Length],
				FuelId = fuels[i % fuels.Length],
				TransmissionId = transmissions[i % transmissions.Length],
				LocationId = locations[i % locations.Length]
			});
		}

		return vehicles;
	}
}
