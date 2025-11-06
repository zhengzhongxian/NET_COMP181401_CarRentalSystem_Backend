using System;
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class PrỉmaryKey_UserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles");

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

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") });

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") });

            migrationBuilder.AddColumn<Guid>(
                name: "user_role_id",
                table: "user_roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles",
                column: "user_role_id");

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 6, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 6, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 6, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 6, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 6, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 6, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 14, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 14, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 14, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 14, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 14, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 15, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 14, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 13, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 10, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 9, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 8, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 12, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 7, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 11, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 3, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 2, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 1, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 31, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 30, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 29, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 4, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 27, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 26, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 25, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 24, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 23, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 22, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 28, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 20, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 19, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 18, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 17, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 17, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 21, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 10, 16, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 11, 5, 15, 41, 6, 522, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 11, 5, 15, 41, 6, 523, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(4311), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(4311), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(4311), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 11, 5, 15, 41, 6, 524, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0f9938e4-927f-46c5-8d8c-535a036781c8"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1968a8cf-d28c-43a7-8394-fdb45af00c53"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e6857b5-b569-42b9-8a9b-deb292148a9b"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e6f540c-2971-4d08-8c56-890b8322cff2"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("29d0e80d-2a29-4e42-91c0-00382dd1312f"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2b3e2132-fcaf-45dd-8f43-669fdc4d1778"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e7b0eda-0668-4281-ae93-9a383595847a"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("550998f4-23ab-4a66-9ec8-6c41f4a85934"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("61943520-aa11-41c3-bbe3-f22101e7fdc5"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("78d9979c-825d-467e-abfd-b99637dab9c7"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7c04b638-b57a-4112-a4c5-a04ddc48df5d"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7c065110-f255-4dd7-96ab-2d2086c6a59d"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("84825322-1264-4eca-b1bb-4d9fd8cdf94c"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("85c8c91f-023c-4fd5-b08d-193ffbab25b2"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9f0bfde9-8517-4957-9450-af3105c57b03"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("9f651109-1545-4a74-a6eb-bcfe5ac80791"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b50415b2-6194-40d4-b4a8-e35cc30b2ee9"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("b77bc108-1df6-4b2a-96f7-b26800b9144e"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d11866e2-914d-4eb2-b656-ca722ce459f0"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d3049977-3ceb-4770-8b8b-04ebc23b6a48"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d8f60e10-cc09-4485-92e1-25521b794cdd"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dfa82070-a99d-497c-b343-78675004fea0"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e75dde5d-c26e-4eeb-96e3-3065dd430473"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f40e9216-d098-4804-972b-34824fe34df7"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f42f0b4c-0854-41f0-88c1-47a1e6270fdd"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fbd66c78-341c-457e-aa62-12771b17de54"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "1b47fa0f-bf0d-4754-a51a-12a5b00e7d2d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "e182d696-5f65-432e-9ce6-eadc1b5e9e20");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "370d2401-b665-4f47-b9ef-1f9bab8fb4b0");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "ee88acad-222e-4b6a-89a2-c8ac30a9f33b");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("2a649dfb-30e0-4753-8c26-aa3ae7a2ea56"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("9e55d85f-157b-45cb-8abf-3da879abce34"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("a1d00ba7-c2e3-4a53-b3aa-e7308eade154"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("e47392bc-e57e-47df-9aba-19139a65ae85"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515), "$2a$11$jJ5dANY3gQg2jT5U9vunxOre1fzuAfaNCGLsHmTxO3UWUb3sceVPG", new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515), "$2a$11$agPmxL5leNh39l7lFzgCNOAZSAG4ecQVFO.4NJvWVvjbqQubT417W", new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515), "$2a$11$g/rgs9Yq2CEuXX8Fh5zLreB4Hoy3BYk6l8D1y/s3aiMguIm4GT/7q", new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515), "$2a$11$D5tQgg0UVt39.iY5EV1nzunoaY5m8jzJ8DfuZC7qxXfuBd0I8W88m", new DateTime(2025, 11, 5, 15, 41, 6, 528, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884), new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884), new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884), new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884), new DateTime(2025, 11, 5, 15, 41, 7, 98, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761), new DateTime(2025, 11, 5, 15, 41, 7, 100, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_user_id",
                table: "user_roles",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles");

            migrationBuilder.DropIndex(
                name: "IX_user_roles_user_id",
                table: "user_roles");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0f9938e4-927f-46c5-8d8c-535a036781c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1968a8cf-d28c-43a7-8394-fdb45af00c53"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e6857b5-b569-42b9-8a9b-deb292148a9b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e6f540c-2971-4d08-8c56-890b8322cff2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("29d0e80d-2a29-4e42-91c0-00382dd1312f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2b3e2132-fcaf-45dd-8f43-669fdc4d1778"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e7b0eda-0668-4281-ae93-9a383595847a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("550998f4-23ab-4a66-9ec8-6c41f4a85934"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("61943520-aa11-41c3-bbe3-f22101e7fdc5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("78d9979c-825d-467e-abfd-b99637dab9c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7c04b638-b57a-4112-a4c5-a04ddc48df5d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7c065110-f255-4dd7-96ab-2d2086c6a59d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84825322-1264-4eca-b1bb-4d9fd8cdf94c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("85c8c91f-023c-4fd5-b08d-193ffbab25b2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f0bfde9-8517-4957-9450-af3105c57b03"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f651109-1545-4a74-a6eb-bcfe5ac80791"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b50415b2-6194-40d4-b4a8-e35cc30b2ee9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b77bc108-1df6-4b2a-96f7-b26800b9144e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d11866e2-914d-4eb2-b656-ca722ce459f0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d3049977-3ceb-4770-8b8b-04ebc23b6a48"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d8f60e10-cc09-4485-92e1-25521b794cdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dfa82070-a99d-497c-b343-78675004fea0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e75dde5d-c26e-4eeb-96e3-3065dd430473"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f40e9216-d098-4804-972b-34824fe34df7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f42f0b4c-0854-41f0-88c1-47a1e6270fdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fbd66c78-341c-457e-aa62-12771b17de54"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("2a649dfb-30e0-4753-8c26-aa3ae7a2ea56"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("9e55d85f-157b-45cb-8abf-3da879abce34"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("a1d00ba7-c2e3-4a53-b3aa-e7308eade154"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("e47392bc-e57e-47df-9aba-19139a65ae85"));

            migrationBuilder.DropColumn(
                name: "user_role_id",
                table: "user_roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles",
                columns: new[] { "user_id", "role_id" });

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

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

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
        }
    }
}
