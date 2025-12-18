using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_Permission_CRUD_WriteDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("046826e1-1fe1-4d74-890a-3e9c39464f9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("147fb4f3-8af8-4fd4-9d93-265888bad8e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b40264c-04cd-422d-8d45-db121384c95b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("283b7fb7-9bbd-4f34-b6ab-2786c76408d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f5f10e3-7dde-4af9-a879-b0689ecc9149"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("37fdb168-4f36-4a9c-96b3-cdab87512019"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47f1bf9b-b9ca-410f-abef-dbb8fbb1e925"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4807943e-b857-4674-aeb9-b2d1a997f6e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4834ab74-3831-4c39-8591-f995981eb7c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5443ef24-6006-4cd2-b21f-798a77a9f293"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("54c17a8a-2c29-4e3a-9ce1-350075645e37"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55f9e7f1-cace-4706-8c89-51b546950801"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("574189a6-f00c-4d94-8895-0ab7642e663b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("58fefa7d-e03f-4213-bc23-7411bc676e62"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("696704d9-fdde-4dd2-afb6-1fdeb0d5da2c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("752a7db2-21a3-4294-8965-bf11d6f14052"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92387513-706b-48a6-bd1b-ea38d79e7d3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92fff580-b665-4354-80aa-7282ddfe51d2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("932315a6-7ebf-47b8-93ff-5d3fd7e17d5b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a077044-eb09-45bf-9628-546b7e127470"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e255aa8-6099-4a5b-8a86-021b03be8ddb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ace0fb64-07e3-43d0-91b8-b31da586b867"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b17d9991-29a7-4e8f-b45c-b7e566c870d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ba7f98a7-bccc-4b6c-ba7f-f9a0de7497a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cbc7bf40-c43b-4dfd-bdac-24ed6a2dc863"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0d830e5-13df-4ce6-9903-6025a4390f4f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dd481eb2-6479-4f63-b369-302fadf73f56"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f087b1be-0653-4197-b61f-2bd646979657"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f4d64e28-a698-4f83-bdf4-fed1c82a1185"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc0c4387-f515-4030-b241-bd444664525b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3b23ce5c-fa97-497f-9ab2-af56c7f77f87"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("51071e5a-a27a-4f34-8760-4e05a2dc9099"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8d8e8fd1-b4ab-4a92-b3d6-5f8fccd7cb75"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ba44880a-ed3f-4463-a987-908161a6b9d1"));

            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 19, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 26, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 21, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 14, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 14, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 7, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 26, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 23, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 16, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 2, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 26, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 25, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 11, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 26, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 20, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 20, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 13, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 6, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 26, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 22, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 15, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 15, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 27, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 26, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 25, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 23, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 22, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 21, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 20, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 19, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 24, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 24, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 16, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 15, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 14, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 17, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 13, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 12, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 11, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 17, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 9, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 8, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 7, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 6, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 5, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 4, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 10, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 2, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 1, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 30, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 29, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 17, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 3, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 11, 28, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 12, 18, 15, 31, 56, 181, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003), new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003), new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003), new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003), new DateTime(2025, 12, 18, 15, 31, 56, 184, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 185, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 12, 18, 15, 31, 56, 185, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 185, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 12, 18, 15, 31, 56, 185, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 185, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 12, 18, 15, 31, 56, 185, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177), null, null, new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177), null, null, new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177), null, null, new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177), null, null, new DateTime(2025, 12, 18, 15, 31, 56, 186, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("05a6574f-a49b-4391-b112-bf473be4d78b"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("063b5f36-7e35-4f6d-902e-cf65106f92f9"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("071b9eb7-e6bf-4001-b698-98466ee71a62"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0f74e021-8524-49b3-82e0-7d71498f0da8"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("27241f67-8432-4153-9b15-d6d10e28ec93"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("286e09d8-5908-4ee6-8bd2-c76dafb7e5a3"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("298fe0d5-78ad-48e9-b28c-3a4fcfda9b5a"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2a9032b6-4a17-48e1-8fb9-78dfa532f339"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e4fc06c-7f50-4ad3-9d53-98b7c5d33230"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("366e93e0-aac1-4bad-b952-1a2deec14e61"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("36d3e157-1a2e-4cc7-bb9b-3d2540a1cab0"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("450b6fdb-d0dc-4374-8862-3e7d271edaee"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("452fb784-b9e2-49ca-92ea-0cb590c7bebc"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("516cf530-e76a-496b-b93b-0f20ccd7a497"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("535ecd7c-1baf-4c0e-8c4b-a560d7ee8233"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("59b04ec2-fc44-4109-b479-cba60e2f1af9"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5e10d18c-71ff-477e-a97e-2f2c1ad89d86"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6f8947cf-9817-43a4-8188-80fca2e1bca0"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("73849a98-511d-41be-8a39-326305cda8a6"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("8c7b6f91-8431-45d1-9efb-7f6761e52841"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("966f2121-ab18-4e54-a611-29226ba61f47"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("99b7a943-38bf-4aa8-8330-b3374345e1b0"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("a490632c-3d1d-49cd-b5f5-8e44dd8bef30"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a80e632e-c835-4330-be60-8d1f1e3d1230"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a87f92be-7f1e-4586-be49-f32c309b7ab3"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ac097d57-4227-4927-800d-3d46733d91ca"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b3fe668e-ad00-4218-9789-c281bfc3b31c"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b6b12ca8-7303-4c87-9c33-0c00cae38ee8"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b919e309-c0f8-4be3-8094-79260a085c6c"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b9f0c289-a553-4de7-92bb-394628d58a09"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c82a52d1-d2a9-4924-a260-2b4e33f80c35"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dff84c57-31f0-4682-9198-5ed6b412b05b"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e08ff82a-1d81-422a-9f56-575feb8aa51f"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e43aaa06-12ae-4846-b6d8-c09b70bcbb34"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f0b2923a-56c2-4e33-a906-42aa0d9cd812"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f4d4fdbe-b6be-4f18-bee8-f108606de661"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe3cf65e-c0a0-4877-b992-46ba2fbef58b"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fef8939d-6b32-4394-be56-665f95e82005"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "cce5098d-03d5-476d-8626-7e3d1cc3fc84");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "35fe0149-ef3d-40f4-8260-2618042ab521");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "07a8ac69-f288-44ee-969e-4fd791f608ac");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "215195f9-b124-45c3-8493-2d772eda4fc1");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("9b69c5f8-4374-4046-96c0-a82c7e256c65"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("a446ed1c-998e-4862-bfee-f4e4ff6859c3"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("d62f74fc-3e4e-485c-9190-b17fdce01724"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("dc12fca9-d22e-49d2-a148-322e3390630f"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254), "$2a$11$vqoSyY9ckE7a4X51WuVG3u6L8tisbWgME8jg2x1j3CeXx/sbZv/22", new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254), "$2a$11$sXGBJi9J1.z5KteTF1SDe.0O29TEjkYZpc5SXIJFrC8CRDkDKvAju", new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254), "$2a$11$8uNHx3YU./g4ftayuhep1eMio1bIVQ7Ww1tzOcHsieM7i/Xj8GVju", new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254), "$2a$11$Vuxidbt2ECkGpY1M4r6eFeeQbQZg6a1RXFKqZiueJ5UziLts0uniG", new DateTime(2025, 12, 18, 15, 31, 56, 192, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245), new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245), new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245), new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245), new DateTime(2025, 12, 18, 15, 31, 57, 203, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 18, 15, 31, 57, 207, DateTimeKind.Utc).AddTicks(7117) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05a6574f-a49b-4391-b112-bf473be4d78b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("063b5f36-7e35-4f6d-902e-cf65106f92f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("071b9eb7-e6bf-4001-b698-98466ee71a62"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0f74e021-8524-49b3-82e0-7d71498f0da8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("27241f67-8432-4153-9b15-d6d10e28ec93"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("286e09d8-5908-4ee6-8bd2-c76dafb7e5a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("298fe0d5-78ad-48e9-b28c-3a4fcfda9b5a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2a9032b6-4a17-48e1-8fb9-78dfa532f339"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e4fc06c-7f50-4ad3-9d53-98b7c5d33230"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("366e93e0-aac1-4bad-b952-1a2deec14e61"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("36d3e157-1a2e-4cc7-bb9b-3d2540a1cab0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("450b6fdb-d0dc-4374-8862-3e7d271edaee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("452fb784-b9e2-49ca-92ea-0cb590c7bebc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("516cf530-e76a-496b-b93b-0f20ccd7a497"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("535ecd7c-1baf-4c0e-8c4b-a560d7ee8233"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("59b04ec2-fc44-4109-b479-cba60e2f1af9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5e10d18c-71ff-477e-a97e-2f2c1ad89d86"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6f8947cf-9817-43a4-8188-80fca2e1bca0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("73849a98-511d-41be-8a39-326305cda8a6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8c7b6f91-8431-45d1-9efb-7f6761e52841"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("966f2121-ab18-4e54-a611-29226ba61f47"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("99b7a943-38bf-4aa8-8330-b3374345e1b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a490632c-3d1d-49cd-b5f5-8e44dd8bef30"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a80e632e-c835-4330-be60-8d1f1e3d1230"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a87f92be-7f1e-4586-be49-f32c309b7ab3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac097d57-4227-4927-800d-3d46733d91ca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b3fe668e-ad00-4218-9789-c281bfc3b31c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b6b12ca8-7303-4c87-9c33-0c00cae38ee8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b919e309-c0f8-4be3-8094-79260a085c6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b9f0c289-a553-4de7-92bb-394628d58a09"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c82a52d1-d2a9-4924-a260-2b4e33f80c35"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dff84c57-31f0-4682-9198-5ed6b412b05b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e08ff82a-1d81-422a-9f56-575feb8aa51f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e43aaa06-12ae-4846-b6d8-c09b70bcbb34"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f0b2923a-56c2-4e33-a906-42aa0d9cd812"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f4d4fdbe-b6be-4f18-bee8-f108606de661"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe3cf65e-c0a0-4877-b992-46ba2fbef58b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fef8939d-6b32-4394-be56-665f95e82005"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9b69c5f8-4374-4046-96c0-a82c7e256c65"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("a446ed1c-998e-4862-bfee-f4e4ff6859c3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d62f74fc-3e4e-485c-9190-b17fdce01724"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("dc12fca9-d22e-49d2-a148-322e3390630f"));

            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "locations");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "locations");

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 2, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 26, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 21, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("046826e1-1fe1-4d74-890a-3e9c39464f9f"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("147fb4f3-8af8-4fd4-9d93-265888bad8e8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1b40264c-04cd-422d-8d45-db121384c95b"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("283b7fb7-9bbd-4f34-b6ab-2786c76408d6"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2f5f10e3-7dde-4af9-a879-b0689ecc9149"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("37fdb168-4f36-4a9c-96b3-cdab87512019"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("47f1bf9b-b9ca-410f-abef-dbb8fbb1e925"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4807943e-b857-4674-aeb9-b2d1a997f6e6"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4834ab74-3831-4c39-8591-f995981eb7c3"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5443ef24-6006-4cd2-b21f-798a77a9f293"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("54c17a8a-2c29-4e3a-9ce1-350075645e37"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("55f9e7f1-cace-4706-8c89-51b546950801"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("574189a6-f00c-4d94-8895-0ab7642e663b"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("58fefa7d-e03f-4213-bc23-7411bc676e62"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("696704d9-fdde-4dd2-afb6-1fdeb0d5da2c"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("752a7db2-21a3-4294-8965-bf11d6f14052"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("92387513-706b-48a6-bd1b-ea38d79e7d3c"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("92fff580-b665-4354-80aa-7282ddfe51d2"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("932315a6-7ebf-47b8-93ff-5d3fd7e17d5b"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a077044-eb09-45bf-9628-546b7e127470"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9e255aa8-6099-4a5b-8a86-021b03be8ddb"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ace0fb64-07e3-43d0-91b8-b31da586b867"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b17d9991-29a7-4e8f-b45c-b7e566c870d6"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ba7f98a7-bccc-4b6c-ba7f-f9a0de7497a0"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cbc7bf40-c43b-4dfd-bdac-24ed6a2dc863"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d0d830e5-13df-4ce6-9903-6025a4390f4f"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dd481eb2-6479-4f63-b369-302fadf73f56"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f087b1be-0653-4197-b61f-2bd646979657"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f4d64e28-a698-4f83-bdf4-fed1c82a1185"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("fc0c4387-f515-4030-b241-bd444664525b"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "b0406c38-ea33-436f-8315-be8bc1f3c647");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "5dde62dd-1c31-4ff7-ba75-8b39440be361");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "ffdf8127-1446-464f-8b4a-b41e5cc8a987");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "ac4f6280-e43b-45e4-ba1d-7229ba4364c8");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("3b23ce5c-fa97-497f-9ab2-af56c7f77f87"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("51071e5a-a27a-4f34-8760-4e05a2dc9099"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("8d8e8fd1-b4ab-4a92-b3d6-5f8fccd7cb75"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("ba44880a-ed3f-4463-a987-908161a6b9d1"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$3zOmcrxL2RRkOcb/DWGLHuw/qOLk/ikMMZbbR/qOFmaLk8CjcLD2G", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$tw8BZV0H5mgHecOyMyZMS.3R56JvXzSbWkJMhFgNCmYPoKPxLHRRW", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$NJo/tzRzQJcscF61cwL6uOitBbPnhZL4SlSchj7SSuwc/PcaOLZKi", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$YTYHBYvyQaRI5tIDD2Pf0eHvRt9h4JlOqQpuW0aaAjytpBUcXEYDm", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });
        }
    }
}
