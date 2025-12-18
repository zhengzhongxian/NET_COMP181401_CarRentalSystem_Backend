using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Add_Permission_CRUD_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("08546129-aff7-45fe-9ded-251308a2b6f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0cbfe5ac-3a4c-4ffa-8ff5-6e652e9b8ec1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0f6f3707-4636-4ad2-ae80-456ad11aea15"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20f11930-99cc-41b8-9f61-4113dc39c117"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23a63530-6734-434e-b8d5-9d37705abe1d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("28262699-a796-44dc-a305-ecc8033d52f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2c1f870c-ff3a-43b7-9fae-ae8dcb6ee8ee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32785c08-596c-4c4d-8053-c483066d05ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("436312cf-57d6-476c-a7bf-61639c9fc2bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47c5bf39-4e6c-4a15-bc74-6b604ab61923"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55f35489-274c-4ba9-91b5-aa0d1da242a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("616c0239-cfdb-4724-9c3b-e02113330513"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("65141daf-8afd-4312-bc13-6c8adc259c2b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("663663fb-14be-4706-a1e6-70d42085dee9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("71c08dd2-ea2a-48e1-a8e5-e69248d5a34d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7ebb55af-d58d-44df-b80d-7e976316f9c4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9c557823-9375-405c-9dc3-d765c886c5be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a0c1a5db-f207-4754-a135-d21da1a1f389"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aeddea42-0e16-48f2-9c2a-f14cf875eb44"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b2341e39-95b9-4ae0-9a38-aa3eef255fad"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b3046b34-f78e-4333-b90f-717b1edd5d1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bc4d84c5-f38c-445a-9878-61ad37b0e68b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be84e42c-8b73-4866-af8c-1c7f5c9497cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c69b09fc-3342-499b-8609-74d8c559908e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c6bd67f9-279a-48e9-9b20-0a92642d932b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cb244b3d-6959-4995-956c-357baa60a387"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d5058b67-5457-4f18-a750-9f6b4387ff1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d5dc21ae-c180-4313-bd00-bcabb5027cd5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e137459e-b16f-43d0-9f17-e422ead41d5a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f78ab1b7-0a5c-48b9-bfe2-1a665d383234"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("5fa94762-ae8c-42c8-947e-f29f89622b55"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("861076ac-ce1d-43b9-8fcf-b8df27db91a2"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f08ca83a-440e-474a-a71a-303e72906eb3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f53a344e-e145-440f-85e2-6e7d64613c07"));

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
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 19, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 21, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 14, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 14, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 7, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 23, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 16, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 2, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 25, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 11, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 20, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 20, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 13, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 6, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 22, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 15, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 15, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 24, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 17, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "PublicId", "Thumbnail", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("04b29980-fa64-4d33-b68b-32bbecee7f8a"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("06f3a386-5fcd-4e9a-a4ee-ac356ed50e20"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("15689755-f0d5-4197-841f-f1e8226757c7"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("195eeeef-eb16-4c3b-b9a9-2b6132a16cbc"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("19867f9a-1859-4e0c-8877-7cba6fa21724"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1be57947-58a8-491d-befa-2a9fc5bab405"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("1e7e40d2-8c92-40ee-8bb2-ff93b2b3df22"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1eaf2450-d47a-4bed-a189-d91f9a961f3d"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("24871817-c373-4d27-b22a-333dddf7db4b"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2e573aab-3e88-4919-a937-08be54a75d17"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2fb8f42f-5761-4207-83d9-c2ef2d63e6b6"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4118daa5-cc8e-4b73-bc0d-a35b6b062cd5"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("57627cc7-1a5a-4b33-b449-4cf6eb0918b0"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5ad95047-ab09-4edb-b0bf-cf110268057d"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("606c4549-1c65-4085-93d9-cf62366419cb"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6d2f2ded-969b-4d89-b6cd-9bbd589af886"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8b9f6c8f-064e-42e9-b4f9-0c268ab0f642"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9f42f3b9-266f-4f88-aa0e-9f5e133cc874"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9f46284f-8a66-4b51-a497-21e67665c316"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a08d12fa-fafc-4be9-a0c8-005589a30c1e"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a445d5d7-7095-4bac-bb2d-67ae595eebdf"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a546573f-148e-4e99-a45d-4b0724f64ece"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aaccce28-7f04-4fe1-97db-2b521f1fcf36"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aae31b94-fb48-486b-a114-a86c3073072e"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ab5dd01f-93f9-4b1a-9e7c-73014395ca6c"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b120e139-6c0d-4c69-b05b-c3b5f96c1452"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c1deca5d-3c7d-42fe-a128-c481e1781ccc"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c2b6264f-2f00-46cc-8257-54d3eb56c7cc"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c4691ddf-fc1d-4b77-8c74-d71878c2d5cb"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ca93539b-ce62-4f54-900e-f030207fd209"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("cd8cb1e5-3ec2-45e6-9f33-b86fb258f801"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d00b4a57-b2d5-4f93-9b2f-bcbec8609c5c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d46a379c-4b0f-4b77-aeda-766ba1c55875"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dc65dd4c-73cf-4d4b-acdc-bd48c6061abb"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7a1a5dc-7eed-44a6-bbfc-3241af8381ce"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eb3cb783-b360-4c1e-9dfb-1c457cc21a20"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ed30119f-a5c2-4737-ba50-29597492e129"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f9d5a162-bc7c-4bf0-9d70-5656cda1c3d9"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "ed4cb362-7df7-4ca7-8a2e-f8865f5a569e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "21ad282a-e2d3-4308-a0b6-cfd9e52362cf");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "82eeb4a5-52a5-4084-973e-77a4cb46f853");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c712561d-626a-4845-b4f0-488e21e5aae7");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("64f46619-c3ae-4e72-a2f4-dab927a92b21"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("9c5e195a-987a-4dc0-b92f-180bf231ef56"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("dbe4a074-bab8-4635-836d-1547c7e05559"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("ecfc21ec-5242-4d94-9727-acea208078a8"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$8U47sA0mGRoy18diIbq3YuuFEtOpJnAKPYLRKfKCxEDxv4Smo42v2", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$.uiLcZsRIv8qkdd2IuiP.uv2Va8x0asMKWME0D8cZ.tO.1ZGZtAlK", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$QVdadgWFwlgN/TgrV8DF3eXErOAPQ79bOEavLY3/B76zUq48HHRte", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$c/.B4l/.Dms5znStgauQbeplliQeNJK4b6WxaliqMI4VUFK1maR02", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04b29980-fa64-4d33-b68b-32bbecee7f8a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("06f3a386-5fcd-4e9a-a4ee-ac356ed50e20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("15689755-f0d5-4197-841f-f1e8226757c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("195eeeef-eb16-4c3b-b9a9-2b6132a16cbc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("19867f9a-1859-4e0c-8877-7cba6fa21724"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1be57947-58a8-491d-befa-2a9fc5bab405"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e7e40d2-8c92-40ee-8bb2-ff93b2b3df22"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1eaf2450-d47a-4bed-a189-d91f9a961f3d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("24871817-c373-4d27-b22a-333dddf7db4b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e573aab-3e88-4919-a937-08be54a75d17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2fb8f42f-5761-4207-83d9-c2ef2d63e6b6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4118daa5-cc8e-4b73-bc0d-a35b6b062cd5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57627cc7-1a5a-4b33-b449-4cf6eb0918b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5ad95047-ab09-4edb-b0bf-cf110268057d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("606c4549-1c65-4085-93d9-cf62366419cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d2f2ded-969b-4d89-b6cd-9bbd589af886"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b9f6c8f-064e-42e9-b4f9-0c268ab0f642"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f42f3b9-266f-4f88-aa0e-9f5e133cc874"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f46284f-8a66-4b51-a497-21e67665c316"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a08d12fa-fafc-4be9-a0c8-005589a30c1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a445d5d7-7095-4bac-bb2d-67ae595eebdf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a546573f-148e-4e99-a45d-4b0724f64ece"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aaccce28-7f04-4fe1-97db-2b521f1fcf36"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aae31b94-fb48-486b-a114-a86c3073072e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ab5dd01f-93f9-4b1a-9e7c-73014395ca6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b120e139-6c0d-4c69-b05b-c3b5f96c1452"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c1deca5d-3c7d-42fe-a128-c481e1781ccc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2b6264f-2f00-46cc-8257-54d3eb56c7cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c4691ddf-fc1d-4b77-8c74-d71878c2d5cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca93539b-ce62-4f54-900e-f030207fd209"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cd8cb1e5-3ec2-45e6-9f33-b86fb258f801"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d00b4a57-b2d5-4f93-9b2f-bcbec8609c5c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d46a379c-4b0f-4b77-aeda-766ba1c55875"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc65dd4c-73cf-4d4b-acdc-bd48c6061abb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7a1a5dc-7eed-44a6-bbfc-3241af8381ce"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eb3cb783-b360-4c1e-9dfb-1c457cc21a20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed30119f-a5c2-4737-ba50-29597492e129"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f9d5a162-bc7c-4bf0-9d70-5656cda1c3d9"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("64f46619-c3ae-4e72-a2f4-dab927a92b21"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9c5e195a-987a-4dc0-b92f-180bf231ef56"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("dbe4a074-bab8-4635-836d-1547c7e05559"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ecfc21ec-5242-4d94-9727-acea208078a8"));

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
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 2, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 9, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 9, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 9, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 9, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 26, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 9, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 21, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 10, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 9, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 8, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 6, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 5, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 4, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 3, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 2, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 7, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 29, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 28, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 27, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 26, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 25, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 24, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 30, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 22, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 21, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 20, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 19, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 18, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 17, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 23, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 15, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 14, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 13, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 12, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 16, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 11, 11, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478), new DateTime(2025, 12, 1, 16, 1, 3, 738, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 12, 1, 16, 1, 3, 743, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 745, DateTimeKind.Utc).AddTicks(5015), new DateTime(2025, 12, 1, 16, 1, 3, 745, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 745, DateTimeKind.Utc).AddTicks(5015), new DateTime(2025, 12, 1, 16, 1, 3, 745, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 745, DateTimeKind.Utc).AddTicks(5015), new DateTime(2025, 12, 1, 16, 1, 3, 745, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 12, 1, 16, 1, 3, 748, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("08546129-aff7-45fe-9ded-251308a2b6f4"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0cbfe5ac-3a4c-4ffa-8ff5-6e652e9b8ec1"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("0f6f3707-4636-4ad2-ae80-456ad11aea15"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("20f11930-99cc-41b8-9f61-4113dc39c117"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("23a63530-6734-434e-b8d5-9d37705abe1d"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("28262699-a796-44dc-a305-ecc8033d52f9"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2c1f870c-ff3a-43b7-9fae-ae8dcb6ee8ee"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("32785c08-596c-4c4d-8053-c483066d05ea"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("436312cf-57d6-476c-a7bf-61639c9fc2bd"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("47c5bf39-4e6c-4a15-bc74-6b604ab61923"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("55f35489-274c-4ba9-91b5-aa0d1da242a5"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("616c0239-cfdb-4724-9c3b-e02113330513"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("65141daf-8afd-4312-bc13-6c8adc259c2b"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("663663fb-14be-4706-a1e6-70d42085dee9"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("71c08dd2-ea2a-48e1-a8e5-e69248d5a34d"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7ebb55af-d58d-44df-b80d-7e976316f9c4"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9c557823-9375-405c-9dc3-d765c886c5be"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a0c1a5db-f207-4754-a135-d21da1a1f389"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aeddea42-0e16-48f2-9c2a-f14cf875eb44"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b2341e39-95b9-4ae0-9a38-aa3eef255fad"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b3046b34-f78e-4333-b90f-717b1edd5d1c"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("bc4d84c5-f38c-445a-9878-61ad37b0e68b"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("be84e42c-8b73-4866-af8c-1c7f5c9497cb"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c69b09fc-3342-499b-8609-74d8c559908e"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c6bd67f9-279a-48e9-9b20-0a92642d932b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("cb244b3d-6959-4995-956c-357baa60a387"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d5058b67-5457-4f18-a750-9f6b4387ff1e"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d5dc21ae-c180-4313-bd00-bcabb5027cd5"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e137459e-b16f-43d0-9f17-e422ead41d5a"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f78ab1b7-0a5c-48b9-bfe2-1a665d383234"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "80ed8218-5eb4-4566-aaf7-26340022d4fb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "431ae472-26d8-436f-ae3f-da016d169397");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "699d4827-f96b-41ec-abfb-868fc4954c99");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "11ee8d71-d61b-468e-bd9d-67bcfa4de7e3");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("5fa94762-ae8c-42c8-947e-f29f89622b55"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("861076ac-ce1d-43b9-8fcf-b8df27db91a2"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("f08ca83a-440e-474a-a71a-303e72906eb3"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("f53a344e-e145-440f-85e2-6e7d64613c07"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860), "$2a$11$Us.0oFz4EBCkjul1PVJoBuXkQ6ZB5Mn0q7qwYipy8w3a33QAaW.Yq", new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860), "$2a$11$pA29CZ/wrYhoulld/glVQOaA3hM.WdtKYAA32erpZdp4VnQQbhcHy", new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860), "$2a$11$fv0yW.xF3LeoeVlKdNGreurnijWJfbXpnLAMbeUnUWFCHOGH08Kk2", new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860), "$2a$11$JNOyUUgc5HB1aEAHZcTBneAGbDMv1IVDtAspyS6GjxvUr/9TPbu92", new DateTime(2025, 12, 1, 16, 1, 3, 762, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 12, 1, 16, 1, 4, 381, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725), new DateTime(2025, 12, 1, 16, 1, 4, 383, DateTimeKind.Utc).AddTicks(5725) });
        }
    }
}
