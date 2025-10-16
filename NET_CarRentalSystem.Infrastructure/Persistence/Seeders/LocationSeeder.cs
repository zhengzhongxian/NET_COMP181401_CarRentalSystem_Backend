using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class LocationSeeder
{
    public static IEnumerable<Location> Seed()
    {
        return
        [
            new()
            {
                LocationId = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                Name = "Chi nhánh Quận 1",
                Address = "123 Lê Lợi, P. Bến Nghé",
                City = "Hồ Chí Minh",
                PhoneNumber = "02838123456",
                OpeningHours = "8:00 - 20:00",
                Latitude = 10.7758,
                Longitude = 106.702,
                CreatedAt = DateTime.UtcNow,
            },
            new()
            {
                LocationId = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                Name = "Chi nhánh Cầu Giấy",
                Address = "456 Xuân Thủy, P. Dịch Vọng Hậu",
                City = "Hà Nội",
                PhoneNumber = "02439123456",
                OpeningHours = "7:30 - 19:30",
                Latitude = 21.036,
                Longitude = 105.782,
                CreatedAt = DateTime.UtcNow,
            }
        ];
    }
}
