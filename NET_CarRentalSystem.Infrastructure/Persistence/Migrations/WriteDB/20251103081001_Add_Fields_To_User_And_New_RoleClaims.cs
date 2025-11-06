using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_Fields_To_User_And_New_RoleClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04b12c61-095c-49b2-a387-45bfe4a3a3da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("12cb7071-a29e-4188-96d9-9e6faaf2bcc7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("206f5465-98b7-4dca-b8b2-942bd1fc1e7d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2538627b-6397-412d-82ab-242194159f3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3af6a44d-5e2c-440a-9ecc-b5b1bf51bb5b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("565727bb-71cc-451b-9d74-9dbb110a2332"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5cebb503-fb76-40d9-8657-8d62d62bb782"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a83e1e1-6100-4a2d-ba5f-07d2aaabe525"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94085391-d3da-4eb6-a19a-c381364c220e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a756a75-2a10-41f2-9acc-541d9b96809b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aa2de675-0b50-4a04-a11a-6ea48b7f5992"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d2a21927-67cb-4dd8-a896-3ca35a045bed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d92f449a-8d9d-423c-b73d-9371a05833b6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de3d1a56-da44-40bb-af15-401d0ade4a62"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e18965b1-84b1-4fc7-9f4f-4a2743909b12"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e20b33b8-2e04-405d-bb07-fcd9a233a2dd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f9404672-2c34-463e-9642-ab8a268922f5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd17dac2-e780-4897-a701-c73385f40e07"));

            migrationBuilder.RenameColumn(
                name: "reset_password_token",
                table: "users",
                newName: "current_refresh_token");

            migrationBuilder.AddColumn<DateTime>(
                name: "refresh_token_expiry_time",
                table: "users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 4, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 4, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 4, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 4, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 4, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 4, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 12, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 12, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 12, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 12, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 12, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 13, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 12, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 11, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 8, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 7, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 6, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 10, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 5, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 9, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 1, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 31, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 30, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 29, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 28, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 27, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 2, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 25, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 24, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 23, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 22, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 21, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 20, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 26, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 18, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 17, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 16, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 15, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 10, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 19, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 10, 14, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 11, 3, 8, 9, 59, 305, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492), new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492), new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492), new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492), new DateTime(2025, 11, 3, 8, 9, 59, 306, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(3379), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(3379), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(3379), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 11, 3, 8, 9, 59, 307, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("08b9d205-9bc3-4fd6-aafa-3fa9590c04a6"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0bda6927-181b-4b68-ba66-15c5b5592bfb"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0d384925-bd30-47a6-98a2-ab5b1d55a50f"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1b90769b-67d8-41e6-b590-f7efbb652edd"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1bb7dd32-307b-42a8-b84b-0c616efcada9"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2d9c680f-04c3-45e9-924d-ddb92fa30489"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("309aefb0-b9e0-49ab-9aaf-58edd30d7d96"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("3dea1f28-c93f-4513-99c3-49525c02dcb2"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4207f1ce-3cc6-41a0-b78b-d60740739220"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("481fcab4-8805-4645-a8ba-d15fae9de61c"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4cc517e4-4437-425b-8250-21db79ce4c32"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("54bc259a-a89b-41ca-a5d3-4b840190a6da"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5a5f5298-693a-44f7-968b-5363061a2a7f"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("698f4734-4eb2-4a7c-8d05-d91ef187987b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("70544c10-df55-4b4e-815a-66ba279d4e75"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("77ba851c-4bf6-4581-8357-4edc1e5b9bbf"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8720de40-ebdf-40ce-819e-c5ac793adb34"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8b5d86bf-5ca9-417d-a558-7da8da3bb5f5"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aba2562d-34ec-404d-b24c-fdb03746fb29"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b3e9db22-954b-4056-8f5c-f0e7cc5b7ba6"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c2677352-c324-489c-b1af-d4f73306da60"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e248cd22-c226-4db8-9dde-d7dd15ad4564"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f42d11a0-13b3-422c-9083-5be4a1133dd2"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f5061852-9d9f-4dc9-8af5-0d7ead57032b"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f8766dd0-7c19-4a0e-92a3-c4c613d7a84c"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fb06bc79-12d4-43e3-84d0-d24cd64d39fd"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "1c1606d6-b6a1-4fff-ad57-1cbd6bcee6fc");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "912b5a0c-1be5-4bac-929f-bffd3665cccf");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "4b21ea22-505c-412d-91f8-17059cc7e3c1");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "27791de0-4995-4e14-9b73-c376b2897a3c");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007), "$2a$11$Mqfl1x7gIEamjlkmGd/xfuCeKabfdbQmcOEZ7WG6YrrJgcMbGptK6", null, new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007), "$2a$11$tlvh1G38qEFxeTbznoAHUeQdc9KtOxRAmn/ayHKdPIX2hHXe0vqGK", null, new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007), "$2a$11$K93DuR6zf/JUm6IEz1Hs4e8wyxpQjPU3BfL7HqnF0rE0RuJzC3a5C", null, new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007), "$2a$11$acuPvZNN/hc8DELEPLluw.x5Ue30qqMI4H5YCZ3vgwER7PG8pmwFy", null, new DateTime(2025, 11, 3, 8, 9, 59, 311, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425), new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425), new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425), new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425), new DateTime(2025, 11, 3, 8, 9, 59, 807, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 11, 3, 8, 9, 59, 809, DateTimeKind.Utc).AddTicks(4336) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("08b9d205-9bc3-4fd6-aafa-3fa9590c04a6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0bda6927-181b-4b68-ba66-15c5b5592bfb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0d384925-bd30-47a6-98a2-ab5b1d55a50f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b90769b-67d8-41e6-b590-f7efbb652edd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1bb7dd32-307b-42a8-b84b-0c616efcada9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2d9c680f-04c3-45e9-924d-ddb92fa30489"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("309aefb0-b9e0-49ab-9aaf-58edd30d7d96"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3dea1f28-c93f-4513-99c3-49525c02dcb2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4207f1ce-3cc6-41a0-b78b-d60740739220"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("481fcab4-8805-4645-a8ba-d15fae9de61c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4cc517e4-4437-425b-8250-21db79ce4c32"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("54bc259a-a89b-41ca-a5d3-4b840190a6da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5a5f5298-693a-44f7-968b-5363061a2a7f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("698f4734-4eb2-4a7c-8d05-d91ef187987b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("70544c10-df55-4b4e-815a-66ba279d4e75"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("77ba851c-4bf6-4581-8357-4edc1e5b9bbf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8720de40-ebdf-40ce-819e-c5ac793adb34"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b5d86bf-5ca9-417d-a558-7da8da3bb5f5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aba2562d-34ec-404d-b24c-fdb03746fb29"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b3e9db22-954b-4056-8f5c-f0e7cc5b7ba6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2677352-c324-489c-b1af-d4f73306da60"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e248cd22-c226-4db8-9dde-d7dd15ad4564"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f42d11a0-13b3-422c-9083-5be4a1133dd2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f5061852-9d9f-4dc9-8af5-0d7ead57032b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8766dd0-7c19-4a0e-92a3-c4c613d7a84c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fb06bc79-12d4-43e3-84d0-d24cd64d39fd"));

            migrationBuilder.DropColumn(
                name: "refresh_token_expiry_time",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "current_refresh_token",
                table: "users",
                newName: "reset_password_token");

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 6, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 8, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 31, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 31, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 31, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 31, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 31, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 6, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 6, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 5, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 6, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 7, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 6, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 7, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 6, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 5, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 4, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 2, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 1, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 30, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 4, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 9, 29, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 11, 3, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 26, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 25, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 24, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 23, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 22, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 21, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 27, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 19, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 18, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 17, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 16, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 15, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 14, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 20, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 12, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 11, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 10, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 9, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 20, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 13, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 8, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 10, 28, 18, 54, 38, 495, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 10, 28, 18, 54, 38, 496, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 10, 28, 18, 54, 38, 497, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("04b12c61-095c-49b2-a387-45bfe4a3a3da"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("12cb7071-a29e-4188-96d9-9e6faaf2bcc7"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("206f5465-98b7-4dca-b8b2-942bd1fc1e7d"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2538627b-6397-412d-82ab-242194159f3e"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("3af6a44d-5e2c-440a-9ecc-b5b1bf51bb5b"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("565727bb-71cc-451b-9d74-9dbb110a2332"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5cebb503-fb76-40d9-8657-8d62d62bb782"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6a83e1e1-6100-4a2d-ba5f-07d2aaabe525"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("94085391-d3da-4eb6-a19a-c381364c220e"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("9a756a75-2a10-41f2-9acc-541d9b96809b"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("aa2de675-0b50-4a04-a11a-6ea48b7f5992"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d2a21927-67cb-4dd8-a896-3ca35a045bed"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d92f449a-8d9d-423c-b73d-9371a05833b6"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("de3d1a56-da44-40bb-af15-401d0ade4a62"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e18965b1-84b1-4fc7-9f4f-4a2743909b12"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e20b33b8-2e04-405d-bb07-fcd9a233a2dd"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f9404672-2c34-463e-9642-ab8a268922f5"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fd17dac2-e780-4897-a701-c73385f40e07"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "855789ef-ad4a-49f4-8c73-caf2430169cb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "3f35290e-471d-4faf-b5ef-5cca8086447e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "9f6859df-179b-4032-b356-2ea08e8653ec");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "f067eb6d-e1ab-4e6e-9071-ff84b9a2311e");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656), "$2a$11$o.A7oR3XhAgJfUPcbNbM5eM7DWD0mTBdAsGSgHyJkHyIE22OUNF2i", new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656), "$2a$11$M76lR2zOqj0RGd.5/UtIIOPD9Cwwis8P4hiJlNK2sYGGEI48UG4Ii", new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656), "$2a$11$74m5j0VqyPxTzUm4/F8LnuLL2B3aT1DY2MiTSmLuxT/UxocRgaWwC", new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656), "$2a$11$QJS0/NqAFcc6hLymnER/vOOLh2c9qYVHVoD1ypi1waTt9ROAn3VRq", new DateTime(2025, 10, 28, 18, 54, 38, 500, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962), new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962), new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962), new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962), new DateTime(2025, 10, 28, 18, 54, 38, 992, DateTimeKind.Utc).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 10, 28, 18, 54, 38, 994, DateTimeKind.Utc).AddTicks(5502) });
        }
    }
}
