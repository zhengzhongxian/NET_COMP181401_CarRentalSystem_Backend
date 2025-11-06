using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
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
                keyValue: new Guid("123e2903-a843-4a53-b91f-5e7379a235ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2461ac8c-bb2b-4ca6-956a-fb675999dc19"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4060c05d-cb6d-4254-af43-49485322a2aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4440c405-b2ef-45ca-b1bb-5019a482b03f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("493602af-bb6e-4f92-833c-5e5a8a7a5363"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4a940f26-91cb-4598-a2c6-293a9ee551ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51607dfb-25a6-4954-8432-f3f91feae0d4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("586c2268-e6c0-4804-b0b0-87a4584267d4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("648e8f34-6c45-4c38-b3f0-b4315ce446f7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6e3f814d-c342-4808-9744-e56b96ad134b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("741e9a29-1f4d-430f-bff1-56d74cc82fd5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7a469ab9-ccc5-42d3-81d2-e441672806a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("85ca2619-ac3d-4af4-bd5e-3204f24955e9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("87ea4717-3934-46ce-8515-01ba0acdcada"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("93b6c578-3ae7-4a82-a67c-75cd5fa23d3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("984217a0-e88f-4186-a689-fec4fb801d23"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a1185834-67bd-4495-bcd4-6fd2c25d50e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3574fa4-76e6-4bbd-815b-071302430ce8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b4badc1a-5ce0-4ae3-8a17-9f3dd5681129"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c746fa0d-4df3-4b29-ae2f-81eb5f687a68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ccf72df1-d13f-4b06-87c5-fe81db728225"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cdf0e69e-3264-466e-ac8d-8380f9147a3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d218bb9f-36bc-45bc-9ef8-0a565e49b7c9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea61216d-222b-46d0-9ddf-763d3d3aa64b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f5ca12fc-5c9b-4dce-886c-4f65410644c2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f99f8da6-356d-4d4f-8d46-02bff2ca7595"));

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
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 6, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 6, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 6, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 6, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 6, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 6, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 14, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 14, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 14, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 14, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 14, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 15, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 14, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 13, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 10, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 9, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 8, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 12, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 7, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 11, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 3, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 2, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 1, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 31, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 30, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 29, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 4, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 27, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 26, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 25, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 24, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 23, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 22, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 28, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 20, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 19, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 18, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 17, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 17, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 21, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 10, 16, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790), new DateTime(2025, 11, 5, 15, 41, 46, 300, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 11, 5, 15, 41, 46, 303, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 304, DateTimeKind.Utc).AddTicks(7887), new DateTime(2025, 11, 5, 15, 41, 46, 304, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 304, DateTimeKind.Utc).AddTicks(7887), new DateTime(2025, 11, 5, 15, 41, 46, 304, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 304, DateTimeKind.Utc).AddTicks(7887), new DateTime(2025, 11, 5, 15, 41, 46, 304, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306), new DateTime(2025, 11, 5, 15, 41, 46, 307, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("05e60b60-b28c-44a9-9e4d-a0c5add34310"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("172cd1f5-39b7-4490-9b2e-0cba4e0b1398"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e88e1ca-0bf5-42f3-92e3-327f52189e0b"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("20e5c9ab-031f-4284-acbc-68d00f7d7793"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("38183fb7-d547-4860-8757-076cf8b6a173"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("3b4b45d3-6d7d-41df-83a8-3cc4e0ae9302"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4c43aad7-8a19-4c24-9fba-c1588947a413"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("53519638-f458-4de1-a9fc-ad85cf722127"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("58f3ee93-b828-401d-9a35-764294c8e3e8"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5adb11ca-a174-4569-bb52-5918b3c18453"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("619afd0a-7ed2-4a0d-81d4-8027be3ae10c"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("87366768-ad48-48cb-b516-39bb3150213b"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8c67644d-f0bf-4d81-bd66-8e826c83a7f7"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("92af0db8-38d5-43d3-bdfa-02ee6e68ef5d"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("97b4696f-0644-439b-b796-14433a9dcd8d"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("9f5c0836-cd45-4f68-adce-5b53e9a921eb"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a4cf5be8-5f65-4037-8005-f7bb070651ec"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b04259e6-0c53-4694-aecf-8d472648e0c9"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b0e15014-f4bd-4e4f-9541-c94c7dc2f190"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("b1c2f818-551b-4b51-9ca8-fceb302b4661"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c6716caa-0eae-4a68-b2ad-eaeca6ae1af7"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c9645307-b98d-4275-94ee-341eb91193c8"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d77952fb-adb1-4d57-aca2-c641af07a68c"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("da5bae42-5e10-4bc5-b998-a2ee87db02ee"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("df800aa0-4f63-413e-964d-e94c35959666"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e5d3c563-90d4-425e-82b5-a2ded432e7e2"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "c05e843b-55b6-4d5c-a687-e0f8bcac0cad");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "b37c1a42-2c20-4d8a-877b-222eaf515984");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "8cd1d421-be84-45c3-896a-df987ff9fce5");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "237b3f7e-d419-4500-af94-9cb50ad9b853");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0ee830e2-137d-40cc-b5e7-2608feec78b5"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("9a4ca3d8-592d-4e20-914d-aac162a798fc"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("a1fa7140-e075-45c6-8af0-0063a94518fa"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("af7905e3-e20c-4743-a660-97b4cc2dee77"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326), "$2a$11$aF423HZJIe9AxmvOckmztuyzjSOCpRAI69wC4FD4c6NnwvZ0EUhN6", new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326), "$2a$11$Dndwl.jjezKausDXgCSwN.To0kd29fDDp7Y.vmewPD28nt8NfuK7O", new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326), "$2a$11$EWQqCQ6SqHwP6GNDqv9TYOjEPIh/MbcuCHr95/4xYFuxlvGx5ySPq", new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326), "$2a$11$lxKELn.Pz7nVxTwUxG5bJed6TDfG4KqnnfrGYXvTyhl/zRzn2fd8S", new DateTime(2025, 11, 5, 15, 41, 46, 317, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 11, 5, 15, 41, 46, 996, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522), new DateTime(2025, 11, 5, 15, 41, 46, 999, DateTimeKind.Utc).AddTicks(7522) });

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
                keyValue: new Guid("05e60b60-b28c-44a9-9e4d-a0c5add34310"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("172cd1f5-39b7-4490-9b2e-0cba4e0b1398"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e88e1ca-0bf5-42f3-92e3-327f52189e0b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20e5c9ab-031f-4284-acbc-68d00f7d7793"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("38183fb7-d547-4860-8757-076cf8b6a173"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b4b45d3-6d7d-41df-83a8-3cc4e0ae9302"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4c43aad7-8a19-4c24-9fba-c1588947a413"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("53519638-f458-4de1-a9fc-ad85cf722127"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("58f3ee93-b828-401d-9a35-764294c8e3e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5adb11ca-a174-4569-bb52-5918b3c18453"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("619afd0a-7ed2-4a0d-81d4-8027be3ae10c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("87366768-ad48-48cb-b516-39bb3150213b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8c67644d-f0bf-4d81-bd66-8e826c83a7f7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92af0db8-38d5-43d3-bdfa-02ee6e68ef5d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97b4696f-0644-439b-b796-14433a9dcd8d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f5c0836-cd45-4f68-adce-5b53e9a921eb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4cf5be8-5f65-4037-8005-f7bb070651ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b04259e6-0c53-4694-aecf-8d472648e0c9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b0e15014-f4bd-4e4f-9541-c94c7dc2f190"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b1c2f818-551b-4b51-9ca8-fceb302b4661"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c6716caa-0eae-4a68-b2ad-eaeca6ae1af7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c9645307-b98d-4275-94ee-341eb91193c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d77952fb-adb1-4d57-aca2-c641af07a68c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da5bae42-5e10-4bc5-b998-a2ee87db02ee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("df800aa0-4f63-413e-964d-e94c35959666"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e5d3c563-90d4-425e-82b5-a2ded432e7e2"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("0ee830e2-137d-40cc-b5e7-2608feec78b5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("9a4ca3d8-592d-4e20-914d-aac162a798fc"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("a1fa7140-e075-45c6-8af0-0063a94518fa"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("af7905e3-e20c-4743-a660-97b4cc2dee77"));

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
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 6, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 6, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 6, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 6, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 6, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 6, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 14, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 14, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 14, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 14, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 15, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 14, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 15, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 14, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 13, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 12, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 10, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 9, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 8, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 12, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 7, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 11, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 3, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 2, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 1, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 31, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 30, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 29, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 4, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 27, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 26, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 25, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 24, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 23, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 22, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 28, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 20, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 19, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 18, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 17, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 15, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 21, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 10, 16, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452), new DateTime(2025, 11, 5, 13, 42, 4, 741, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(9413), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(9413), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(9413), new DateTime(2025, 11, 5, 13, 42, 4, 742, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184), new DateTime(2025, 11, 5, 13, 42, 4, 743, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("123e2903-a843-4a53-b91f-5e7379a235ea"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2461ac8c-bb2b-4ca6-956a-fb675999dc19"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4060c05d-cb6d-4254-af43-49485322a2aa"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4440c405-b2ef-45ca-b1bb-5019a482b03f"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("493602af-bb6e-4f92-833c-5e5a8a7a5363"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4a940f26-91cb-4598-a2c6-293a9ee551ea"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("51607dfb-25a6-4954-8432-f3f91feae0d4"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("586c2268-e6c0-4804-b0b0-87a4584267d4"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("648e8f34-6c45-4c38-b3f0-b4315ce446f7"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6e3f814d-c342-4808-9744-e56b96ad134b"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("741e9a29-1f4d-430f-bff1-56d74cc82fd5"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7a469ab9-ccc5-42d3-81d2-e441672806a3"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("85ca2619-ac3d-4af4-bd5e-3204f24955e9"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("87ea4717-3934-46ce-8515-01ba0acdcada"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("93b6c578-3ae7-4a82-a67c-75cd5fa23d3e"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("984217a0-e88f-4186-a689-fec4fb801d23"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a1185834-67bd-4495-bcd4-6fd2c25d50e8"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a3574fa4-76e6-4bbd-815b-071302430ce8"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b4badc1a-5ce0-4ae3-8a17-9f3dd5681129"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c746fa0d-4df3-4b29-ae2f-81eb5f687a68"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ccf72df1-d13f-4b06-87c5-fe81db728225"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cdf0e69e-3264-466e-ac8d-8380f9147a3c"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d218bb9f-36bc-45bc-9ef8-0a565e49b7c9"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ea61216d-222b-46d0-9ddf-763d3d3aa64b"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f5ca12fc-5c9b-4dce-886c-4f65410644c2"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f99f8da6-356d-4d4f-8d46-02bff2ca7595"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "2025468a-fc2b-4a87-b42d-eb0ca00760be");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "9d7044fa-1a9a-4400-a37d-2b5b0683b3e0");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "340b0bd8-452b-4447-a1cb-bbb6af51bb4f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "943e1a33-addd-4c48-ba19-d86331aa7102");

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
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573), "$2a$11$9f//.RM7FsY6Q9qjaGEZFOQBPI8qH14LjuNJzdsE9Ypq8H6E3dARe", new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573), "$2a$11$4EjI4rzMfYG8XaJ0BSG6DuNiXywMqTSiWPvSyNtYv1xpJyZuCqDV2", new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573), "$2a$11$FfleMwtUAjyAOLMpHjAfQucHKeblGTbKFlquofqZ38sr42k8ER.qG", new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573), "$2a$11$n1uho34QMKLSXx2z3g991uXeoNUigGVDy./aPS66wYECImkPltNaK", new DateTime(2025, 11, 5, 13, 42, 4, 748, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 11, 5, 13, 42, 5, 327, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 11, 5, 13, 42, 5, 329, DateTimeKind.Utc).AddTicks(6923) });
        }
    }
}
