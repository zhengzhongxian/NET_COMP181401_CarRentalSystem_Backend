using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Fix_Customers_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_UserId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_UserId",
                table: "customers");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0451c8b6-f97f-4157-81fa-823e8e111aad"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0e3a6c8a-d8fe-4037-aaeb-c2baeaa9ce99"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("147e3fa7-80a5-4850-9e85-3b9dfbf77d08"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("190c3afb-aa47-41e4-922f-742aadc1784f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d1d85de-f120-49e7-b706-31dda8cccadb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("241b8261-27cd-42b2-8624-6932566b9478"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2829513a-ed83-4c4b-990e-2e6bdaf92e70"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("294bb313-0f2c-4f1f-b6fc-6d2a215bbdce"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2b47e38d-cd80-4325-8b70-3e37885d9787"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("354bf629-6e9c-4a2b-a5c4-cda2b215e240"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("35abb12c-d336-414d-8363-0bad587d127d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("366a083a-d158-4c75-9f5d-ee6c787516ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b2032b1-cacf-4ada-bf9e-4006412a2bf8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3ba4ae0a-0720-4061-a727-c937bb2b2333"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3f4d8628-f904-4d50-a547-804779833491"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("40868d5f-aa22-49a2-bf4f-90e97361f327"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("422b288f-c44a-429c-920e-20c0b515f586"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43bc24ea-0647-4cf8-b3ab-4ddfa093e0c2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4634ffd2-ffdd-4d91-8314-0ebbcfcfc4d4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4aaedf61-60a9-4766-bee2-9dfa5c801518"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("512152b9-76c8-4277-bff7-f2423067b398"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("52007aed-dbf8-4fa5-b53d-d6d8e058a88b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("53d82803-75cc-41b0-99fb-5f39677a9cc0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("58ecfea4-3f20-43ce-afe9-4923d06d2ddf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5b976ebb-1e69-42e1-a541-ff503ed3136c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6c65bcba-d061-40f3-8093-32da3b3fb00f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7fd37aa4-69a9-42de-837e-43613ed53f68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80c2b987-6cd5-4944-8aa4-4cf1438aab06"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88a4a86c-b3dd-4393-aa64-eb8e2e86e813"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("899fa0e8-abb7-4929-b5d5-06bca3c726c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("89bce11d-284a-48a6-98d6-dd0a2293ce19"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8ae0a5bc-1477-403c-af8e-277875b8238a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92cd9710-9a02-4913-9c10-18e8e0d2bc10"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92e11d97-0955-4d67-8531-728cf8f5e062"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("98294272-aa1d-4916-9b43-e44ca6506efc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a5e5694a-0954-4aef-905d-82d06e3ce5d2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a65a53b8-34b5-406b-bfec-7406e1b2432b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6658f59-a7dd-415e-a428-0b4a037de8b2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a93928c3-8068-485b-9636-912e9c67d03b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae7b5f52-44c9-4006-b980-97e24cba07ce"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae90ab6e-2b08-4d69-a484-7bb9403d8786"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aee3e50c-2b10-428d-8deb-10ca923965f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b58fcb23-7f95-444e-8e8a-3087b2e12df3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b88e4120-c887-445e-89e3-ed9666eff0a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bb04342d-b0b9-4274-aeac-cac08ef1fb06"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("beb018ed-51b1-4b0e-be4f-7d4e4e3fb05a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c6bf9543-710b-47b3-bcf6-8869dd36f683"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cfda4e55-57c6-40ae-b398-69c3e13f7669"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d8fe7696-9fae-459a-9f72-b7b0530a93a6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de1cb809-c9b9-4061-accd-d4c8b938a1e4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ebf341c1-b751-4375-8da3-cdb64ce14ffc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ef571280-3d55-4f2d-9a54-f7e4d3d5b99d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f25044c3-ca21-4891-9cfb-8728ce5c182f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f555cb54-eb72-42ae-9e57-ef1ace4b2f8f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc06b113-2d43-47c1-9e4b-047378b3b987"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ff1acae3-6bef-499b-87ab-e4a2939d7173"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("64729dc7-9428-441e-9525-b78fd3180f24"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("6822b4d9-1a2f-4e7c-b4b2-b33be43ad12f"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("99c04ba2-41de-4d73-a7ad-81cf4eb3a002"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fb0088d5-81e9-4716-a62a-8e949ec025d6"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "customers",
                newName: "user_id");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987), new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987), new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987), new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987), new DateTime(2026, 1, 28, 7, 12, 30, 414, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 415, DateTimeKind.Utc).AddTicks(1760), new DateTime(2026, 1, 28, 7, 12, 30, 415, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 415, DateTimeKind.Utc).AddTicks(1760), new DateTime(2026, 1, 28, 7, 12, 30, 415, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 415, DateTimeKind.Utc).AddTicks(1760), new DateTime(2026, 1, 28, 7, 12, 30, 415, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910), new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910), new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910), new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910), new DateTime(2026, 1, 28, 7, 12, 30, 416, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("07cb5357-9c03-4182-aa23-cd0efc7d0b15"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0934ab47-8efe-40ab-b88f-bc415d87aa61"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0a9d4c00-3ae8-4048-ba71-7bf634ccfbb9"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0b928492-06e2-4253-afac-91187026e10d"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0f3a91f8-3ce2-4796-a61e-26ef84431cce"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("12c323c5-beb3-4ec3-86cc-1307f8f5b72c"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("158cf478-c7cf-4385-9e2e-4e3690dc8d74"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("17c23810-83f6-467e-829b-aaa7080d0989"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1d894aec-0595-4798-acf0-b366a4e5c7c9"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("288d994b-1086-46b3-af27-4bfa78cd1882"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2b72cbf0-cba0-46e5-b09b-ba661fb5730e"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2efba4f8-f368-48d2-a32a-dcff088a1453"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("324b5eaf-41ad-4ee0-ab69-78485275c52e"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("32988ac1-4cd7-4272-be3b-3c1045db2b28"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("372feb84-5a49-438c-b33d-97ca1b68bc17"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("398bb5f4-d6ef-47aa-8183-ca23ab43343f"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3a10610d-0ac2-4311-9594-5db8880b25da"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3c9963cb-16b5-4d14-b1e4-aef27b6ac752"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3e5abffe-c761-4841-b1fd-df95fe45a475"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4317321b-2d73-45cc-9bd5-df5391bcd850"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4538e2e8-6478-4dc3-9b29-c55887307603"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("52a74a79-ef39-402f-96b6-a095673d2186"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("56440144-f2aa-4480-a0b7-5c8c682a8ffe"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("670c6802-3dc6-4121-abaf-2511b390ea70"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("6dd6a02c-8ab6-4d9a-bb99-34120a32b42a"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6f10de86-faa2-4269-a40e-d95ede28f786"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6f6d5fb1-57ad-498c-9c94-f10acdf13d50"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7636cc48-f2fd-4ca1-be7d-d45c08446e45"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7bdf132f-98ca-4411-94be-f3dae3b32020"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7fd2b785-1423-49ae-82a4-e114a16c145e"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8405e805-b71c-4a5a-a517-73221063fdbc"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("877d5539-5bfc-46a7-939b-7b7e2d96c7e0"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("88c4ba22-0e1f-471c-937b-3469b78e87a8"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("90de9c6f-e731-411d-a6f6-bf82fbaf8796"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("93888b91-575a-493a-ab8a-73feb17134b6"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("9df7533c-b270-49de-9423-67c88230f382"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad486a4a-401c-49e2-ad0a-b3d1166fcd31"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae9bdaaa-25e4-4390-8d16-95a940b4855f"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("b67cdc6b-e52a-4583-bb5f-a7ea17f3aec7"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("b97bcad3-f73a-4ee8-bf89-b79eef812eb8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("be127bcc-bb4a-4802-a2e0-8c5fbec97962"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c7132c0e-7cb8-424d-a127-3ff0d6811a92"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ca30c646-ed1c-46c8-99fa-578ebe2757fd"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ce4cebf3-ed21-445f-97fb-e8ed94eb3be5"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dbf99a87-9b3a-4085-be6e-85f8fa7ce9fd"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("e23b8729-4a1e-43d6-a581-91663fa63c39"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e34bdeee-41e3-481f-8602-5508476d4cc1"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e75b7998-c7de-442c-b8b0-3af778e1422b"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ea24d9fa-69d0-47cd-866e-6a8d9ce82b9e"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f58bb7a3-8963-4d5c-8efb-505b99fb40d4"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f60097b2-7b44-4344-a3a8-36956d5820ae"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f6b0d2dd-8660-4235-a271-40a60133de64"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f9d2eb62-cf51-469e-b0da-136a812084a9"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe62969e-8436-4b05-a0d1-ce79a716c777"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "67843dab-1d53-4685-a7b5-d8144d6cb668");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "e84e242d-d8a0-4d9f-8afa-0b4d42e2ff4e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "5d635388-2bcb-4478-8c45-9c6e4fc64353");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "288cad86-37ce-412e-b380-e2aa222e4898");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 12, 30, 424, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 12, 30, 424, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 12, 30, 424, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("1306713b-d6dc-4919-a1b1-f702d728832c"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("4498ebdb-51d9-402e-8219-b0765789f6d1"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("4874c5ea-d586-4d70-8a99-9f53c23f79a5"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("d1213178-ca01-4eb3-876f-4f20eb9fea96"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716), "$2a$11$PJysVOLeAi/xEdZXiugvLeeQhcVnAS.e2GRvBsrcyFl.LoHWDfSFO", new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716), "$2a$11$waUt7qyes5Y1fnrN.u7Uh.jXokgZtBFwd5E28jtt8IGjZoiXZdyA2", new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716), "$2a$11$wk.z8rG9Jd1qAq9.8QeMyOMjayiqTLana.vG84o8B6GqbesiPZfym", new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716), "$2a$11$.Bc1vVNxpR1lvOVR8obt9OD2bYJy9tSf2AdKmVRgI.xr7yTuumGe.", new DateTime(2026, 1, 28, 7, 12, 30, 426, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858), new DateTime(2026, 1, 28, 7, 12, 31, 21, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_user_id",
                table: "customers",
                column: "user_id",
                unique: true,
                filter: "[user_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_user_id",
                table: "customers",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_user_id",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_user_id",
                table: "customers");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("07cb5357-9c03-4182-aa23-cd0efc7d0b15"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0934ab47-8efe-40ab-b88f-bc415d87aa61"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0a9d4c00-3ae8-4048-ba71-7bf634ccfbb9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0b928492-06e2-4253-afac-91187026e10d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0f3a91f8-3ce2-4796-a61e-26ef84431cce"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("12c323c5-beb3-4ec3-86cc-1307f8f5b72c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("158cf478-c7cf-4385-9e2e-4e3690dc8d74"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("17c23810-83f6-467e-829b-aaa7080d0989"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d894aec-0595-4798-acf0-b366a4e5c7c9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("288d994b-1086-46b3-af27-4bfa78cd1882"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2b72cbf0-cba0-46e5-b09b-ba661fb5730e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2efba4f8-f368-48d2-a32a-dcff088a1453"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("324b5eaf-41ad-4ee0-ab69-78485275c52e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32988ac1-4cd7-4272-be3b-3c1045db2b28"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("372feb84-5a49-438c-b33d-97ca1b68bc17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("398bb5f4-d6ef-47aa-8183-ca23ab43343f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3a10610d-0ac2-4311-9594-5db8880b25da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3c9963cb-16b5-4d14-b1e4-aef27b6ac752"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3e5abffe-c761-4841-b1fd-df95fe45a475"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4317321b-2d73-45cc-9bd5-df5391bcd850"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4538e2e8-6478-4dc3-9b29-c55887307603"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("52a74a79-ef39-402f-96b6-a095673d2186"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("56440144-f2aa-4480-a0b7-5c8c682a8ffe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("670c6802-3dc6-4121-abaf-2511b390ea70"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6dd6a02c-8ab6-4d9a-bb99-34120a32b42a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6f10de86-faa2-4269-a40e-d95ede28f786"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6f6d5fb1-57ad-498c-9c94-f10acdf13d50"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7636cc48-f2fd-4ca1-be7d-d45c08446e45"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7bdf132f-98ca-4411-94be-f3dae3b32020"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7fd2b785-1423-49ae-82a4-e114a16c145e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8405e805-b71c-4a5a-a517-73221063fdbc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("877d5539-5bfc-46a7-939b-7b7e2d96c7e0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88c4ba22-0e1f-471c-937b-3469b78e87a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("90de9c6f-e731-411d-a6f6-bf82fbaf8796"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("93888b91-575a-493a-ab8a-73feb17134b6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9df7533c-b270-49de-9423-67c88230f382"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad486a4a-401c-49e2-ad0a-b3d1166fcd31"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae9bdaaa-25e4-4390-8d16-95a940b4855f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b67cdc6b-e52a-4583-bb5f-a7ea17f3aec7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b97bcad3-f73a-4ee8-bf89-b79eef812eb8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be127bcc-bb4a-4802-a2e0-8c5fbec97962"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c7132c0e-7cb8-424d-a127-3ff0d6811a92"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca30c646-ed1c-46c8-99fa-578ebe2757fd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ce4cebf3-ed21-445f-97fb-e8ed94eb3be5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dbf99a87-9b3a-4085-be6e-85f8fa7ce9fd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e23b8729-4a1e-43d6-a581-91663fa63c39"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e34bdeee-41e3-481f-8602-5508476d4cc1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e75b7998-c7de-442c-b8b0-3af778e1422b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea24d9fa-69d0-47cd-866e-6a8d9ce82b9e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f58bb7a3-8963-4d5c-8efb-505b99fb40d4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f60097b2-7b44-4344-a3a8-36956d5820ae"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f6b0d2dd-8660-4235-a271-40a60133de64"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f9d2eb62-cf51-469e-b0da-136a812084a9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe62969e-8436-4b05-a0d1-ce79a716c777"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("1306713b-d6dc-4919-a1b1-f702d728832c"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("4498ebdb-51d9-402e-8219-b0765789f6d1"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("4874c5ea-d586-4d70-8a99-9f53c23f79a5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d1213178-ca01-4eb3-876f-4f20eb9fea96"));

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "customers",
                newName: "UserId");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541), new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541), new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541), new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541), new DateTime(2026, 1, 25, 3, 17, 47, 393, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 394, DateTimeKind.Utc).AddTicks(6014), new DateTime(2026, 1, 25, 3, 17, 47, 394, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 394, DateTimeKind.Utc).AddTicks(6014), new DateTime(2026, 1, 25, 3, 17, 47, 394, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 394, DateTimeKind.Utc).AddTicks(6014), new DateTime(2026, 1, 25, 3, 17, 47, 394, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 17, 47, 395, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 17, 47, 395, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 17, 47, 395, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776), new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776), new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776), new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776), new DateTime(2026, 1, 25, 3, 17, 47, 396, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0451c8b6-f97f-4157-81fa-823e8e111aad"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0e3a6c8a-d8fe-4037-aaeb-c2baeaa9ce99"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("147e3fa7-80a5-4850-9e85-3b9dfbf77d08"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("190c3afb-aa47-41e4-922f-742aadc1784f"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1d1d85de-f120-49e7-b706-31dda8cccadb"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("241b8261-27cd-42b2-8624-6932566b9478"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2829513a-ed83-4c4b-990e-2e6bdaf92e70"), "Permission", "Permissions.Violations.Resolve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("294bb313-0f2c-4f1f-b6fc-6d2a215bbdce"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2b47e38d-cd80-4325-8b70-3e37885d9787"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("354bf629-6e9c-4a2b-a5c4-cda2b215e240"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("35abb12c-d336-414d-8363-0bad587d127d"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("366a083a-d158-4c75-9f5d-ee6c787516ed"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3b2032b1-cacf-4ada-bf9e-4006412a2bf8"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3ba4ae0a-0720-4061-a727-c937bb2b2333"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("3f4d8628-f904-4d50-a547-804779833491"), "Permission", "Permissions.Violations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("40868d5f-aa22-49a2-bf4f-90e97361f327"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("422b288f-c44a-429c-920e-20c0b515f586"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("43bc24ea-0647-4cf8-b3ab-4ddfa093e0c2"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("4634ffd2-ffdd-4d91-8314-0ebbcfcfc4d4"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4aaedf61-60a9-4766-bee2-9dfa5c801518"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("512152b9-76c8-4277-bff7-f2423067b398"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("52007aed-dbf8-4fa5-b53d-d6d8e058a88b"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("53d82803-75cc-41b0-99fb-5f39677a9cc0"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("58ecfea4-3f20-43ce-afe9-4923d06d2ddf"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5b976ebb-1e69-42e1-a541-ff503ed3136c"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6c65bcba-d061-40f3-8093-32da3b3fb00f"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7fd37aa4-69a9-42de-837e-43613ed53f68"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80c2b987-6cd5-4944-8aa4-4cf1438aab06"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("88a4a86c-b3dd-4393-aa64-eb8e2e86e813"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("899fa0e8-abb7-4929-b5d5-06bca3c726c8"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("89bce11d-284a-48a6-98d6-dd0a2293ce19"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8ae0a5bc-1477-403c-af8e-277875b8238a"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("92cd9710-9a02-4913-9c10-18e8e0d2bc10"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("92e11d97-0955-4d67-8531-728cf8f5e062"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("98294272-aa1d-4916-9b43-e44ca6506efc"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a5e5694a-0954-4aef-905d-82d06e3ce5d2"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a65a53b8-34b5-406b-bfec-7406e1b2432b"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a6658f59-a7dd-415e-a428-0b4a037de8b2"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a93928c3-8068-485b-9636-912e9c67d03b"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae7b5f52-44c9-4006-b980-97e24cba07ce"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ae90ab6e-2b08-4d69-a484-7bb9403d8786"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aee3e50c-2b10-428d-8deb-10ca923965f3"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b58fcb23-7f95-444e-8e8a-3087b2e12df3"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b88e4120-c887-445e-89e3-ed9666eff0a4"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bb04342d-b0b9-4274-aeac-cac08ef1fb06"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("beb018ed-51b1-4b0e-be4f-7d4e4e3fb05a"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c6bf9543-710b-47b3-bcf6-8869dd36f683"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cfda4e55-57c6-40ae-b398-69c3e13f7669"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d8fe7696-9fae-459a-9f72-b7b0530a93a6"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("de1cb809-c9b9-4061-accd-d4c8b938a1e4"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ebf341c1-b751-4375-8da3-cdb64ce14ffc"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ef571280-3d55-4f2d-9a54-f7e4d3d5b99d"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f25044c3-ca21-4891-9cfb-8728ce5c182f"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f555cb54-eb72-42ae-9e57-ef1ace4b2f8f"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fc06b113-2d43-47c1-9e4b-047378b3b987"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ff1acae3-6bef-499b-87ab-e4a2939d7173"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "f8f731e9-2862-46a6-bccc-fd2e9e9e0ba4");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "9a421649-f7c4-427d-b4a2-8cbbb3cbfa4b");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "8eab1fa8-bd01-4910-9188-20bc7e3151f2");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c9d06f26-7872-401f-80e5-9f8a0d3de446");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 17, 47, 405, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 17, 47, 405, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 17, 47, 405, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("64729dc7-9428-441e-9525-b78fd3180f24"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("6822b4d9-1a2f-4e7c-b4b2-b33be43ad12f"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("99c04ba2-41de-4d73-a7ad-81cf4eb3a002"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("fb0088d5-81e9-4716-a62a-8e949ec025d6"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481), "$2a$11$o9W.t37Ue1sIbyIqmPRFdulDFbashcuw5IL1iZve.7GA1VVlzXlY6", new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481), "$2a$11$vBAKkSfgcGy.l2SLLhpGPeSLaJz.wv8gfPhaBgFBN/ISfY3lidHYe", new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481), "$2a$11$o8lJ06g087TF8M9YSq1gh.zbXSMtv7kyjHd0sqtB7inDKtGJKUpE2", new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481), "$2a$11$I8BAnJSKQJ6pxqSifB1tQeqpsKr8qX3rP.GkwkGYap/2FcSarRb7.", new DateTime(2026, 1, 25, 3, 17, 47, 410, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991), new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991), new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991), new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991), new DateTime(2026, 1, 25, 3, 17, 48, 0, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_UserId",
                table: "customers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_UserId",
                table: "customers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "user_id");
        }
    }
}
