using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class LocationSeeder
{
    public static IEnumerable<Location> Seed()
    {
        var now = DateTime.UtcNow;
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
                CreatedAt = now,
                UpdatedAt = now
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
                CreatedAt = now,
                UpdatedAt = now
            },
            new()
            {
                LocationId = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                Name = "Chi nhánh Hải Châu",
                Address = "789 Hùng Vương, Hải Châu",
                City = "Đà Nẵng",
                PhoneNumber = "023639123456",
                OpeningHours = "8:00 - 20:00",
                Latitude = 16.0544,
                Longitude = 108.2022,
                CreatedAt = now,
                UpdatedAt = now
            },
            new()
            {
                LocationId = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                Name = "Chi nhánh Nha Trang",
                Address = "12 Trần Phú, Lộc Thọ",
                City = "Khánh Hòa",
                PhoneNumber = "025839123456",
                OpeningHours = "8:00 - 20:00",
                Latitude = 12.2388,
                Longitude = 109.1967,
                CreatedAt = now,
                UpdatedAt = now
            }
        ];
    }
}
