using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_Key_User_Login_WriteDB : Migration
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
                keyValue: new Guid("04db6064-6b73-416c-a8c0-8dfde2f709a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("15ada848-ac9b-4da8-b767-3adfb38532ff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("15ff68e5-7f02-44eb-a2e1-7d8a26b7b91b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1ec756e0-d392-4219-a1ce-d225fc809d63"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20c97df1-07e4-4055-9815-2bf9a80b325d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("322cd380-fd8f-4afd-9d72-c37046f87627"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("67c13856-ac27-424a-aa04-bc54ede68955"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a2d9693-6a02-4e44-b260-c4c68f825ac1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d5df0a0-6edb-45f3-a198-b56735331bfc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6e069275-162a-4bbf-bf2a-07b793f05839"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("739eef82-8b1d-4e2c-81e8-339c459540f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("78f6c36f-f7f3-47e1-a91b-e6472a4e8bc9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("86785db3-8343-4004-9e28-2acbfb17ef68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91bcd4f9-9313-4f8d-8232-09b82deee420"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97bd43fa-a44e-4a5e-92fb-c10a2712eb5e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a18becd4-dfb2-4732-b745-1dba6c780af8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a72cc8e7-ea4e-4156-95e3-f711bf8e86d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("abef3dd2-5a8e-4d22-a139-6186eadd89c6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af00762d-021d-4d5d-b684-8e87e5f2eba7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca7a0231-ca98-49b4-9009-01b844aefb73"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d21f5b08-51a8-42c0-9945-aa080c06124e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de90c598-0549-475a-a1ba-a9babd8664e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7e38acf-4dec-425c-a9a2-c21ce582a362"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed537a7a-601d-4103-b90f-285e8e12b216"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f681c953-9421-414b-9c0f-0fafe881b70c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fb8e5066-2b46-44ed-9deb-eb397fd15410"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("39e3c689-8ca7-46a3-accc-df64e18ae5d1"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("6303fa42-1668-4adb-bd79-8660ddd0513b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d03f226a-ddd8-4eac-8647-2b8e15aed9c8"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ff936a5b-e54d-49b8-8d56-a59576eb5f7b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_logins",
                table: "user_logins");

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
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 14, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 14, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 14, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 14, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 14, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 14, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 31, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 22, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 24, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 9, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 2, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 22, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 26, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 4, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 28, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 22, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 21, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 6, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 30, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 22, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 23, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 1, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 22, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 25, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 3, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 27, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 23, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 22, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 21, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 20, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 18, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 17, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 16, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 20, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 15, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 19, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 11, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 10, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 9, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 8, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 7, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 6, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 12, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 4, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 3, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 2, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 1, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 31, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 30, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 5, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 5, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 28, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 27, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 26, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 25, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 10, 29, 13, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 29, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 10, 24, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 11, 13, 11, 11, 19, 703, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 11, 13, 11, 11, 19, 705, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744), new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744), new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744), new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744), new DateTime(2025, 11, 13, 11, 11, 19, 706, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("04db6064-6b73-416c-a8c0-8dfde2f709a4"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("15ada848-ac9b-4da8-b767-3adfb38532ff"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("15ff68e5-7f02-44eb-a2e1-7d8a26b7b91b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1ec756e0-d392-4219-a1ce-d225fc809d63"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("20c97df1-07e4-4055-9815-2bf9a80b325d"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("322cd380-fd8f-4afd-9d72-c37046f87627"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("67c13856-ac27-424a-aa04-bc54ede68955"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("6a2d9693-6a02-4e44-b260-c4c68f825ac1"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6d5df0a0-6edb-45f3-a198-b56735331bfc"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6e069275-162a-4bbf-bf2a-07b793f05839"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("739eef82-8b1d-4e2c-81e8-339c459540f3"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("78f6c36f-f7f3-47e1-a91b-e6472a4e8bc9"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("86785db3-8343-4004-9e28-2acbfb17ef68"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91bcd4f9-9313-4f8d-8232-09b82deee420"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("97bd43fa-a44e-4a5e-92fb-c10a2712eb5e"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a18becd4-dfb2-4732-b745-1dba6c780af8"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a72cc8e7-ea4e-4156-95e3-f711bf8e86d9"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("abef3dd2-5a8e-4d22-a139-6186eadd89c6"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af00762d-021d-4d5d-b684-8e87e5f2eba7"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ca7a0231-ca98-49b4-9009-01b844aefb73"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d21f5b08-51a8-42c0-9945-aa080c06124e"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("de90c598-0549-475a-a1ba-a9babd8664e8"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7e38acf-4dec-425c-a9a2-c21ce582a362"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ed537a7a-601d-4103-b90f-285e8e12b216"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f681c953-9421-414b-9c0f-0fafe881b70c"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fb8e5066-2b46-44ed-9deb-eb397fd15410"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "9d1cdc71-5b7b-4569-9d40-64ed02cb2a31");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "27aee723-63ec-46bc-9a38-3ce56fa3d615");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "8e001ee2-3c03-4cb2-803c-da2e977f77b4");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "082a9192-e4ba-4aa6-a47f-b7b3773d8342");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("39e3c689-8ca7-46a3-accc-df64e18ae5d1"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("6303fa42-1668-4adb-bd79-8660ddd0513b"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("d03f226a-ddd8-4eac-8647-2b8e15aed9c8"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("ff936a5b-e54d-49b8-8d56-a59576eb5f7b"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214), "$2a$11$pP4kP79SiyD5VI2o7fpoCugZI2109TCHooRqQWxSbc0uiDqgTV1Ty", new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214), "$2a$11$E5bWlWzh/C1Kwz/WRD3hsusTooQbYnEkLHiab5gT8QWhVvZOahrly", new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214), "$2a$11$2KwKshvq.PUJ5f80D43R5OjqGqeFBCTTbsajX/pB2SJqOdlO1FtHS", new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214), "$2a$11$0/rhNEDXSi8VAC1Ij1hXJuuOHFMW.wP9He5Jwpf48wUrg5MY4Q5pO", new DateTime(2025, 11, 13, 11, 11, 19, 710, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627), new DateTime(2025, 11, 13, 11, 11, 20, 247, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 11, 13, 11, 11, 20, 248, DateTimeKind.Utc).AddTicks(8394) });
        }
    }
}
