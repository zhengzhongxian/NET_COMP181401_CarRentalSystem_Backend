using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Edit_Table_User_And_UserSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_user_id",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_cccd_number",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_driver_license_id",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_user_id",
                table: "customers");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("09cc5fd6-5980-4f50-ad59-ad8e36fd527c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0e889cd5-0a78-4095-a270-a3c3533a0b47"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21345c8e-298f-4b83-a0a8-d0bfa79f9e69"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("275555e4-4c97-4c47-a4ea-7b36a98aee7a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30de98c6-47c0-4caf-a0b2-d12078aa3542"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3ffaaaa4-abc0-4c41-8049-1459e9abfc6b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4940c396-52c9-49ef-8a6c-75090a44b9f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4d6e3b22-ee10-4259-a060-426f9ae10202"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5a4713cd-fde4-499b-ae2a-2dcbdc76b3c2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6241a303-1e0c-40c3-bcc6-8bbf2a2f76d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("695fb4c5-3e8a-44aa-8d62-888495c2d927"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("85460b66-daf7-4ea7-b3ad-d69882ce0c5e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8a1ca1e6-b25b-43a2-9f04-e7620b689e43"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8aa7b862-9ed2-42e5-af95-d9929ae6f56b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8e7f0e93-1d1f-4a42-8e8f-cdf839349c46"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("926721c0-b635-4178-98f4-989d5b9997c6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9b64cec1-b970-4087-b08a-7614b931e468"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aefb4894-871f-4c9c-8c7e-d8e6b33a7181"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b320fe9b-b8b3-41c0-a01d-004302c240b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c4dadd95-e2d2-45cb-b3ad-ba0ffff6f9b4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e555a074-11dc-4cfa-a6e2-6677f82eb0bc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed3b0c06-fbf6-4af9-9cd0-90bc9c547f18"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1119086-549f-41ef-ab39-82692fe5245a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe394ac6-b755-4d39-a510-d5a54ad39263"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("feddbdda-8ccf-478f-8f31-8ec9c6529433"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fffb6a78-cd38-401c-bb3e-e7d7f24c957c"));

            migrationBuilder.DropColumn(
                name: "otp",
                table: "users");

            migrationBuilder.DropColumn(
                name: "otp_attempts",
                table: "users");

            migrationBuilder.DropColumn(
                name: "otp_expires",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_id",
                table: "customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_front_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "driver_license_expiry",
                table: "customers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_back_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cccd_number",
                table: "customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "cccd_issue_place",
                table: "customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "cccd_issue_date",
                table: "customers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "cccd_front_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cccd_back_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "customers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 6, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 6, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 6, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 6, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 6, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 6, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 14, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 14, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 14, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 14, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 14, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 15, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 14, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 13, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 10, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 9, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 8, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 12, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 7, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 11, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 3, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 2, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 1, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 31, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 30, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 29, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 4, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 27, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 26, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 25, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 24, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 23, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 22, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 28, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 20, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 19, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 18, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 17, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 15, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 21, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 10, 16, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 11, 5, 13, 42, 42, 771, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(8239), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(8239), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(8239), new DateTime(2025, 11, 5, 13, 42, 42, 773, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762), new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762), new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762), new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762), new DateTime(2025, 11, 5, 13, 42, 42, 774, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("146a1d6e-369d-4a23-9c09-1a8c7725c616"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("168b6123-6b0c-4c9d-9376-30da482c65b6"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1cd64795-8554-4298-89a8-20d98bf37059"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("204fb89f-5e8e-44ce-9392-e5c4f8da83d8"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("20e12b96-4122-4e0c-9607-af022f0975bd"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3f3b464a-9eae-40d9-9c98-bbae78ef790c"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("50847f8e-1858-4d87-bad6-8068ca6f28b9"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5702a1c8-c940-4a1e-bf89-ae0928431c73"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5df43722-e76e-46bf-9e6c-6e057d38f007"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("612e536b-7c88-43ab-91dd-e1c386af8356"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6486c693-2984-40ec-9f45-0aac8608cf43"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6a148f72-6a4e-44bb-bf33-6f4fbe43e0a2"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6b6f8fbc-1a88-4645-bff7-4c309317edfd"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("6bf6096e-0da9-4cd0-92b4-af541f350409"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6dff2b84-3bf5-43e5-ae3c-0b99a91623e9"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7449db65-e3e9-4a68-acb0-32417d9ef1b1"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7452a2de-19b6-415e-b6da-c9d1548547cc"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("787a66f7-eaf0-4687-9afb-7b0c2fc1cc5a"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7db2685d-816c-47ea-a577-c8aa1a68fa75"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("860019e2-1768-4cc2-bc85-b9169d25334f"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8d16f8c5-efb7-47d2-bdc2-cf8c3cee39f5"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a27dc395-d439-4f72-9bc5-1b33ba9b4c8f"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c05d3dbc-d1d3-4a1c-861a-0cd05c6e0e26"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d101f442-b1e6-45b8-8e0f-eab4c45f0f20"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d55e7376-22cf-49a9-9cd6-9027d3087968"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("df2c538e-286c-4184-81e5-fb5e930304e6"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "3f34bcf5-18be-48a9-96e5-99382ff69258");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "403ced16-f664-4f4e-847f-ba03180910a3");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "6b092f6e-4965-443e-99e2-45378fe89848");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "1e4b4aba-a1fc-4f1d-a4b7-b68d57cb269f");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754), "$2a$11$k1H00ZCwUCByZJlAhnlKhuzi6JUZ6SgjV03N89tGXA2JJHgxN3tGy", new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754), "$2a$11$sMhoW8304Oo.7r0aCHEX0eHx7Gn8oLvGvasu5Q8Igy5KHYI3lBXHq", new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754), "$2a$11$b.avjXzs0.gsRPdrSg1lIuuQvKuPNmD0a2m5pkG6KOEHC7sy4nRnK", new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754), "$2a$11$68f7Znz1B.xd0o1/gIVS2.S4DLryAKnUzgtEEGLydmVM/7yqH8Kvm", new DateTime(2025, 11, 5, 13, 42, 42, 778, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753), new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753), new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753), new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753), new DateTime(2025, 11, 5, 13, 42, 43, 350, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 11, 5, 13, 42, 43, 352, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_cccd_number",
                table: "customers",
                column: "cccd_number",
                unique: true,
                filter: "[cccd_number] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_customers_driver_license_id",
                table: "customers",
                column: "driver_license_id",
                unique: true,
                filter: "[driver_license_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_customers_user_id",
                table: "customers",
                column: "user_id",
                unique: true,
                filter: "[user_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_user_id",
                table: "customers",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_user_id",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_cccd_number",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_driver_license_id",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_user_id",
                table: "customers");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("146a1d6e-369d-4a23-9c09-1a8c7725c616"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("168b6123-6b0c-4c9d-9376-30da482c65b6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1cd64795-8554-4298-89a8-20d98bf37059"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("204fb89f-5e8e-44ce-9392-e5c4f8da83d8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20e12b96-4122-4e0c-9607-af022f0975bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3f3b464a-9eae-40d9-9c98-bbae78ef790c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("50847f8e-1858-4d87-bad6-8068ca6f28b9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5702a1c8-c940-4a1e-bf89-ae0928431c73"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5df43722-e76e-46bf-9e6c-6e057d38f007"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("612e536b-7c88-43ab-91dd-e1c386af8356"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6486c693-2984-40ec-9f45-0aac8608cf43"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a148f72-6a4e-44bb-bf33-6f4fbe43e0a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6b6f8fbc-1a88-4645-bff7-4c309317edfd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6bf6096e-0da9-4cd0-92b4-af541f350409"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6dff2b84-3bf5-43e5-ae3c-0b99a91623e9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7449db65-e3e9-4a68-acb0-32417d9ef1b1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7452a2de-19b6-415e-b6da-c9d1548547cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("787a66f7-eaf0-4687-9afb-7b0c2fc1cc5a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7db2685d-816c-47ea-a577-c8aa1a68fa75"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("860019e2-1768-4cc2-bc85-b9169d25334f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8d16f8c5-efb7-47d2-bdc2-cf8c3cee39f5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a27dc395-d439-4f72-9bc5-1b33ba9b4c8f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c05d3dbc-d1d3-4a1c-861a-0cd05c6e0e26"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d101f442-b1e6-45b8-8e0f-eab4c45f0f20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d55e7376-22cf-49a9-9cd6-9027d3087968"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("df2c538e-286c-4184-81e5-fb5e930304e6"));

            migrationBuilder.AddColumn<string>(
                name: "otp",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "otp_attempts",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "otp_expires",
                table: "users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_id",
                table: "customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_front_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "driver_license_expiry",
                table: "customers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_back_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cccd_number",
                table: "customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cccd_issue_place",
                table: "customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "cccd_issue_date",
                table: "customers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cccd_front_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cccd_back_url",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "customers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 5, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 5, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 5, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 5, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 5, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 5, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 13, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 13, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 13, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 13, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 13, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 14, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 13, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 12, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 11, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 9, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 8, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 7, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 11, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 6, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 10, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 2, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 1, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 31, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 30, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 29, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 28, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 3, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 26, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 25, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 24, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 23, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 22, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 21, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 27, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 19, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 18, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 17, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 16, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 5, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 20, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 10, 15, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 11, 4, 3, 36, 55, 699, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 11, 4, 3, 36, 55, 700, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 11, 4, 3, 36, 55, 701, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("09cc5fd6-5980-4f50-ad59-ad8e36fd527c"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0e889cd5-0a78-4095-a270-a3c3533a0b47"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("21345c8e-298f-4b83-a0a8-d0bfa79f9e69"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("275555e4-4c97-4c47-a4ea-7b36a98aee7a"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30de98c6-47c0-4caf-a0b2-d12078aa3542"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("3ffaaaa4-abc0-4c41-8049-1459e9abfc6b"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4940c396-52c9-49ef-8a6c-75090a44b9f4"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("4d6e3b22-ee10-4259-a060-426f9ae10202"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5a4713cd-fde4-499b-ae2a-2dcbdc76b3c2"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6241a303-1e0c-40c3-bcc6-8bbf2a2f76d3"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("695fb4c5-3e8a-44aa-8d62-888495c2d927"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("85460b66-daf7-4ea7-b3ad-d69882ce0c5e"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8a1ca1e6-b25b-43a2-9f04-e7620b689e43"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8aa7b862-9ed2-42e5-af95-d9929ae6f56b"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8e7f0e93-1d1f-4a42-8e8f-cdf839349c46"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("926721c0-b635-4178-98f4-989d5b9997c6"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9b64cec1-b970-4087-b08a-7614b931e468"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aefb4894-871f-4c9c-8c7e-d8e6b33a7181"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b320fe9b-b8b3-41c0-a01d-004302c240b0"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c4dadd95-e2d2-45cb-b3ad-ba0ffff6f9b4"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e555a074-11dc-4cfa-a6e2-6677f82eb0bc"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ed3b0c06-fbf6-4af9-9cd0-90bc9c547f18"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1119086-549f-41ef-ab39-82692fe5245a"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("fe394ac6-b755-4d39-a510-d5a54ad39263"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("feddbdda-8ccf-478f-8f31-8ec9c6529433"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fffb6a78-cd38-401c-bb3e-e7d7f24c957c"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "af59ef91-6400-4c8f-9cb6-a801eb863eb6");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "2fb190f9-40b7-4b21-8851-467963ad4762");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "4f1968cb-970b-4bbf-afc6-b37c3cc35416");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "05f2892f-422d-4b0b-9076-f9bc5d1de808");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "otp", "otp_attempts", "otp_expires", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606), null, 0, null, "$2a$11$i551NcbVxo2m/4lzkTUmkOiKTSCsROJm6dGroETWFUb8fUUH70wqG", new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "otp", "otp_attempts", "otp_expires", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606), null, 0, null, "$2a$11$6OPATbxLp4wRAEWcTUvK3.325e9K1BcC8lqj0uewmXZ5gdgP5E1f.", new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "otp", "otp_attempts", "otp_expires", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606), null, 0, null, "$2a$11$X59aPhObvkBSr/6UXuBID.PZ1NNbyFawg7J6OsqQdOkzh65IPZBfm", new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "otp", "otp_attempts", "otp_expires", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606), null, 0, null, "$2a$11$90mliShpjywMPf19UJwVN.h6SziXxl3zX9Fl2bcLFBd1Rb4kPR4Ea", new DateTime(2025, 11, 4, 3, 36, 55, 704, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 11, 4, 3, 36, 56, 185, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628), new DateTime(2025, 11, 4, 3, 36, 56, 186, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_cccd_number",
                table: "customers",
                column: "cccd_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_driver_license_id",
                table: "customers",
                column: "driver_license_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_user_id",
                table: "customers",
                column: "user_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_user_id",
                table: "customers",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
