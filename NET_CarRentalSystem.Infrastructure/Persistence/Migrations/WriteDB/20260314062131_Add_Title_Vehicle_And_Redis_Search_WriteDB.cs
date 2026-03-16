using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_Title_Vehicle_And_Redis_Search_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("01bb91a8-23c5-47ce-a831-0f1d9ef19f5c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c315283-0b60-4669-b749-ad4cc3545f61"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0d3a6fba-de4a-4766-9182-68709ccf3d72"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("133ca6ad-0998-4e9f-9719-537234d33262"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("144ed10b-878e-419a-9457-00221f7a7793"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2658b455-42f3-4ab3-ad80-e7fd13d6ece7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30caecf2-0668-42cb-b173-a0b0eaacde3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32ad62eb-e6c6-423a-ba1e-e5fcee7a9ed8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("35408254-85b5-40a9-90e2-4fe11662f009"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3d1ce4f8-65f2-4cec-8cbd-48f41e3eb978"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3fd00dcf-b50d-45cd-9a58-0d0e18bbf832"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43e79d29-297f-4cab-aa3f-53023f92659f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("44ce5b66-5800-4e6b-9536-6f3666fa01bc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("45df66b2-e6d1-4ec4-b1dc-d677d3da353d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4a5035af-98b8-4de1-a58f-a15907c5299c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4e9b3200-c19a-4d10-ba08-4a2844acb4fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4f658bc5-bc47-466f-a8b6-610b30b38b68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("675a9f5e-3ddf-4e67-9de4-01f15a0182fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("71e0f213-b5f6-4e0e-939d-8fbb9cdbce03"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7488a74d-317a-474d-bb17-60f45dec65d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("76121de8-acd2-42a3-8b5c-e6e0912975ad"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("799f2b94-7f5a-4504-a0c7-ca6ded0fb850"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80eff780-faa8-4f07-974d-aa31c7276391"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("83e6375a-e13a-4fe5-adeb-00c3586e7043"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84a664ee-5788-4c5f-bd53-f0729108cf6d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("890a1247-64e1-4b86-82d4-efd86692da5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("893f44ea-b610-463c-8d13-00e8400a1eb6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8a8b3bce-1b00-40ae-8004-1de9c2015a2c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8d7e3975-4189-4bad-9ab8-ca2366e93a2c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8dcb5ac1-a00f-4af6-9044-5e504e457792"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9d3040ac-a28f-46ed-93c4-51425d999fd5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a06062e4-6805-49ee-8019-8f1bf9ec57a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a5cd718a-705b-4be2-9894-e30d47780891"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a72ae9ce-57a4-4446-8088-fcfddb837199"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a8345f0e-fb85-4158-a801-34ab9b02a67e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("add7fbb0-c20f-4a87-a107-637f038b8aa5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b0741075-8c90-43da-8d46-e8f1b36dbcc1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b5252954-b1f1-4065-8953-4c24c8f1aeaf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b8c36a6f-09a1-4752-aa54-b9ad0ff462b5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bcd85b62-6f3c-4ec7-9bc4-bb163255d906"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bf6746f0-6751-4a85-a2d8-96f609177ab0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c5c90254-e2e5-45f3-bd9e-db17d2f1ca9c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c95ad645-736c-475d-8531-cd67d15c554b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cd3a243a-85cb-49e5-aae9-ccf7ceaa6fd6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d4d129ae-0694-4d85-b568-da4364e420a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d73c9ddf-2a32-41e1-b541-1aa1e58edbd1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dee71545-9815-413e-9c0a-e0117802b681"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e4b58905-bb95-4505-8225-98eaca1f914e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e62a95b1-95e7-4128-a519-9e7b91ae1a4e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ef6b439c-487a-4e9f-9df0-61eb64420f91"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f0086a87-6788-4e64-96f4-ba334f7051d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f01623fa-c41e-4c83-835f-de339efc7843"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f145d096-c73d-40eb-b364-f340a234f43d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc6451d8-49f4-46aa-be28-3c435d6f8fb8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fef7fbe1-fa03-4e1c-a169-e4c5ca13df03"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("1702a326-0a53-4de0-b1eb-1455d027ab72"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b7888bbd-c521-4710-b479-3a9f6ff4c0dc"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("cc936299-cc31-40f0-a795-5072a341bf4e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e7664b37-baa1-4638-a010-5bb093d7fb82"));

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "vehicles",
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

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(8775), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(8775), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(8775), new DateTime(2026, 3, 14, 6, 21, 23, 419, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 3, 14, 6, 21, 23, 420, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0468c98d-bdda-4c6c-a918-82f1fb5c419c"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("0a98fbc9-c26f-40bd-993f-2db333fd543e"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0daa6739-45ca-4a34-8d33-78d588cff7dd"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0dde0af2-a57a-41bb-82bb-620b8397c1e8"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("19cdf7ad-bb99-4a53-8241-cd915c71b869"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1a28d2b3-a834-4088-bd5b-be2d194f31d5"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1b2bbf74-ec0f-455b-b377-1e278584fd8a"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e4ce809-4de3-4fd5-a7bc-fc6bb5defb84"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2080f8e7-b3d0-4395-b16f-a0a02ca361d8"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2232b776-2653-4e79-9eda-8f81a8a132fb"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("26136270-1d53-410e-9608-e2b85c7f5fc8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("31f7104e-31bc-4876-9126-7ab91b0e112b"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("41cc8c97-09be-4063-a5dd-c1667a6b1afb"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4356d773-9360-47c0-8d81-52aa1938ceb0"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4accc896-5613-49a1-b84d-5a669a68741a"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4dc5472d-b59b-41ce-9202-838c35b965e5"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4ef512f2-e556-42e1-bf98-358ed7a619d9"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4fb42681-0bc4-4813-922b-8036af8342a8"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("50b7261e-89c0-4802-bbd0-2b1d914094d1"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("53cf3897-01e9-4a43-a09a-c76f3bc4ae11"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("582a5840-a09d-465f-979a-0ac4d402a152"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5a99b43c-f097-46c1-a32c-4bf7cfb46489"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("603c6603-a5dd-4dcd-863d-4dcbf866bd48"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6059bafa-d65e-406e-ab92-509dd79adf5b"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("61869daa-307a-4138-8aa0-435c38609845"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("72812288-4807-4ebd-98e4-9e426f6b7c71"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7375774e-8ab3-49f9-a88f-ae738ebf880d"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7c680a8b-074f-48b2-9057-b484f0f47884"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7ef1f2a2-7029-491c-8729-3b1c86a04089"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("846c7709-d032-47c8-a267-b1091baff394"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("84a62447-6dc1-4823-99dd-9e807584f317"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91c32782-363d-497e-a588-f74d341a7d61"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("927f3bec-7ddb-41de-a7ea-8f1b92a9ff6b"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9413683d-9cac-444e-9933-b11f8b6491a3"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("95d5ab1b-34d8-4624-972c-8aade71420f6"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9cc0e0ca-73f7-4c10-93ce-59a21e596415"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a3f743a6-d2a1-4c3f-b95c-c362a38f8207"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a7f50d80-3618-4bd6-ba09-0f280b741c22"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af4905ae-65f4-4a56-8428-aaf0538d70a3"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bda4624e-1cdc-43d5-9677-e7f86ea240c2"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c3662c9c-5cea-4f6f-898b-38ce5d84f430"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ca108f65-66fc-4018-8cd2-685ed526abcb"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cf8a7045-3605-44ba-b362-a71de0b95f95"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cfbd40c0-532e-4e7e-b911-df01847bcf08"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d63eec14-9670-4d45-a66e-47edf592db14"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d6da7963-2983-4ac7-8f13-07eea0443fae"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("de349727-8467-495d-82e8-bf54267820b0"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e30530f2-cc9c-4775-af29-7caee3f03135"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7514a75-5fa6-41f5-b321-e374c4acd5f7"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7a94225-d981-4f8c-8fa4-8162d751eea3"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e8d7399f-6c81-4246-b729-a9b0c9cb50e4"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f0354bfd-84fd-400f-956d-c20617ac7491"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f53ae804-517e-496b-8772-4f536bff698f"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f653aacf-fb6d-44e6-bb4e-5bbe70061249"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f77c0507-f339-455e-9b10-58eaa505d7c6"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "20a56d96-dac3-476b-b607-ddc97d4926e3");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "2f72b99c-74da-426a-8adb-012ea3899f37");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "63fbb609-0b15-4060-a896-fde49a3b27a7");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c1669a2d-cf61-4119-a652-30350b087dc6");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 21, 23, 428, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 21, 23, 428, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 14, 6, 21, 23, 428, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("31484e84-b1dd-4f73-ba20-cf0674ca65c6"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("8bba5d8f-5b97-4dd8-9c4f-5854b002336b"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("ce24accb-121d-4e79-afb0-299866d7e858"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("f5abdd4b-be52-4d46-8052-6d0d25cc71e3"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944), "$2a$11$pvRcXEF7f8S9iHXUxSFYXuY8q3r2gsxD8f8Y0vpCrd9zsE3Dmr3gC", new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944), "$2a$11$GH/1OxzJc5NHHGsZAKPP7u.T2Z.SL01NUO5uNQP5Go2lJMmUZYTOC", new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944), "$2a$11$v4rMkruAcZz5YckoKylqO.JhmwO43oNpic/8CzcmyXlWMvhofdDx6", new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944), "$2a$11$DFV7/75ppGc501JQhYfPnuPox3Rl65Un.V6raBomtSC8GZ.wLIFS6", new DateTime(2026, 3, 14, 6, 21, 23, 430, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267), new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267), new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267), new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267), new DateTime(2026, 3, 14, 6, 21, 24, 646, DateTimeKind.Utc).AddTicks(5267) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0468c98d-bdda-4c6c-a918-82f1fb5c419c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0a98fbc9-c26f-40bd-993f-2db333fd543e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0daa6739-45ca-4a34-8d33-78d588cff7dd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0dde0af2-a57a-41bb-82bb-620b8397c1e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("19cdf7ad-bb99-4a53-8241-cd915c71b869"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1a28d2b3-a834-4088-bd5b-be2d194f31d5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b2bbf74-ec0f-455b-b377-1e278584fd8a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e4ce809-4de3-4fd5-a7bc-fc6bb5defb84"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2080f8e7-b3d0-4395-b16f-a0a02ca361d8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2232b776-2653-4e79-9eda-8f81a8a132fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("26136270-1d53-410e-9608-e2b85c7f5fc8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("31f7104e-31bc-4876-9126-7ab91b0e112b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41cc8c97-09be-4063-a5dd-c1667a6b1afb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4356d773-9360-47c0-8d81-52aa1938ceb0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4accc896-5613-49a1-b84d-5a669a68741a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4dc5472d-b59b-41ce-9202-838c35b965e5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ef512f2-e556-42e1-bf98-358ed7a619d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4fb42681-0bc4-4813-922b-8036af8342a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("50b7261e-89c0-4802-bbd0-2b1d914094d1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("53cf3897-01e9-4a43-a09a-c76f3bc4ae11"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("582a5840-a09d-465f-979a-0ac4d402a152"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5a99b43c-f097-46c1-a32c-4bf7cfb46489"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("603c6603-a5dd-4dcd-863d-4dcbf866bd48"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6059bafa-d65e-406e-ab92-509dd79adf5b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("61869daa-307a-4138-8aa0-435c38609845"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("72812288-4807-4ebd-98e4-9e426f6b7c71"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7375774e-8ab3-49f9-a88f-ae738ebf880d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7c680a8b-074f-48b2-9057-b484f0f47884"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7ef1f2a2-7029-491c-8729-3b1c86a04089"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("846c7709-d032-47c8-a267-b1091baff394"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84a62447-6dc1-4823-99dd-9e807584f317"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91c32782-363d-497e-a588-f74d341a7d61"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("927f3bec-7ddb-41de-a7ea-8f1b92a9ff6b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9413683d-9cac-444e-9933-b11f8b6491a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("95d5ab1b-34d8-4624-972c-8aade71420f6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9cc0e0ca-73f7-4c10-93ce-59a21e596415"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3f743a6-d2a1-4c3f-b95c-c362a38f8207"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a7f50d80-3618-4bd6-ba09-0f280b741c22"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af4905ae-65f4-4a56-8428-aaf0538d70a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bda4624e-1cdc-43d5-9677-e7f86ea240c2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c3662c9c-5cea-4f6f-898b-38ce5d84f430"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca108f65-66fc-4018-8cd2-685ed526abcb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cf8a7045-3605-44ba-b362-a71de0b95f95"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cfbd40c0-532e-4e7e-b911-df01847bcf08"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d63eec14-9670-4d45-a66e-47edf592db14"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6da7963-2983-4ac7-8f13-07eea0443fae"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de349727-8467-495d-82e8-bf54267820b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e30530f2-cc9c-4775-af29-7caee3f03135"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7514a75-5fa6-41f5-b321-e374c4acd5f7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7a94225-d981-4f8c-8fa4-8162d751eea3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e8d7399f-6c81-4246-b729-a9b0c9cb50e4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f0354bfd-84fd-400f-956d-c20617ac7491"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f53ae804-517e-496b-8772-4f536bff698f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f653aacf-fb6d-44e6-bb4e-5bbe70061249"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f77c0507-f339-455e-9b10-58eaa505d7c6"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("31484e84-b1dd-4f73-ba20-cf0674ca65c6"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8bba5d8f-5b97-4dd8-9c4f-5854b002336b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ce24accb-121d-4e79-afb0-299866d7e858"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f5abdd4b-be52-4d46-8052-6d0d25cc71e3"));

            migrationBuilder.DropColumn(
                name: "title",
                table: "vehicles");

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
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(6794), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(6794), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(6794), new DateTime(2026, 2, 9, 16, 1, 20, 169, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155), new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155), new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155), new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155), new DateTime(2026, 2, 9, 16, 1, 20, 170, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("01bb91a8-23c5-47ce-a831-0f1d9ef19f5c"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0c315283-0b60-4669-b749-ad4cc3545f61"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0d3a6fba-de4a-4766-9182-68709ccf3d72"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("133ca6ad-0998-4e9f-9719-537234d33262"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("144ed10b-878e-419a-9457-00221f7a7793"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2658b455-42f3-4ab3-ad80-e7fd13d6ece7"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30caecf2-0668-42cb-b173-a0b0eaacde3c"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("32ad62eb-e6c6-423a-ba1e-e5fcee7a9ed8"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("35408254-85b5-40a9-90e2-4fe11662f009"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("3d1ce4f8-65f2-4cec-8cbd-48f41e3eb978"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3fd00dcf-b50d-45cd-9a58-0d0e18bbf832"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("43e79d29-297f-4cab-aa3f-53023f92659f"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("44ce5b66-5800-4e6b-9536-6f3666fa01bc"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("45df66b2-e6d1-4ec4-b1dc-d677d3da353d"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4a5035af-98b8-4de1-a58f-a15907c5299c"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4e9b3200-c19a-4d10-ba08-4a2844acb4fc"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4f658bc5-bc47-466f-a8b6-610b30b38b68"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("675a9f5e-3ddf-4e67-9de4-01f15a0182fa"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("71e0f213-b5f6-4e0e-939d-8fbb9cdbce03"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7488a74d-317a-474d-bb17-60f45dec65d0"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("76121de8-acd2-42a3-8b5c-e6e0912975ad"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("799f2b94-7f5a-4504-a0c7-ca6ded0fb850"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80eff780-faa8-4f07-974d-aa31c7276391"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("83e6375a-e13a-4fe5-adeb-00c3586e7043"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("84a664ee-5788-4c5f-bd53-f0729108cf6d"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("890a1247-64e1-4b86-82d4-efd86692da5f"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("893f44ea-b610-463c-8d13-00e8400a1eb6"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8a8b3bce-1b00-40ae-8004-1de9c2015a2c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8d7e3975-4189-4bad-9ab8-ca2366e93a2c"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8dcb5ac1-a00f-4af6-9044-5e504e457792"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("9d3040ac-a28f-46ed-93c4-51425d999fd5"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a06062e4-6805-49ee-8019-8f1bf9ec57a0"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a5cd718a-705b-4be2-9894-e30d47780891"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a72ae9ce-57a4-4446-8088-fcfddb837199"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a8345f0e-fb85-4158-a801-34ab9b02a67e"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("add7fbb0-c20f-4a87-a107-637f038b8aa5"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b0741075-8c90-43da-8d46-e8f1b36dbcc1"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b5252954-b1f1-4065-8953-4c24c8f1aeaf"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b8c36a6f-09a1-4752-aa54-b9ad0ff462b5"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bcd85b62-6f3c-4ec7-9bc4-bb163255d906"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("bf6746f0-6751-4a85-a2d8-96f609177ab0"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c5c90254-e2e5-45f3-bd9e-db17d2f1ca9c"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c95ad645-736c-475d-8531-cd67d15c554b"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cd3a243a-85cb-49e5-aae9-ccf7ceaa6fd6"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d4d129ae-0694-4d85-b568-da4364e420a5"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d73c9ddf-2a32-41e1-b541-1aa1e58edbd1"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dee71545-9815-413e-9c0a-e0117802b681"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e4b58905-bb95-4505-8225-98eaca1f914e"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e62a95b1-95e7-4128-a519-9e7b91ae1a4e"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ef6b439c-487a-4e9f-9df0-61eb64420f91"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f0086a87-6788-4e64-96f4-ba334f7051d3"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f01623fa-c41e-4c83-835f-de339efc7843"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f145d096-c73d-40eb-b364-f340a234f43d"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fc6451d8-49f4-46aa-be28-3c435d6f8fb8"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fef7fbe1-fa03-4e1c-a169-e4c5ca13df03"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "71189154-4fe8-4ee4-b85e-5082d2cf7366");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "e21c6b0c-e7f6-4849-be78-1058c85d462a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "432fb2c7-0d45-4b0e-a8fb-4ba29eeb4f61");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "725733bc-4274-4355-bd27-5a83e6509104");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 1, 20, 177, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 1, 20, 177, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 16, 1, 20, 177, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("1702a326-0a53-4de0-b1eb-1455d027ab72"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("b7888bbd-c521-4710-b479-3a9f6ff4c0dc"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cc936299-cc31-40f0-a795-5072a341bf4e"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("e7664b37-baa1-4638-a010-5bb093d7fb82"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160), "$2a$11$7vX22mYI7anAV7lG2Pah/uUVGmkL6Uh8v9DrM3sujQVTh5/kUUAq.", new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160), "$2a$11$DRWJd/Z32.wckzYut7pSBe5FQY9pUKjbfQCqdrdUhFspQbxZe/10a", new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160), "$2a$11$VrFGc.VNxb7pFjjqtstJUeS1y9KwoAJzv2vrmTzpW5xDZBAbd1c2i", new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160), "$2a$11$2kK9bMtX/bWMdXIUZxzvnua5VgC.xNzNAhzNf8S.eBqwS5Hf1T1Ou", new DateTime(2026, 2, 9, 16, 1, 20, 180, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040), new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040), new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040), new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040), new DateTime(2026, 2, 9, 16, 1, 20, 673, DateTimeKind.Utc).AddTicks(8040) });
        }
    }
}
