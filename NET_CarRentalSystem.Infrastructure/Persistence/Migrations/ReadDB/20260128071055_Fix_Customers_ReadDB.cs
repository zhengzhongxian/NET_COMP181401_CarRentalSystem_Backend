using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Fix_Customers_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_customers_UserId",
                table: "customers");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0336c421-b23a-4f37-9223-a70741a3c5e0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("10928299-011a-4966-a8de-e5e79b572401"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("14683ce3-c6c9-486b-886f-991d8084d674"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("163ce962-577b-4a66-a211-6d5151138a18"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1cb01e40-dd72-4dc6-b0c8-b9828ac104c4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d69cd28-923e-447f-a8a8-c1bd71b695e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1dc40fdb-72b1-42f6-930d-d1ad37ffaa41"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("202db3aa-459e-4937-95f0-142544526a2a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("232cac8b-5f27-4df1-bf36-754ed5414421"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("29ba2f1b-b72b-4101-ab6c-ecc6ff2bd159"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2a58e82d-469b-4fff-8a8e-760a12d1177e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f192517-3ab6-4fdb-bada-bfda8ae186c1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3129b855-3013-4910-96c2-f36d212ba571"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32b1b337-efda-49f9-82bb-054bbca418e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("33d9c718-b7e4-4814-9784-f949c8741311"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41660dfc-76e1-465e-ab54-8e68244c0feb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4282e9aa-e0d9-4c13-b339-a36220706fdb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("463504b9-3ba4-47d9-9476-2fb17cb3abe4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("470ef3e9-822e-4bb9-8001-3c1c90c563bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("49d9f564-2229-4d19-bf44-701c656948ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4b51da79-52ae-4947-86cb-40c96ddf5923"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55a03d1c-a6e9-4cec-80dc-1f63612c7ff2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("59b8b46d-0509-4ab1-a625-15b5bfc08d98"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("62d2e256-af21-4dcf-81aa-beee6c0b1bef"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6b038a04-d009-4298-9c23-d709bf66291e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6c7613c1-8e7d-49df-b11d-3177f6d29ce2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("73f76a58-5c9b-47b8-99b5-4e1f2d14724b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7636bc4c-4e69-4ee4-b676-edb17a69dbc4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7a5a2b60-c705-4319-9350-7d3bd13ec82b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("848cdbdf-7f8c-476d-9ec3-ea9cb6ec048c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88ebe1fb-da3b-497e-b34d-5626c508e3f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8cb8f1d1-ea3b-4458-9cc6-96e17f6284a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8dd21dfe-6935-4774-9653-03026a3c4d0a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("90915517-284b-4019-a5c7-16d62f5e268b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91b812d9-724d-447e-9fc0-b7231bed2eaf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9405505a-e645-4d9d-8626-6ac31ee17c03"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("944d621e-f7b1-4688-849c-ed297a5cf83f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("95a007d8-9247-46c0-8628-0d8a2424730c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a07ac0dc-f13d-4b10-8040-5665af1b89e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a0de2b59-6776-444a-8594-124ffad3a653"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a19e8d18-7a92-47b4-9098-5c0a2c7f2f55"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a770477d-a7cd-4ce1-b299-a7491fbf49d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d020a0c4-4675-47ac-a7fe-583a90500445"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dae6cbcc-ff23-4130-a4ed-a82d692d8600"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de1214e1-7231-48b1-a8af-49c4f2b5299a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3838084-9983-4190-a178-e6f0b23b1b93"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea4fddd9-9fa1-47f4-9aa0-87da8ff8c6ac"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ebd51268-6308-4ffb-86a9-ce9011f6d594"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eda33108-18d1-477b-9408-3aeb74e0d30b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f2a923ba-09a1-464f-af42-a49420566aa3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f3583fd8-3bb0-4613-bcff-f7749f0c8d96"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f61b10e5-ddce-4524-874d-e21adbd93796"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f6970700-caf9-43df-b122-adf3c44cf101"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f6a78e04-a17c-4e49-bbed-350ed5a00a92"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f7c8896d-729f-4e4e-8d94-d28867af397c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fae5e120-e325-440f-bef3-704f95ce1cf8"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("0ea362bc-3876-41a8-8e24-9f044143c32d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("1ff100cf-b3fd-4314-8b36-ee171d4169f2"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("47f04dd6-978c-469e-8993-a80ef5859a1d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("6cec7f13-6a07-4fc3-9196-5618d63122e2"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "customers",
                newName: "user_id");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906), new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906), new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906), new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906), new DateTime(2026, 1, 28, 7, 10, 53, 586, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 594, DateTimeKind.Utc).AddTicks(7265), new DateTime(2026, 1, 28, 7, 10, 53, 594, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 594, DateTimeKind.Utc).AddTicks(7265), new DateTime(2026, 1, 28, 7, 10, 53, 594, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 594, DateTimeKind.Utc).AddTicks(7265), new DateTime(2026, 1, 28, 7, 10, 53, 594, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476), new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476), new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476), new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476), new DateTime(2026, 1, 28, 7, 10, 53, 595, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0b79bc72-9477-4e18-a190-b17199d63044"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("114ce6cb-9217-480c-b07c-005acca94dc5"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("149c4ed7-f77b-4f1f-bf11-0cf0394986d5"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1507d03d-1b12-4407-ba7f-868f16a5a7de"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("157aad11-4b9b-4e86-a73d-92643258a19e"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("24f00358-69a1-4c45-909d-1fe1d74b1cdd"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e2536ce-663d-4dcf-a41f-76b76f114cb7"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("306e8365-99b2-4182-8d9a-2b49f75d01df"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("395c6060-1c8a-40d6-8e2d-9db8893cb582"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3a4e05bb-66a3-4b92-82ef-8e8ea4411ccc"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3e036eda-0966-4956-bb7a-4f8e8157d1a2"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("418b13b2-f0cc-45f2-aa01-05e215fe6683"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4390ce0a-fdf5-423d-b4db-5e74e3273b89"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4dbd12df-72fb-41b4-bb7a-b92a96a3a75c"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5158c76f-786d-4e84-bdec-f604af8c612b"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5330535e-474d-4aa5-a44a-9a074ebcbc7b"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("55e2aebf-fd6a-4983-b54d-731c68f05053"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("590fbf68-fc9e-45aa-bf1b-5ef99e012881"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5cd83e1c-26cd-4040-97eb-d8faf5e1a067"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5cf9e7e6-9000-4649-9559-715b6b6c6a9d"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("6129a244-dc53-4ca1-886c-3eb7f9b14f58"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("62eb28f9-eb77-420d-a8a5-46f8337aa0b1"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("658a603d-17aa-47a2-8200-4f3aa328cf43"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6c964590-ab2d-46cc-9889-14b11a51a2d0"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("6e009ea4-f7fc-4abd-b484-927e77e535f4"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("716a4805-44bf-42f7-b9f5-923ad451cb22"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("73cc63ce-3bb0-46c0-a5f2-3680974fa376"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("75a3e918-ca89-4cb5-82ad-30d893974eb7"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("787cb7ab-8f70-47e4-9391-70cab5adb1cb"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("78e04a88-b8be-435d-b82e-1662125d6806"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7a0f6a8e-11d8-41fc-b222-70baf7f00b76"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7f2ca167-fe05-4d15-bd00-5b99bdde0053"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("83a0f6ad-2295-45b3-bfc3-05f1db1ff709"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("88744bad-405c-45cd-a405-90f2972afb1b"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a2e9040f-bea4-40bb-b862-4e3d056e88c1"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a3183ab6-85fb-4cb5-aef6-c8c8d92bdb3b"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a4629b83-e51e-4fff-9b53-fbe696e6761a"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a97702f3-c60c-455f-85ed-dad365363f34"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("abf2fe3e-20be-4ad1-8b9a-afd9474e1e65"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae0839f5-f24a-4c64-aa37-59772f32d072"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b36ebbe5-93e0-4413-8b5c-dd97ec2bff16"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b5e723ce-3e21-442a-b960-f5dc7b5a4b4f"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b9aa01d3-11ff-4b65-91d7-70cfbd15c6d6"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c4464435-c74a-43f2-9fa7-482f614823d7"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c47105ee-edb3-42e9-878c-f78d23ba5f75"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c52db72b-8fdf-4434-af1b-f60c8758523e"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c58be8e1-2254-4b44-b147-a425348d4da4"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cd1e2b3c-0d12-4758-8bb9-17504ec0065f"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d30f14d3-414f-4aed-8ce9-3c3ff9dc2c27"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d3fa5be5-26de-4e68-a6dc-7479b653a1bf"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da57ce2e-b2a9-4e52-b873-c4b210d65984"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ec8b347e-d5c5-4b0c-8953-442fbfab16fa"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("efd0157b-6dde-4d54-a699-0759d5ec3722"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1074d84-0cdc-4526-b2af-32aecd7eee4c"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "af8ce70d-670e-4fcb-a594-19b940a290e0");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "19183f7e-300c-4aab-950a-3b2cec46c779");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "5cb70062-641b-4895-b80d-8dcb37f0b3df");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "357316f2-ab6b-487d-85e8-1064d4c86872");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 10, 53, 603, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 10, 53, 603, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 7, 10, 53, 603, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0e732ce7-cd92-428d-a381-36a7e4b6c016"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("7ff6db67-1efa-455c-b15e-63a269a20403"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("d64fd34b-0b0d-47b6-bb3e-6f3c1ea76f17"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("fb0c3bb6-4024-48ce-9776-221bafa35011"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188), "$2a$11$.gzej8f6LSXjRAP2GExenuaKhEIE5lcNDDGqr6tywzJU.3wf7nB4u", new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188), "$2a$11$zTvGJhdSB8UR7B7Aqg91m.errXlvE42iqEG4BLrXCRtZ5d27W.w5W", new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188), "$2a$11$qcNFG62Jm5LqlVccPmtQ3ucYZd7SFxrOF1Cp.6i2DrwS6aSo/yuN.", new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188), "$2a$11$0fYiZvtUvsj1HduaHBuGsOUVKkl8RJqo4lknJ3.2eEgVRcsqp70sS", new DateTime(2026, 1, 28, 7, 10, 53, 606, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536), new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536), new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536), new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536), new DateTime(2026, 1, 28, 7, 10, 54, 134, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_user_id",
                table: "customers",
                column: "user_id",
                unique: true,
                filter: "[user_id] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_customers_user_id",
                table: "customers");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0b79bc72-9477-4e18-a190-b17199d63044"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("114ce6cb-9217-480c-b07c-005acca94dc5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("149c4ed7-f77b-4f1f-bf11-0cf0394986d5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1507d03d-1b12-4407-ba7f-868f16a5a7de"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("157aad11-4b9b-4e86-a73d-92643258a19e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("24f00358-69a1-4c45-909d-1fe1d74b1cdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e2536ce-663d-4dcf-a41f-76b76f114cb7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("306e8365-99b2-4182-8d9a-2b49f75d01df"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("395c6060-1c8a-40d6-8e2d-9db8893cb582"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3a4e05bb-66a3-4b92-82ef-8e8ea4411ccc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3e036eda-0966-4956-bb7a-4f8e8157d1a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("418b13b2-f0cc-45f2-aa01-05e215fe6683"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4390ce0a-fdf5-423d-b4db-5e74e3273b89"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4dbd12df-72fb-41b4-bb7a-b92a96a3a75c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5158c76f-786d-4e84-bdec-f604af8c612b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5330535e-474d-4aa5-a44a-9a074ebcbc7b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55e2aebf-fd6a-4983-b54d-731c68f05053"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("590fbf68-fc9e-45aa-bf1b-5ef99e012881"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5cd83e1c-26cd-4040-97eb-d8faf5e1a067"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5cf9e7e6-9000-4649-9559-715b6b6c6a9d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6129a244-dc53-4ca1-886c-3eb7f9b14f58"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("62eb28f9-eb77-420d-a8a5-46f8337aa0b1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("658a603d-17aa-47a2-8200-4f3aa328cf43"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6c964590-ab2d-46cc-9889-14b11a51a2d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6e009ea4-f7fc-4abd-b484-927e77e535f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("716a4805-44bf-42f7-b9f5-923ad451cb22"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("73cc63ce-3bb0-46c0-a5f2-3680974fa376"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("75a3e918-ca89-4cb5-82ad-30d893974eb7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("787cb7ab-8f70-47e4-9391-70cab5adb1cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("78e04a88-b8be-435d-b82e-1662125d6806"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7a0f6a8e-11d8-41fc-b222-70baf7f00b76"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7f2ca167-fe05-4d15-bd00-5b99bdde0053"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("83a0f6ad-2295-45b3-bfc3-05f1db1ff709"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88744bad-405c-45cd-a405-90f2972afb1b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a2e9040f-bea4-40bb-b862-4e3d056e88c1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3183ab6-85fb-4cb5-aef6-c8c8d92bdb3b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4629b83-e51e-4fff-9b53-fbe696e6761a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a97702f3-c60c-455f-85ed-dad365363f34"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("abf2fe3e-20be-4ad1-8b9a-afd9474e1e65"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae0839f5-f24a-4c64-aa37-59772f32d072"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b36ebbe5-93e0-4413-8b5c-dd97ec2bff16"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b5e723ce-3e21-442a-b960-f5dc7b5a4b4f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b9aa01d3-11ff-4b65-91d7-70cfbd15c6d6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c4464435-c74a-43f2-9fa7-482f614823d7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c47105ee-edb3-42e9-878c-f78d23ba5f75"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c52db72b-8fdf-4434-af1b-f60c8758523e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c58be8e1-2254-4b44-b147-a425348d4da4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cd1e2b3c-0d12-4758-8bb9-17504ec0065f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d30f14d3-414f-4aed-8ce9-3c3ff9dc2c27"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d3fa5be5-26de-4e68-a6dc-7479b653a1bf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da57ce2e-b2a9-4e52-b873-c4b210d65984"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ec8b347e-d5c5-4b0c-8953-442fbfab16fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("efd0157b-6dde-4d54-a699-0759d5ec3722"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1074d84-0cdc-4526-b2af-32aecd7eee4c"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("0e732ce7-cd92-428d-a381-36a7e4b6c016"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7ff6db67-1efa-455c-b15e-63a269a20403"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d64fd34b-0b0d-47b6-bb3e-6f3c1ea76f17"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fb0c3bb6-4024-48ce-9776-221bafa35011"));

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "customers",
                newName: "UserId");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882), new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882), new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882), new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882), new DateTime(2026, 1, 25, 3, 19, 19, 867, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 868, DateTimeKind.Utc).AddTicks(1321), new DateTime(2026, 1, 25, 3, 19, 19, 868, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 868, DateTimeKind.Utc).AddTicks(1321), new DateTime(2026, 1, 25, 3, 19, 19, 868, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 868, DateTimeKind.Utc).AddTicks(1321), new DateTime(2026, 1, 25, 3, 19, 19, 868, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 19, 19, 869, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 19, 19, 869, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 19, 19, 869, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438), new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438), new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438), new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438), new DateTime(2026, 1, 25, 3, 19, 19, 870, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0336c421-b23a-4f37-9223-a70741a3c5e0"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("10928299-011a-4966-a8de-e5e79b572401"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("14683ce3-c6c9-486b-886f-991d8084d674"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("163ce962-577b-4a66-a211-6d5151138a18"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1cb01e40-dd72-4dc6-b0c8-b9828ac104c4"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("1d69cd28-923e-447f-a8a8-c1bd71b695e7"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1dc40fdb-72b1-42f6-930d-d1ad37ffaa41"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("202db3aa-459e-4937-95f0-142544526a2a"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("232cac8b-5f27-4df1-bf36-754ed5414421"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("29ba2f1b-b72b-4101-ab6c-ecc6ff2bd159"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2a58e82d-469b-4fff-8a8e-760a12d1177e"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2f192517-3ab6-4fdb-bada-bfda8ae186c1"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3129b855-3013-4910-96c2-f36d212ba571"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("32b1b337-efda-49f9-82bb-054bbca418e7"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("33d9c718-b7e4-4814-9784-f949c8741311"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("41660dfc-76e1-465e-ab54-8e68244c0feb"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4282e9aa-e0d9-4c13-b339-a36220706fdb"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("463504b9-3ba4-47d9-9476-2fb17cb3abe4"), "Permission", "Permissions.Violations.Resolve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("470ef3e9-822e-4bb9-8001-3c1c90c563bd"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("49d9f564-2229-4d19-bf44-701c656948ea"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4b51da79-52ae-4947-86cb-40c96ddf5923"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("55a03d1c-a6e9-4cec-80dc-1f63612c7ff2"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("59b8b46d-0509-4ab1-a625-15b5bfc08d98"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("62d2e256-af21-4dcf-81aa-beee6c0b1bef"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6b038a04-d009-4298-9c23-d709bf66291e"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6c7613c1-8e7d-49df-b11d-3177f6d29ce2"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("73f76a58-5c9b-47b8-99b5-4e1f2d14724b"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7636bc4c-4e69-4ee4-b676-edb17a69dbc4"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7a5a2b60-c705-4319-9350-7d3bd13ec82b"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("848cdbdf-7f8c-476d-9ec3-ea9cb6ec048c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("88ebe1fb-da3b-497e-b34d-5626c508e3f3"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8cb8f1d1-ea3b-4458-9cc6-96e17f6284a0"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8dd21dfe-6935-4774-9653-03026a3c4d0a"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("90915517-284b-4019-a5c7-16d62f5e268b"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91b812d9-724d-447e-9fc0-b7231bed2eaf"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9405505a-e645-4d9d-8626-6ac31ee17c03"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("944d621e-f7b1-4688-849c-ed297a5cf83f"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("95a007d8-9247-46c0-8628-0d8a2424730c"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a07ac0dc-f13d-4b10-8040-5665af1b89e8"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a0de2b59-6776-444a-8594-124ffad3a653"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a19e8d18-7a92-47b4-9098-5c0a2c7f2f55"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a770477d-a7cd-4ce1-b299-a7491fbf49d9"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d020a0c4-4675-47ac-a7fe-583a90500445"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dae6cbcc-ff23-4130-a4ed-a82d692d8600"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("de1214e1-7231-48b1-a8af-49c4f2b5299a"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e3838084-9983-4190-a178-e6f0b23b1b93"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ea4fddd9-9fa1-47f4-9aa0-87da8ff8c6ac"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ebd51268-6308-4ffb-86a9-ce9011f6d594"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eda33108-18d1-477b-9408-3aeb74e0d30b"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f2a923ba-09a1-464f-af42-a49420566aa3"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f3583fd8-3bb0-4613-bcff-f7749f0c8d96"), "Permission", "Permissions.Violations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f61b10e5-ddce-4524-874d-e21adbd93796"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f6970700-caf9-43df-b122-adf3c44cf101"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f6a78e04-a17c-4e49-bbed-350ed5a00a92"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f7c8896d-729f-4e4e-8d94-d28867af397c"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fae5e120-e325-440f-bef3-704f95ce1cf8"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "df14501a-72e9-4e97-9f97-47f2a176e656");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "353bc15b-5a39-4472-9a73-9da5ffbf7a34");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "5b1f85ff-4453-4e25-ad73-e4b65a45d9f2");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "b14523d4-a3c9-4de1-bb01-25ec999677f4");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 19, 19, 888, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 19, 19, 888, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 25, 3, 19, 19, 888, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0ea362bc-3876-41a8-8e24-9f044143c32d"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("1ff100cf-b3fd-4314-8b36-ee171d4169f2"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("47f04dd6-978c-469e-8993-a80ef5859a1d"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("6cec7f13-6a07-4fc3-9196-5618d63122e2"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180), "$2a$11$2KSMG2njeq5a9ysxtT2HTuOZg0p8kyY1uSG2xsstgTzEkrANZUF6a", new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180), "$2a$11$z/iCnOYMrjfCONXH/AQYMekQdlWJl8d2S05boPdPi9uRXo.e8sQ/C", new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180), "$2a$11$7QVAmEP08vphvJUYcDaSJuZ0L5DvbhY9P5EpYVw8hwXRpo8RMWmsq", new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180), "$2a$11$dzFYVj1Bo30R6kf8pjkxKeQoCSVj62/PkPlHzE9eE1pM7sjJiooxS", new DateTime(2026, 1, 25, 3, 19, 19, 891, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555), new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555), new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555), new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555), new DateTime(2026, 1, 25, 3, 19, 20, 440, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.CreateIndex(
                name: "IX_customers_UserId",
                table: "customers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }
    }
}
