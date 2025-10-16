using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class BookingSeeder
{
    public static IEnumerable<Booking> Seed()
    {
        return
        [
            new()
            {
                BookingId = Guid.Parse("c1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                CustomerId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                VehicleId = Guid.Parse("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a01"),
                StartDate = DateTime.UtcNow.AddDays(5),
                EndDate = DateTime.UtcNow.AddDays(7),
                TotalPrice = 1440,
                PickupLocationId = Guid.Parse("10000000-0000-0000-0000-000000000001"), 
                ReturnLocationId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                CreatedAt = DateTime.UtcNow
            }
        ];
    }
}
