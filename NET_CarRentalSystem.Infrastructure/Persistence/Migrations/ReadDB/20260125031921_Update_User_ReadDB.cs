using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Update_User_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0cc989c0-b9bd-4cca-a713-f6d374eee3fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0eb63fb4-9a6c-4744-b6c2-e0b269c4a065"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0ee39bf2-be9e-4a16-99cc-fd1ba9a23ba6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1129ec12-ea75-47fd-9314-a1a8851de9aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1241307b-3069-4d53-8650-c601c5f13bd2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1360740c-f653-4a6f-949d-f7508ff85c45"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16c71a8a-30d8-4d90-a74d-a093ab368501"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("171ceeb6-c1c7-4a83-900a-a2084f312027"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d4ce2a2-c330-4854-809b-97622d1250fe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1fd3c2a1-0c93-428f-a01d-53f6080941aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f94b43c-72fc-461e-ad66-ff89d25037eb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3427d764-6117-4189-998c-01b398464cea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3622cda4-576b-4ea5-b1a0-01b2cfed352f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3bf2e04f-2c07-4726-bc0f-563f8c831c3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3dbad722-cf8c-4307-96e8-e0bf85f041ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4975fe5b-7467-4c6f-9aef-6d010bc80fa1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ab0a84a-c172-41c0-a96c-00acba9a59ca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4d45b7b1-b9a7-42af-bcb0-b6de8efb9436"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("509596ca-8485-4242-a3f5-d6fc27189422"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("565eaece-9fbb-4e6e-b625-725f0c581d60"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5684f162-7c9f-4f24-8b88-f51742ffafab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57ba77ca-59cb-4757-9fb3-5bb4e99129af"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("614803d5-de69-46b1-b7c6-9480675e2518"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("64de83ec-80fc-4051-95a7-b35af04d7b66"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("68f717c8-86b9-4f3a-b0f9-87930c7d57e0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a7a4120-a9bf-4662-8540-0e8f2e3ee26b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7544e941-a017-4b63-b2d0-8db0a0cc58ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7799e432-1e66-49b8-9bf3-3d8fd0fdf669"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79c11f60-e501-476a-ae65-c9dc86d78ec2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b5e4359-9fcf-40c2-b54a-32ac91a78dbd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91010f5a-68f6-43ba-bb2d-d784df48c27e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("93e3ee21-3e47-406a-b4c3-cf9d9db43cd6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97cbee24-bb68-4fc9-aafa-3555ef235376"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a61c8cd-59a1-4c7f-843d-df30ca449e6b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a9437de-8893-4a95-a6b8-f99f61184acb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e7eb5ef-be6a-4f5d-bda5-633e82c4f89c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3e82519-9992-420b-bf77-b2ac449d45aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a83b32e6-6b79-444c-a1c3-c9ceab62f97b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a83d98f2-71db-4f38-9ea8-0dc9445dbde1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a8416db1-a40a-445d-80fa-17fb21fba5b2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a8bd2982-efd9-4f19-b526-2beda3145516"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a9fbb53e-7a03-43ae-bde6-cb65bdd6c34c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b224c89b-5018-4513-a15b-072a5f7e44f1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b408b51a-895e-4874-9187-b8ea8063f70b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c3a91ba8-71cb-43ce-8056-b796f9a67d4f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0037745-81c3-469c-8f3e-4432805adecd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d7d9292f-c06e-4515-a2a8-7918dac6af57"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da0aa2aa-e75e-4aa9-bec1-44e6c3b9b45c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("db5a1ec6-141e-4269-95b6-aff833a0d812"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ddb88325-1ec4-45fd-96a4-066a2c09ef0c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dfe85be0-aa00-469f-a58e-22b7024a5dec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e32134ec-9d2d-4600-940b-0133fc2473cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e95a8969-85c6-41df-810a-b10114c9ae64"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea309e6c-d9fe-442b-b6ec-23a177c8bb57"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1b25f90-a56a-49e8-886d-e2cafc6888c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8a9e0fc-c130-4c95-aa50-461dd4c088fa"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9f1be8f7-6330-4b33-ad1f-5c519ce4e6aa"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("c88a4992-77af-4df5-955f-a931a6fda94d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("cd8494d8-0b48-49e6-8ba1-ef73ef4a1c30"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f6eebabd-1f5e-42de-b8de-c1cc80fc1c7a"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0cc989c0-b9bd-4cca-a713-f6d374eee3fb"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0eb63fb4-9a6c-4744-b6c2-e0b269c4a065"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0ee39bf2-be9e-4a16-99cc-fd1ba9a23ba6"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1129ec12-ea75-47fd-9314-a1a8851de9aa"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1241307b-3069-4d53-8650-c601c5f13bd2"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1360740c-f653-4a6f-949d-f7508ff85c45"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16c71a8a-30d8-4d90-a74d-a093ab368501"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("171ceeb6-c1c7-4a83-900a-a2084f312027"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1d4ce2a2-c330-4854-809b-97622d1250fe"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1fd3c2a1-0c93-428f-a01d-53f6080941aa"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2f94b43c-72fc-461e-ad66-ff89d25037eb"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3427d764-6117-4189-998c-01b398464cea"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3622cda4-576b-4ea5-b1a0-01b2cfed352f"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3bf2e04f-2c07-4726-bc0f-563f8c831c3a"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("3dbad722-cf8c-4307-96e8-e0bf85f041ba"), "Permission", "Permissions.Violations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4975fe5b-7467-4c6f-9aef-6d010bc80fa1"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4ab0a84a-c172-41c0-a96c-00acba9a59ca"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("4d45b7b1-b9a7-42af-bcb0-b6de8efb9436"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("509596ca-8485-4242-a3f5-d6fc27189422"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("565eaece-9fbb-4e6e-b625-725f0c581d60"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5684f162-7c9f-4f24-8b88-f51742ffafab"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("57ba77ca-59cb-4757-9fb3-5bb4e99129af"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("614803d5-de69-46b1-b7c6-9480675e2518"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("64de83ec-80fc-4051-95a7-b35af04d7b66"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("68f717c8-86b9-4f3a-b0f9-87930c7d57e0"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6a7a4120-a9bf-4662-8540-0e8f2e3ee26b"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7544e941-a017-4b63-b2d0-8db0a0cc58ec"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7799e432-1e66-49b8-9bf3-3d8fd0fdf669"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("79c11f60-e501-476a-ae65-c9dc86d78ec2"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8b5e4359-9fcf-40c2-b54a-32ac91a78dbd"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91010f5a-68f6-43ba-bb2d-d784df48c27e"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("93e3ee21-3e47-406a-b4c3-cf9d9db43cd6"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("97cbee24-bb68-4fc9-aafa-3555ef235376"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a61c8cd-59a1-4c7f-843d-df30ca449e6b"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a9437de-8893-4a95-a6b8-f99f61184acb"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9e7eb5ef-be6a-4f5d-bda5-633e82c4f89c"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a3e82519-9992-420b-bf77-b2ac449d45aa"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("a83b32e6-6b79-444c-a1c3-c9ceab62f97b"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a83d98f2-71db-4f38-9ea8-0dc9445dbde1"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a8416db1-a40a-445d-80fa-17fb21fba5b2"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a8bd2982-efd9-4f19-b526-2beda3145516"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a9fbb53e-7a03-43ae-bde6-cb65bdd6c34c"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b224c89b-5018-4513-a15b-072a5f7e44f1"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b408b51a-895e-4874-9187-b8ea8063f70b"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c3a91ba8-71cb-43ce-8056-b796f9a67d4f"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d0037745-81c3-469c-8f3e-4432805adecd"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d7d9292f-c06e-4515-a2a8-7918dac6af57"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da0aa2aa-e75e-4aa9-bec1-44e6c3b9b45c"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("db5a1ec6-141e-4269-95b6-aff833a0d812"), "Permission", "Permissions.Violations.Resolve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ddb88325-1ec4-45fd-96a4-066a2c09ef0c"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dfe85be0-aa00-469f-a58e-22b7024a5dec"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e32134ec-9d2d-4600-940b-0133fc2473cd"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e95a8969-85c6-41df-810a-b10114c9ae64"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ea309e6c-d9fe-442b-b6ec-23a177c8bb57"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1b25f90-a56a-49e8-886d-e2cafc6888c7"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f8a9e0fc-c130-4c95-aa50-461dd4c088fa"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "59b2f970-130c-441d-8959-9561085f9268");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "4def619a-012d-457c-92d2-428abcffa28e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "65a1ae46-3bfc-4c4c-a0e6-6b4714d743d6");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c8ed1af1-899f-4199-a30b-392b4c330f5e");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 843, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 843, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 843, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("9f1be8f7-6330-4b33-ad1f-5c519ce4e6aa"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("c88a4992-77af-4df5-955f-a931a6fda94d"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cd8494d8-0b48-49e6-8ba1-ef73ef4a1c30"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("f6eebabd-1f5e-42de-b8de-c1cc80fc1c7a"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$Oykg4rtqr0Xq4MR3XpXWqOekDwb/qJAMJ8io7336nBX7j8V.muRZe", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$0qKJZHCLatCVlixmnyNrmO/e2TCTMgV0INmGHbpKzyjmAcSkDPh1.", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$mKtBOr47Oc248TQwYP.u3e.e5FVIPt9CrbFlmXTHDAH2wdAceR0Hm", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$XS5ycwc0DGdV9ybgvSa.zu9PcQDDUc6vLRUjBBXAONQ5ClQj6WGd6", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });
        }
    }
}
