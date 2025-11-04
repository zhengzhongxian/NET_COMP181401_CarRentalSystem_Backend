using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Table_User_Sessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0021d322-d768-4dcd-90ad-a07f4d98fde5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05c9d42f-5235-46fb-abe9-60be783765fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("142d2d79-291e-43e1-9f87-0a519ead7b77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("240b4743-eea5-4258-a46e-7becf1544219"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("24e7b433-1bcd-4fe4-a8fd-1279e5d389f8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("25d8f611-b96f-4077-889c-df76adf8f7f0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("28128a3b-81c7-4007-b873-67730010dfb6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2a4fce93-e570-4a18-87bd-30978d99d8a9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("419665d6-efdf-40b0-8807-f4f55f718e5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("444848e1-ece9-413b-92de-a72a58d015e5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5c0f16f9-2b3a-4f5f-9d3c-263280764466"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5c5d221f-00f6-463d-9cf2-d3788150a53d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5ec850da-db49-4995-bf96-dafe33a2c36e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6db07877-d413-4d1c-bf2f-c42db64cfc9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7698bb7d-515e-4e31-9f4b-8e0d3461553f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7e4ca5e5-f387-4f11-b6e1-cb8b9a048b1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8a0a62e1-ecfc-4e33-baaa-7763348631d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9b3c0838-1535-4dd2-8efe-43be16e4ddbe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a2f7e96b-ae9b-4cd8-ad26-3af7d3b00709"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aee87968-56bd-49d7-8951-8723840785bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bf172f63-57a7-47f4-8b2a-45365ac2bb65"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c5235d32-33a7-448a-8293-f36392f700f1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c9ce8891-e6d7-4fcd-8a6a-af60454ab917"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ce739956-bd2d-449d-b965-e51f2dd64b0e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cef0426b-45aa-4be2-ab0f-4ecfd5ef8b13"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d48cef13-3323-4add-8cfb-c2745c2bb2e2"));

            migrationBuilder.DropColumn(
                name: "current_refresh_token",
                table: "users");

            migrationBuilder.DropColumn(
                name: "refresh_token_expiry_time",
                table: "users");

            migrationBuilder.CreateTable(
                name: "user_sessions",
                columns: table => new
                {
                    user_session_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    refresh_token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    refresh_token_expiry_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    device_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ip_address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_sessions", x => x.user_session_id);
                    table.ForeignKey(
                        name: "FK_user_sessions_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 5, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 5, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 5, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 5, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 5, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 5, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 13, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 13, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 13, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 13, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 13, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 14, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 13, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 12, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 9, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 8, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 7, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 11, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 6, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 10, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 2, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 1, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 31, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 30, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 29, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 28, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 3, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 26, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 25, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 24, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 23, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 22, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 21, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 27, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 19, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 18, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 17, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 16, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 5, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 20, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 10, 15, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 11, 4, 3, 37, 31, 925, DateTimeKind.Utc).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 11, 4, 3, 37, 31, 926, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 11, 4, 3, 37, 31, 927, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("07376432-af51-4c51-8e53-295bf39b326d"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0c844797-406d-473f-9542-683874542db1"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("19746243-0215-49db-b9c4-41e006f41926"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30cfd568-7636-4d79-b1ad-d9cae283e036"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("426b0b8b-a396-4627-b939-329a5c018b17"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("505371cf-2dca-4a8c-9b86-de3a56deda1c"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("57f67bb0-565b-4f27-9f2e-4be2f83ab288"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5c6ff11f-b805-4d9e-bbe4-aceabab88a59"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("664db311-1eb9-4bf6-b147-02cb0f08a05b"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6902984c-4b75-44e1-82c1-395e8356ca79"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7f077df1-62b8-4d75-960a-015f9d435dfb"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("94ce6fe8-b615-434b-a945-28ee140cc385"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9c8642e5-9676-45c5-b7f8-e556e84e6828"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9cc0e223-fb5c-4006-87f8-91c6eddca46e"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9f83cd81-4fc8-4480-9f8e-48dccf3c6997"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a92c6146-9778-4901-831b-db7f084eac64"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b4a84482-01d1-4c59-bf0a-5a07cf2b20cd"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b7d1ebed-b5bb-46c6-974f-d23336bef1d6"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c636e191-eaf2-41d2-a92d-df7089fe4d3a"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d9cb97d1-f1bb-47b3-ac7c-25fca0424938"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("dc898076-9c37-487f-95e2-1f6620d8d8f0"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("de0278b1-39fd-47c1-9a86-23f6724b6d4e"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("de7569b6-328f-42e9-8520-5cb11c9dfbf5"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e1a28142-549a-4d7f-9c97-5315fad9f603"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e62c74d4-f64b-4bb7-9854-6f00ac96f8fb"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fc510c4e-95d0-43b3-83bd-cb18537f643f"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "5444e87b-71b7-411a-9cda-7ea14bffd4de");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "74a11b07-f82b-4a56-9b30-7a1f6c00f8cf");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "e052d156-56ec-4718-a0d5-360b3d0cbd05");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "3dba4355-3c50-44f2-86a4-a8aaf001c9b9");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678), "$2a$11$PAATeYTX6OgoHvJFcbwaqePnrIxMwpvGalpNiW/lRmIzzm8lsDj7S", new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678), "$2a$11$/q9AKKLLTbgNpuVvQDwofuKGZxhc/0l9FLCvexyNou8WzZKpPOEum", new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678), "$2a$11$UE6.QJx2StmoHHz7yinp3eC9ml5WFfKv07M2LjbIGgcNnSt3WKUd.", new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678), "$2a$11$cqJ1WG3Ks9TGAmJUzIuLk.K5iyrUuLaf2Yt5dECIX2dVFiu7KMj6K", new DateTime(2025, 11, 4, 3, 37, 31, 930, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 11, 4, 3, 37, 32, 435, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 11, 4, 3, 37, 32, 437, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.CreateIndex(
                name: "IX_user_sessions_user_id",
                table: "user_sessions",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_sessions");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("07376432-af51-4c51-8e53-295bf39b326d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c844797-406d-473f-9542-683874542db1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("19746243-0215-49db-b9c4-41e006f41926"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30cfd568-7636-4d79-b1ad-d9cae283e036"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("426b0b8b-a396-4627-b939-329a5c018b17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("505371cf-2dca-4a8c-9b86-de3a56deda1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57f67bb0-565b-4f27-9f2e-4be2f83ab288"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5c6ff11f-b805-4d9e-bbe4-aceabab88a59"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("664db311-1eb9-4bf6-b147-02cb0f08a05b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6902984c-4b75-44e1-82c1-395e8356ca79"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7f077df1-62b8-4d75-960a-015f9d435dfb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94ce6fe8-b615-434b-a945-28ee140cc385"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9c8642e5-9676-45c5-b7f8-e556e84e6828"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9cc0e223-fb5c-4006-87f8-91c6eddca46e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f83cd81-4fc8-4480-9f8e-48dccf3c6997"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a92c6146-9778-4901-831b-db7f084eac64"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b4a84482-01d1-4c59-bf0a-5a07cf2b20cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b7d1ebed-b5bb-46c6-974f-d23336bef1d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c636e191-eaf2-41d2-a92d-df7089fe4d3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d9cb97d1-f1bb-47b3-ac7c-25fca0424938"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc898076-9c37-487f-95e2-1f6620d8d8f0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de0278b1-39fd-47c1-9a86-23f6724b6d4e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de7569b6-328f-42e9-8520-5cb11c9dfbf5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e1a28142-549a-4d7f-9c97-5315fad9f603"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e62c74d4-f64b-4bb7-9854-6f00ac96f8fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc510c4e-95d0-43b3-83bd-cb18537f643f"));

            migrationBuilder.AddColumn<string>(
                name: "current_refresh_token",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 4, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 4, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 4, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 4, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 4, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 4, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 12, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 12, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 12, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 12, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 12, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 13, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 12, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 11, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 8, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 7, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 6, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 10, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 5, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 9, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 1, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 31, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 30, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 29, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 28, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 27, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 2, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 25, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 24, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 23, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 22, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 21, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 20, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 26, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 18, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 17, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 16, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 15, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 10, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 19, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 10, 14, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 11, 3, 8, 8, 51, 170, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578), new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578), new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578), new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578), new DateTime(2025, 11, 3, 8, 8, 51, 171, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889), new DateTime(2025, 11, 3, 8, 8, 51, 172, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0021d322-d768-4dcd-90ad-a07f4d98fde5"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("05c9d42f-5235-46fb-abe9-60be783765fc"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("142d2d79-291e-43e1-9f87-0a519ead7b77"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("240b4743-eea5-4258-a46e-7becf1544219"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("24e7b433-1bcd-4fe4-a8fd-1279e5d389f8"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("25d8f611-b96f-4077-889c-df76adf8f7f0"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("28128a3b-81c7-4007-b873-67730010dfb6"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("2a4fce93-e570-4a18-87bd-30978d99d8a9"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("419665d6-efdf-40b0-8807-f4f55f718e5f"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("444848e1-ece9-413b-92de-a72a58d015e5"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5c0f16f9-2b3a-4f5f-9d3c-263280764466"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5c5d221f-00f6-463d-9cf2-d3788150a53d"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5ec850da-db49-4995-bf96-dafe33a2c36e"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6db07877-d413-4d1c-bf2f-c42db64cfc9f"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7698bb7d-515e-4e31-9f4b-8e0d3461553f"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7e4ca5e5-f387-4f11-b6e1-cb8b9a048b1e"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8a0a62e1-ecfc-4e33-baaa-7763348631d6"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9b3c0838-1535-4dd2-8efe-43be16e4ddbe"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a2f7e96b-ae9b-4cd8-ad26-3af7d3b00709"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aee87968-56bd-49d7-8951-8723840785bd"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("bf172f63-57a7-47f4-8b2a-45365ac2bb65"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c5235d32-33a7-448a-8293-f36392f700f1"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c9ce8891-e6d7-4fcd-8a6a-af60454ab917"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ce739956-bd2d-449d-b965-e51f2dd64b0e"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("cef0426b-45aa-4be2-ab0f-4ecfd5ef8b13"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d48cef13-3323-4add-8cfb-c2745c2bb2e2"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "90628fd7-e256-4b19-9571-c29877b9117e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "89e47fae-f2b9-4eb2-9ae4-094f3616c9c8");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "10759957-5e7d-4c65-ab3e-f4ddae786040");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "45b0e6fd-2766-4656-bb88-dc9c38664bd3");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "current_refresh_token", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968), null, "$2a$11$HKrAvW2DBij52CEPQS68SegnzyvLef6sip7vNDyOmrkMsXKT8Hp5u", null, new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "current_refresh_token", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968), null, "$2a$11$MhGI590WjU9q1tFheY4BYeZCoQ7BhEJFInXkGp2ZQF1AlKiZihglW", null, new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "current_refresh_token", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968), null, "$2a$11$jN07qaTitirz43DtHQtX/uPGRZTr9z/vy7gP6zJQ1tnSxzDwyp/bS", null, new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "current_refresh_token", "password", "refresh_token_expiry_time", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968), null, "$2a$11$ftgbIr14e902ILD8Zpu8Zuaw/X2uacchP/3r5DORMwoHcmnLVrbgW", null, new DateTime(2025, 11, 3, 8, 8, 51, 176, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 11, 3, 8, 8, 51, 654, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 11, 3, 8, 8, 51, 655, DateTimeKind.Utc).AddTicks(9766) });
        }
    }
}
