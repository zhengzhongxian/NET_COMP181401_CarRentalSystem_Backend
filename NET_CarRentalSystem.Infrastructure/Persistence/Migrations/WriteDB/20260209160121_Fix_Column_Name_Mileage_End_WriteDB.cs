using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Fix_Column_Name_Mileage_End_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("066e8bbd-d2ba-4220-ab22-fc92189b0c21"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0dfbcfb8-27c7-4766-a454-799a1bb59b79"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0e503e86-6b2e-4a62-a15f-74a626d2f587"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0fb70138-2f4f-4f5f-afe6-45f0b13a7d6d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("131d1628-cddf-4ae8-b221-f875275f86c6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("13e6367d-d8e1-4475-96dc-2c5ad0287bf5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("14b535a1-0a1b-4f80-a40d-8ef97705c2c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16d08313-64c7-48b8-868c-18ef0eed76db"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("309ea712-7402-4509-94f6-b96e10a45f5d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3137cc84-5b28-4793-8a34-c7291e64814d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3273d71b-f98b-4277-a54f-f3d04fb9d1c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("342d7e42-fcd2-4ce9-926a-6ecae6b794a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("37504a62-cac0-4624-b621-f08761084201"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3757fc51-17d6-43f4-8fc6-19c94a893a89"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3c7e1d4a-6fc0-4c48-abc3-d728503099e4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3da2a673-5d54-413c-a91d-073ef2a8b45c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3f275de3-1942-4fc8-93da-8b23c36a8738"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4b558679-2ddc-4dcc-843c-cb8014dd5485"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51cc5807-1705-4dc3-ae70-48f238934a1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("557effcf-1712-4c29-b57f-df681512c3ab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5bc86999-3136-4172-a5f6-9a490976e92c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5bddb7cc-a4c9-465b-80cd-a6690620d9d8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6456aaa2-d575-4839-ba20-2911e6f97aab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("649878c6-7e99-4563-9fad-ea039fa53cad"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("64ceaef4-45fd-486a-9643-0c1287e439d7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("69ac8d89-84f6-4aed-97ae-88eb9b1d9c43"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a272f45-1657-4495-8a2f-b4b66db1c2a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("73119bc7-7f45-4684-a936-de64f204050a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("73251069-5004-4017-a8c2-8b4760f3033d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("74e52ccc-ba39-477a-880f-12efc15cc71b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("796d9c86-6232-4f9c-860c-282d59bf4b6d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b90a0dd-eb33-4299-928c-bf0bb892244f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8dcb56c3-7a17-498e-ba44-fde63143c9c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("98c84bd8-0f16-4d55-b34f-6623846dda79"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e38db1c-d8d3-41e1-9e62-7ee4fa1631ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4d339dc-af0f-4106-9c1b-767b5accfe73"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6b01728-5087-4db2-aa7a-89fe6b298e60"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aa807899-bfdf-4b9c-bf91-6005532ce83f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac3aa4d2-88ee-4df3-a4d0-1c010a10fcbf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b29bc2e3-e27e-4377-b678-0fff896b4a39"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b6111e0e-1a15-4e08-9407-56bbe0b1a1c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bbc5dcbd-b095-403c-876e-6eb4dfa0d55b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be180a07-ed3d-4fc6-8a37-65d5660eec76"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c752d9fa-cbdf-4af0-b93a-05987a78f598"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dd465931-c0ad-49e4-934c-c4a1c1e50cb8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("defa0a96-efc7-4bad-b8f7-1e031ccf0a7a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("df37a435-210e-40ee-a3e8-7fdbd9db66d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e05b5647-4e9e-444c-a219-aeaec2c89c1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e6e1d546-3ffb-4ceb-b16c-24c0fc8c617a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e888107d-5215-44fc-86e9-ac05ef17a7b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("efea0828-1200-40fa-ad4b-4234a5c2cd7a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f4401468-322d-4509-9c25-123d51e34ef1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f700ed10-7d97-4195-b246-82d2b37f42f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fa37d7ea-0640-4b09-b194-de9f0937ad19"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fa8ac408-121b-43ad-bc11-fa3144bb598b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("0bc9a1d8-fc90-458d-8121-73189bbcf61e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b7600782-d3d2-4a71-ae56-5844c848d06b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d4000ae1-2947-4967-886f-2f9d0cf01361"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f3e5627d-d317-4802-89c6-42cfe87a3a6b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(5915), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(5915), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(5915), new DateTime(2026, 2, 9, 15, 39, 43, 39, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614), new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614), new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614), new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614), new DateTime(2026, 2, 9, 15, 39, 43, 40, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("066e8bbd-d2ba-4220-ab22-fc92189b0c21"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0dfbcfb8-27c7-4766-a454-799a1bb59b79"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0e503e86-6b2e-4a62-a15f-74a626d2f587"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("0fb70138-2f4f-4f5f-afe6-45f0b13a7d6d"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("131d1628-cddf-4ae8-b221-f875275f86c6"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("13e6367d-d8e1-4475-96dc-2c5ad0287bf5"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("14b535a1-0a1b-4f80-a40d-8ef97705c2c7"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("16d08313-64c7-48b8-868c-18ef0eed76db"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("309ea712-7402-4509-94f6-b96e10a45f5d"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("3137cc84-5b28-4793-8a34-c7291e64814d"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3273d71b-f98b-4277-a54f-f3d04fb9d1c7"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("342d7e42-fcd2-4ce9-926a-6ecae6b794a0"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("37504a62-cac0-4624-b621-f08761084201"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3757fc51-17d6-43f4-8fc6-19c94a893a89"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3c7e1d4a-6fc0-4c48-abc3-d728503099e4"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3da2a673-5d54-413c-a91d-073ef2a8b45c"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3f275de3-1942-4fc8-93da-8b23c36a8738"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4b558679-2ddc-4dcc-843c-cb8014dd5485"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("51cc5807-1705-4dc3-ae70-48f238934a1e"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("557effcf-1712-4c29-b57f-df681512c3ab"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5bc86999-3136-4172-a5f6-9a490976e92c"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5bddb7cc-a4c9-465b-80cd-a6690620d9d8"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6456aaa2-d575-4839-ba20-2911e6f97aab"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("649878c6-7e99-4563-9fad-ea039fa53cad"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("64ceaef4-45fd-486a-9643-0c1287e439d7"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("69ac8d89-84f6-4aed-97ae-88eb9b1d9c43"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6a272f45-1657-4495-8a2f-b4b66db1c2a3"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("73119bc7-7f45-4684-a936-de64f204050a"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("73251069-5004-4017-a8c2-8b4760f3033d"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("74e52ccc-ba39-477a-880f-12efc15cc71b"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("796d9c86-6232-4f9c-860c-282d59bf4b6d"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8b90a0dd-eb33-4299-928c-bf0bb892244f"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8dcb56c3-7a17-498e-ba44-fde63143c9c8"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("98c84bd8-0f16-4d55-b34f-6623846dda79"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9e38db1c-d8d3-41e1-9e62-7ee4fa1631ed"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a4d339dc-af0f-4106-9c1b-767b5accfe73"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a6b01728-5087-4db2-aa7a-89fe6b298e60"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aa807899-bfdf-4b9c-bf91-6005532ce83f"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ac3aa4d2-88ee-4df3-a4d0-1c010a10fcbf"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b29bc2e3-e27e-4377-b678-0fff896b4a39"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b6111e0e-1a15-4e08-9407-56bbe0b1a1c8"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("bbc5dcbd-b095-403c-876e-6eb4dfa0d55b"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("be180a07-ed3d-4fc6-8a37-65d5660eec76"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c752d9fa-cbdf-4af0-b93a-05987a78f598"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dd465931-c0ad-49e4-934c-c4a1c1e50cb8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("defa0a96-efc7-4bad-b8f7-1e031ccf0a7a"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("df37a435-210e-40ee-a3e8-7fdbd9db66d3"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e05b5647-4e9e-444c-a219-aeaec2c89c1c"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e6e1d546-3ffb-4ceb-b16c-24c0fc8c617a"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e888107d-5215-44fc-86e9-ac05ef17a7b0"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("efea0828-1200-40fa-ad4b-4234a5c2cd7a"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f4401468-322d-4509-9c25-123d51e34ef1"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f700ed10-7d97-4195-b246-82d2b37f42f9"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fa37d7ea-0640-4b09-b194-de9f0937ad19"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fa8ac408-121b-43ad-bc11-fa3144bb598b"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "3155f909-5c2d-474c-8a6f-cc5e74928fa9");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "66c696c3-152e-46de-8d91-e7ffe92a4e6e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "41cb47d8-1c54-49ac-ae71-ad56b8c8ffaf");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "e674f888-0912-4c49-869f-b09095bc1b80");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 15, 39, 43, 46, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 15, 39, 43, 46, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 9, 15, 39, 43, 46, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0bc9a1d8-fc90-458d-8121-73189bbcf61e"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("b7600782-d3d2-4a71-ae56-5844c848d06b"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("d4000ae1-2947-4967-886f-2f9d0cf01361"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("f3e5627d-d317-4802-89c6-42cfe87a3a6b"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189), "$2a$11$/VoN0XqAtcXNkj4y6Sk3tOBnivKdv5n6BK0ezzSux4nboQP8WLyOm", new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189), "$2a$11$babjaaxAmaLWR8Lv.TZObumHodHGIgUOME0wMZJUl7BBiO4lRJZv.", new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189), "$2a$11$TTIIBbEKGg.hyqQBEgfTveOXFuZFx64JPY1k6CEe/nJO4A5aA6f6q", new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189), "$2a$11$QcJmfV08t9CGm91uLJ/7DOSA/yYICqwM1qwyLfz4R2x14HcYqaB5G", new DateTime(2026, 2, 9, 15, 39, 43, 49, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826), new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826), new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826), new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826), new DateTime(2026, 2, 9, 15, 39, 43, 562, DateTimeKind.Utc).AddTicks(826) });
        }
    }
}
