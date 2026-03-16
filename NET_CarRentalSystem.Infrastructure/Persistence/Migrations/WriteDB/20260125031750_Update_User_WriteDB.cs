using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Update_User_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("08e15697-1ba7-4b6f-a711-781f23dcdbf1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0dc2ae3e-98fb-4fc3-b64e-a4856c64dcfb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("10a8cc75-bdc5-45e8-883d-d73853e3d4a3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("111c2e2f-a189-4c90-8230-4238577464ac"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("12e7f1c6-b850-4726-8950-ace53f718a50"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("138e152b-2390-4529-9d6a-a3e492c7f0b9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16dacc4d-0685-4252-93cb-93d9801165b9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1a842ef8-fd59-4e17-9a0f-1bc96b4a7819"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d44a5a5-6c8c-443e-9755-87ea9a2d066d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2be4799b-c188-4740-9ce8-78bc620adbc2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2c7b7762-c2cb-4016-8344-fc23f5bbfddf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3116c41f-e00c-42dd-9259-c3b1420cf371"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("382dae1f-2c4a-4bb7-84ab-0d1692e4af87"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("39579272-c1a7-4d48-aac2-22c2cbba947f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3e0757e8-a514-43e0-baa4-73c8ec55a7c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("415d10af-9301-41a6-b5fd-bdfe26c0b756"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41d2e47f-7147-411e-8651-7ca61b2b067b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43967c8a-7b2a-495c-af97-bcc53caea96b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("568c3a6c-01d5-4497-a741-9b89cbfd40cf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5cecaa68-9fb2-4c69-b860-51839b0d4e23"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("61e4d49f-f7a6-4327-aff8-349cdbfa3b52"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("633a6dff-14cc-4b5d-83e3-2c717109f5b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6467472e-134a-4bee-9636-6031f997faf6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6de11b94-a524-418a-9e31-e0f535c7bd13"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7c82250c-4ff0-4c05-92ad-07fccad25723"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("845d1605-afa7-43c4-9ec2-37c97623ea7e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84f85107-01b7-4720-a5fb-ea11ca3ec53a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("85740ce2-a825-438f-9fff-3586539ae0dd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("87edbe39-e425-46b6-8537-6b91579df25e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8810c42f-fcc7-444e-b1f3-e717810a33ae"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8d372170-c514-4af9-abf9-a1f89fe6597a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f91d26b-fa2a-4e25-bd16-8c047f91499f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8fa3a2f0-5f40-4247-a1b6-b49620c3f682"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92bc965d-43d0-46fe-be9e-d9d9889f3ff0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("950333a4-8c58-4f34-a6e1-7f85e7add914"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9c14dbd0-1a3e-49de-97c4-36a09a51d5f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9fa54497-60f6-4910-8b26-067816432b0a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a2351518-ad91-4187-942f-1e8b47d6f535"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3cb88a9-4bb5-40a2-b031-d6402f7fcd11"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3dbe4fd-d316-4a0e-be80-430ca2ab49e1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a64636c1-c197-4d0e-906b-51b887745e04"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6a34ffe-0e1a-4eac-9ab0-16c89ac6065e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ab44c290-b18b-4159-9a3f-eaa56383a9c1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae0592dc-a070-47b0-9ba9-00762fbcc960"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b51ddded-8d09-481b-a5d1-4b763940f8e5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b863d2d6-b3b9-443e-b10f-4cd5009d889d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ba7e0564-ed66-4e65-b521-f154650405fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c57de18e-bac0-49d0-af86-8053b865d09b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6ec73c7-48a6-4169-aa09-66c8a2ca4fea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dac5bc49-0a9a-4fb8-a552-f8869a95a0cf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dd148ab5-c625-45d7-a59c-9c782e0ad6fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e2b32267-d584-4a1a-a353-2749bcfd9f11"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9de1170-7e02-4113-a089-4a3e68e06b0b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ebe1ff87-0c79-46a6-a70c-8486e62044ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eeaccf70-1f68-47eb-b5bf-289dc76e04d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f034eb9f-f52f-4ba8-a47c-89f48da12732"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("23774934-2535-47b0-ad38-20d921a71d3f"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("27392991-aa41-45df-a4fe-b9359f821a31"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b34485c5-13d2-4103-8e7b-4f0f5c7dc162"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("fb8ab743-dce6-49f1-a28d-99ee3c207747"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673), new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673), new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673), new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673), new DateTime(2026, 1, 24, 13, 57, 12, 380, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 381, DateTimeKind.Utc).AddTicks(1829), new DateTime(2026, 1, 24, 13, 57, 12, 381, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 381, DateTimeKind.Utc).AddTicks(1829), new DateTime(2026, 1, 24, 13, 57, 12, 381, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 381, DateTimeKind.Utc).AddTicks(1829), new DateTime(2026, 1, 24, 13, 57, 12, 381, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720), new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720), new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720), new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720), new DateTime(2026, 1, 24, 13, 57, 12, 382, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("08e15697-1ba7-4b6f-a711-781f23dcdbf1"), "Permission", "Permissions.Violations.Resolve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0dc2ae3e-98fb-4fc3-b64e-a4856c64dcfb"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("10a8cc75-bdc5-45e8-883d-d73853e3d4a3"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("111c2e2f-a189-4c90-8230-4238577464ac"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("12e7f1c6-b850-4726-8950-ace53f718a50"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("138e152b-2390-4529-9d6a-a3e492c7f0b9"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16dacc4d-0685-4252-93cb-93d9801165b9"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1a842ef8-fd59-4e17-9a0f-1bc96b4a7819"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1d44a5a5-6c8c-443e-9755-87ea9a2d066d"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2be4799b-c188-4740-9ce8-78bc620adbc2"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2c7b7762-c2cb-4016-8344-fc23f5bbfddf"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3116c41f-e00c-42dd-9259-c3b1420cf371"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("382dae1f-2c4a-4bb7-84ab-0d1692e4af87"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("39579272-c1a7-4d48-aac2-22c2cbba947f"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3e0757e8-a514-43e0-baa4-73c8ec55a7c7"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("415d10af-9301-41a6-b5fd-bdfe26c0b756"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("41d2e47f-7147-411e-8651-7ca61b2b067b"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("43967c8a-7b2a-495c-af97-bcc53caea96b"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("568c3a6c-01d5-4497-a741-9b89cbfd40cf"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("5cecaa68-9fb2-4c69-b860-51839b0d4e23"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("61e4d49f-f7a6-4327-aff8-349cdbfa3b52"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("633a6dff-14cc-4b5d-83e3-2c717109f5b0"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6467472e-134a-4bee-9636-6031f997faf6"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6de11b94-a524-418a-9e31-e0f535c7bd13"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7c82250c-4ff0-4c05-92ad-07fccad25723"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("845d1605-afa7-43c4-9ec2-37c97623ea7e"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("84f85107-01b7-4720-a5fb-ea11ca3ec53a"), "Permission", "Permissions.Violations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("85740ce2-a825-438f-9fff-3586539ae0dd"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("87edbe39-e425-46b6-8537-6b91579df25e"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("8810c42f-fcc7-444e-b1f3-e717810a33ae"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8d372170-c514-4af9-abf9-a1f89fe6597a"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8f91d26b-fa2a-4e25-bd16-8c047f91499f"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8fa3a2f0-5f40-4247-a1b6-b49620c3f682"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("92bc965d-43d0-46fe-be9e-d9d9889f3ff0"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("950333a4-8c58-4f34-a6e1-7f85e7add914"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9c14dbd0-1a3e-49de-97c4-36a09a51d5f9"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9fa54497-60f6-4910-8b26-067816432b0a"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a2351518-ad91-4187-942f-1e8b47d6f535"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a3cb88a9-4bb5-40a2-b031-d6402f7fcd11"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a3dbe4fd-d316-4a0e-be80-430ca2ab49e1"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a64636c1-c197-4d0e-906b-51b887745e04"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a6a34ffe-0e1a-4eac-9ab0-16c89ac6065e"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ab44c290-b18b-4159-9a3f-eaa56383a9c1"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ae0592dc-a070-47b0-9ba9-00762fbcc960"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b51ddded-8d09-481b-a5d1-4b763940f8e5"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b863d2d6-b3b9-443e-b10f-4cd5009d889d"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ba7e0564-ed66-4e65-b521-f154650405fa"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c57de18e-bac0-49d0-af86-8053b865d09b"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6ec73c7-48a6-4169-aa09-66c8a2ca4fea"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dac5bc49-0a9a-4fb8-a552-f8869a95a0cf"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dd148ab5-c625-45d7-a59c-9c782e0ad6fc"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e2b32267-d584-4a1a-a353-2749bcfd9f11"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e9de1170-7e02-4113-a089-4a3e68e06b0b"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ebe1ff87-0c79-46a6-a70c-8486e62044ec"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eeaccf70-1f68-47eb-b5bf-289dc76e04d0"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f034eb9f-f52f-4ba8-a47c-89f48da12732"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "8a2e1dfd-6dc8-42ea-88a6-56ed5141054f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "d07147c5-7dc6-451c-b360-f424c53b7ad8");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "74fbffa9-bc23-44a2-882f-ba48ade4689a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "e2ea28ff-ac7a-4b27-b4ff-6995b24563b7");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 57, 12, 391, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 57, 12, 391, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 57, 12, 391, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("23774934-2535-47b0-ad38-20d921a71d3f"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("27392991-aa41-45df-a4fe-b9359f821a31"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("b34485c5-13d2-4103-8e7b-4f0f5c7dc162"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("fb8ab743-dce6-49f1-a28d-99ee3c207747"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986), "$2a$11$iqy79C3iHTFZQwaE0w0SGuair3ixx3SUeRGd45mj8o5HKvcZofM4O", new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986), "$2a$11$WcxhfshJTePeNvhpaYn1fONWAt4A5yi7NcFmq1emP3s25t6RGoEyi", new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986), "$2a$11$PTlevaqhuXFMAvo8E2fyzuSlqcgwh0id3FbfH6wcEoeXe/Aba2Fvi", new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986), "$2a$11$nbIpU0U7ZKNh.yPKx8w6FuPPRdDAo1XicaFbqn25nycFp89Q3esWy", new DateTime(2026, 1, 24, 13, 57, 12, 395, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537), new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537), new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537), new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537), new DateTime(2026, 1, 24, 13, 57, 12, 938, DateTimeKind.Utc).AddTicks(537) });
        }
    }
}
