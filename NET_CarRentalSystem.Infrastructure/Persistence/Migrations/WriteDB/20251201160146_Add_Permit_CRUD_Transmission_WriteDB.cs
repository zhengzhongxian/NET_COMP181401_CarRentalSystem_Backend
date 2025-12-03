using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_Permit_CRUD_Transmission_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("039ef08f-fb7c-40bc-8269-ff9f074b918a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("11f7f3e9-ec22-4ba8-96af-fb3b2f84fcdf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("136eb7bf-97f9-4ffe-b87c-ac9ee7fa4077"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2295102a-1093-44e0-b8c4-846f30582a12"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22bf18eb-6d3d-46cc-bae9-48bb2adcc0c5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2314fafe-4714-4704-bf49-bf5766832e16"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43989e73-b887-4a0f-9509-b556d1bfdb66"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4f912c7a-efea-4bed-bbdf-10784ccd689f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("587891c6-ba69-4670-ac51-41691cd76c8a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("60647278-010f-4b01-a185-e7f97266fd17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("726c82ab-4214-4254-ab26-68b10f7c3c98"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7b4699f1-a78a-40ff-997f-19f0898cff50"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("963359b4-b9e6-4053-9238-8c2949825576"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a693f30b-98f2-44d1-abea-9918f73338ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b34ce8de-4984-409d-a447-d69551c16c9b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bef77944-4db1-41b3-8aeb-950094133f1d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c0252631-2b1e-48ed-95aa-fe4fb0d3580a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c0a20ff2-4185-4342-a3bf-f30084b3bd83"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c22dd040-5ee6-4e6d-814e-00001241c455"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d168823f-2f86-4544-a5a5-b65921bbb0a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6f28ebc-c18a-413f-ba55-ae54379c3bec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d75259b1-6cbf-42c8-8279-2689259508f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9e76284-c404-436e-98cd-353feec20e13"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea7a00a6-132b-4db6-8b5c-2e9cd0eac271"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f59f7e61-5d6f-4665-96ab-117dd9bd2d41"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fdbe2ed2-e77c-45c6-a3d6-4a306dfdf5a2"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7cd7d2dc-2044-4c6f-abe6-25e811dfbf55"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7db3aa39-8e3e-4959-95dc-4569e9d44ca1"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e10f893f-2742-47c6-b717-38955bac4a51"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fb86a33d-5ae1-4978-a245-822c6ccfb47c"));

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 2, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 26, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 21, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 10, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 9, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 8, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 6, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 5, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 4, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 3, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 2, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 7, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 29, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 28, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 27, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 26, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 25, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 24, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 30, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 22, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 21, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 20, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 19, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 18, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 17, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 23, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 15, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 14, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 13, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 12, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 18, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 16, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 11, 11, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 12, 1, 16, 1, 44, 329, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 12, 1, 16, 1, 44, 331, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 12, 1, 16, 1, 44, 332, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514), new DateTime(2025, 12, 1, 16, 1, 44, 333, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("046826e1-1fe1-4d74-890a-3e9c39464f9f"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("147fb4f3-8af8-4fd4-9d93-265888bad8e8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1b40264c-04cd-422d-8d45-db121384c95b"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("283b7fb7-9bbd-4f34-b6ab-2786c76408d6"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2f5f10e3-7dde-4af9-a879-b0689ecc9149"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("37fdb168-4f36-4a9c-96b3-cdab87512019"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("47f1bf9b-b9ca-410f-abef-dbb8fbb1e925"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4807943e-b857-4674-aeb9-b2d1a997f6e6"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4834ab74-3831-4c39-8591-f995981eb7c3"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5443ef24-6006-4cd2-b21f-798a77a9f293"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("54c17a8a-2c29-4e3a-9ce1-350075645e37"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("55f9e7f1-cace-4706-8c89-51b546950801"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("574189a6-f00c-4d94-8895-0ab7642e663b"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("58fefa7d-e03f-4213-bc23-7411bc676e62"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("696704d9-fdde-4dd2-afb6-1fdeb0d5da2c"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("752a7db2-21a3-4294-8965-bf11d6f14052"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("92387513-706b-48a6-bd1b-ea38d79e7d3c"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("92fff580-b665-4354-80aa-7282ddfe51d2"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("932315a6-7ebf-47b8-93ff-5d3fd7e17d5b"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a077044-eb09-45bf-9628-546b7e127470"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9e255aa8-6099-4a5b-8a86-021b03be8ddb"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ace0fb64-07e3-43d0-91b8-b31da586b867"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b17d9991-29a7-4e8f-b45c-b7e566c870d6"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ba7f98a7-bccc-4b6c-ba7f-f9a0de7497a0"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cbc7bf40-c43b-4dfd-bdac-24ed6a2dc863"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d0d830e5-13df-4ce6-9903-6025a4390f4f"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dd481eb2-6479-4f63-b369-302fadf73f56"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f087b1be-0653-4197-b61f-2bd646979657"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f4d64e28-a698-4f83-bdf4-fed1c82a1185"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("fc0c4387-f515-4030-b241-bd444664525b"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "b0406c38-ea33-436f-8315-be8bc1f3c647");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "5dde62dd-1c31-4ff7-ba75-8b39440be361");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "ffdf8127-1446-464f-8b4a-b41e5cc8a987");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "ac4f6280-e43b-45e4-ba1d-7229ba4364c8");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("3b23ce5c-fa97-497f-9ab2-af56c7f77f87"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("51071e5a-a27a-4f34-8760-4e05a2dc9099"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("8d8e8fd1-b4ab-4a92-b3d6-5f8fccd7cb75"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("ba44880a-ed3f-4463-a987-908161a6b9d1"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$3zOmcrxL2RRkOcb/DWGLHuw/qOLk/ikMMZbbR/qOFmaLk8CjcLD2G", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$tw8BZV0H5mgHecOyMyZMS.3R56JvXzSbWkJMhFgNCmYPoKPxLHRRW", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$NJo/tzRzQJcscF61cwL6uOitBbPnhZL4SlSchj7SSuwc/PcaOLZKi", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029), "$2a$11$YTYHBYvyQaRI5tIDD2Pf0eHvRt9h4JlOqQpuW0aaAjytpBUcXEYDm", new DateTime(2025, 12, 1, 16, 1, 44, 340, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 12, 1, 16, 1, 44, 887, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 12, 1, 16, 1, 44, 890, DateTimeKind.Utc).AddTicks(3544) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("046826e1-1fe1-4d74-890a-3e9c39464f9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("147fb4f3-8af8-4fd4-9d93-265888bad8e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b40264c-04cd-422d-8d45-db121384c95b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("283b7fb7-9bbd-4f34-b6ab-2786c76408d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f5f10e3-7dde-4af9-a879-b0689ecc9149"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("37fdb168-4f36-4a9c-96b3-cdab87512019"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47f1bf9b-b9ca-410f-abef-dbb8fbb1e925"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4807943e-b857-4674-aeb9-b2d1a997f6e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4834ab74-3831-4c39-8591-f995981eb7c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5443ef24-6006-4cd2-b21f-798a77a9f293"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("54c17a8a-2c29-4e3a-9ce1-350075645e37"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55f9e7f1-cace-4706-8c89-51b546950801"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("574189a6-f00c-4d94-8895-0ab7642e663b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("58fefa7d-e03f-4213-bc23-7411bc676e62"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("696704d9-fdde-4dd2-afb6-1fdeb0d5da2c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("752a7db2-21a3-4294-8965-bf11d6f14052"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92387513-706b-48a6-bd1b-ea38d79e7d3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92fff580-b665-4354-80aa-7282ddfe51d2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("932315a6-7ebf-47b8-93ff-5d3fd7e17d5b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a077044-eb09-45bf-9628-546b7e127470"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e255aa8-6099-4a5b-8a86-021b03be8ddb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ace0fb64-07e3-43d0-91b8-b31da586b867"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b17d9991-29a7-4e8f-b45c-b7e566c870d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ba7f98a7-bccc-4b6c-ba7f-f9a0de7497a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cbc7bf40-c43b-4dfd-bdac-24ed6a2dc863"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0d830e5-13df-4ce6-9903-6025a4390f4f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dd481eb2-6479-4f63-b369-302fadf73f56"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f087b1be-0653-4197-b61f-2bd646979657"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f4d64e28-a698-4f83-bdf4-fed1c82a1185"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc0c4387-f515-4030-b241-bd444664525b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3b23ce5c-fa97-497f-9ab2-af56c7f77f87"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("51071e5a-a27a-4f34-8760-4e05a2dc9099"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8d8e8fd1-b4ab-4a92-b3d6-5f8fccd7cb75"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ba44880a-ed3f-4463-a987-908161a6b9d1"));

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 2, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 25, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 18, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 9, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 11, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 4, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 27, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 20, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 9, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 13, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 6, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 29, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 22, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 15, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 9, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 8, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 8, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 24, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 17, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 9, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 10, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 3, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 26, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 19, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 9, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 12, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 5, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 28, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 21, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 14, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 10, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 9, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 8, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 7, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 6, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 5, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 4, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 3, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 2, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 7, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 7, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 29, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 28, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 27, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 30, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 26, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 25, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 24, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 30, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 22, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 21, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 20, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 19, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 18, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 17, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 23, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 23, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 15, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 14, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 13, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"),
                columns: new[] { "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 12, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"),
                columns: new[] { "actual_end_date", "created_at", "end_date", "start_date", "updated_at" },
                values: new object[] { new DateTime(2025, 11, 16, 7, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 16, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 11, 11, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 1, 5, 29, 35, 834, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 12, 1, 5, 29, 35, 835, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(5113), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509), new DateTime(2025, 12, 1, 5, 29, 35, 836, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("039ef08f-fb7c-40bc-8269-ff9f074b918a"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("11f7f3e9-ec22-4ba8-96af-fb3b2f84fcdf"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("136eb7bf-97f9-4ffe-b87c-ac9ee7fa4077"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2295102a-1093-44e0-b8c4-846f30582a12"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("22bf18eb-6d3d-46cc-bae9-48bb2adcc0c5"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2314fafe-4714-4704-bf49-bf5766832e16"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("43989e73-b887-4a0f-9509-b556d1bfdb66"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4f912c7a-efea-4bed-bbdf-10784ccd689f"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("587891c6-ba69-4670-ac51-41691cd76c8a"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("60647278-010f-4b01-a185-e7f97266fd17"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("726c82ab-4214-4254-ab26-68b10f7c3c98"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7b4699f1-a78a-40ff-997f-19f0898cff50"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("963359b4-b9e6-4053-9238-8c2949825576"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a693f30b-98f2-44d1-abea-9918f73338ba"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b34ce8de-4984-409d-a447-d69551c16c9b"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("bef77944-4db1-41b3-8aeb-950094133f1d"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c0252631-2b1e-48ed-95aa-fe4fb0d3580a"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c0a20ff2-4185-4342-a3bf-f30084b3bd83"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c22dd040-5ee6-4e6d-814e-00001241c455"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d168823f-2f86-4544-a5a5-b65921bbb0a4"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6f28ebc-c18a-413f-ba55-ae54379c3bec"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d75259b1-6cbf-42c8-8279-2689259508f9"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e9e76284-c404-436e-98cd-353feec20e13"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ea7a00a6-132b-4db6-8b5c-2e9cd0eac271"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f59f7e61-5d6f-4665-96ab-117dd9bd2d41"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fdbe2ed2-e77c-45c6-a3d6-4a306dfdf5a2"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "1c495741-d051-4119-8155-b7a189268c6f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "f9ad8cca-56fe-4bdf-be50-00473d3db25a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "8b903f4c-a867-44af-bee3-ff464a55efe6");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c019947e-40e3-40ae-aead-4ad4c8e8aff3");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("7cd7d2dc-2044-4c6f-abe6-25e811dfbf55"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("7db3aa39-8e3e-4959-95dc-4569e9d44ca1"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("e10f893f-2742-47c6-b717-38955bac4a51"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("fb86a33d-5ae1-4978-a245-822c6ccfb47c"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562), "$2a$11$8fTStB.EuVPBk8XcLcQsG.b2zMe8RCCZR49VVpX3lnGRDoBqXHA62", new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562), "$2a$11$EALf29mNxhRuZ/WKsU/.i.DTwQFSuuqmoaqcEVCYDjYIkXlSRzuAG", new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562), "$2a$11$XTSSEumIQ7z9TYDl9SP2qOx2JjqDSQHivW7EGIBI/Cd3NKGXq5rwO", new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562), "$2a$11$x7vuGquhKMLGlErVPRzvE.bBsJGM5Cxq2EHMkxIfAr82qlgQyXshi", new DateTime(2025, 12, 1, 5, 29, 35, 841, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011), new DateTime(2025, 12, 1, 5, 29, 36, 357, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214), new DateTime(2025, 12, 1, 5, 29, 36, 358, DateTimeKind.Utc).AddTicks(6214) });
        }
    }
}
