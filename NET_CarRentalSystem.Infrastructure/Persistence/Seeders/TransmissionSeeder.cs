using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class TransmissionSeeder
{
    public static IEnumerable<Transmission> Seed()
    {
        return
        [
            new()
            {
                TransmissionId = Guid.Parse("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                Name = "Automatic Transmission",
                Code = "AT",
                Description = "Hộp số tự động"
            },
            new()
            {
                TransmissionId = Guid.Parse("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"),
                Name = "Manual Transmission",
                Code = "MT",
                Description = "Hộp số sàn"
            }
        ];
    }
}