using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Change_UserLogin_Status_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0e331874-55d4-460e-8c6d-d1233b4d104d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("202cec2e-1a12-4ba2-af1d-72086b393985"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3a2c79b5-ab26-4834-bcc7-26e148795622"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3c5422d1-7553-4fda-958b-f32f96313f6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4931620a-afcd-44fd-ad87-89cfed0b11cf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4e3b25bc-2c8f-4611-8e8f-d5f84c74d9a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4e7dba79-bce3-4882-bbac-be25d1922d8f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51edc6ee-89eb-4743-9e2f-cb2d3097a50a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66082cd8-ab1c-4d01-8bc7-13f47443da51"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6fa86f7f-d546-4b48-b2bd-5ca1d678ba2c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79fb40a3-dc99-41bb-baa0-5ac40505699f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("86a90649-084a-4345-a099-78fcc5faa35a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8a62a896-8f50-4a81-a513-95c2393b9114"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f6daa4d-4f60-4c22-9337-1fae1e5651c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8fb3a893-7928-4ca7-94f5-d46103f50762"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("90714b69-fffa-4299-9945-8cc9af85fbe8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4b03990-aa3e-486e-95f8-e70b8b666232"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6722c3e-019f-4005-bd86-d0b3634ca879"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b11dc354-37fb-4674-bef0-cf55bc871fbd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b28d2fbf-89cc-4ab4-8798-4b67954184c5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b3a452de-680a-4566-aa59-8f9071da68d5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bce78d24-d095-4d73-b11c-df771c7f563a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c4c19811-7773-4c6f-a53a-f42ecab3747a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c8793e68-7f8f-4df3-9e81-cfa3f4be24e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ebd6304d-ca7b-42e5-bb0d-a8ff8a01496a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc4823b7-a0f9-4267-b7d1-4c1574712083"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3a7fc42b-ae8b-46c3-9899-53a684ad3760"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("699e743f-f29c-43ea-a5ec-9394d4412cf8"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d7561339-69e1-4f6e-95c7-2b8b2d907c18"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d7b53492-02a9-4234-a11d-4c120bcaba12"));

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 20, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 20, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 20, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 20, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 20, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 20, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 28, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 28, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 28, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 26, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 28, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 21, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 21, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 28, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 29, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 28, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 27, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 24, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 23, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 22, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 26, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 21, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 25, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 17, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 16, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 15, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 14, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 13, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 12, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 18, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 10, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 9, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 8, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 7, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 6, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 5, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 11, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 3, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 2, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 1, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 31, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 4, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 10, 30, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189), new DateTime(2025, 11, 19, 13, 1, 29, 497, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 11, 19, 13, 1, 29, 498, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 499, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 11, 19, 13, 1, 29, 499, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 499, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 11, 19, 13, 1, 29, 499, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 499, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 11, 19, 13, 1, 29, 499, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429), new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429), new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429), new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429), new DateTime(2025, 11, 19, 13, 1, 29, 500, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("057c0201-6706-4a53-acde-89417f67c410"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16608ee1-62e4-4ed7-b8eb-53536ba995df"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1e70d6b9-3c21-4239-8ee7-0ee6a7fe09e7"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("34984c99-bf4c-4f98-93e2-646a4e809cba"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3a350eea-6a49-420c-9453-f0d5e5847e09"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("46da75ba-baf6-4c77-8c67-2f331620da40"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("479554ce-592e-4e8d-b965-126a8a7d7195"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("498937b1-dcef-4046-8ce2-b852404b0f7e"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("591e4977-508c-4905-a001-e0614491b05e"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8ae53560-2a62-47b7-b72d-493585ef9d8b"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91d10917-ccd9-40c2-bf65-63ca1aa88234"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("961764ec-a4dd-461f-ab21-a7c8a8a34a7c"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9f9cd984-aafd-4537-8ffd-dc0060fef39c"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a6932de3-e254-4c69-b73e-56e2f1eaff8e"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("aa762712-93df-4f9a-84f9-ee24d7cc6a24"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b677ff12-355f-4a28-a535-0718842b7fa8"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d005bdf6-f605-4a5a-b3d9-e603a0b03cec"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d010b4de-4162-43dd-a780-103e8a50f336"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d30cdf97-6313-409d-9c3b-4fe13b35730d"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e77155c4-0da6-4b57-b25e-5bfd9d744880"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eaf4491c-cc22-4e0b-be69-9c7089be9c12"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eb2f2dbb-3193-45ff-b987-5f480aef4e49"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("edd2aaca-b28b-4cf2-8da0-b489540462e3"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("edd700c7-6056-460b-b3db-3ee184398da9"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f52a4a31-e52c-4330-b60d-747373dddf89"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fd403039-50bd-4e52-a0cf-44a7bcd7800d"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "a20a3451-d252-4096-ad33-decbe1263b7b");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "3d2a90e8-ba0a-448e-88fb-dcc235bb0978");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "79e45718-4769-4f15-bbf0-acd82e3153d5");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "5e7bbe4f-8efa-4603-a113-1fcc87762dff");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("31cce68c-ffb0-47cf-8fdf-ae4577f562e3"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("862c62e2-9059-447e-a846-352fdd3a6d81"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("e36bac3f-a760-4ec8-b555-1e5f44be4e28"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("fc30d2c4-707a-472e-afff-e14aa560a035"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279), "$2a$11$elRpoTN7AZumcF4TJwPdO.VSY6nO/Dba1zPc/ditv2uyusUHuU9he", new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279), "$2a$11$licnElpxLjjwdyX1Q/5oDeUN5pb5q35VNHYmAVH6SYQrtmjItorB2", new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279), "$2a$11$1E2.F3sy7u8lD7nhBLALwubZW.bqNu6PCoJeeFSDVcDIdwHEdMHW.", new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279), "$2a$11$S.SM/Sixjx1VL5Y7j7AKTuJXHSmpzL4QCA2zo3vt1xnzK6DukJiBC", new DateTime(2025, 11, 19, 13, 1, 29, 504, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119), new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119), new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119), new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119), new DateTime(2025, 11, 19, 13, 1, 30, 2, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 11, 19, 13, 1, 30, 3, DateTimeKind.Utc).AddTicks(6795) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("057c0201-6706-4a53-acde-89417f67c410"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16608ee1-62e4-4ed7-b8eb-53536ba995df"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e70d6b9-3c21-4239-8ee7-0ee6a7fe09e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("34984c99-bf4c-4f98-93e2-646a4e809cba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3a350eea-6a49-420c-9453-f0d5e5847e09"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("46da75ba-baf6-4c77-8c67-2f331620da40"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("479554ce-592e-4e8d-b965-126a8a7d7195"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("498937b1-dcef-4046-8ce2-b852404b0f7e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("591e4977-508c-4905-a001-e0614491b05e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8ae53560-2a62-47b7-b72d-493585ef9d8b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91d10917-ccd9-40c2-bf65-63ca1aa88234"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("961764ec-a4dd-461f-ab21-a7c8a8a34a7c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f9cd984-aafd-4537-8ffd-dc0060fef39c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6932de3-e254-4c69-b73e-56e2f1eaff8e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aa762712-93df-4f9a-84f9-ee24d7cc6a24"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b677ff12-355f-4a28-a535-0718842b7fa8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d005bdf6-f605-4a5a-b3d9-e603a0b03cec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d010b4de-4162-43dd-a780-103e8a50f336"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d30cdf97-6313-409d-9c3b-4fe13b35730d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e77155c4-0da6-4b57-b25e-5bfd9d744880"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eaf4491c-cc22-4e0b-be69-9c7089be9c12"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eb2f2dbb-3193-45ff-b987-5f480aef4e49"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edd2aaca-b28b-4cf2-8da0-b489540462e3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edd700c7-6056-460b-b3db-3ee184398da9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f52a4a31-e52c-4330-b60d-747373dddf89"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd403039-50bd-4e52-a0cf-44a7bcd7800d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("31cce68c-ffb0-47cf-8fdf-ae4577f562e3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("862c62e2-9059-447e-a846-352fdd3a6d81"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e36bac3f-a760-4ec8-b555-1e5f44be4e28"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fc30d2c4-707a-472e-afff-e14aa560a035"));

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 14, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 14, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 14, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 14, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 14, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 14, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 22, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 22, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 22, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 22, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 22, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 23, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 22, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 21, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 18, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 17, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 16, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 20, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 15, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 19, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 11, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 10, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 9, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 8, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 7, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 6, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 12, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 4, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 3, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 2, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 1, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 31, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 30, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 5, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 28, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 27, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 26, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 25, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 19, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 29, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 10, 24, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413), new DateTime(2025, 11, 13, 17, 10, 34, 787, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 11, 13, 17, 10, 34, 788, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 789, DateTimeKind.Utc).AddTicks(4110), new DateTime(2025, 11, 13, 17, 10, 34, 789, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 789, DateTimeKind.Utc).AddTicks(4110), new DateTime(2025, 11, 13, 17, 10, 34, 789, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 789, DateTimeKind.Utc).AddTicks(4110), new DateTime(2025, 11, 13, 17, 10, 34, 789, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397), new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397), new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397), new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397), new DateTime(2025, 11, 13, 17, 10, 34, 790, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0e331874-55d4-460e-8c6d-d1233b4d104d"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("202cec2e-1a12-4ba2-af1d-72086b393985"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3a2c79b5-ab26-4834-bcc7-26e148795622"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3c5422d1-7553-4fda-958b-f32f96313f6c"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4931620a-afcd-44fd-ad87-89cfed0b11cf"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4e3b25bc-2c8f-4611-8e8f-d5f84c74d9a0"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4e7dba79-bce3-4882-bbac-be25d1922d8f"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("51edc6ee-89eb-4743-9e2f-cb2d3097a50a"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66082cd8-ab1c-4d01-8bc7-13f47443da51"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("6fa86f7f-d546-4b48-b2bd-5ca1d678ba2c"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("79fb40a3-dc99-41bb-baa0-5ac40505699f"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("86a90649-084a-4345-a099-78fcc5faa35a"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8a62a896-8f50-4a81-a513-95c2393b9114"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("8f6daa4d-4f60-4c22-9337-1fae1e5651c7"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8fb3a893-7928-4ca7-94f5-d46103f50762"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("90714b69-fffa-4299-9945-8cc9af85fbe8"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a4b03990-aa3e-486e-95f8-e70b8b666232"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a6722c3e-019f-4005-bd86-d0b3634ca879"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b11dc354-37fb-4674-bef0-cf55bc871fbd"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b28d2fbf-89cc-4ab4-8798-4b67954184c5"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("b3a452de-680a-4566-aa59-8f9071da68d5"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("bce78d24-d095-4d73-b11c-df771c7f563a"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c4c19811-7773-4c6f-a53a-f42ecab3747a"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c8793e68-7f8f-4df3-9e81-cfa3f4be24e6"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ebd6304d-ca7b-42e5-bb0d-a8ff8a01496a"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("fc4823b7-a0f9-4267-b7d1-4c1574712083"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "e9adcf96-f3b2-495e-821b-4a6508ba6f1f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "9e71bdc2-155e-4e20-b3a4-907512dbd97f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "d9484eb0-f077-40fc-8e74-7da36d490267");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "9ebb228a-50e0-4568-b334-f9e726a2f114");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("3a7fc42b-ae8b-46c3-9899-53a684ad3760"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("699e743f-f29c-43ea-a5ec-9394d4412cf8"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("d7561339-69e1-4f6e-95c7-2b8b2d907c18"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("d7b53492-02a9-4234-a11d-4c120bcaba12"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614), "$2a$11$Z8nLlgbReaE37.LkX9hWoukmnDujFnHTQIjF8YwTAEN1tWu.6J.yu", new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614), "$2a$11$vEip.5jeAttkWSujFhyMBejjFgWrOOqFheLUCfVGqNwag9l8WyiQG", new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614), "$2a$11$YyZkKVuA1gUOC0VykDVezOXrKPslg4TQGSc28NmFLwqHHAbB6OvQ6", new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614), "$2a$11$9k6LPOO50dUY/iJZD/7OsOS0Ccvpo/MbE13ob8Xh3jzK5kB0JpIUC", new DateTime(2025, 11, 13, 17, 10, 34, 794, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312), new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312), new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312), new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312), new DateTime(2025, 11, 13, 17, 10, 35, 313, DateTimeKind.Utc).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251), new DateTime(2025, 11, 13, 17, 10, 35, 315, DateTimeKind.Utc).AddTicks(251) });
        }
    }
}
