using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_Accessibility_Column_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(9087), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(9087), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(9087), new DateTime(2026, 3, 17, 8, 14, 46, 401, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292), new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292), new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292), new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292), new DateTime(2026, 3, 17, 8, 14, 46, 402, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0048155f-caa1-4ac6-96d1-6ae46dff0751"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("063d8eff-1f84-4845-a81e-94620a367530"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0c48ff3d-1cfe-44a7-b5d6-8f5da061b094"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("11102e8c-99c1-4778-9292-75813f89c329"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("198d387a-928c-45f4-a43f-e26693bbe696"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("229aa4ea-0bbf-4e5f-bfb3-9cee64a04575"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("23779b04-ca6f-429b-a992-aecfc80fc66a"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("26298e7e-0ad3-4e4b-a36b-20502b697b01"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ce2f775-6b1b-4db5-a1a5-5b0ea887e3c4"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("30294ce2-89fb-4b47-8931-d903fa2ae08c"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("329d56f3-c3b2-4511-835a-730e301db818"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("331f7201-8cec-42ff-8c8d-008b68462bd6"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("340ef116-9547-4811-9d6e-26ddaa172904"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3d1f82eb-8a8c-4d6d-aa3c-06a7aae30270"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3db37b6c-cc08-4e24-844a-ae90e4778b6f"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("47d8c7b8-f340-4d03-9e4a-9e739d049219"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("49cdc91f-1ff8-451e-8f33-b1ae446864ca"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("4c85776a-d2e5-4874-affe-26583ea86922"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4e5a2b76-53dd-4623-937c-49a46b0695d3"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("57519135-f1b4-4395-8964-5199c33fd63e"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5d2ee229-bf3c-4ee1-83ad-10f6a56b62a5"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("67a9b5a3-6f86-4391-883c-c3e8d796b8f0"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6ab3b694-2e36-413c-a310-1e5d7a600999"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6f71f0f6-25c6-4994-b52e-35374630e654"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("71384086-d6b9-451b-8753-b895b1dc592b"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("72c53803-c597-4ffe-b6f7-7fe0b68fdfb9"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("77a4af64-dd29-4c1b-afcd-8c8e2c21dad5"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7e5be480-f98f-4441-9d10-adadd49da4c7"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("862a167e-1b47-4ab3-bafb-2c6de6e5171f"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8dcc81aa-91d6-455c-af55-fa7063d77f37"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9436b8e4-89ac-468a-8975-c04db1897036"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("98012ae1-aefa-413e-b5ec-16d2890295ea"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9964dedf-cbda-4382-b935-0be1855abf3e"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a4a3703-cc6f-43aa-9a8b-fb9dd5dd63cc"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a6195eb6-55d4-4a2c-bace-845d4c22ce8a"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("a772bfcf-201f-4336-9d90-3d65e5236510"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b493cbb9-2ba2-4162-a4c6-906bdd6eac86"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b7193bec-efe4-4921-a4f4-caf3994b3697"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b8292ad7-be4c-4b52-bbdf-0efa8a7639a6"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b97f781d-3937-4740-ae2f-bef6062171da"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c062e90c-9ad0-477a-8891-95350be2da0c"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c0cfee89-afc6-4e67-8051-0d317194cc59"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c361ba29-16c5-485b-921a-0a396255967d"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c808882d-ce5e-4990-af85-e7d0d2e84dd6"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("cd293bcf-9ced-4a4a-8424-81e8adbd8d79"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d2f792da-70ed-4787-a36f-c5d1b8040b63"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d8b4d376-c531-4041-a6e3-19b2148eded1"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da47c276-2313-4ec8-92ff-5ab467273250"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("da92bbef-2b86-4713-b069-cc64eb15fd29"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e1ace357-e322-4f41-8592-44849ef10212"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7206f7c-4c38-499e-88ca-8549698579fc"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e80cb897-82cf-4d1b-a8d9-4c76240157d7"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("eacf2f46-65dd-473c-b50f-53c499f35b95"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f6dfde7c-158f-416b-83c3-c94e5278a1c2"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fd0640f8-5760-4510-bf30-c093b1de799f"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "d7c3ea6e-27d9-4d0c-886d-dc70b38f1e50");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "7771a81c-9465-4ef9-9efd-85932aec5f5f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "baa15df8-72c0-4295-9cd7-9c995cd5fda9");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "5ad8b604-a263-4cd5-866c-c36dd8e815fc");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 14, 46, 407, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 14, 46, 407, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 3, 17, 8, 14, 46, 407, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("3357ae84-3693-4a56-ac34-c70bed888ce7"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("40be6adc-bc6c-4991-bca4-49454f5899c7"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("7bf65bc4-14bc-4f59-9451-319c2ba7ab2e"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("e555fe85-214d-421e-86c4-ec4bad5f01e9"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322), "$2a$11$dfluiYTAgVC6tisxaaiSROIn79A0suxNgz.dNmkVQq8BwO4IdhZiS", new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322), "$2a$11$f4XJS0RI9KZr/sGr7DwRYOoGZDhk7p0cWt7LVFXRdc8wHp4/FlzjC", new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322), "$2a$11$v7Ps9WpZVEMbTFFVe2y9q.R32fQnj5x94nSeKbC8/LP8tITUUWm/K", new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322), "$2a$11$/1Iw9BjiosyigpKdBV9UnefopBcqOV5u.jXrY8OaAxbIQzH18N.Jm", new DateTime(2026, 3, 17, 8, 14, 46, 409, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066), new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066), new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066), new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066), new DateTime(2026, 3, 17, 8, 14, 46, 915, DateTimeKind.Utc).AddTicks(6066) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0048155f-caa1-4ac6-96d1-6ae46dff0751"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("063d8eff-1f84-4845-a81e-94620a367530"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c48ff3d-1cfe-44a7-b5d6-8f5da061b094"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("11102e8c-99c1-4778-9292-75813f89c329"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("198d387a-928c-45f4-a43f-e26693bbe696"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("229aa4ea-0bbf-4e5f-bfb3-9cee64a04575"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23779b04-ca6f-429b-a992-aecfc80fc66a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("26298e7e-0ad3-4e4b-a36b-20502b697b01"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ce2f775-6b1b-4db5-a1a5-5b0ea887e3c4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30294ce2-89fb-4b47-8931-d903fa2ae08c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("329d56f3-c3b2-4511-835a-730e301db818"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("331f7201-8cec-42ff-8c8d-008b68462bd6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("340ef116-9547-4811-9d6e-26ddaa172904"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3d1f82eb-8a8c-4d6d-aa3c-06a7aae30270"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3db37b6c-cc08-4e24-844a-ae90e4778b6f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47d8c7b8-f340-4d03-9e4a-9e739d049219"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("49cdc91f-1ff8-451e-8f33-b1ae446864ca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4c85776a-d2e5-4874-affe-26583ea86922"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4e5a2b76-53dd-4623-937c-49a46b0695d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57519135-f1b4-4395-8964-5199c33fd63e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d2ee229-bf3c-4ee1-83ad-10f6a56b62a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("67a9b5a3-6f86-4391-883c-c3e8d796b8f0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6ab3b694-2e36-413c-a310-1e5d7a600999"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6f71f0f6-25c6-4994-b52e-35374630e654"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("71384086-d6b9-451b-8753-b895b1dc592b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("72c53803-c597-4ffe-b6f7-7fe0b68fdfb9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("77a4af64-dd29-4c1b-afcd-8c8e2c21dad5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7e5be480-f98f-4441-9d10-adadd49da4c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("862a167e-1b47-4ab3-bafb-2c6de6e5171f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8dcc81aa-91d6-455c-af55-fa7063d77f37"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9436b8e4-89ac-468a-8975-c04db1897036"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("98012ae1-aefa-413e-b5ec-16d2890295ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9964dedf-cbda-4382-b935-0be1855abf3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a4a3703-cc6f-43aa-9a8b-fb9dd5dd63cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6195eb6-55d4-4a2c-bace-845d4c22ce8a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a772bfcf-201f-4336-9d90-3d65e5236510"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b493cbb9-2ba2-4162-a4c6-906bdd6eac86"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b7193bec-efe4-4921-a4f4-caf3994b3697"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b8292ad7-be4c-4b52-bbdf-0efa8a7639a6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b97f781d-3937-4740-ae2f-bef6062171da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c062e90c-9ad0-477a-8891-95350be2da0c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c0cfee89-afc6-4e67-8051-0d317194cc59"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c361ba29-16c5-485b-921a-0a396255967d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c808882d-ce5e-4990-af85-e7d0d2e84dd6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cd293bcf-9ced-4a4a-8424-81e8adbd8d79"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d2f792da-70ed-4787-a36f-c5d1b8040b63"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d8b4d376-c531-4041-a6e3-19b2148eded1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da47c276-2313-4ec8-92ff-5ab467273250"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da92bbef-2b86-4713-b069-cc64eb15fd29"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e1ace357-e322-4f41-8592-44849ef10212"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7206f7c-4c38-499e-88ca-8549698579fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e80cb897-82cf-4d1b-a8d9-4c76240157d7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eacf2f46-65dd-473c-b50f-53c499f35b95"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f6dfde7c-158f-416b-83c3-c94e5278a1c2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd0640f8-5760-4510-bf30-c093b1de799f"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3357ae84-3693-4a56-ac34-c70bed888ce7"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("40be6adc-bc6c-4991-bca4-49454f5899c7"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7bf65bc4-14bc-4f59-9451-319c2ba7ab2e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e555fe85-214d-421e-86c4-ec4bad5f01e9"));

            migrationBuilder.DropColumn(
                name: "accessibility",
                table: "roles");

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
    }
}
