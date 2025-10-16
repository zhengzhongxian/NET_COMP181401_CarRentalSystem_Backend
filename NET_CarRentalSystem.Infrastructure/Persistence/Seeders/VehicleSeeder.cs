using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class VehicleSeeder
{
    public static IEnumerable<Vehicle> Seed()
    {
        var vehicles = new List<Vehicle>
        {
            new()
            {
                VehicleId = Guid.Parse("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a01"),
                NumberPlate = "51K-123.45",
                Manufacturer = "Toyota",
                Model = "Vios",
                Color = "Bạc",
                Mileage = 15000,
                PricePerHour = 30,
                Rating = 4.5f,
                Status = VehicleStatus.Available,
                CreatedAt = DateTime.UtcNow,
                VehicleCategoryId = Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                FuelId = Guid.Parse("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                TransmissionId = Guid.Parse("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                LocationId = Guid.Parse("10000000-0000-0000-0000-000000000001")
            },
            new()
            {
                VehicleId = Guid.Parse("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a02"),
                NumberPlate = "29A-678.90",
                Manufacturer = "Ford",
                Model = "Everest",
                Color = "Đen",
                Mileage = 5000,
                PricePerHour = 50,
                Rating = 4.8f,
                Status = VehicleStatus.Available,
                CreatedAt = DateTime.UtcNow,
                VehicleCategoryId = Guid.Parse("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                FuelId = Guid.Parse("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                TransmissionId = Guid.Parse("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                LocationId = Guid.Parse("10000000-0000-0000-0000-000000000002")
            }
        };

        return vehicles;
    }
}
