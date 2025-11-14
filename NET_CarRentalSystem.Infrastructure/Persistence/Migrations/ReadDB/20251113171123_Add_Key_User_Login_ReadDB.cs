using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Add_Key_User_Login_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_logins",
                table: "user_logins");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("01bd40d3-0472-463c-adb3-7c40543a2a50"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c34a0c2-465b-4ab4-8165-18d7b7f2010e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("15ceb008-8f16-4c57-aba7-74957a395e5d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16307564-0a13-41d9-a4e9-0a93525b9578"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("33eb84b3-394c-4860-98f6-7ebe099a5b11"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3824d12a-6319-4318-9e6f-e8c8a1548d16"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("49fb8b52-d822-49c8-a5b8-16ce98d3dc35"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5749af45-9873-42a2-b81d-6d3064ee5d0b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("64bdb686-dc7f-4ab0-926f-1911bd60ec56"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6e06f36a-c5b0-479d-81b2-0ea684a47b2c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79c5c885-7463-4acb-8b5f-4c3515a1e800"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("939b3696-a902-48ae-bfa0-a02bbec28c8b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("988bef77-849b-4242-9b51-cedf7699d740"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("99b3adfa-bc80-4cc9-994a-916a7de9f9c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e86f370-6e1d-4cbd-a999-df3b2499a872"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a9e2dbd5-6d20-4adf-bf56-334421a19306"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b60245d2-155e-4136-9c56-64b87b84797d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be0f2dfd-df63-4b90-853b-9fc1ffcdcaff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c531a196-02ea-4b7c-9968-2de42fad7ead"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d430a50e-fbb4-46e6-9ab9-5d804a0cca64"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc80a251-d4a9-40bd-97d2-b80b9fb26264"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e070d18c-877c-473a-a35b-f9433bbe78ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e720af33-7a9a-43c2-acf9-55593ede9966"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eeaea524-55be-4b2e-b1a5-609b1d66c99d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f0aa5ef1-e3ac-4347-8e40-afc7e77055fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f26b5a3b-3cf0-4a1c-8b7e-32bfd8d05a48"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("0c55b08f-97f8-4a5c-a8f8-c4c8ad9404f3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("cf2238be-c4c5-48ba-9fd7-6dd52da15249"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d2d15fdc-d73f-47a8-9033-888f2acad72c"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d9b3222b-2ae9-406e-b6ca-dc3fdfea277b"));

            migrationBuilder.AddColumn<Guid>(
                name: "user_login_id",
                table: "user_logins",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWSEQUENTIALID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_logins",
                table: "user_logins",
                column: "user_login_id");

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 14, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 14, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 14, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 14, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 14, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 14, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 22, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 22, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 22, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 22, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 22, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 23, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 22, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 21, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 18, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 17, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 16, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 20, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 15, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 19, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 11, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 10, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 9, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 8, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 7, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 6, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 12, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 4, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 3, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 2, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 1, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 31, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 30, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 5, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 28, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 27, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 26, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 25, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 19, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 29, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 10, 24, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665), new DateTime(2025, 11, 13, 17, 11, 21, 49, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906), new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906), new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906), new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906), new DateTime(2025, 11, 13, 17, 11, 21, 51, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(688), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(688), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(688), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 11, 13, 17, 11, 21, 52, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("17ef1739-1c23-45e0-8b26-c302962691d4"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("256d970e-fbbf-4925-9fd7-677d92fe4a7d"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("26d9c6b4-2f87-43b2-a419-4289829df8c5"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("27e541ad-ef02-46a1-b784-95281e41465b"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30b003c6-2973-42c8-ae00-70bbbb59dfcf"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("44c038ff-67c1-42c6-a812-9e3b6d0cd020"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4ad89f62-51be-4514-8306-71d9534fd135"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6b598d5d-6190-4f83-82b5-19472604887b"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6ca017a7-0f27-4646-88a1-1d856757d0fe"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("6d404422-39a6-4a70-8e2a-2d31523090d9"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("7dd0a3b7-25f1-467d-b675-a89345a279a0"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("97ab144d-77b7-41bf-836a-52f0988e0f21"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("993fd464-7aee-4f18-96fa-f37415336bd3"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae590a4f-f152-473c-93a3-13dfc72bb829"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ba7b59cc-7f4e-400b-9f60-585627cef8fd"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c7e91098-cdb0-4f52-8490-f51a3bbdaad3"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cf8f81a9-95a5-4dec-b006-a869a98898e6"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d0c16357-ff46-4359-908e-976db5f70e4e"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d798b9c4-b3a9-4cea-83dc-0a7ed04eb431"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("dc96fdf5-ee65-41f2-ba22-024a7d4307a4"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dec2095a-0ea3-477d-9138-22889ca3492d"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e4ff3f7c-a852-499f-ae7a-ec8e1820c5bc"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("eba657ab-ce8e-4482-a258-1eba5f6d9316"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ef4c3184-3dbf-4977-baf9-8f3b3ccc4d6c"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f4cd36e4-7655-4555-b206-27ab7fc0aa7d"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fdf0973c-e8cf-4f78-924c-bedb80e49e7b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "d55c0cc7-170b-43d3-bc65-51581af3315e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "f5db87b5-dffe-4893-8dcb-57084c57c535");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "3583997c-d16e-45fd-a307-aa56c0dd592f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "126a7e92-f833-4d3f-8082-75618800103c");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("2a310c41-1ebf-4349-a088-741c348ef5b3"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("67c5033e-cc6c-41f2-bbb2-ae11993af292"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("88097215-0aaf-4020-a2a8-ef58abe463f3"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("ac093415-53a3-476a-9edf-1da57248ac32"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913), "$2a$11$WLh1BWFq0gveuOiMx9on3OwQm/juWmhHYIiXJ1tP9Gj5Kj2i4KWGq", new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913), "$2a$11$3CpmriWygvNKulMG/eMI1eFvBSWle0wQEzIQMQern/lhKTxXKK.VC", new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913), "$2a$11$IPamKqapBBUTkFeVrdEB2e8k6kAUs3jK8vItOCyiYJqO2/QZnXtj6", new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913), "$2a$11$i8Si9vOgGAdVCZtj.ZlHmeq67adWDg9kyOqboJDH4TQG8jIxvKS1O", new DateTime(2025, 11, 13, 17, 11, 21, 56, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 11, 13, 17, 11, 21, 594, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367), new DateTime(2025, 11, 13, 17, 11, 21, 596, DateTimeKind.Utc).AddTicks(2367) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_logins",
                table: "user_logins");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("17ef1739-1c23-45e0-8b26-c302962691d4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("256d970e-fbbf-4925-9fd7-677d92fe4a7d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("26d9c6b4-2f87-43b2-a419-4289829df8c5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("27e541ad-ef02-46a1-b784-95281e41465b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30b003c6-2973-42c8-ae00-70bbbb59dfcf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("44c038ff-67c1-42c6-a812-9e3b6d0cd020"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ad89f62-51be-4514-8306-71d9534fd135"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6b598d5d-6190-4f83-82b5-19472604887b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6ca017a7-0f27-4646-88a1-1d856757d0fe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d404422-39a6-4a70-8e2a-2d31523090d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7dd0a3b7-25f1-467d-b675-a89345a279a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97ab144d-77b7-41bf-836a-52f0988e0f21"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("993fd464-7aee-4f18-96fa-f37415336bd3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae590a4f-f152-473c-93a3-13dfc72bb829"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ba7b59cc-7f4e-400b-9f60-585627cef8fd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c7e91098-cdb0-4f52-8490-f51a3bbdaad3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cf8f81a9-95a5-4dec-b006-a869a98898e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0c16357-ff46-4359-908e-976db5f70e4e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d798b9c4-b3a9-4cea-83dc-0a7ed04eb431"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc96fdf5-ee65-41f2-ba22-024a7d4307a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dec2095a-0ea3-477d-9138-22889ca3492d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e4ff3f7c-a852-499f-ae7a-ec8e1820c5bc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eba657ab-ce8e-4482-a258-1eba5f6d9316"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ef4c3184-3dbf-4977-baf9-8f3b3ccc4d6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f4cd36e4-7655-4555-b206-27ab7fc0aa7d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fdf0973c-e8cf-4f78-924c-bedb80e49e7b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("2a310c41-1ebf-4349-a088-741c348ef5b3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("67c5033e-cc6c-41f2-bbb2-ae11993af292"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("88097215-0aaf-4020-a2a8-ef58abe463f3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ac093415-53a3-476a-9edf-1da57248ac32"));

            migrationBuilder.DropColumn(
                name: "user_login_id",
                table: "user_logins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_logins",
                table: "user_logins",
                columns: new[] { "login_provider", "provider_key" });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 14, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 14, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 14, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 14, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 14, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 14, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 22, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 22, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 22, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 22, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 22, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 23, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 22, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 21, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 18, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 17, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 16, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 20, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 15, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 19, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 11, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 10, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 9, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 8, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 7, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 6, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 12, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 4, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 3, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 2, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 1, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 31, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 30, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 5, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 28, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 27, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 26, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 25, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 13, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 29, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 10, 24, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626), new DateTime(2025, 11, 13, 11, 10, 45, 908, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175), new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175), new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175), new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175), new DateTime(2025, 11, 13, 11, 10, 45, 909, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(1046), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 11, 13, 11, 10, 45, 910, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("01bd40d3-0472-463c-adb3-7c40543a2a50"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0c34a0c2-465b-4ab4-8165-18d7b7f2010e"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("15ceb008-8f16-4c57-aba7-74957a395e5d"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("16307564-0a13-41d9-a4e9-0a93525b9578"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("33eb84b3-394c-4860-98f6-7ebe099a5b11"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3824d12a-6319-4318-9e6f-e8c8a1548d16"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("49fb8b52-d822-49c8-a5b8-16ce98d3dc35"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5749af45-9873-42a2-b81d-6d3064ee5d0b"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("64bdb686-dc7f-4ab0-926f-1911bd60ec56"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6e06f36a-c5b0-479d-81b2-0ea684a47b2c"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("79c5c885-7463-4acb-8b5f-4c3515a1e800"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("939b3696-a902-48ae-bfa0-a02bbec28c8b"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("988bef77-849b-4242-9b51-cedf7699d740"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("99b3adfa-bc80-4cc9-994a-916a7de9f9c8"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9e86f370-6e1d-4cbd-a999-df3b2499a872"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a9e2dbd5-6d20-4adf-bf56-334421a19306"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b60245d2-155e-4136-9c56-64b87b84797d"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("be0f2dfd-df63-4b90-853b-9fc1ffcdcaff"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c531a196-02ea-4b7c-9968-2de42fad7ead"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d430a50e-fbb4-46e6-9ab9-5d804a0cca64"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dc80a251-d4a9-40bd-97d2-b80b9fb26264"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e070d18c-877c-473a-a35b-f9433bbe78ed"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e720af33-7a9a-43c2-acf9-55593ede9966"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("eeaea524-55be-4b2e-b1a5-609b1d66c99d"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f0aa5ef1-e3ac-4347-8e40-afc7e77055fb"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f26b5a3b-3cf0-4a1c-8b7e-32bfd8d05a48"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "66e61914-0e06-4802-845d-2ed0178da534");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "262a70aa-766a-43d9-b6b2-ac43839c34b4");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "88ce8f56-befe-4be6-ac79-792cb01c9e25");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "5ea1a8a9-d50f-41b3-b851-6eb2baf5e9e8");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0c55b08f-97f8-4a5c-a8f8-c4c8ad9404f3"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("cf2238be-c4c5-48ba-9fd7-6dd52da15249"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("d2d15fdc-d73f-47a8-9033-888f2acad72c"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("d9b3222b-2ae9-406e-b6ca-dc3fdfea277b"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052), "$2a$11$rKnUGUjWwon3251cQbme6Ofrs9wXxrzQ4Z2l41INnnqJPYinF5m66", new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052), "$2a$11$pnyZMh6n.6WjArJb7zOFf.5C9iepnaKZAknWgcmik/afKerPbvpOO", new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052), "$2a$11$EcwIHN1K2TTApHtZZ1eV/uinbwnkZXCTp8mZraUkHdDRaxWQ4oaNm", new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052), "$2a$11$YBkXKqpCr0jh5wGmhT12lecavg/BKG3m76LEHbsVqo7xn1Lu/Lree", new DateTime(2025, 11, 13, 11, 10, 45, 913, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234), new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234), new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234), new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234), new DateTime(2025, 11, 13, 11, 10, 46, 432, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 11, 13, 11, 10, 46, 433, DateTimeKind.Utc).AddTicks(9894) });
        }
    }
}
