using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class BookingSeeder
{
	public static IEnumerable<Booking> Seed()
	{
		var list = new List<Booking>();
		var now = DateTime.UtcNow;
		var customers = new[]
		{
			Guid.Parse("00000000-0000-0000-0000-000000000001"),
			Guid.Parse("00000000-0000-0000-0000-000000000002"),
			Guid.Parse("00000000-0000-0000-0000-000000000003"),
			Guid.Parse("00000000-0000-0000-0000-000000000004")
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
			var bookingId = new Guid($"10000000-0000-0000-0000-{(1000 + i).ToString("D12")}");
			var vehicleId = new Guid($"00000000-0000-0000-0000-{i.ToString("D12")}");
			var start = now.AddDays(-(i % 30));
			var end = start.AddDays(1 + (i % 7));
			list.Add(new Booking
			{
				BookingId = bookingId,
				CustomerId = customers[i % customers.Length],
				VehicleId = vehicleId,
				StartDate = start,
				EndDate = end,
				ActualEndDate = (i % 5 == 0) ? end.AddHours(2) : null,
				LatePenaltyRatio = 0.0m,
				DepositRatio = 0.1m,
				TotalPrice = 24 * (20 + (i % 60)),
				MileageStart = 1000 * i,
				FuelLevelEnd = (i % 2 == 0) ? 80 : 60,
				FuelPrice = (i % 3 == 0) ? 200000 : null,
				ConditionNotes = null,
				PickupLocationId = locations[i % locations.Length],
				ReturnLocationId = locations[(i + 1) % locations.Length],
				CreatedAt = now,
				UpdatedAt = now
			});
		}

		return list;
	}
}
