using NET_CarRentalSystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class VehicleImageSeeder
{
	public static IEnumerable<VehicleImage> Seed()
	{
		return
		[
			new()
			{
				ImageId = Guid.Parse("20000000-0000-0000-0000-000000000001"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
				Order = 1,
				ImageUrl = "https://hientoyota.vn/wp-content/uploads/2019/05/Toyota-Vios-1.jpg",
				AltText = "Ảnh ngoại thất Toyota Vios"
			},
			new()
			{
				ImageId = Guid.Parse("20000000-0000-0000-0000-000000000002"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
				Order = 2,
				ImageUrl = "https://toyotatanphu.vn/quannguyenphat/uploads/2019/06/Vios-Nau-vang.png.webp",
				AltText = "Ảnh nội thất Toyota Vios"
			},
			new()
			{
				ImageId = Guid.Parse("20000000-0000-0000-0000-000000000003"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000002"), 
				Order = 1,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKY7Bfrr6iP-Al8YWIBsqEjOfrRn0EZ--QMg&s",
				AltText = "Ảnh ngoại thất Ford Everest"
			}
		];
	}
}
