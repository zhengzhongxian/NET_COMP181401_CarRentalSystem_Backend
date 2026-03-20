using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Add_Accessibility_Column_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "accessibility",
                table: "roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000), new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000), new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000), new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000), new DateTime(2026, 3, 17, 8, 10, 22, 753, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(643), new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(643), new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(643), new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 10, 22, 754, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45), new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45), new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45), new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45), new DateTime(2026, 3, 17, 8, 10, 22, 755, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("01b5b002-1ab5-47bd-9f93-27845b937f6d"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("028b1e8a-f328-487e-b05c-4988894e5efa"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("02bc16cc-a60a-4caf-8644-51cfdba85e37"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0a3326af-e82f-482b-9669-6565402e5279"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("11d8c77e-e744-4892-8a73-516bdee06a93"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1298fd9d-0c1c-4dcb-9b2d-5ed95984b483"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1447cf7d-2e5f-465b-8a51-8041e8c28999"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1831128b-784b-41bf-802c-3d62e18b55ce"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("197a26a3-9c9f-4267-87ba-9fa78967a3cd"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1bbb0c61-c5ab-4c3c-8516-019567c85b0a"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("267073ea-eb8c-4604-bd25-b30a958da009"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("26e75204-02b8-4fd4-a33e-10d5011db03a"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2cfac86f-d5e5-41a7-b7a6-a0c868168261"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2df4828f-659b-4d7d-85b4-0b44122cd5a1"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("306e1215-54f5-48cb-90ee-5a5cce386c91"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("33fbfda4-03fe-42b2-bd8a-bb2fbffe3659"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("36c1283a-c42b-4e64-afed-ec1202c52c2b"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("37002ba4-045c-4172-addd-3a33f7939f3a"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3805ad28-3eda-4d5f-afd9-e10fadb4c37b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("3b25adfa-b708-445d-9c1e-461d38a61c4d"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3b4d562b-c8e0-4ba5-9952-973a4647a201"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("417acdf8-e529-4382-9bae-782f0eaa5348"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("494c79e7-5dc6-466c-a71f-c24bd8392972"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5d0f8920-aede-4fa2-b997-aed612eff3e6"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("607c463c-534d-4408-8dbf-4789b9f90835"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("60b680a4-7c58-4ba0-bf3d-51844d930864"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("65fc4430-621e-4f6f-992b-9a3af610d9c3"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("69b9a4ce-fe94-47fb-aa18-8673a55ca7f4"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6b9c639f-d243-4a46-b497-44197cf4fee8"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("72e3ad57-2168-411b-a999-3a39ab353353"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7920b5c0-23eb-4680-9948-7036459c6c58"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7adb720e-0de7-4199-8050-30ae0f2ee997"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7d6a54cf-8976-4c59-99cc-196637df03ea"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7feb02d3-47fe-4b7f-8c47-29e9ea52d1f6"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("801f5ad0-ee04-4c4c-9eee-6f82d1bf8c9f"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("863ad739-ae6a-49b7-ab44-c540ad7a0c97"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("88b05d82-dce5-4959-acc2-a06156d8a977"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8ee59ba6-7ade-4898-8217-4e8115d8ec51"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("91ab274b-6f78-4792-aa05-b63567e6279b"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("96ffe7dc-6b7e-46cd-9934-0a3301e1517c"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9e53f892-20a4-4aa4-ae09-10d76c16af10"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a67edb3e-6e1a-47d5-ba14-69f03bd5c03c"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af998cf7-281f-467c-a64f-7e0e83315f7f"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("be20d9c7-4e46-46e6-88de-4a675330bf08"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("be550c83-3943-4749-86f4-f4aa220c5211"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c3b71b56-9bc5-4351-92c9-38ae845590c9"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c85eec24-b43a-4f5b-ad8c-0a6dbdf86841"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7b8a6d4-31ef-40ab-b59d-cfa16eb8fa78"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("e900440e-1c54-498a-ba7b-66612f55a88a"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1f05428-f744-42e4-b9aa-823b243ae876"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f3a8130f-236b-4940-88c8-43d591d19a8e"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f5edd8c0-c821-45f9-bc99-405657442c48"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f8248d8c-198d-4e3d-9064-0cb752290256"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fc6b7d23-cd4a-4df4-9fc1-c40b3cee54ac"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe2eb23a-4771-4e6f-95e1-ec52e361fd2f"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "c9a77e98-bcb2-4a8b-a7ad-5aa5b60038a2");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "241ef8d6-ca84-4676-b052-929e0db28839");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "6290a949-0a94-405f-8c84-c02a0ead215f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "dcbf52e3-9dc4-4494-8c24-22afcab0519d");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 10, 22, 760, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 10, 22, 760, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 10, 22, 760, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("67c3fd7a-6c27-4494-8869-ad3b22f192a8"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("e49679ea-b595-403b-bca2-6762dc1ec490"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("f7b8e14c-f44f-47ef-97d2-3ae9be606c92"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("fad0bada-dbbb-4223-a01b-e18a917883b0"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929), "$2a$11$qyk.zNNV/aqEK9jyXUQNu.Jxscr8JlxxgpqjQDZKUlnChKolAzPLG", new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929), "$2a$11$nEAh1ydGK4Xj4ceTjicB8O639dkEdrz0Unouxn6GMSPT0vwkfInum", new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929), "$2a$11$vzTQEav8Xe2olkK4eTcDdeWTMOZyKYSpOHr8Oy3vfZ4LXK04D1H1W", new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929), "$2a$11$gHiS96db/OGQ4eZbbH1A7eyNo4CGdrnoT0gLTjAxUMj7SYxPutq6q", new DateTime(2026, 3, 17, 8, 10, 22, 763, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160), new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160), new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160), new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160), new DateTime(2026, 3, 17, 8, 10, 23, 285, DateTimeKind.Utc).AddTicks(8160) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("01b5b002-1ab5-47bd-9f93-27845b937f6d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("028b1e8a-f328-487e-b05c-4988894e5efa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("02bc16cc-a60a-4caf-8644-51cfdba85e37"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0a3326af-e82f-482b-9669-6565402e5279"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("11d8c77e-e744-4892-8a73-516bdee06a93"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1298fd9d-0c1c-4dcb-9b2d-5ed95984b483"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1447cf7d-2e5f-465b-8a51-8041e8c28999"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1831128b-784b-41bf-802c-3d62e18b55ce"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("197a26a3-9c9f-4267-87ba-9fa78967a3cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1bbb0c61-c5ab-4c3c-8516-019567c85b0a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("267073ea-eb8c-4604-bd25-b30a958da009"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("26e75204-02b8-4fd4-a33e-10d5011db03a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2cfac86f-d5e5-41a7-b7a6-a0c868168261"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2df4828f-659b-4d7d-85b4-0b44122cd5a1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("306e1215-54f5-48cb-90ee-5a5cce386c91"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("33fbfda4-03fe-42b2-bd8a-bb2fbffe3659"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("36c1283a-c42b-4e64-afed-ec1202c52c2b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("37002ba4-045c-4172-addd-3a33f7939f3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3805ad28-3eda-4d5f-afd9-e10fadb4c37b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b25adfa-b708-445d-9c1e-461d38a61c4d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b4d562b-c8e0-4ba5-9952-973a4647a201"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("417acdf8-e529-4382-9bae-782f0eaa5348"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("494c79e7-5dc6-466c-a71f-c24bd8392972"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d0f8920-aede-4fa2-b997-aed612eff3e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("607c463c-534d-4408-8dbf-4789b9f90835"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("60b680a4-7c58-4ba0-bf3d-51844d930864"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("65fc4430-621e-4f6f-992b-9a3af610d9c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("69b9a4ce-fe94-47fb-aa18-8673a55ca7f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6b9c639f-d243-4a46-b497-44197cf4fee8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("72e3ad57-2168-411b-a999-3a39ab353353"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7920b5c0-23eb-4680-9948-7036459c6c58"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7adb720e-0de7-4199-8050-30ae0f2ee997"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d6a54cf-8976-4c59-99cc-196637df03ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7feb02d3-47fe-4b7f-8c47-29e9ea52d1f6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("801f5ad0-ee04-4c4c-9eee-6f82d1bf8c9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("863ad739-ae6a-49b7-ab44-c540ad7a0c97"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88b05d82-dce5-4959-acc2-a06156d8a977"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8ee59ba6-7ade-4898-8217-4e8115d8ec51"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91ab274b-6f78-4792-aa05-b63567e6279b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("96ffe7dc-6b7e-46cd-9934-0a3301e1517c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e53f892-20a4-4aa4-ae09-10d76c16af10"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a67edb3e-6e1a-47d5-ba14-69f03bd5c03c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af998cf7-281f-467c-a64f-7e0e83315f7f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be20d9c7-4e46-46e6-88de-4a675330bf08"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be550c83-3943-4749-86f4-f4aa220c5211"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c3b71b56-9bc5-4351-92c9-38ae845590c9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c85eec24-b43a-4f5b-ad8c-0a6dbdf86841"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7b8a6d4-31ef-40ab-b59d-cfa16eb8fa78"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e900440e-1c54-498a-ba7b-66612f55a88a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1f05428-f744-42e4-b9aa-823b243ae876"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f3a8130f-236b-4940-88c8-43d591d19a8e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f5edd8c0-c821-45f9-bc99-405657442c48"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8248d8c-198d-4e3d-9064-0cb752290256"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc6b7d23-cd4a-4df4-9fc1-c40b3cee54ac"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe2eb23a-4771-4e6f-95e1-ec52e361fd2f"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("67c3fd7a-6c27-4494-8869-ad3b22f192a8"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e49679ea-b595-403b-bca2-6762dc1ec490"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f7b8e14c-f44f-47ef-97d2-3ae9be606c92"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fad0bada-dbbb-4223-a01b-e18a917883b0"));

            migrationBuilder.DropColumn(
                name: "accessibility",
                table: "roles");

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
    }
}
