using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Update_Customer_Column_DriverId_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("08d112dd-402b-4ffb-9487-69af983502ee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0ca48945-8049-4b5f-ac4a-7d2920f64f29"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("162f8dc8-2b24-47ee-95c6-2d072346f434"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("17339333-ad46-4149-9ad5-92565b103b67"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("19da3d95-0a29-45f8-ad0f-9ff946b5301b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("19eafceb-e0a1-44dd-a42c-dd816b2a02f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1dacb354-0f9a-423a-875c-517976e53137"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("24b45720-e8d4-47cc-b139-4e1ffb916801"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("25fefe6e-6a17-4391-b8c7-860560ad3984"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2beb4f70-751d-47fa-ae76-c67c6762b609"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f5c0737-53e9-492d-9fe0-fc9587d04655"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3dc5703c-5720-4a3e-98c9-c82dcfda91a9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3f69e880-b993-4c5b-8bf6-09ccee3e1981"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41cf048a-72b5-41ed-94ff-00f37a7536a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47edac82-e103-44d4-b8e2-f9d1045bfd27"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4854f8e6-9c18-42f1-a905-b4a3b017c2a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4a7d108c-74a9-48b8-99e9-ffc72c620f52"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4f6f417d-8ec9-4b66-843f-5155b9e9147e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("505004ca-18e6-448a-ac0a-7205d1c9fe5e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("59323c0c-d936-4ae2-a8a6-ba334dc9d9f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("680567ee-002e-4582-8778-53a7f6cbec61"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("69ceb11b-9209-440f-96dd-1d9f0c6a17bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d03b720-8f7b-46bb-848c-57f32b730974"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6fade1e3-a9ff-4544-9732-78405565ad89"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("702a1a98-9f03-4acb-aa87-2c3d5e305029"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7228af52-0b73-4fc2-8775-1403f1189b8c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("73f1acd8-f0b5-4c97-ae9b-dfb4145e1867"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7b271947-2e0c-4b51-afe8-8031a745937f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d3a9f76-2878-4fc5-ae9e-04b77d26ec44"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7fb010db-077b-4ef8-9729-7fe160e9ee42"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7fb2d722-102e-4cbf-85fa-de0685e415c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84651830-d245-4996-b0f2-22e2e4ee580f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("863a6922-7611-42c6-a614-dacb58b426a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8bf49476-b3a5-49e5-bfa8-cc4a002c1034"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8c24ab17-a879-402a-8ba4-8282bb2131fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("906af114-a899-474f-a6d0-c0bf245c404f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9375f4e6-4772-4d6d-bb04-3501bce5c42a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9976127a-15a7-4b07-bb7c-db6f27e45225"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9b517120-f7a7-4d00-b9bf-b9c29effe6fd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a24b5fda-359f-4bd1-b1b9-c6fe944187c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a38dd84c-a5ad-4b9b-a08e-b123030dc242"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a675ca60-7450-424e-a08d-763f910a087f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a685e746-6b49-4e4b-9a44-215b9846ad3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a98a7fbe-05e8-4263-a0e2-8423ceacebb7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b8dca931-8f82-417e-92b3-7dd420f88cdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ba12d15e-af6a-40ce-9550-07e41d027ac8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca70fde2-7ffa-4b60-92e8-b1875f4167cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d3712556-e25a-4d37-896a-01436d89d764"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d55b4367-46fe-4207-a25e-9549a481edd3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e4971c83-d993-4356-859b-da3ddd7d5415"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e49fef12-4cf5-48ac-8820-cef42f627150"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ebd8401c-b5cf-401f-9500-e61fd79f7a1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f29d84f5-1314-479c-883b-1f2befe1b085"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8f4b33f-c629-43e7-8924-9865886afc8d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fbcad456-f162-4445-b85d-337f35819093"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("1bd71d95-42b7-40d4-b29e-226388f93e12"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("49ca59b1-0c51-43fd-a8bc-0389a280efd3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("588df79c-cf44-4e54-8db7-575e3ea9db29"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d01f76d6-50d1-46a8-bae0-94c2ff26df5d"));

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
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447), new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447), new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447), new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("005b4d69-5344-4291-94de-576bdcc72bdd"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0098b202-186f-4d58-890e-9746cf047da4"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05b377ef-aebe-4f00-b161-c731cf66b8fc"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0962978e-f68c-4f10-b9e4-2f2296e72463"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0c5831f8-ff5c-47ec-bd31-2b493472b535"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1947bd74-1510-4683-b588-95b3da54bab2"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e5a5032-ab87-4576-b21a-95d21e16c874"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("20f898ce-53e7-4fee-8185-d5b282228591"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2321e197-cd51-4c58-bf73-5297a4f07075"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2792fcbf-5ddf-4ec7-871a-bee665d99960"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e7b4e01-eb9e-4123-b206-7e026dc092a9"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e82356e-0207-4a8f-a26a-c427dfc0d90e"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30b8dfc6-309d-4d90-8ae0-a6dd0d2a9d3d"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("32344919-e5fe-457c-9646-1e939404cf9f"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("329ecd33-6992-4bb0-9465-bd8b621d40e3"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3634b9f8-a2a9-4c7b-9379-cbd480c97ed2"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("38d5c80b-dc58-492c-b773-2e71aca4795b"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3d401069-8db6-46fc-a460-d5ceaa2e91a5"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("41d11d35-587a-40fe-a555-d82d168b102d"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("46f6cd7f-e83b-45ec-99e1-154b3ddde079"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4839d953-04df-4b78-9026-a771dbcd664a"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("48e4eea2-9ed0-4ad8-8892-3091de5f2117"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("56cc240f-f9ad-4844-8966-0ba7b6fb7d54"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6494f7d3-a1ed-41ac-86d0-142662bf9048"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6db0fa88-8ed1-41a7-ab9b-65888b1e6e1c"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("718d3603-3dc5-480e-b4f5-78d682b3b834"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("791192bd-839e-4e7d-9682-0113c13c0f54"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("815ac59a-b756-4da0-afbd-dd38d7c9d0a8"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("826c7dbd-60ee-40b5-87fa-32fd6610fcd4"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8cd3d87b-4fc1-40ae-9c06-0a535d075f16"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8f069dc0-47cc-464b-a61f-0ae31dd53786"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8f64b21a-d7b0-4e68-a42a-488311b4df63"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91be52ef-2300-40b1-8f70-634c9485cff1"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("928e1bcd-710a-4119-a768-477bb5740e02"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("97abd8e5-700e-4b25-ba64-6942bdbff8cc"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("97dc0b84-9751-4e3e-a850-175e2713cb3c"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9f7fdbb9-3bbe-4c22-9632-d20fb7438c5e"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a36ca8b0-6052-4343-a922-60e5c2edbe6c"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aba0ca0c-f9a5-4ad0-b45c-081fee1e5355"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ac386893-a9d4-4e35-b7b6-e4252e3eee25"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("acd44ea5-a453-4402-93dd-ddd52104be77"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad6863bf-1873-4b08-a8af-8442e224873d"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("adc71771-1032-4655-8eb7-e7bf7ec43a9f"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b14fde3d-b044-403a-8044-1fb5b9e09793"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b31d455b-4e06-42ad-9a8b-86d592b1f715"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bb53521b-af3d-46f6-ae2e-dd2f224d5363"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("bd04cc24-50de-4c95-9afc-e173f0a6ff74"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ceda8ced-a7c2-46c2-b738-80e718ebbeea"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da40a484-5876-4991-a36c-f223c900862a"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e899fa20-fe31-487b-bd65-e2d944e3bde7"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ecded164-6a3a-46c7-a90f-c36a29e0a622"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("edddfc96-eb9b-459b-9601-ea88a1a5dab9"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("edf7769c-0d58-43f4-acf2-1e60d676db93"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f502c62c-8f99-49a4-8ae6-223a0c29f2aa"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("fe72254c-0552-4d78-b039-6bf09a31b5e4"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "71ae4f89-2cbc-4f4e-a78a-d7e63c52d89a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "4f3d351d-c8dd-43e0-85c0-07b8273c5e29");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "233dcf6e-702a-4e22-aa12-9acc39936b67");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "5aad462e-dcac-42a3-a7d8-d5b59ded8056");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 811, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 811, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 811, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("7f7b946d-455d-4b34-876c-e7abcffe47b5"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("9475bf82-ce98-4ebe-9856-0e11b19fdac5"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("b39dd88b-e36c-43d7-a348-845b96c8e6f9"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("ee1d31d0-2a4c-4b7d-84c2-96a9bf0c85e0"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$QnbpCkSQpDJGDGkTvtBJZ.DxVAXpSJEjD2/oAFs0R4nBf6u03dYzK", new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$5NcaWtPdR2e/D.8AUJahxO3DTTtGknQQmc0Z3UJWCbTKKoWsB9XZy", new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$2b73amhKmkQuElZjem1ABev4r5UFGlxysovrmTLaNaLe9hvqWzOTG", new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$lgLLu./RNuelvMAd2XVVZeG0MmlyblpU3JiqMMdjfaN/95gNiJp5G", new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("005b4d69-5344-4291-94de-576bdcc72bdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0098b202-186f-4d58-890e-9746cf047da4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05b377ef-aebe-4f00-b161-c731cf66b8fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0962978e-f68c-4f10-b9e4-2f2296e72463"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c5831f8-ff5c-47ec-bd31-2b493472b535"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1947bd74-1510-4683-b588-95b3da54bab2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e5a5032-ab87-4576-b21a-95d21e16c874"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20f898ce-53e7-4fee-8185-d5b282228591"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2321e197-cd51-4c58-bf73-5297a4f07075"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2792fcbf-5ddf-4ec7-871a-bee665d99960"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e7b4e01-eb9e-4123-b206-7e026dc092a9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e82356e-0207-4a8f-a26a-c427dfc0d90e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30b8dfc6-309d-4d90-8ae0-a6dd0d2a9d3d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32344919-e5fe-457c-9646-1e939404cf9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("329ecd33-6992-4bb0-9465-bd8b621d40e3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3634b9f8-a2a9-4c7b-9379-cbd480c97ed2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("38d5c80b-dc58-492c-b773-2e71aca4795b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3d401069-8db6-46fc-a460-d5ceaa2e91a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41d11d35-587a-40fe-a555-d82d168b102d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("46f6cd7f-e83b-45ec-99e1-154b3ddde079"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4839d953-04df-4b78-9026-a771dbcd664a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("48e4eea2-9ed0-4ad8-8892-3091de5f2117"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("56cc240f-f9ad-4844-8966-0ba7b6fb7d54"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6494f7d3-a1ed-41ac-86d0-142662bf9048"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6db0fa88-8ed1-41a7-ab9b-65888b1e6e1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("718d3603-3dc5-480e-b4f5-78d682b3b834"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("791192bd-839e-4e7d-9682-0113c13c0f54"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("815ac59a-b756-4da0-afbd-dd38d7c9d0a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("826c7dbd-60ee-40b5-87fa-32fd6610fcd4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8cd3d87b-4fc1-40ae-9c06-0a535d075f16"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f069dc0-47cc-464b-a61f-0ae31dd53786"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f64b21a-d7b0-4e68-a42a-488311b4df63"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91be52ef-2300-40b1-8f70-634c9485cff1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("928e1bcd-710a-4119-a768-477bb5740e02"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97abd8e5-700e-4b25-ba64-6942bdbff8cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97dc0b84-9751-4e3e-a850-175e2713cb3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f7fdbb9-3bbe-4c22-9632-d20fb7438c5e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a36ca8b0-6052-4343-a922-60e5c2edbe6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aba0ca0c-f9a5-4ad0-b45c-081fee1e5355"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac386893-a9d4-4e35-b7b6-e4252e3eee25"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("acd44ea5-a453-4402-93dd-ddd52104be77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad6863bf-1873-4b08-a8af-8442e224873d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("adc71771-1032-4655-8eb7-e7bf7ec43a9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b14fde3d-b044-403a-8044-1fb5b9e09793"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b31d455b-4e06-42ad-9a8b-86d592b1f715"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bb53521b-af3d-46f6-ae2e-dd2f224d5363"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bd04cc24-50de-4c95-9afc-e173f0a6ff74"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ceda8ced-a7c2-46c2-b738-80e718ebbeea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da40a484-5876-4991-a36c-f223c900862a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e899fa20-fe31-487b-bd65-e2d944e3bde7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ecded164-6a3a-46c7-a90f-c36a29e0a622"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edddfc96-eb9b-459b-9601-ea88a1a5dab9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edf7769c-0d58-43f4-acf2-1e60d676db93"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f502c62c-8f99-49a4-8ae6-223a0c29f2aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe72254c-0552-4d78-b039-6bf09a31b5e4"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7f7b946d-455d-4b34-876c-e7abcffe47b5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9475bf82-ce98-4ebe-9856-0e11b19fdac5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b39dd88b-e36c-43d7-a348-845b96c8e6f9"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ee1d31d0-2a4c-4b7d-84c2-96a9bf0c85e0"));

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
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319), new DateTime(2026, 1, 28, 14, 32, 37, 115, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(276), new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(276), new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(276), new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 32, 37, 116, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156), new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156), new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156), new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156), new DateTime(2026, 1, 28, 14, 32, 37, 117, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("08d112dd-402b-4ffb-9487-69af983502ee"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0ca48945-8049-4b5f-ac4a-7d2920f64f29"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("162f8dc8-2b24-47ee-95c6-2d072346f434"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("17339333-ad46-4149-9ad5-92565b103b67"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("19da3d95-0a29-45f8-ad0f-9ff946b5301b"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("19eafceb-e0a1-44dd-a42c-dd816b2a02f3"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1dacb354-0f9a-423a-875c-517976e53137"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("24b45720-e8d4-47cc-b139-4e1ffb916801"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("25fefe6e-6a17-4391-b8c7-860560ad3984"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2beb4f70-751d-47fa-ae76-c67c6762b609"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2f5c0737-53e9-492d-9fe0-fc9587d04655"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3dc5703c-5720-4a3e-98c9-c82dcfda91a9"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3f69e880-b993-4c5b-8bf6-09ccee3e1981"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("41cf048a-72b5-41ed-94ff-00f37a7536a2"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("47edac82-e103-44d4-b8e2-f9d1045bfd27"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4854f8e6-9c18-42f1-a905-b4a3b017c2a2"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4a7d108c-74a9-48b8-99e9-ffc72c620f52"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4f6f417d-8ec9-4b66-843f-5155b9e9147e"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("505004ca-18e6-448a-ac0a-7205d1c9fe5e"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("59323c0c-d936-4ae2-a8a6-ba334dc9d9f9"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("680567ee-002e-4582-8778-53a7f6cbec61"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("69ceb11b-9209-440f-96dd-1d9f0c6a17bd"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6d03b720-8f7b-46bb-848c-57f32b730974"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6fade1e3-a9ff-4544-9732-78405565ad89"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("702a1a98-9f03-4acb-aa87-2c3d5e305029"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7228af52-0b73-4fc2-8775-1403f1189b8c"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("73f1acd8-f0b5-4c97-ae9b-dfb4145e1867"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7b271947-2e0c-4b51-afe8-8031a745937f"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7d3a9f76-2878-4fc5-ae9e-04b77d26ec44"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7fb010db-077b-4ef8-9729-7fe160e9ee42"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7fb2d722-102e-4cbf-85fa-de0685e415c3"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("84651830-d245-4996-b0f2-22e2e4ee580f"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("863a6922-7611-42c6-a614-dacb58b426a2"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8bf49476-b3a5-49e5-bfa8-cc4a002c1034"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("8c24ab17-a879-402a-8ba4-8282bb2131fb"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("906af114-a899-474f-a6d0-c0bf245c404f"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9375f4e6-4772-4d6d-bb04-3501bce5c42a"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9976127a-15a7-4b07-bb7c-db6f27e45225"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9b517120-f7a7-4d00-b9bf-b9c29effe6fd"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a24b5fda-359f-4bd1-b1b9-c6fe944187c8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a38dd84c-a5ad-4b9b-a08e-b123030dc242"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a675ca60-7450-424e-a08d-763f910a087f"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a685e746-6b49-4e4b-9a44-215b9846ad3e"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a98a7fbe-05e8-4263-a0e2-8423ceacebb7"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b8dca931-8f82-417e-92b3-7dd420f88cdd"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ba12d15e-af6a-40ce-9550-07e41d027ac8"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ca70fde2-7ffa-4b60-92e8-b1875f4167cd"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d3712556-e25a-4d37-896a-01436d89d764"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d55b4367-46fe-4207-a25e-9549a481edd3"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e4971c83-d993-4356-859b-da3ddd7d5415"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e49fef12-4cf5-48ac-8820-cef42f627150"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ebd8401c-b5cf-401f-9500-e61fd79f7a1c"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f29d84f5-1314-479c-883b-1f2befe1b085"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f8f4b33f-c629-43e7-8924-9865886afc8d"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("fbcad456-f162-4445-b85d-337f35819093"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "7c1aa043-3376-4110-9822-d4e40f257883");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "c12014c0-b3da-4f71-b0cb-26fa5090f233");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "9d2815cf-fadd-45c2-b889-246bbcf0796f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "78a21935-0ff2-40f3-abd3-cf95c0fa24de");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 32, 37, 127, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 32, 37, 127, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 32, 37, 127, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("1bd71d95-42b7-40d4-b29e-226388f93e12"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("49ca59b1-0c51-43fd-a8bc-0389a280efd3"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("588df79c-cf44-4e54-8db7-575e3ea9db29"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("d01f76d6-50d1-46a8-bae0-94c2ff26df5d"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697), "$2a$11$4qBbQ2Uda9ZAhJ2McaXi2ePgiPKPK6luDtdVcrZ1wAbbwBn0tsCHe", new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697), "$2a$11$JWFrnz5/G1bDedajYUd9s.9mHqnXW.ccBGNr9izSsdx9nATVVOwhe", new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697), "$2a$11$wqB99EwgwD3DONJ0X.iJpeVb4olQVbxOUFoiuryd9OjSziLzuoTjO", new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697), "$2a$11$sUTGH2u3LaW7ZGPRe0H2SuYLD4gihJgwma.gMbCiSy1kujsV6t/eC", new DateTime(2026, 1, 28, 14, 32, 37, 136, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598), new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598), new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598), new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598), new DateTime(2026, 1, 28, 14, 32, 37, 717, DateTimeKind.Utc).AddTicks(598) });
        }
    }
}
