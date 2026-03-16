using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Add_Title_Vehicle_And_Redis_Search_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("033ba688-8d62-4c06-85c9-90ccfe1709d8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c7ba3f6-9621-44af-aa3e-7d2c100383f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e065155-b6d4-4501-b5cb-ce9cd1f82ad8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e899df4-dd65-481e-9dea-71c3387adac0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21fbe3a0-e618-4065-ba67-aba69616b7b1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("242933bc-4156-4d93-b9ca-9350f4524b08"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("254577e6-db10-4b06-8786-ede1d36335b8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("26d3a6f4-97e5-40e3-a732-65369533fc75"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2964c774-1cab-4155-8c27-421d52de414e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2cf0a430-6c8e-473a-8207-66c2ef50d439"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ff5e9b7-6e72-4d08-9446-d503cd8e273e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("33a17096-20cb-402b-a3b0-9610f84ae195"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("35fdf09f-3aab-4ea0-b02a-d1709d0776e4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3cba7380-e6b5-45c5-a97f-22e8cd3a0162"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("406f2e5b-f17e-45f5-9acf-3803c008f81d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41f94105-bdf2-4fd1-a60f-da0b1fc8b762"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43892472-6130-467d-bd23-94c506d795e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("446e0ff5-0d7d-4f13-b86e-5fc229873d5d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("522cfcec-af3d-4149-9c0d-fbf1f2a7b2a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("537b78cc-f4fd-46d1-ad11-f4ae3d1fbf0d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6570ecda-cc54-47c3-a92e-22af495334bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("696c13a5-fcbf-4dbb-bf51-5415f9c99f08"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a663c2e-14cf-49df-be2e-31b1960764a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6bb66801-4c92-4f9d-8270-571f82ed8f2d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6c6ebe9c-e5ec-4454-989a-6beec0a97e95"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6ebc8d32-4476-4853-a9f9-cd88442125d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("717bdd8b-52e2-437f-91ee-b25b4902d10c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7a26268a-bc93-460b-8688-df88e3c35d35"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7dcfdb6c-1351-4c00-9eee-60751fa3713d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80b47d83-9327-42e2-b7a5-3db42eb2a5a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80f155a4-cd0f-4d2d-8d2d-4b94515e715e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e3c929e-ae5b-42b0-80f5-93e5871832b2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9ee353da-4944-46e8-8fd5-0da6f81d1431"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9ee7fd05-a2e6-4c6f-b6f2-91eba5329833"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a084716e-f3dc-46e3-9f98-1d310842be0e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a64b5a27-fcda-44b8-8365-226b9a90c313"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac09c978-6267-42cf-a848-03e69aa90fb1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b0dcc393-c674-46eb-b6ec-8c436ebd5dec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b2b9589e-e510-45cc-b42a-01a15975001a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b3f719a9-b3a0-458c-8a03-c5b195ba6486"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b9731fc0-31ad-429a-850e-fc07104aa8c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c09d436d-95e2-4b1a-bf4a-ed456ae21e79"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c8fa0fcb-fcff-4de4-8ee6-01dc7823177c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cf1f555b-d1dd-4699-858d-3112744d3655"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0a0f981-75a7-494a-a7f3-cd8a12c0c268"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d1a16ac7-5a9f-42cf-89d1-78eed21fc687"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d702b7d2-0649-4127-848c-8c502aea26d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc119898-bc34-4360-b92a-376a6b51ce0d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dfa4ff89-f09f-4354-8aa3-c17b200efbb6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3a6c4bf-ecd0-4be2-aeeb-bd0defc40899"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e4bf46af-98c1-43fc-96c6-e58d0d41c39b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9fee929-9357-4a5e-9de5-a81003c267fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eb45d3bc-6392-4e5c-99f8-67006024e380"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f862ad1a-41d7-4f0c-96ad-93fee0382122"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fda6677f-7924-4fd6-979c-f19f493826dc"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("30edd6c1-c205-4085-b520-aa11140de1bc"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8267ea8e-ff8a-4b58-a4ca-7686816d2cca"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("a3c295d2-ff9f-446f-a163-2d440bdf93a7"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("abc9d930-4c36-4965-b216-96dec5b6da09"));

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "vehicles",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "vehicle_read_flat",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "refund_requests",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "admin_notes",
                table: "refund_requests",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_deposit_refund",
                table: "refund_requests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ready_to_process_at",
                table: "refund_requests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "scheduled_at",
                table: "refund_requests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "deposit_refund_scheduled_at",
                table: "bookings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DepositRefundScheduledAt",
                table: "booking_read_flat",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(9161), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(9161), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(9161), new DateTime(2026, 3, 14, 6, 20, 16, 721, DateTimeKind.Utc).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977), new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977), new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977), new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977), new DateTime(2026, 3, 14, 6, 20, 16, 722, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0144c01b-19ac-4088-b180-79ea07d453a4"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("07791058-716c-4429-82a5-4d93de181bf4"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("094adfe4-e04b-4153-9f84-8833a060d689"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("09e55d58-379d-46ac-9c11-1d60f1e94142"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0e7877df-4785-4ad5-962d-1c0d9dc9c825"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1062a19b-62c4-4f59-a50e-a86d2f6e1020"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1228a72e-4e82-4bee-b3e4-cf25c56efd54"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1519aa87-6983-4c51-a295-d42781eb0c5b"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("15986a35-e7e0-4c50-903f-1057af5e1daa"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("177e297f-b174-4779-87b0-9088359603be"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("18215126-3fef-4239-b0f7-a1ddc0630aff"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("21eef847-9882-4b23-b4e0-df9c8ee04ad6"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("22b6b53e-c02e-45c9-86f7-d2fb3c754cf5"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("250e4eb6-b2ff-42be-a431-61b72e1a0956"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3094d45b-e685-450e-8c9e-03afcde16b2b"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3123384d-8bac-499d-ae86-a31454591e7e"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("312e643f-3691-4f54-a38b-123306211591"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("341cf4a5-d507-452a-a5ca-95b39ab471f7"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3d280898-990c-42f1-b928-372c08d6184c"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5d09b2e1-844b-45d2-a1b9-b4dd1c86dcc5"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5d43b532-a3c9-4451-9fe9-4429c4afc605"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("63496f61-74a2-4464-870a-c3daf232e3fb"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("724720f9-7ca4-4d63-8767-957957e69694"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("773e5b77-1f20-480e-aa21-cc3058c3b6df"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("78317d5a-9bc5-49e0-9bfe-9fa725c0e9cb"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7d46f1da-a2e4-47f7-9723-a8740d101413"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7d683538-278f-4ae2-ac88-d24a3dcc6259"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7ef7364a-8e0c-4ac9-bf99-146348d69695"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8449b543-7faf-4ddb-8994-6ed03ddcf5df"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("8a8ce933-427f-4bdf-9d16-65b064aac3cb"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8bc8eb1e-0ab5-49f9-9f58-6ce4e5c3f0a3"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8ef7009d-8772-4c8a-ab69-85e81a90afd2"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("96b8ad01-00f8-4c4a-809e-82388d0ff19b"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9aba26ec-6d5e-4949-813b-0c6a74a0174f"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9b94047b-42f8-45d5-81d0-215087de2b5f"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9d120571-f9ce-4400-b527-00d8c27bfc68"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a1f911d3-e912-487b-8e32-23f3d2f66161"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a248f959-f975-489d-a21f-08500a53e9c4"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a423a180-7a7b-4d4a-ba19-c8a9a221c79c"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a69967f5-effd-4ef4-9ca2-0346c3d347e8"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("b68ee564-1ba0-47ff-9cde-9373c43ad8f3"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b9563138-de74-4030-92e1-07eb35d10f87"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bc1d75cb-a473-4f1d-a3e7-f54243d91ad5"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c7749021-0087-47e7-a314-b0af2bed9ae8"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cabd771d-c492-4951-9df2-caebee722f5f"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cc0c1799-4631-43bb-8b30-63a9de35d352"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d9aa61d3-1106-468e-a58d-5171856e3833"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dc21dff8-0a50-46af-a569-fa5dc3da45b3"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dcbfc053-7fd0-4f55-a261-d5954bbf8ca6"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e2a737e5-364f-4ed9-b1c0-aad831da74ed"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e589c841-0dd1-4c99-a89a-bb4906be595a"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e9975bbf-5112-40d2-ab73-c74b0c239cfa"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f315037e-b8d8-4991-8c2a-119553887936"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f75a0a3f-22cf-415d-8bac-2c9ac51a86c8"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f8814779-0fe3-4817-b04e-4fa07667f5bf"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "c4f8ceab-53b2-40c3-af66-32c00336ebee");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "44082d9e-b57a-4dde-b032-9184ec65505d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "84d370b4-fa58-4a53-a9dd-4ccc77c43aca");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "e390bfaa-edcf-49ed-8681-a6bd43bdba64");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 20, 16, 728, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 20, 16, 728, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 20, 16, 728, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("584ab13c-4a54-4c94-b75e-36c8c520c73e"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("70f7609a-09be-49e2-80c6-520c0b50efd8"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("c2a0867c-9395-4b9e-92c0-c615df8446dd"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("e37cdde5-cf72-4d19-9416-9149a021b2e5"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839), "$2a$11$sWBGHM.VwUK8dCtcIFYtxONiNAIeF204pdrukH6odb.Lm8638l36O", new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839), "$2a$11$KmO5DJ8J2IDBlrc29ygQvufJPXLzwAh.fKnP/BrobAYdNcRn8cPfG", new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839), "$2a$11$MKswv3vAI32yI37RwdrtaO2PI7lJoQ9XK5AIcCJHGhVLE9mcGcT76", new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839), "$2a$11$tQd.4N8HS94F2VkRpVMibuzjcumEa8bU89.fpr9TPszbXomHXoRmC", new DateTime(2026, 3, 14, 6, 20, 16, 732, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454), new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454), new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454), new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454), new DateTime(2026, 3, 14, 6, 20, 17, 247, DateTimeKind.Utc).AddTicks(1454) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0144c01b-19ac-4088-b180-79ea07d453a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("07791058-716c-4429-82a5-4d93de181bf4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("094adfe4-e04b-4153-9f84-8833a060d689"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("09e55d58-379d-46ac-9c11-1d60f1e94142"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0e7877df-4785-4ad5-962d-1c0d9dc9c825"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1062a19b-62c4-4f59-a50e-a86d2f6e1020"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1228a72e-4e82-4bee-b3e4-cf25c56efd54"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1519aa87-6983-4c51-a295-d42781eb0c5b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("15986a35-e7e0-4c50-903f-1057af5e1daa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("177e297f-b174-4779-87b0-9088359603be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("18215126-3fef-4239-b0f7-a1ddc0630aff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21eef847-9882-4b23-b4e0-df9c8ee04ad6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22b6b53e-c02e-45c9-86f7-d2fb3c754cf5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("250e4eb6-b2ff-42be-a431-61b72e1a0956"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3094d45b-e685-450e-8c9e-03afcde16b2b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3123384d-8bac-499d-ae86-a31454591e7e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("312e643f-3691-4f54-a38b-123306211591"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("341cf4a5-d507-452a-a5ca-95b39ab471f7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3d280898-990c-42f1-b928-372c08d6184c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d09b2e1-844b-45d2-a1b9-b4dd1c86dcc5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d43b532-a3c9-4451-9fe9-4429c4afc605"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("63496f61-74a2-4464-870a-c3daf232e3fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("724720f9-7ca4-4d63-8767-957957e69694"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("773e5b77-1f20-480e-aa21-cc3058c3b6df"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("78317d5a-9bc5-49e0-9bfe-9fa725c0e9cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d46f1da-a2e4-47f7-9723-a8740d101413"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d683538-278f-4ae2-ac88-d24a3dcc6259"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7ef7364a-8e0c-4ac9-bf99-146348d69695"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8449b543-7faf-4ddb-8994-6ed03ddcf5df"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8a8ce933-427f-4bdf-9d16-65b064aac3cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8bc8eb1e-0ab5-49f9-9f58-6ce4e5c3f0a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8ef7009d-8772-4c8a-ab69-85e81a90afd2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("96b8ad01-00f8-4c4a-809e-82388d0ff19b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9aba26ec-6d5e-4949-813b-0c6a74a0174f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9b94047b-42f8-45d5-81d0-215087de2b5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9d120571-f9ce-4400-b527-00d8c27bfc68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a1f911d3-e912-487b-8e32-23f3d2f66161"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a248f959-f975-489d-a21f-08500a53e9c4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a423a180-7a7b-4d4a-ba19-c8a9a221c79c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a69967f5-effd-4ef4-9ca2-0346c3d347e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b68ee564-1ba0-47ff-9cde-9373c43ad8f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b9563138-de74-4030-92e1-07eb35d10f87"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bc1d75cb-a473-4f1d-a3e7-f54243d91ad5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c7749021-0087-47e7-a314-b0af2bed9ae8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cabd771d-c492-4951-9df2-caebee722f5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cc0c1799-4631-43bb-8b30-63a9de35d352"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d9aa61d3-1106-468e-a58d-5171856e3833"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc21dff8-0a50-46af-a569-fa5dc3da45b3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dcbfc053-7fd0-4f55-a261-d5954bbf8ca6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e2a737e5-364f-4ed9-b1c0-aad831da74ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e589c841-0dd1-4c99-a89a-bb4906be595a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9975bbf-5112-40d2-ab73-c74b0c239cfa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f315037e-b8d8-4991-8c2a-119553887936"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f75a0a3f-22cf-415d-8bac-2c9ac51a86c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8814779-0fe3-4817-b04e-4fa07667f5bf"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("584ab13c-4a54-4c94-b75e-36c8c520c73e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("70f7609a-09be-49e2-80c6-520c0b50efd8"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("c2a0867c-9395-4b9e-92c0-c615df8446dd"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e37cdde5-cf72-4d19-9416-9149a021b2e5"));

            migrationBuilder.DropColumn(
                name: "title",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "title",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "is_deposit_refund",
                table: "refund_requests");

            migrationBuilder.DropColumn(
                name: "ready_to_process_at",
                table: "refund_requests");

            migrationBuilder.DropColumn(
                name: "scheduled_at",
                table: "refund_requests");

            migrationBuilder.DropColumn(
                name: "deposit_refund_scheduled_at",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "DepositRefundScheduledAt",
                table: "booking_read_flat");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "refund_requests",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "admin_notes",
                table: "refund_requests",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269), new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269), new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269), new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269), new DateTime(2026, 2, 9, 16, 8, 34, 650, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(1680), new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(1680), new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(1680), new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 8, 34, 651, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335), new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335), new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335), new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335), new DateTime(2026, 2, 9, 16, 8, 34, 652, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("033ba688-8d62-4c06-85c9-90ccfe1709d8"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0c7ba3f6-9621-44af-aa3e-7d2c100383f4"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e065155-b6d4-4501-b5cb-ce9cd1f82ad8"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e899df4-dd65-481e-9dea-71c3387adac0"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("21fbe3a0-e618-4065-ba67-aba69616b7b1"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("242933bc-4156-4d93-b9ca-9350f4524b08"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("254577e6-db10-4b06-8786-ede1d36335b8"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("26d3a6f4-97e5-40e3-a732-65369533fc75"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2964c774-1cab-4155-8c27-421d52de414e"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2cf0a430-6c8e-473a-8207-66c2ef50d439"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ff5e9b7-6e72-4d08-9446-d503cd8e273e"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("33a17096-20cb-402b-a3b0-9610f84ae195"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("35fdf09f-3aab-4ea0-b02a-d1709d0776e4"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3cba7380-e6b5-45c5-a97f-22e8cd3a0162"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("406f2e5b-f17e-45f5-9acf-3803c008f81d"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("41f94105-bdf2-4fd1-a60f-da0b1fc8b762"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("43892472-6130-467d-bd23-94c506d795e7"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("446e0ff5-0d7d-4f13-b86e-5fc229873d5d"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("522cfcec-af3d-4149-9c0d-fbf1f2a7b2a5"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("537b78cc-f4fd-46d1-ad11-f4ae3d1fbf0d"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6570ecda-cc54-47c3-a92e-22af495334bd"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("696c13a5-fcbf-4dbb-bf51-5415f9c99f08"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6a663c2e-14cf-49df-be2e-31b1960764a5"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6bb66801-4c92-4f9d-8270-571f82ed8f2d"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6c6ebe9c-e5ec-4454-989a-6beec0a97e95"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6ebc8d32-4476-4853-a9f9-cd88442125d9"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("717bdd8b-52e2-437f-91ee-b25b4902d10c"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7a26268a-bc93-460b-8688-df88e3c35d35"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7dcfdb6c-1351-4c00-9eee-60751fa3713d"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("80b47d83-9327-42e2-b7a5-3db42eb2a5a3"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80f155a4-cd0f-4d2d-8d2d-4b94515e715e"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9e3c929e-ae5b-42b0-80f5-93e5871832b2"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9ee353da-4944-46e8-8fd5-0da6f81d1431"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9ee7fd05-a2e6-4c6f-b6f2-91eba5329833"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a084716e-f3dc-46e3-9f98-1d310842be0e"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a64b5a27-fcda-44b8-8365-226b9a90c313"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ac09c978-6267-42cf-a848-03e69aa90fb1"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b0dcc393-c674-46eb-b6ec-8c436ebd5dec"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("b2b9589e-e510-45cc-b42a-01a15975001a"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b3f719a9-b3a0-458c-8a03-c5b195ba6486"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b9731fc0-31ad-429a-850e-fc07104aa8c3"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c09d436d-95e2-4b1a-bf4a-ed456ae21e79"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c8fa0fcb-fcff-4de4-8ee6-01dc7823177c"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cf1f555b-d1dd-4699-858d-3112744d3655"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d0a0f981-75a7-494a-a7f3-cd8a12c0c268"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d1a16ac7-5a9f-42cf-89d1-78eed21fc687"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("d702b7d2-0649-4127-848c-8c502aea26d0"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dc119898-bc34-4360-b92a-376a6b51ce0d"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dfa4ff89-f09f-4354-8aa3-c17b200efbb6"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e3a6c4bf-ecd0-4be2-aeeb-bd0defc40899"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e4bf46af-98c1-43fc-96c6-e58d0d41c39b"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e9fee929-9357-4a5e-9de5-a81003c267fa"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eb45d3bc-6392-4e5c-99f8-67006024e380"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f862ad1a-41d7-4f0c-96ad-93fee0382122"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fda6677f-7924-4fd6-979c-f19f493826dc"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "81cb4dee-faf5-4152-8659-a8e6da870a50");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "4420aa2a-6d8a-4ac5-b7d8-906a6892fe7d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "3a353df5-0b90-4d10-a101-aa08c25ef4bb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "1bcf2d89-218f-48d3-a4ba-810d021f3122");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 8, 34, 662, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 8, 34, 662, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 8, 34, 662, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("30edd6c1-c205-4085-b520-aa11140de1bc"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("8267ea8e-ff8a-4b58-a4ca-7686816d2cca"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("a3c295d2-ff9f-446f-a163-2d440bdf93a7"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("abc9d930-4c36-4965-b216-96dec5b6da09"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055), "$2a$11$zi7ItCAaUOnFBobZMB8Wwuy3oRCwUj9t0iLATqE7EZC8M15t7s.TC", new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055), "$2a$11$FHUp.GrTPli9Z1/LxlhFH.K.5t1GwkNOoixbA7ojhu0FwqUOFfBpK", new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055), "$2a$11$IgUeWf0LjJdLuOT6LVAmFO8cpYC.6SSfJN.jBAvspKDDrSOUmzF/.", new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055), "$2a$11$83ZQ51bzNcvJU78sSODkYOdeIdnmDrdYnM8exTYib71/RVYkl2roy", new DateTime(2026, 2, 9, 16, 8, 34, 665, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612), new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612), new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612), new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612), new DateTime(2026, 2, 9, 16, 8, 35, 202, DateTimeKind.Utc).AddTicks(1612) });
        }
    }
}
