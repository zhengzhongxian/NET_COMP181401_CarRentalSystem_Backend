using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class VehicleCategorySeeder
{
    public static IEnumerable<VehicleCategory> Seed()
    {
        return
        [
            new()
            {
                CategoryId = Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                CategoryCode = "SEDAN",
                Seat = 5,
                Description = "Xe sedan 4-5 chỗ, phổ thông",
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false
            },
            new()
            {
                CategoryId = Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                CategoryCode = "SUV",
                Seat = 7,
                Description = "Xe thể thao đa dụng, gầm cao",
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false
            },
            new()
            {
                CategoryId = Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                CategoryCode = "HATCHBACK",
                Seat = 5,
                Description = "Xe cỡ nhỏ cho đô thị",
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false
            },
            new()
            {
                CategoryId = Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                CategoryCode = "MINIVAN",
                Seat = 7,
                Description = "Xe gia đình, rộng rãi",
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false
            }
        ];
    }
}
