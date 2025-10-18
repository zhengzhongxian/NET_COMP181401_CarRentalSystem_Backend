using NET_CarRentalSystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class VehicleAttributeSeeder
{
	public static IEnumerable<VehicleAttribute> Seed()
	{
		return
		[
			new()
			{
				AttributeId = Guid.Parse("30000000-0000-0000-0000-000000000001"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
				AttributeKey = "Dung tích xi lanh",
				AttributeValue = "1.5L"
			},
			new()
			{
				AttributeId = Guid.Parse("30000000-0000-0000-0000-000000000002"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
				AttributeKey = "Mức tiêu thụ nhiên liệu",
				AttributeValue = "5.8L/100km"
			},
			new()
			{
				AttributeId = Guid.Parse("30000000-0000-0000-0000-000000000003"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
				AttributeKey = "Hệ dẫn động",
				AttributeValue = "Cầu sau (RWD)"
			},
			new()
			{
				AttributeId = Guid.Parse("30000000-0000-0000-0000-000000000004"),
				VehicleId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
				AttributeKey = "Số túi khí",
				AttributeValue = "7"
			}
		];
	}
}

