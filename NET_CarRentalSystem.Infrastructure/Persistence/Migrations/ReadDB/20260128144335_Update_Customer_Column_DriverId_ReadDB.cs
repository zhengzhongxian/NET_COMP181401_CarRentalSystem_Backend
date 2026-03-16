using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Update_Customer_Column_DriverId_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0298e4c9-6ed6-4759-ab8b-91ff701b84be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05dfcade-6916-40c5-b1f1-14c30ec76f85"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("067a14c8-efb5-4104-9f97-403d24e3072e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("12e441bc-3435-4627-83cf-b6f3eaa92d3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("132daa65-8507-479d-821a-9da7581c772e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("157ebfc1-158a-4b19-b5c0-3652fc1dce7d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1a8b97f7-4baa-4850-b480-4fd3708891b8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1c99a83e-df13-40bc-8854-212ad8cbb28d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21e63730-02a2-4f29-9510-6895928cefa2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("25ead804-3b96-4529-a9ae-99210eeabcc5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("26713976-df1a-4e53-a2e9-b08b900e5f7c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("29078231-fdd2-440b-923b-7e39af42bf47"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2dde8914-ea66-4850-9070-72e2229c9809"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b586761-832c-43ca-aea8-e8594114344a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b8de235-6864-459a-8470-8974d01e2f45"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3d5702c9-e09d-4796-a8e3-41f746947e43"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("40252f3a-f6ba-4d85-b348-e22cbcea6dc7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4118af71-8e34-4944-8647-2d73ca34b73a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4432972d-3623-4f9c-b537-ab4c245bc5c0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("49ef7968-9036-473f-a4e0-a3105b990f3b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4c224aaa-33ed-45f7-8e35-e774e5cf985b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("539a5179-f37f-413a-803d-59b5ac476ac2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5e0e1abf-8a34-4f98-a667-a59a81857877"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("63835b3d-69d7-4431-96aa-a6bdfcc1dec4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6af231e2-a678-4a0c-b30e-89594285febe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("758f6fef-f4c9-4286-809b-393b80553ba6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("761b3b7d-0979-499d-a0f0-cd9e9c9712a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7aae0232-b06d-4d0c-9142-1cb21ebb95b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7f8ac93b-ca33-42ae-93fb-cbd599165e67"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("824a63d0-9c66-420b-a941-95d08d99b269"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("85c2d723-6f47-4fc7-a3b3-77f5bb8607eb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9247e21a-4f4d-4464-b430-45e0fe22d232"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9516596b-f9dc-4793-8daa-313e1b0327a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9b0138a7-7cfd-45d3-87c2-5e9ed76f4dfc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a1aaf59b-9ece-4305-a526-1f6892a47608"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a52403e7-7734-421d-b68d-6df6fba0a409"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a7637a62-63ff-4226-8b30-e0e873470e76"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b33a2e1f-6657-4d9a-8831-866a1e875736"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b6b5d459-db74-4210-afde-9ecf161f906e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b73f9a54-4957-414b-b817-bc2972d05ca8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bde8c7ed-e383-4f3a-b8e0-4753bdb66adc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bf4a2c2b-51ca-4664-a6e6-528a82c7faf5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c267a55a-39ae-44b9-b396-03a276829deb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c62340e3-c3a8-4c34-a407-605a4166f1f5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c88f148f-1b6b-4776-9afb-4451d382e720"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d83df09a-e485-416b-b210-637d6fdde374"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e27c56be-80e9-4a16-8cca-c403f4570ba1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3ad12f0-8c1d-4383-9a9d-e1c1b7043cea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e53fc17f-8f03-49f0-ba3d-d1e77d419582"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7f17163-cdb7-4355-92d8-006329b00766"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e87ae0a1-d383-42ae-940a-5ee3d78cff7c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed83e340-58e9-4a13-a34b-a97536fd7bfe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1c4433b-dcbb-4644-ac73-73f715a5035b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f55d078c-56b1-441e-93e4-2a64625a011a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f9c8370b-cfd8-4fc9-a4f8-d4279fab61d1"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("94df164d-e7c1-4e5a-b1de-0f3ff0fbdfb7"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("a2c0102f-75b4-4fda-851c-c7266768f9dc"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f35fae7a-809c-4a4b-b9bf-2182392d70dd"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fa357a19-0156-448c-b643-31c65813281b"));

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_id",
                table: "customers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096), new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096), new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096), new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("04359469-76fb-4077-8fa7-d159683bef8b"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0efe80d9-14c4-4cfa-9af5-9bd8153dd6e7"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1126fa72-92e7-45a6-b39d-5d753fdac6ee"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("11b3e189-c271-4b97-8a81-1165f5e51112"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16a911fd-3a89-4548-8d13-da313f002356"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("17a47c76-a2e2-4698-b5e0-d71cc7a68cb0"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1b654908-c85f-4916-8099-f0ac070868ff"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1bf20d44-bc91-493b-8ca6-da6d7f707dea"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1dcfbb73-a355-4bd9-8c67-1b5d4b0a232a"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1f36dc52-325c-470f-8fd4-130c1c344070"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("21eb37aa-3629-46ff-a4cf-6a2ee736ef1f"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2bff8c33-4991-45c7-971d-0e460a8d63ab"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2dd91366-c867-4fd0-a663-0886174c1484"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ef8b685-5509-4160-adde-1cc6c6203269"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("362ac8a7-28a8-4d79-a01a-ed19475ed52b"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("4092830e-f3dc-499b-a967-bef69d98d5b5"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("446698c6-37bf-4fc2-9910-29697a08e1e6"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("4ba92ee4-b268-4429-b797-f4828d391c6a"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("511934fe-e2f8-4e7f-a17a-2e8b49ebfc3a"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("51648138-9cb2-43c5-8838-d468b0036e5f"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("59c4dbc2-253f-4523-8929-8b40e14b6ae1"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("61285281-32ec-46ac-a421-5de8d309c07c"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("63987aac-1f6c-4a74-a2f4-c5821518fb45"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66c6d29a-c890-441c-ab19-2fcd2e797cb1"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6cb9d1ea-c067-4d1e-9e62-d29c1e9a9501"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80d1b6f1-0338-4a1e-9969-60391b88c946"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8378e753-b212-43a8-adb5-1a5aff97a32a"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("84b2a423-78c3-4895-9674-6bab2325f0da"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8650f4f1-1d96-4844-b593-c77afc75a7ec"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("86ef0752-353c-408c-9cbd-d47a22f66e68"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8898749e-57bb-4b18-9110-1b4ebf2cf366"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("88e537c5-5405-44e5-a181-8c798fce024b"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8af9dbe6-3f0f-4095-a1c8-0ce402b15fcb"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8d48da88-df36-4d48-9f6a-c39156c8b9b9"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("950e6fdc-c885-4be2-9b5e-d183ca598749"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("9761ea88-33e0-4966-8500-e7820c90b3f4"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9976254d-6068-4496-a88d-27fe6208e0aa"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9a1c1d3f-557f-492d-83e4-332f93bfae14"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a4962488-1937-455a-bfac-6378b7715fc1"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a7903267-0109-46e4-84f3-72015b275429"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("aae02558-6369-4347-a42a-35fd74706ac1"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae2fa53a-f0d5-4942-ac33-de6d6ea0cae4"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae61abef-d75b-4b6b-af75-0d486741fd77"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af3adbae-fc68-49c7-a51e-6120cb2b335b"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b4dc2ee4-6a7f-4961-9ab7-ff35cab9a5bc"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c2bb4b88-078a-4739-9ddb-d13d63699e72"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c2c22453-fe69-4ef5-8a55-e9536116b052"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c63851e1-424c-4343-8f62-55d6b5084239"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d13942d3-8c98-4ed2-9514-b8a19550d62d"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d2700d61-5e47-40aa-adec-0484b5ad9e4d"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6f20951-8db3-4420-83aa-a2ebbbce2f82"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e861d2ea-ef16-44a8-a8a0-36429678e919"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e9b86d0f-ad46-4514-8227-058aebf31cd3"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f30dfaab-cdca-4333-b3ee-95bf1ea6077c"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f8604159-a830-405e-bb3a-8409adb23455"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "ed313200-a6bf-4c79-b205-b5323599dfdb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "149b6a49-d658-44fb-9281-15df496a0f3f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "50bb4d21-57a6-47a7-950d-c9949e286c31");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "614cbbbe-9e1c-4b87-89fc-32cc1020c11f");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 944, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 944, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 944, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("3b5d7095-482f-4b52-9ca8-e308ddbe925e"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("53b015f9-8add-47f4-a4ea-4e454539b8b9"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("63410530-7a56-4a1d-ba4f-8d956f0c1533"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("b4fca666-5c6b-47e8-9f40-29c43ef5c6ad"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$ZcOdTBUEZ2BcdYwIo6.R4uiUeHlnpJKzUx/s56vxOi1cLnZFl9Puq", new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$DrNNb1fuyUBCmUTzNx7is.xTdATT6zyr6olozK10WNOXA6XDYFnXC", new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$CkByaOQxXCUK1VZVnzI7veyi4ThN15EE7qhF368P/dadRsnT0xJ1S", new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$H2SbydPd9XW8EIf2s.vrHOkyzuO.8UNoKZ3/2ASA9lNaAvH.hqzP.", new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04359469-76fb-4077-8fa7-d159683bef8b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0efe80d9-14c4-4cfa-9af5-9bd8153dd6e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1126fa72-92e7-45a6-b39d-5d753fdac6ee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("11b3e189-c271-4b97-8a81-1165f5e51112"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16a911fd-3a89-4548-8d13-da313f002356"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("17a47c76-a2e2-4698-b5e0-d71cc7a68cb0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b654908-c85f-4916-8099-f0ac070868ff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1bf20d44-bc91-493b-8ca6-da6d7f707dea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1dcfbb73-a355-4bd9-8c67-1b5d4b0a232a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1f36dc52-325c-470f-8fd4-130c1c344070"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21eb37aa-3629-46ff-a4cf-6a2ee736ef1f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2bff8c33-4991-45c7-971d-0e460a8d63ab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2dd91366-c867-4fd0-a663-0886174c1484"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ef8b685-5509-4160-adde-1cc6c6203269"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("362ac8a7-28a8-4d79-a01a-ed19475ed52b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4092830e-f3dc-499b-a967-bef69d98d5b5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("446698c6-37bf-4fc2-9910-29697a08e1e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ba92ee4-b268-4429-b797-f4828d391c6a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("511934fe-e2f8-4e7f-a17a-2e8b49ebfc3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51648138-9cb2-43c5-8838-d468b0036e5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("59c4dbc2-253f-4523-8929-8b40e14b6ae1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("61285281-32ec-46ac-a421-5de8d309c07c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("63987aac-1f6c-4a74-a2f4-c5821518fb45"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66c6d29a-c890-441c-ab19-2fcd2e797cb1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6cb9d1ea-c067-4d1e-9e62-d29c1e9a9501"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80d1b6f1-0338-4a1e-9969-60391b88c946"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8378e753-b212-43a8-adb5-1a5aff97a32a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84b2a423-78c3-4895-9674-6bab2325f0da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8650f4f1-1d96-4844-b593-c77afc75a7ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("86ef0752-353c-408c-9cbd-d47a22f66e68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8898749e-57bb-4b18-9110-1b4ebf2cf366"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88e537c5-5405-44e5-a181-8c798fce024b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8af9dbe6-3f0f-4095-a1c8-0ce402b15fcb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8d48da88-df36-4d48-9f6a-c39156c8b9b9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("950e6fdc-c885-4be2-9b5e-d183ca598749"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9761ea88-33e0-4966-8500-e7820c90b3f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9976254d-6068-4496-a88d-27fe6208e0aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a1c1d3f-557f-492d-83e4-332f93bfae14"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4962488-1937-455a-bfac-6378b7715fc1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a7903267-0109-46e4-84f3-72015b275429"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aae02558-6369-4347-a42a-35fd74706ac1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae2fa53a-f0d5-4942-ac33-de6d6ea0cae4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae61abef-d75b-4b6b-af75-0d486741fd77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af3adbae-fc68-49c7-a51e-6120cb2b335b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b4dc2ee4-6a7f-4961-9ab7-ff35cab9a5bc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2bb4b88-078a-4739-9ddb-d13d63699e72"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2c22453-fe69-4ef5-8a55-e9536116b052"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c63851e1-424c-4343-8f62-55d6b5084239"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d13942d3-8c98-4ed2-9514-b8a19550d62d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d2700d61-5e47-40aa-adec-0484b5ad9e4d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6f20951-8db3-4420-83aa-a2ebbbce2f82"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e861d2ea-ef16-44a8-a8a0-36429678e919"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9b86d0f-ad46-4514-8227-058aebf31cd3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f30dfaab-cdca-4333-b3ee-95bf1ea6077c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8604159-a830-405e-bb3a-8409adb23455"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3b5d7095-482f-4b52-9ca8-e308ddbe925e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("53b015f9-8add-47f4-a4ea-4e454539b8b9"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("63410530-7a56-4a1d-ba4f-8d956f0c1533"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b4fca666-5c6b-47e8-9f40-29c43ef5c6ad"));

            migrationBuilder.AlterColumn<string>(
                name: "driver_license_id",
                table: "customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910), new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910), new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910), new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910), new DateTime(2026, 1, 28, 14, 34, 0, 718, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 720, DateTimeKind.Utc).AddTicks(2339), new DateTime(2026, 1, 28, 14, 34, 0, 720, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 720, DateTimeKind.Utc).AddTicks(2339), new DateTime(2026, 1, 28, 14, 34, 0, 720, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 720, DateTimeKind.Utc).AddTicks(2339), new DateTime(2026, 1, 28, 14, 34, 0, 720, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 34, 0, 722, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 34, 0, 722, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 34, 0, 722, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623), new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623), new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623), new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623), new DateTime(2026, 1, 28, 14, 34, 0, 724, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0298e4c9-6ed6-4759-ab8b-91ff701b84be"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05dfcade-6916-40c5-b1f1-14c30ec76f85"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("067a14c8-efb5-4104-9f97-403d24e3072e"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("12e441bc-3435-4627-83cf-b6f3eaa92d3c"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("132daa65-8507-479d-821a-9da7581c772e"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("157ebfc1-158a-4b19-b5c0-3652fc1dce7d"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1a8b97f7-4baa-4850-b480-4fd3708891b8"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1c99a83e-df13-40bc-8854-212ad8cbb28d"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("21e63730-02a2-4f29-9510-6895928cefa2"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("25ead804-3b96-4529-a9ae-99210eeabcc5"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("26713976-df1a-4e53-a2e9-b08b900e5f7c"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("29078231-fdd2-440b-923b-7e39af42bf47"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2dde8914-ea66-4850-9070-72e2229c9809"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3b586761-832c-43ca-aea8-e8594114344a"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3b8de235-6864-459a-8470-8974d01e2f45"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3d5702c9-e09d-4796-a8e3-41f746947e43"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("40252f3a-f6ba-4d85-b348-e22cbcea6dc7"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4118af71-8e34-4944-8647-2d73ca34b73a"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4432972d-3623-4f9c-b537-ab4c245bc5c0"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("49ef7968-9036-473f-a4e0-a3105b990f3b"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4c224aaa-33ed-45f7-8e35-e774e5cf985b"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("539a5179-f37f-413a-803d-59b5ac476ac2"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5e0e1abf-8a34-4f98-a667-a59a81857877"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("63835b3d-69d7-4431-96aa-a6bdfcc1dec4"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6af231e2-a678-4a0c-b30e-89594285febe"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("758f6fef-f4c9-4286-809b-393b80553ba6"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("761b3b7d-0979-499d-a0f0-cd9e9c9712a0"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7aae0232-b06d-4d0c-9142-1cb21ebb95b0"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7f8ac93b-ca33-42ae-93fb-cbd599165e67"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("824a63d0-9c66-420b-a941-95d08d99b269"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("85c2d723-6f47-4fc7-a3b3-77f5bb8607eb"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9247e21a-4f4d-4464-b430-45e0fe22d232"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("9516596b-f9dc-4793-8daa-313e1b0327a8"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9b0138a7-7cfd-45d3-87c2-5e9ed76f4dfc"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a1aaf59b-9ece-4305-a526-1f6892a47608"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a52403e7-7734-421d-b68d-6df6fba0a409"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a7637a62-63ff-4226-8b30-e0e873470e76"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b33a2e1f-6657-4d9a-8831-866a1e875736"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b6b5d459-db74-4210-afde-9ecf161f906e"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b73f9a54-4957-414b-b817-bc2972d05ca8"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bde8c7ed-e383-4f3a-b8e0-4753bdb66adc"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bf4a2c2b-51ca-4664-a6e6-528a82c7faf5"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c267a55a-39ae-44b9-b396-03a276829deb"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c62340e3-c3a8-4c34-a407-605a4166f1f5"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c88f148f-1b6b-4776-9afb-4451d382e720"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d83df09a-e485-416b-b210-637d6fdde374"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e27c56be-80e9-4a16-8cca-c403f4570ba1"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e3ad12f0-8c1d-4383-9a9d-e1c1b7043cea"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e53fc17f-8f03-49f0-ba3d-d1e77d419582"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e7f17163-cdb7-4355-92d8-006329b00766"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e87ae0a1-d383-42ae-940a-5ee3d78cff7c"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ed83e340-58e9-4a13-a34b-a97536fd7bfe"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1c4433b-dcbb-4644-ac73-73f715a5035b"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f55d078c-56b1-441e-93e4-2a64625a011a"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f9c8370b-cfd8-4fc9-a4f8-d4279fab61d1"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "ffabae6b-2879-4421-954a-d0f608f378ef");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "25a66376-8cdf-4d49-a428-183deab28ea2");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "50dc38c0-2c1a-467f-9290-4128fa97864d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "4e843b62-36fd-4961-9553-6a8d98275e24");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 34, 0, 754, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 34, 0, 754, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 34, 0, 754, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("94df164d-e7c1-4e5a-b1de-0f3ff0fbdfb7"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("a2c0102f-75b4-4fda-851c-c7266768f9dc"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("f35fae7a-809c-4a4b-b9bf-2182392d70dd"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("fa357a19-0156-448c-b643-31c65813281b"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677), "$2a$11$V9eKkfnuSIzuGm7KouNg.OUJcO5k2LqEZ1RCk.BZbzavc63YRnyNK", new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677), "$2a$11$aqByxd8syBMCbyHrZ1waruNp9l0gFk6BRp1j2bZwVHlg7WUJQtTYe", new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677), "$2a$11$9wBe6J6POLdA0UTdx8xLb.SnleQMAXaNejcPq6EPXtpefDVytlWK2", new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677), "$2a$11$eAp8V4cA3xJ8RWsg9bKIxeRd7DrcSZ2sV1RrhPz8Q.r3Kbn/FXeFS", new DateTime(2026, 1, 28, 14, 34, 0, 761, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797), new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797), new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797), new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797), new DateTime(2026, 1, 28, 14, 34, 1, 847, DateTimeKind.Utc).AddTicks(3797) });
        }
    }
}
