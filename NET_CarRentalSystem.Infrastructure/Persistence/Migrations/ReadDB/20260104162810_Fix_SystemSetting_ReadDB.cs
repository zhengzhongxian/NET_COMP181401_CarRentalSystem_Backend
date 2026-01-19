using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Fix_SystemSetting_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemSettings",
                table: "SystemSettings");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("004672b3-24db-4256-af45-ea5882d34789"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("01cdf3fe-9469-4d26-ba08-9b8bd2408bc3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("074a957b-dfbf-41cd-ac68-1b2376ac441f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("08207f99-64c4-4f23-838f-0ad3774b7b01"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("130410b2-f874-4c54-a93f-a49af961edbb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("13d59165-1579-4024-856a-1fc63a614f47"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("260d3118-56b4-461d-8069-f2bda8a10075"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("27a1a217-c6c1-405e-9f30-000099cce525"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2d099a61-4cfd-4c02-8c1b-cfe9e7a7e35c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3b5dcb79-e245-4203-96b3-a27dfa17191c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("40ad5685-7cd8-47c0-b7b3-bcdd76dc7816"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4a78d48e-36e7-4eb2-b970-12d841c9b6d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4aed01ab-25ee-452d-9494-62d4557b830c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ff65282-65d0-42a7-aac8-ec6d4cca6bdf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5033c66c-37eb-4000-943e-d13fb39aa183"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55349120-d6d8-4221-a7c7-006211f72f77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5650f67d-acc2-443d-904e-efb5af110bb5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("59f1fd5a-59aa-4048-b0ea-aa5d3006730e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5f0a106b-aa57-423f-9e95-05b9edb8d898"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6c5108d0-1260-48e4-9f2c-ea3259fb35e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7078f369-b9b2-4704-9000-ae1c1d5a3c78"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("70c49787-cc78-4067-9280-5cd0801e9b85"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("808d7546-27d2-4a4e-aaca-f187247454f0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94c31916-cc7f-4da8-bf8d-4dcf09a7fb9a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4fbd428-1369-4dd8-8af7-285f7f785fb2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ab6c494c-5f67-4cb1-b57d-c6d261c30afd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac277a15-1ca6-4368-b2f9-cf926fe99fca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bec33d19-50ae-4872-81ab-6dbb9d755441"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c1cd37b8-c26d-4a22-abcf-c4ed5c803585"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c277df03-67a5-446d-abff-d42b53f89aab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c747fa22-8c69-49c2-af21-64703b9fee01"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c92940f7-474d-4ba0-815a-864b737f9773"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ccc429b0-944e-4dd5-912f-e312289464d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6206b8f-7fc4-4ab5-bedd-72c8bf34a112"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de4d8d98-a8ae-4e1c-8867-0cbf6d1460d4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e2c030a6-a7f0-45cf-99ce-7659034ae248"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eb5eb92a-2295-409b-8c67-b5f5c0b0bbf5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f0368239-2049-4741-ab8d-e52480845ea2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fda0975f-e663-4179-8024-1899689df5d0"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("2315f984-ed78-4984-949f-c578a6d64f2a"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7bceb433-8cd6-46ac-9b80-c84a838ada59"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("dc995808-c737-40d7-a177-207aa1d637ea"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("eab254e4-4e0b-400b-abd8-74a01202d9f0"));

            migrationBuilder.RenameTable(
                name: "SystemSettings",
                newName: "system_settings");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "system_settings",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "SettingValue",
                table: "system_settings",
                newName: "setting_value");

            migrationBuilder.RenameColumn(
                name: "SettingKey",
                table: "system_settings",
                newName: "setting_key");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "system_settings",
                newName: "setting_id");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "system_settings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "setting_value",
                table: "system_settings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "setting_key",
                table: "system_settings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "setting_id",
                table: "system_settings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWSEQUENTIALID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_system_settings",
                table: "system_settings",
                column: "setting_id");

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
                table: "system_settings",
                columns: new[] { "setting_id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "description", "IsDeleted", "setting_key", "setting_value", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("019b5088-3895-7376-9e27-14a43c0df1d3"), null, null, null, null, "Points required for Bronze tier", false, "MembershipThresholds.Bronze", "10000", null, null },
                    { new Guid("019b5088-5aa1-70c5-954e-307f367c0ff2"), null, null, null, null, "Points required for Silver tier", false, "MembershipThresholds.Silver", "20000", null, null },
                    { new Guid("019b5088-6c4e-728e-b019-30b10d351c72"), null, null, null, null, "Points required for Gold tier", false, "MembershipThresholds.Gold", "30000", null, null },
                    { new Guid("019b5088-870d-72a6-9ab1-eadf6bf04999"), null, null, null, null, "Points required for Platinum tier", false, "MembershipThresholds.Platinum", "50000", null, null },
                    { new Guid("019b5088-9d8d-7041-83e3-ebc01f9d0a47"), null, null, null, null, "Points required for Diamond tier", false, "MembershipThresholds.Diamond", "100000", null, null },
                    { new Guid("019b5088-c214-77e3-8e6d-7b68b0ee7f90"), null, null, null, null, "Discount ratio for Bronze tier", false, "MembershipDiscounts.Bronze", "0", null, null },
                    { new Guid("019b5088-e037-780b-98f8-b1dd868ca193"), null, null, null, null, "Discount ratio for Silver tier", false, "MembershipDiscounts.Silver", "0.05", null, null },
                    { new Guid("019b5088-f455-70e7-818f-341025ede937"), null, null, null, null, "Discount ratio for Gold tier", false, "MembershipDiscounts.Gold", "0.1", null, null },
                    { new Guid("019b5089-05bb-739e-a4d3-bae8cff04983"), null, null, null, null, "Discount ratio for Platinum tier", false, "MembershipDiscounts.Platinum", "0.15", null, null },
                    { new Guid("019b5089-20ac-7253-85c6-3a4367442414"), null, null, null, null, "Discount ratio for Diamond tier", false, "MembershipDiscounts.Diamond", "0.2", null, null },
                    { new Guid("019b50de-de75-72d8-88b9-a28c3da7fc00"), null, null, null, null, "Default deposit ratio for all bookings (0.3 = 30%)", false, "BookingSettings.DepositRatio", "0.3", null, null },
                    { new Guid("019b50de-f123-7a4b-9c12-d3e4f5a6b789"), null, null, null, null, "Late penalty ratio per day (0.1 = 10% of booking price per day late)", false, "BookingSettings.LatePenaltyRatio", "0.1", null, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_system_settings_setting_key",
                table: "system_settings",
                column: "setting_key",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_system_settings",
                table: "system_settings");

            migrationBuilder.DropIndex(
                name: "IX_system_settings_setting_key",
                table: "system_settings");

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
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-3895-7376-9e27-14a43c0df1d3"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-5aa1-70c5-954e-307f367c0ff2"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-6c4e-728e-b019-30b10d351c72"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-870d-72a6-9ab1-eadf6bf04999"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-9d8d-7041-83e3-ebc01f9d0a47"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-c214-77e3-8e6d-7b68b0ee7f90"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-e037-780b-98f8-b1dd868ca193"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5088-f455-70e7-818f-341025ede937"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5089-05bb-739e-a4d3-bae8cff04983"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b5089-20ac-7253-85c6-3a4367442414"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b50de-de75-72d8-88b9-a28c3da7fc00"));

            migrationBuilder.DeleteData(
                table: "system_settings",
                keyColumn: "setting_id",
                keyValue: new Guid("019b50de-f123-7a4b-9c12-d3e4f5a6b789"));

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

            migrationBuilder.RenameTable(
                name: "system_settings",
                newName: "SystemSettings");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "SystemSettings",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "setting_value",
                table: "SystemSettings",
                newName: "SettingValue");

            migrationBuilder.RenameColumn(
                name: "setting_key",
                table: "SystemSettings",
                newName: "SettingKey");

            migrationBuilder.RenameColumn(
                name: "setting_id",
                table: "SystemSettings",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SystemSettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SettingValue",
                table: "SystemSettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SettingKey",
                table: "SystemSettings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SystemSettings",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWSEQUENTIALID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemSettings",
                table: "SystemSettings",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847), new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847), new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847), new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847), new DateTime(2026, 1, 4, 15, 38, 47, 145, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(3428), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(3428), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(3428), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588), new DateTime(2026, 1, 4, 15, 38, 47, 146, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("004672b3-24db-4256-af45-ea5882d34789"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("01cdf3fe-9469-4d26-ba08-9b8bd2408bc3"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("074a957b-dfbf-41cd-ac68-1b2376ac441f"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("08207f99-64c4-4f23-838f-0ad3774b7b01"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("130410b2-f874-4c54-a93f-a49af961edbb"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("13d59165-1579-4024-856a-1fc63a614f47"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("260d3118-56b4-461d-8069-f2bda8a10075"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("27a1a217-c6c1-405e-9f30-000099cce525"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2d099a61-4cfd-4c02-8c1b-cfe9e7a7e35c"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3b5dcb79-e245-4203-96b3-a27dfa17191c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("40ad5685-7cd8-47c0-b7b3-bcdd76dc7816"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4a78d48e-36e7-4eb2-b970-12d841c9b6d3"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4aed01ab-25ee-452d-9494-62d4557b830c"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4ff65282-65d0-42a7-aac8-ec6d4cca6bdf"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5033c66c-37eb-4000-943e-d13fb39aa183"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("55349120-d6d8-4221-a7c7-006211f72f77"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5650f67d-acc2-443d-904e-efb5af110bb5"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("59f1fd5a-59aa-4048-b0ea-aa5d3006730e"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5f0a106b-aa57-423f-9e95-05b9edb8d898"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6c5108d0-1260-48e4-9f2c-ea3259fb35e7"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7078f369-b9b2-4704-9000-ae1c1d5a3c78"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("70c49787-cc78-4067-9280-5cd0801e9b85"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("808d7546-27d2-4a4e-aaca-f187247454f0"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("94c31916-cc7f-4da8-bf8d-4dcf09a7fb9a"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a4fbd428-1369-4dd8-8af7-285f7f785fb2"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ab6c494c-5f67-4cb1-b57d-c6d261c30afd"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ac277a15-1ca6-4368-b2f9-cf926fe99fca"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bec33d19-50ae-4872-81ab-6dbb9d755441"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c1cd37b8-c26d-4a22-abcf-c4ed5c803585"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c277df03-67a5-446d-abff-d42b53f89aab"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c747fa22-8c69-49c2-af21-64703b9fee01"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c92940f7-474d-4ba0-815a-864b737f9773"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ccc429b0-944e-4dd5-912f-e312289464d0"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6206b8f-7fc4-4ab5-bedd-72c8bf34a112"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("de4d8d98-a8ae-4e1c-8867-0cbf6d1460d4"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e2c030a6-a7f0-45cf-99ce-7659034ae248"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("eb5eb92a-2295-409b-8c67-b5f5c0b0bbf5"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f0368239-2049-4741-ab8d-e52480845ea2"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fda0975f-e663-4179-8024-1899689df5d0"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "25dd2bfd-b0ad-49e5-ae24-415d035c87d9");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "5fc001f7-1c47-44ca-8972-91ebfeb7c027");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "6e78629b-9d48-4a95-a59b-0a65cf675726");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "76f40b74-24de-453f-a374-c15933d7029c");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("2315f984-ed78-4984-949f-c578a6d64f2a"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("7bceb433-8cd6-46ac-9b80-c84a838ada59"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("dc995808-c737-40d7-a177-207aa1d637ea"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("eab254e4-4e0b-400b-abd8-74a01202d9f0"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780), "$2a$11$.xRSwi9IDq0rUWJy3n8PY.JnJ84YGAwq7NCxRiKXEuWvEFcK7n8Fu", new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780), "$2a$11$mXE3k2v50yx.UsScn.2i7.6RiI6JUdFlJHx8rp7cVl5rDa.vzr85O", new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780), "$2a$11$LSUpUKy7JXpS6D91p20qO..1phP3znxd7ajdZ0fZ6Y.vA.K0pslTq", new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780), "$2a$11$93ugAfY48waBdEukGjP35uhJZjNE8cTYb0f/TyqU4Irb1kYL.4hPG", new DateTime(2026, 1, 4, 15, 38, 47, 153, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148), new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148), new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148), new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148), new DateTime(2026, 1, 4, 15, 38, 47, 657, DateTimeKind.Utc).AddTicks(3148) });
        }
    }
}
