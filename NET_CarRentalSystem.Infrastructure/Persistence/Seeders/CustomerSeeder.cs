using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class CustomerSeeder
{
	public static IEnumerable<Customer> Seed()
	{
		var now = DateTime.UtcNow;
		return
		[
			new()
			{
				CustomerId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
				FirstName = "An",
				LastName = "Nguyen",
				Dob = new DateTime(1995, 5, 20),
				PhoneNumber = "fupEgUxoPV44LCKJSY7JLw==",
				Address = "1 Nguyen Trai, Q1",
				CccdNumber = "0s7H23SQolvCsrWr20Orjw==",
				CccdIssueDate = new DateTime(2015, 1, 1),
				CccdIssuePlace = "TP.HCM",
				CccdFrontUrl = "https://example.com/cccd1-front.jpg",
				CccdBackUrl = "https://example.com/cccd1-back.jpg",
				DriverLicenseId = "A12345601",
				DriverLicenseExpiry = new DateTime(2030, 1, 1),
				DriverLicenseFrontUrl = "https://example.com/dl1-front.jpg",
				DriverLicenseBackUrl = "https://example.com/dl1-back.jpg",
				AvatarUrl = null,
				UserId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				CustomerId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
				FirstName = "Binh",
				LastName = "Tran",
				Dob = new DateTime(1992, 10, 10),
				PhoneNumber = "8JAbpw+SbCGaHGhEfWg3g==",
				Address = "2 Le Loi, Q1",
				CccdNumber = "cVXHyBreralnzAB1L4PQPg==",
				CccdIssueDate = new DateTime(2014, 2, 2),
				CccdIssuePlace = "TP.HCM",
				CccdFrontUrl = "https://example.com/cccd2-front.jpg",
				CccdBackUrl = "https://example.com/cccd2-back.jpg",
				DriverLicenseId = "A12345602",
				DriverLicenseExpiry = new DateTime(2030, 2, 2),
				DriverLicenseFrontUrl = "https://example.com/dl2-front.jpg",
				DriverLicenseBackUrl = "https://example.com/dl2-back.jpg",
				AvatarUrl = null,
				UserId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				CustomerId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
				FirstName = "Chi",
				LastName = "Le",
				Dob = new DateTime(1998, 3, 15),
				PhoneNumber = "Ha5ZLxongotYMMoHd5FJxg==",
				Address = "3 Cach Mang Thang 8, Q3",
				CccdNumber = " MK+LCGCQBxHbW7CoM5pipw==",
				CccdIssueDate = new DateTime(2016, 3, 3),
				CccdIssuePlace = "TP.HCM",
				CccdFrontUrl = "https://example.com/cccd3-front.jpg",
				CccdBackUrl = "https://example.com/cccd3-back.jpg",
				DriverLicenseId = "A12345603",
				DriverLicenseExpiry = new DateTime(2031, 3, 3),
				DriverLicenseFrontUrl = "https://example.com/dl3-front.jpg",
				DriverLicenseBackUrl = "https://example.com/dl3-back.jpg",
				AvatarUrl = null,
				UserId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			},
			new()
			{
				CustomerId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
				FirstName = "Dũng",
				LastName = "Bú Cu",
				Dob = new DateTime(1990, 7, 1),
				PhoneNumber = "BFW3YFm70nX+X+CmDyqtrQ==",
				Address = "4 Phan Xich Long, Phu Nhuan",
				CccdNumber = "c3UJRjSHiGUa76qRID5QIg==",
				CccdIssueDate = new DateTime(2013, 4, 4),
				CccdIssuePlace = "TP.HCM",
				CccdFrontUrl = "https://example.com/cccd4-front.jpg",
				CccdBackUrl = "https://example.com/cccd4-back.jpg",
				DriverLicenseId = "A12345604",
				DriverLicenseExpiry = new DateTime(2032, 4, 4),
				DriverLicenseFrontUrl = "https://example.com/dl4-front.jpg",
				DriverLicenseBackUrl = "https://example.com/dl4-back.jpg",
				AvatarUrl = null,
				UserId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
				CreatedAt = now,
				UpdatedAt = now,
				IsDeleted = false
			}
		];
	}
}


