using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class SeedData_Attribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 8, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 8, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 29, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 1, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 29, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 3, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 5, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 29, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 28, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 7, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 7, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 29, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 30, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 9, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 2, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 29, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 2, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 4, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 30, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 29, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 28, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 27, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 26, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 25, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 24, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 23, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 9, 22, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 27, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 19, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 18, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 17, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 16, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 15, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 14, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 20, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 12, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 11, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 10, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 9, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 8, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 7, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 13, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 5, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 4, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 3, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 2, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 6, 11, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 6, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 1, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846), new DateTime(2025, 10, 21, 9, 25, 20, 738, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 10, 21, 9, 25, 20, 739, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(2146), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 10, 21, 9, 25, 20, 740, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                columns: new[] { "concurrency_stamp", "created_at", "updated_at" },
                values: new object[] { "3104ca6e-4fd2-4372-87f3-3046b3bf4c77", new DateTime(2025, 10, 21, 9, 25, 20, 741, DateTimeKind.Utc).AddTicks(8636), new DateTime(2025, 10, 21, 9, 25, 20, 741, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"),
                columns: new[] { "concurrency_stamp", "created_at", "updated_at" },
                values: new object[] { "683058b3-606f-4472-825e-4379849717f8", new DateTime(2025, 10, 21, 9, 25, 20, 741, DateTimeKind.Utc).AddTicks(8636), new DateTime(2025, 10, 21, 9, 25, 20, 741, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"),
                columns: new[] { "concurrency_stamp", "created_at", "updated_at" },
                values: new object[] { "f56636ef-dca9-4300-b3a9-2a73a8a4b853", new DateTime(2025, 10, 21, 9, 25, 20, 741, DateTimeKind.Utc).AddTicks(8636), new DateTime(2025, 10, 21, 9, 25, 20, 741, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700), "$2a$11$hvRgOKZ9VfHwKqjFg7.2UOE8WCq7b3gKw1qNF56jyT0NnajNucIhS", new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700), "$2a$11$wEK.8nDMMsBEbBx62usTOOw14.VKo2KdaI4TCbJaxIkXBvKc1IKUG", new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700), "$2a$11$LYyVca.ppX/X6gJJlzNMKerDwqz8VhGW6iUHDZHQAlT8j4hzPXxKS", new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700), "$2a$11$m38XkKI4wQ/x6QHZMde70u.P7LdM5UuLhUC21RblTb15QxeRFL.Kq", new DateTime(2025, 10, 21, 9, 25, 20, 743, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.InsertData(
                table: "vehicle_attributes",
                columns: new[] { "attribute_id", "attribute_key", "attribute_value", "vehicle_id" },
                values: new object[,]
                {
                    { new Guid("30000000-0000-0000-0000-000000000001"), "Dung tích xi lanh", "1.5L", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("30000000-0000-0000-0000-000000000002"), "Mức tiêu thụ nhiên liệu", "5.8L/100km", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("30000000-0000-0000-0000-000000000003"), "Hệ dẫn động", "Cầu sau (RWD)", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("30000000-0000-0000-0000-000000000004"), "Số túi khí", "7", new Guid("00000000-0000-0000-0000-000000000002") }
                });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025), new DateTime(2025, 10, 21, 9, 25, 21, 264, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 10, 21, 9, 25, 21, 266, DateTimeKind.Utc).AddTicks(6074) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vehicle_attributes",
                keyColumn: "attribute_id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "vehicle_attributes",
                keyColumn: "attribute_id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "vehicle_attributes",
                keyColumn: "attribute_id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "vehicle_attributes",
                keyColumn: "attribute_id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"));

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 6, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 6, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 27, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 29, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 8, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 1, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 27, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 1, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 10, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 3, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 27, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 26, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 5, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 5, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 27, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 28, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 7, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 30, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 27, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 30, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 9, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 2, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 28, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 27, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 26, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 9, 25, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 24, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 23, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 22, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 21, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 20, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 25, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 17, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 16, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 15, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 14, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 13, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 12, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 18, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 10, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 9, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 8, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 7, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 6, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 5, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 11, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 3, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 2, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 1, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 30, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 4, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 9, 29, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513), new DateTime(2025, 10, 19, 3, 50, 0, 50, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 10, 19, 3, 50, 0, 51, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(2557), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(2557), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(2557), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714), new DateTime(2025, 10, 19, 3, 50, 0, 52, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                columns: new[] { "concurrency_stamp", "created_at", "updated_at" },
                values: new object[] { "45a4421f-1855-4674-a6ff-48649389bf8b", new DateTime(2025, 10, 19, 3, 50, 0, 53, DateTimeKind.Utc).AddTicks(6963), new DateTime(2025, 10, 19, 3, 50, 0, 53, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa2"),
                columns: new[] { "concurrency_stamp", "created_at", "updated_at" },
                values: new object[] { "08bc8336-a51d-4d49-bcf7-b7818b541a31", new DateTime(2025, 10, 19, 3, 50, 0, 53, DateTimeKind.Utc).AddTicks(6963), new DateTime(2025, 10, 19, 3, 50, 0, 53, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3"),
                columns: new[] { "concurrency_stamp", "created_at", "updated_at" },
                values: new object[] { "39c07ce1-ff98-4457-88fa-4df72acc28b3", new DateTime(2025, 10, 19, 3, 50, 0, 53, DateTimeKind.Utc).AddTicks(6963), new DateTime(2025, 10, 19, 3, 50, 0, 53, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147), "$2a$11$7ZzSjnWzYS7Fej7p6F9YzuXs9Y3br0c/H/8VJxY/MqYXuk24ZmIge", new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147), "$2a$11$06AdaSSzi9v6zwTlbWedVewGvsKxbiGbLRSSG5/6g0L5OKahT89.C", new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147), "$2a$11$VD6KVnBjjLXfEV1UKZ7YpeY9lMolX0uF0aLA0X6E798FY.vTJEN5S", new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147), "$2a$11$cFmqt5Wud.MASKH2SH8qou848cWs32kg6Eni91JqcT.hGA4vjCkTu", new DateTime(2025, 10, 19, 3, 50, 0, 55, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920), new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920), new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920), new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920), new DateTime(2025, 10, 19, 3, 50, 0, 555, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 10, 19, 3, 50, 0, 557, DateTimeKind.Utc).AddTicks(4556) });
        }
    }
}
