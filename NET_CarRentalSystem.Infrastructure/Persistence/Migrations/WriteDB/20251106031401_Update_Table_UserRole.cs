using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Update_Table_UserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("2a649dfb-30e0-4753-8c26-aa3ae7a2ea56"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9e55d85f-157b-45cb-8abf-3da879abce34"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("a1d00ba7-c2e3-4a53-b3aa-e7308eade154"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e47392bc-e57e-47df-9aba-19139a65ae85"));

            migrationBuilder.AlterColumn<Guid>(
                name: "user_role_id",
                table: "user_roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWSEQUENTIALID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 7, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 7, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 7, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 7, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 7, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 7, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 15, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 17, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 15, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 19, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 15, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 14, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 15, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 16, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 15, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 18, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 16, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 15, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 14, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 13, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 11, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 10, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 9, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 13, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 8, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 12, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 4, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 3, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 2, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 1, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 31, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 30, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 5, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 28, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 27, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 26, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 25, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 24, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 23, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 29, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 21, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 20, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 19, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 18, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 22, 5, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 22, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 10, 17, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 11, 6, 3, 13, 59, 130, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775), new DateTime(2025, 11, 6, 3, 13, 59, 131, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 133, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 11, 6, 3, 13, 59, 133, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 133, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 11, 6, 3, 13, 59, 133, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 133, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 11, 6, 3, 13, 59, 133, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 11, 6, 3, 13, 59, 135, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("007aa896-fc40-491e-971b-59a2e509f1ff"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("01155aec-2c31-4d98-ae86-59d8eeeb375d"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05dddac7-a202-43ef-becc-a3791fa2205a"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1621c8c8-ba76-4e83-a609-685a8d0ac9d0"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1710ac35-231b-461c-b957-22ea8ab1324d"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2b1e2b4b-28dd-47d5-b7b5-939555176788"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3f236aa1-2aa5-4b94-ab42-32113a1023a2"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("55112023-8db5-4147-8b94-5000543a27a8"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5e2a8afe-938d-416d-ad08-d880c5cc8db1"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("5f7518d2-f8ff-4c88-b19f-57f3dbd3ac55"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6d16e218-dce7-46de-9a80-b9eed1a23dd3"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8641d452-d6ae-4c38-a39e-c9ffb3e3435c"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("92307d6d-a1a1-4215-86a0-a2cdbd284923"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("99ae45a7-e46f-404b-b240-e2b312dea391"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9dbe311f-c009-4721-97b8-d0846933a18a"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("b117b691-0bce-42e6-adaa-d241eeaff77a"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b55a3ba9-1997-4686-879d-072f50a24b59"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("be8dff7f-e752-4bf1-a46c-26aafd0b86bb"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ddc31d05-4f30-4b9c-a19c-ef53e5a777e9"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e248b1b5-9ed3-49be-bea0-ac5f7fd58e9e"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e3b315fc-8c01-4279-9db1-23827bf17361"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ebfb6295-de5d-47a5-bea8-c5e8ca2ec709"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("efc7ace1-69e7-4766-81ac-67c7baeae4d3"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f020b7b7-0147-47a0-8ba2-7d789bf13c3e"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f7d66a02-81d3-44a2-b34a-2a2e2dbff1c5"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fd8f8317-130a-49f4-846a-c0e751538383"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "01ddc044-d471-4f9e-a456-324842266a07");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "72b210c0-7e17-40b5-accc-5daea28302cb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "7180dd27-8b3e-4665-8940-4d4341ca706a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "ad57cded-1277-4c66-96ae-66c92f33d628");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("1c4f7524-923b-4a3d-9a9a-f145a1ed4a52"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("3184007d-2595-4be3-911c-a60439732e7f"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("7e2f7784-d9ec-4a4b-8d13-a589d5c5d081"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("dc1612aa-ba91-4d06-97d8-91deb3690bd6"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851), "$2a$11$iebYCVg.ikIXueJqrwzgFOo01xJI.RUFgfBrVsZjG8GhN3mJZi2qy", new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851), "$2a$11$FaYR7JsZsgolApm3cvhg3erx7HDHDkFp6u8/A9kVKt3JjQB7jRpKK", new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851), "$2a$11$BOkocUza3YnX5vzb3ee2VeBpaknaJFQSMOU6yaipNYzAJWQH7TG2m", new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851), "$2a$11$Ag/zQZWobVVbQwJHFTcide8vRMW2Mu5RbmQLcr.q38nj48HCeNR16", new DateTime(2025, 11, 6, 3, 13, 59, 146, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 11, 6, 3, 13, 59, 737, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058), new DateTime(2025, 11, 6, 3, 13, 59, 739, DateTimeKind.Utc).AddTicks(3058) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("007aa896-fc40-491e-971b-59a2e509f1ff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("01155aec-2c31-4d98-ae86-59d8eeeb375d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05dddac7-a202-43ef-becc-a3791fa2205a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1621c8c8-ba76-4e83-a609-685a8d0ac9d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1710ac35-231b-461c-b957-22ea8ab1324d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2b1e2b4b-28dd-47d5-b7b5-939555176788"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3f236aa1-2aa5-4b94-ab42-32113a1023a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55112023-8db5-4147-8b94-5000543a27a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5e2a8afe-938d-416d-ad08-d880c5cc8db1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5f7518d2-f8ff-4c88-b19f-57f3dbd3ac55"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d16e218-dce7-46de-9a80-b9eed1a23dd3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8641d452-d6ae-4c38-a39e-c9ffb3e3435c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92307d6d-a1a1-4215-86a0-a2cdbd284923"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("99ae45a7-e46f-404b-b240-e2b312dea391"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9dbe311f-c009-4721-97b8-d0846933a18a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b117b691-0bce-42e6-adaa-d241eeaff77a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b55a3ba9-1997-4686-879d-072f50a24b59"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be8dff7f-e752-4bf1-a46c-26aafd0b86bb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ddc31d05-4f30-4b9c-a19c-ef53e5a777e9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e248b1b5-9ed3-49be-bea0-ac5f7fd58e9e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3b315fc-8c01-4279-9db1-23827bf17361"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ebfb6295-de5d-47a5-bea8-c5e8ca2ec709"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("efc7ace1-69e7-4766-81ac-67c7baeae4d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f020b7b7-0147-47a0-8ba2-7d789bf13c3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f7d66a02-81d3-44a2-b34a-2a2e2dbff1c5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd8f8317-130a-49f4-846a-c0e751538383"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("1c4f7524-923b-4a3d-9a9a-f145a1ed4a52"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3184007d-2595-4be3-911c-a60439732e7f"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7e2f7784-d9ec-4a4b-8d13-a589d5c5d081"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("dc1612aa-ba91-4d06-97d8-91deb3690bd6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "user_role_id",
                table: "user_roles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWSEQUENTIALID()");

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
        }
    }
}
