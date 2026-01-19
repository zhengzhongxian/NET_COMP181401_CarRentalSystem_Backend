using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Fix_LengthOfPhone_BookingFlat_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("07196715-4908-4234-91ab-ad3e0cb087e9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0a66af99-2a03-44a3-86eb-ad50338d7d50"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c2051bb-fdd0-48da-a5a1-ff5d5c7eb37d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22956edb-aa22-47f1-ae86-81b651f0a986"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e2e1c81-4ce0-4894-a1c8-65e813ca9ab7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("34248995-4ba7-4b8d-9e3a-1020c7909850"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3ab3002c-dd9a-4a2a-8d11-990e4cee7c78"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b6182ab-0357-46a1-b577-4e9a06ef77ae"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47692072-3da8-47cc-9e60-c889af919481"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4a446411-e9d5-49ca-9181-ce062c425b07"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4f44e6f2-6759-4580-97c5-dad7bdbb907b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("60612c1d-55ce-4a8d-ac01-abc966259666"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("615c4988-b903-49d0-9231-c8f4537fd1cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("62983f0b-dc12-4d72-95aa-d015a41a8f0a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("62b2d017-2ba9-44bf-9a60-645225bb2696"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6417460a-5c5d-4080-ae85-d0b3ebd3d988"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("75f7b928-35d0-404e-9619-3a4ae7e155ab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("78fc2e3b-e00c-4d84-a1f3-d2fd40824aa6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7c18868b-b34a-4568-b4dd-7f4d20112a30"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d3c45c2-fa69-44be-ad9d-7ba8542254ef"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8195256b-e65b-4e47-8db5-f627fdc12775"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8d24203e-2fa8-4785-8966-41aeb705b577"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9823b3c2-ef73-46b8-a9a1-e2fe1c5864fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e7fd82b-6a98-4dd1-b008-e7ebd9935f0c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a78b6014-c18c-41a8-b5d5-35f137ddb02a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bf366b25-88c0-4dff-a050-b5d9f1c664ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c5166c32-bf89-470c-acbf-cb8b3af11ba4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c97efc00-2dcd-4a61-89ea-88bc8a0c8423"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca7e8325-f4e2-4e06-9e87-d9bec141a045"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d124f3c2-d1a8-4b93-8801-fa83fa23e765"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d4f29932-ad20-46eb-b0bd-d144d0b0ab7c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d8859afe-66e1-45d9-be50-8a49496d0c27"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dfd69726-bb17-4505-814a-4c680493f0f0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e01ddfd3-2804-43b8-a967-85ef67257d76"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eaa04489-c500-4b7d-ae0d-74629ce4191e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed23d206-7401-4668-8272-f85f724efa20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f24d3512-33c8-436b-862e-d4ed67d01a8a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f54ee3b4-1d84-41ae-afed-4b5ee3599e6d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe5dfcff-b1db-4657-ba2c-266c5e45cecd"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("2e749843-4a71-43ac-bcb1-4d9731b55778"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("a545d119-0029-4ce1-80c2-f0ec2b1a0a95"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("be1d96cd-bc0b-44f2-9cfa-0ca56fec37db"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e7f3e88d-c2ee-4142-ab5f-5a150e479f06"));

            migrationBuilder.AlterColumn<string>(
                name: "customer_phone",
                table: "booking_read_flat",
                type: "nvarchar(500)",
                maxLength: 500,
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
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(5424), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(5424), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(5424), new DateTime(2026, 1, 4, 18, 22, 8, 231, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253), new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253), new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253), new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253), new DateTime(2026, 1, 4, 18, 22, 8, 232, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0ad85ded-597d-4ecb-ab6a-5cd9bd09c80a"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0f718d9b-16a3-426c-9f5c-a4b9b3873dd4"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1147024f-fa8a-4313-9945-ad51a753edeb"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1a766b92-3d7e-4807-99e9-b1f5d314e68d"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("22497451-32f7-4dc4-8256-f66520625bff"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("22bcd17c-4cfe-412f-b1ed-8d86d39e5264"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("27bec08f-be98-4cf4-83b9-966eac99f744"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("27df40ad-b21f-48f0-9d55-902b67d6340f"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e6e2a69-2fd6-47bb-9590-0b1fb2a73c1e"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2eb75ebc-90c5-4f7a-837e-308ee39ee19b"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2effeed0-d69a-47ba-ae05-a497d88839f3"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2f035ef8-d90d-4cb4-b407-3172d80d9f84"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("32746d32-b79c-4bb8-9ed8-ffba001f51ee"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("33e73f7d-d202-47ca-aff6-f440b41560f9"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3611f04f-5031-4c2d-a43f-08761baad780"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("43856fd2-3e3b-47f2-b90e-01a36e2da881"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("527b84ff-a9a4-4e7c-be79-39f102e22dbe"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5d0f7984-6b26-438d-bcf4-aca647799d18"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("64a11805-db2f-423b-a945-517875dc8609"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("654f3076-af77-47f2-b8a1-5e6763f3fa70"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6b645e9d-cab6-42ec-844f-4a52355acdaa"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6d037da8-5053-4ce0-976a-ade3b22e98be"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("7f2160ee-e3c9-43ac-9030-73e5cfc77af7"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8fcee0c4-b33d-457b-b148-11bd8f24a39d"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("a6ff3ab9-a4e7-4c1c-9980-f6cc33b14333"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af7848d2-68a0-459d-80a0-6c2ac9b54075"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b176d1b6-0b20-4000-8304-ab72da12a7c0"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("baaea6db-6adf-4907-ab77-c081ab99203c"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c0d93ec3-d284-41ac-89b2-f6a3e7d53f01"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c5c797d6-2e71-4971-91dd-2a72f2a628d7"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d2219600-0524-4d5a-a6f6-739e2924cee7"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d2ba1057-6fed-4a47-9518-0b07ee8b317f"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6f89220-4bcb-42c9-b315-2f46c3e9a9cd"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d861f39d-933b-44da-96b8-c7a8c62a6a1d"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d9f39c7b-1357-49cc-8bdb-2622afd7868a"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dc26c4f1-5a25-460a-ba59-3f1547ec32bb"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e9f8ef59-a305-4f15-bcac-531168c8aaef"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ec16b28b-488c-4b7b-9bca-b0d89901f3e8"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f5010527-836f-4a44-a29e-08e24740522b"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "83e449aa-1fb2-46af-b0da-18fdbedabf5f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "56573578-d154-44e1-b649-a38d987ded9d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "0c5c79c8-5d78-44cf-90ae-e6a425749cc3");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "2f938d39-df99-47c2-8b57-cb1496d5a73e");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("12bbc2e0-97b4-49ae-b4dd-4396df9c0073"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("3e81e797-b42b-41cb-a7b0-0a2aac547b20"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("63e38e71-ceea-4049-9ac1-3bfc088ecda2"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("c4115e27-c544-493a-83b4-05b40a0f9e13"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352), "$2a$11$WZd/pOUj2p.vp/74Q4Z0X.efTLXKyf7NYWacYnak9vonstvlVyk.e", new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352), "$2a$11$QEfRSv1Q5HX./pB5h7JI3u7k86kAF763W7X9zvPHqsRkgEhcr.GyO", new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352), "$2a$11$LcVMxqrFR4gKJtVscPIaC.ZQJ66RBktYEWB2lPkkFzEthDO/tvy9O", new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352), "$2a$11$HnPWemZ.IroXo4NYKO7a2uzxzmxL8mt3YKyEbUk6VGFV1WuLPOVKy", new DateTime(2026, 1, 4, 18, 22, 8, 237, DateTimeKind.Utc).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096), new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096), new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096), new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096), new DateTime(2026, 1, 4, 18, 22, 8, 734, DateTimeKind.Utc).AddTicks(6096) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0ad85ded-597d-4ecb-ab6a-5cd9bd09c80a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0f718d9b-16a3-426c-9f5c-a4b9b3873dd4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1147024f-fa8a-4313-9945-ad51a753edeb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1a766b92-3d7e-4807-99e9-b1f5d314e68d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22497451-32f7-4dc4-8256-f66520625bff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22bcd17c-4cfe-412f-b1ed-8d86d39e5264"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("27bec08f-be98-4cf4-83b9-966eac99f744"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("27df40ad-b21f-48f0-9d55-902b67d6340f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e6e2a69-2fd6-47bb-9590-0b1fb2a73c1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2eb75ebc-90c5-4f7a-837e-308ee39ee19b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2effeed0-d69a-47ba-ae05-a497d88839f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f035ef8-d90d-4cb4-b407-3172d80d9f84"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32746d32-b79c-4bb8-9ed8-ffba001f51ee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("33e73f7d-d202-47ca-aff6-f440b41560f9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3611f04f-5031-4c2d-a43f-08761baad780"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43856fd2-3e3b-47f2-b90e-01a36e2da881"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("527b84ff-a9a4-4e7c-be79-39f102e22dbe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d0f7984-6b26-438d-bcf4-aca647799d18"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("64a11805-db2f-423b-a945-517875dc8609"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("654f3076-af77-47f2-b8a1-5e6763f3fa70"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6b645e9d-cab6-42ec-844f-4a52355acdaa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d037da8-5053-4ce0-976a-ade3b22e98be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7f2160ee-e3c9-43ac-9030-73e5cfc77af7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8fcee0c4-b33d-457b-b148-11bd8f24a39d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6ff3ab9-a4e7-4c1c-9980-f6cc33b14333"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af7848d2-68a0-459d-80a0-6c2ac9b54075"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b176d1b6-0b20-4000-8304-ab72da12a7c0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("baaea6db-6adf-4907-ab77-c081ab99203c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c0d93ec3-d284-41ac-89b2-f6a3e7d53f01"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c5c797d6-2e71-4971-91dd-2a72f2a628d7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d2219600-0524-4d5a-a6f6-739e2924cee7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d2ba1057-6fed-4a47-9518-0b07ee8b317f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6f89220-4bcb-42c9-b315-2f46c3e9a9cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d861f39d-933b-44da-96b8-c7a8c62a6a1d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d9f39c7b-1357-49cc-8bdb-2622afd7868a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc26c4f1-5a25-460a-ba59-3f1547ec32bb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9f8ef59-a305-4f15-bcac-531168c8aaef"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ec16b28b-488c-4b7b-9bca-b0d89901f3e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f5010527-836f-4a44-a29e-08e24740522b"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("12bbc2e0-97b4-49ae-b4dd-4396df9c0073"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3e81e797-b42b-41cb-a7b0-0a2aac547b20"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("63e38e71-ceea-4049-9ac1-3bfc088ecda2"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("c4115e27-c544-493a-83b4-05b40a0f9e13"));

            migrationBuilder.AlterColumn<string>(
                name: "customer_phone",
                table: "booking_read_flat",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633), new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633), new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633), new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633), new DateTime(2026, 1, 4, 16, 28, 9, 172, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 173, DateTimeKind.Utc).AddTicks(4267), new DateTime(2026, 1, 4, 16, 28, 9, 173, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 173, DateTimeKind.Utc).AddTicks(4267), new DateTime(2026, 1, 4, 16, 28, 9, 173, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 173, DateTimeKind.Utc).AddTicks(4267), new DateTime(2026, 1, 4, 16, 28, 9, 173, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464), new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464), new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464), new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464), new DateTime(2026, 1, 4, 16, 28, 9, 174, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("07196715-4908-4234-91ab-ad3e0cb087e9"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0a66af99-2a03-44a3-86eb-ad50338d7d50"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0c2051bb-fdd0-48da-a5a1-ff5d5c7eb37d"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("22956edb-aa22-47f1-ae86-81b651f0a986"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e2e1c81-4ce0-4894-a1c8-65e813ca9ab7"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("34248995-4ba7-4b8d-9e3a-1020c7909850"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3ab3002c-dd9a-4a2a-8d11-990e4cee7c78"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3b6182ab-0357-46a1-b577-4e9a06ef77ae"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("47692072-3da8-47cc-9e60-c889af919481"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4a446411-e9d5-49ca-9181-ce062c425b07"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4f44e6f2-6759-4580-97c5-dad7bdbb907b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("60612c1d-55ce-4a8d-ac01-abc966259666"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("615c4988-b903-49d0-9231-c8f4537fd1cd"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("62983f0b-dc12-4d72-95aa-d015a41a8f0a"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("62b2d017-2ba9-44bf-9a60-645225bb2696"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6417460a-5c5d-4080-ae85-d0b3ebd3d988"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("75f7b928-35d0-404e-9619-3a4ae7e155ab"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("78fc2e3b-e00c-4d84-a1f3-d2fd40824aa6"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7c18868b-b34a-4568-b4dd-7f4d20112a30"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7d3c45c2-fa69-44be-ad9d-7ba8542254ef"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("8195256b-e65b-4e47-8db5-f627fdc12775"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8d24203e-2fa8-4785-8966-41aeb705b577"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9823b3c2-ef73-46b8-a9a1-e2fe1c5864fa"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9e7fd82b-6a98-4dd1-b008-e7ebd9935f0c"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a78b6014-c18c-41a8-b5d5-35f137ddb02a"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bf366b25-88c0-4dff-a050-b5d9f1c664ed"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c5166c32-bf89-470c-acbf-cb8b3af11ba4"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c97efc00-2dcd-4a61-89ea-88bc8a0c8423"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ca7e8325-f4e2-4e06-9e87-d9bec141a045"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d124f3c2-d1a8-4b93-8801-fa83fa23e765"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d4f29932-ad20-46eb-b0bd-d144d0b0ab7c"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d8859afe-66e1-45d9-be50-8a49496d0c27"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dfd69726-bb17-4505-814a-4c680493f0f0"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e01ddfd3-2804-43b8-a967-85ef67257d76"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eaa04489-c500-4b7d-ae0d-74629ce4191e"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ed23d206-7401-4668-8272-f85f724efa20"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f24d3512-33c8-436b-862e-d4ed67d01a8a"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f54ee3b4-1d84-41ae-afed-4b5ee3599e6d"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe5dfcff-b1db-4657-ba2c-266c5e45cecd"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "241cc932-992a-483e-8de2-08f993c28878");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "ad47de8c-1953-4d04-a618-559660ca03a4");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "00d7a41b-7da2-4beb-b2a0-c779ba9b6c22");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "a48714ca-9a8f-41c2-bbc7-733659e66e4d");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("2e749843-4a71-43ac-bcb1-4d9731b55778"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("a545d119-0029-4ce1-80c2-f0ec2b1a0a95"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("be1d96cd-bc0b-44f2-9cfa-0ca56fec37db"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("e7f3e88d-c2ee-4142-ab5f-5a150e479f06"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284), "$2a$11$qHikJRX8MXLZ8wvrIz/i7.n5.69Z189WB6eIpZxuIKGVEMALjxHVu", new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284), "$2a$11$/3IwZGVA3z2X6NbkHRzgBe54At6Puj8h5phzajHAJ4CzWwi3YnkFa", new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284), "$2a$11$IUemwLi1kNBmapsG/Lr/b.wuw3MWUaqPXf.OCt3MPrmryTlfMP7T2", new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284), "$2a$11$eMA6F7p4Ebr.neRRXxZ1ceRW8BzP4zYTWyU6rrKWjolGeIRdjNY22", new DateTime(2026, 1, 4, 16, 28, 9, 181, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119), new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119), new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119), new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119), new DateTime(2026, 1, 4, 16, 28, 9, 724, DateTimeKind.Utc).AddTicks(119) });
        }
    }
}
