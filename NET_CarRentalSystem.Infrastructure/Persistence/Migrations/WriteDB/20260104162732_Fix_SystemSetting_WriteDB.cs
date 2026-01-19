using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Fix_SystemSetting_WriteDB : Migration
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
                keyValue: new Guid("0c205c96-2e50-45e1-b136-e047fb9b7a51"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("10d7a137-20c1-4019-8197-6c83a6351ba9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("14938ede-a5d1-42b5-b485-941e81918e0d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("17c5930d-e558-4203-8964-105cf1a8bc60"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20613271-bc95-498c-a576-db3d6c13851f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("295d066f-bc1f-45fe-8308-d7edb2826500"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2a75e3d0-1da3-40f0-8123-2f6fa4b475ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ff78396-71b0-4c52-90ac-aaa4f95666d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3111864a-ac90-4a06-b5c8-6f1dbad7ad20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3533401b-f40e-449b-a269-b09ffbeff64a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("36cb2307-dfa1-4d59-bf01-d801a49db9a0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("37120e8f-f7d1-47f3-9f00-1391f963c992"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3fccec62-810c-4198-b0da-b04141a22cc8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("458ca4c9-dd4a-403c-9e96-2587498b30b6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5328cb82-7848-4016-be1d-65b70d5a138d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5f5da86f-96d3-4073-823e-33f2eec865d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("602ab198-c422-4582-b6bc-cac93ae7eb1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6108efa6-907f-437e-b475-65e34e3fb18c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6479fa50-91bd-407c-a4ac-07a169ee954b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7193c8fa-5d42-4465-b1da-c87d1cf1d2a7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("71aa40b2-fb8f-418f-b41b-6ef71fa588d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("90cbe01a-b811-45b5-be95-ac1d545df436"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92d23b42-6cc0-412d-9598-26e19eab0f11"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("935231cd-0b23-4462-8669-0e2144e5e550"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9ac37865-895e-4d43-a5aa-e638bd94fc06"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a5d87cec-773d-48ed-9e29-dd6142756c1f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a9475a64-d40e-45d2-92b1-48b1bfcf7605"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad6da287-bd4e-4fdf-98f5-c30e82c28513"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bd4de594-ed5d-42e6-af23-c409410687f7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bf65f96f-e4ff-4f6f-86fd-b7c41df56fa2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cd578e13-fa77-4795-b5c3-bad94ad360c2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ceb5d696-778b-481f-bf62-fc2b774551d7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dee70b07-ff2b-4a72-9684-749bd8c91653"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e54e444d-7aaf-4080-9ecd-aefd18c0e818"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9184fd3-0699-4f9d-8d21-2935105bd14d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1485b3f-1142-4558-862b-2c49b348e483"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f4df74b1-ea85-420f-921c-4074b923aa06"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fbcabd92-c89e-48da-ad04-8b59862223d5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe56fae9-69e1-49b5-9c40-cf8c83708b18"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("051aec6e-f88e-43f2-b474-9804fe586c85"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("188150b9-d685-4eff-a19c-b95f2313dd9e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("303dde0d-26cd-403e-b791-9cc5c396b4ee"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("aaab1017-5320-4ffa-aaa0-43dd69e31c58"));

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
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613), new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613), new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613), new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613), new DateTime(2026, 1, 4, 16, 27, 30, 580, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(1376), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(1376), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(1376), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168), new DateTime(2026, 1, 4, 16, 27, 30, 581, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0161655d-e3a2-47b0-9f53-734545b14f7a"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0849c5ed-bf18-4626-8f81-8e98cd59e891"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("23f65978-594c-47d1-aa92-79ef70b87c5d"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("28306566-87a0-459e-a038-18bd8a3617d3"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ba8f983-c1c4-45d1-9ef9-e124405a59ae"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2dea4109-a0ef-40a6-827a-9b009464a6d9"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("325b061e-2562-4ae0-a876-6734a4953dbf"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("33cc3e2c-1da5-41e3-9455-91bd4216bb20"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("36e732f0-0cc5-4b08-865b-eda964896c89"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("38b3849b-f8a4-426a-835d-bd9057a77b0e"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3ccbfad5-00ed-4108-8f1a-2997fc6c6fdc"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3f8d51dc-1f57-4b72-a6e3-49f1e1080ce7"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("56a6200d-397a-4bf6-b701-32946f422256"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5d2457eb-0867-4e01-a2d9-52e660c68248"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("619a4b13-630c-432e-9ef2-d21cf8e8009a"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("778d52a5-ff12-4979-b135-f677544bd353"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7f5bd8ce-c442-49cd-be0c-cf09ae013ce4"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("81740df8-37d3-4b8b-b778-45b1401b2e4f"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("94f7b4c6-629a-47ce-b279-875a8a8052a8"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("96d2f32e-e76f-494b-a5d0-461e3910fab3"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("99432639-ce2f-402b-bf39-b3ecf012272b"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9fc07711-c1c5-4b44-a676-47e8df679f53"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a1e44e50-c1d4-4c64-a85d-44b111d20208"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("abc496d8-66e6-4ddc-8f09-c562ff6210d3"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b6d9894d-e05b-4750-bfd6-abc58d4a76f3"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b90714e5-75b3-449a-9bd4-39e4896e668f"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b978b135-8354-4347-b5c2-9aa31e6d068f"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bc7b3f18-1cb0-4a1e-8ec8-4c761c893f2e"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d53d306a-e9c2-4de3-b4c0-f13a988865b0"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d6de7275-54bf-499f-9971-f4d3e3af4632"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d9a64eb2-003a-4beb-95a6-95febe660f44"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e3a9170b-b135-4de1-bfd7-4ab1946aa64f"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e3be984e-5f25-4cdd-981a-442f104aea5c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ee27f592-a219-4787-9b27-825d00bb1515"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f043f0e8-6d3c-43ea-b35c-46d967a91b6a"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fc093783-da7d-4e4d-91da-4d1016b01e8f"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("fc9ad67c-9414-46f8-a35e-241556d9e7cc"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fd74f4f2-6d15-4938-8396-3fc642877b41"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe4373d6-745d-4d3f-a2a8-7aa570a5f67d"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "2ed7a132-1ea0-4dee-bed4-c03f5ffc2c62");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "e3a5a53e-d8d5-4b0f-af5b-a12293473e1d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "79f23099-ba57-4c85-8f6b-0f738fb921cb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "05713da1-67a7-4114-9ecf-04f14f7fa30e");

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
                    { new Guid("0d1d6ef1-4199-41cf-b3aa-d41c89816e65"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("5b0f2e2b-11e1-4aa0-9aea-fe7490b79800"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("c90d2474-700d-4585-b825-f5ac489602b3"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("ebd50431-18ae-4059-9d7c-fc3adea38123"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456), "$2a$11$/umUMvBwE8JrZXCXBMDZX.9RXETF45Npnn2gb6qIvDgDtSEHydTea", new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456), "$2a$11$kWfylJEbjDqSJmenlslCs.KTI6U8/k7vCyoR89T7IoYiaFtRQCpLG", new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456), "$2a$11$XJUVuFcHxYbN/tixOjG9Beek1URZhfq7kClpwt86xXnflJK.wrdde", new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456), "$2a$11$S5nG3Zof/wCT6PIlzabRDub9wGCt0pwwa3tMo4vL0yej3b3kBtPFe", new DateTime(2026, 1, 4, 16, 27, 30, 589, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679), new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679), new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679), new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679), new DateTime(2026, 1, 4, 16, 27, 31, 158, DateTimeKind.Utc).AddTicks(4679) });

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
                keyValue: new Guid("0161655d-e3a2-47b0-9f53-734545b14f7a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0849c5ed-bf18-4626-8f81-8e98cd59e891"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23f65978-594c-47d1-aa92-79ef70b87c5d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("28306566-87a0-459e-a038-18bd8a3617d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ba8f983-c1c4-45d1-9ef9-e124405a59ae"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2dea4109-a0ef-40a6-827a-9b009464a6d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("325b061e-2562-4ae0-a876-6734a4953dbf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("33cc3e2c-1da5-41e3-9455-91bd4216bb20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("36e732f0-0cc5-4b08-865b-eda964896c89"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("38b3849b-f8a4-426a-835d-bd9057a77b0e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3ccbfad5-00ed-4108-8f1a-2997fc6c6fdc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3f8d51dc-1f57-4b72-a6e3-49f1e1080ce7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("56a6200d-397a-4bf6-b701-32946f422256"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d2457eb-0867-4e01-a2d9-52e660c68248"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("619a4b13-630c-432e-9ef2-d21cf8e8009a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("778d52a5-ff12-4979-b135-f677544bd353"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7f5bd8ce-c442-49cd-be0c-cf09ae013ce4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("81740df8-37d3-4b8b-b778-45b1401b2e4f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94f7b4c6-629a-47ce-b279-875a8a8052a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("96d2f32e-e76f-494b-a5d0-461e3910fab3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("99432639-ce2f-402b-bf39-b3ecf012272b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9fc07711-c1c5-4b44-a676-47e8df679f53"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a1e44e50-c1d4-4c64-a85d-44b111d20208"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("abc496d8-66e6-4ddc-8f09-c562ff6210d3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b6d9894d-e05b-4750-bfd6-abc58d4a76f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b90714e5-75b3-449a-9bd4-39e4896e668f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b978b135-8354-4347-b5c2-9aa31e6d068f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bc7b3f18-1cb0-4a1e-8ec8-4c761c893f2e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d53d306a-e9c2-4de3-b4c0-f13a988865b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6de7275-54bf-499f-9971-f4d3e3af4632"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d9a64eb2-003a-4beb-95a6-95febe660f44"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3a9170b-b135-4de1-bfd7-4ab1946aa64f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3be984e-5f25-4cdd-981a-442f104aea5c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ee27f592-a219-4787-9b27-825d00bb1515"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f043f0e8-6d3c-43ea-b35c-46d967a91b6a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc093783-da7d-4e4d-91da-4d1016b01e8f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc9ad67c-9414-46f8-a35e-241556d9e7cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd74f4f2-6d15-4938-8396-3fc642877b41"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe4373d6-745d-4d3f-a2a8-7aa570a5f67d"));

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
                keyValue: new Guid("0d1d6ef1-4199-41cf-b3aa-d41c89816e65"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("5b0f2e2b-11e1-4aa0-9aea-fe7490b79800"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("c90d2474-700d-4585-b825-f5ac489602b3"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ebd50431-18ae-4059-9d7c-fc3adea38123"));

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
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382), new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382), new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382), new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382), new DateTime(2026, 1, 4, 16, 14, 32, 210, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 211, DateTimeKind.Utc).AddTicks(5071), new DateTime(2026, 1, 4, 16, 14, 32, 211, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 211, DateTimeKind.Utc).AddTicks(5071), new DateTime(2026, 1, 4, 16, 14, 32, 211, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 211, DateTimeKind.Utc).AddTicks(5071), new DateTime(2026, 1, 4, 16, 14, 32, 211, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414), new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414), new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414), new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414), new DateTime(2026, 1, 4, 16, 14, 32, 212, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0c205c96-2e50-45e1-b136-e047fb9b7a51"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("10d7a137-20c1-4019-8197-6c83a6351ba9"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("14938ede-a5d1-42b5-b485-941e81918e0d"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("17c5930d-e558-4203-8964-105cf1a8bc60"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("20613271-bc95-498c-a576-db3d6c13851f"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("295d066f-bc1f-45fe-8308-d7edb2826500"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2a75e3d0-1da3-40f0-8123-2f6fa4b475ba"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ff78396-71b0-4c52-90ac-aaa4f95666d3"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3111864a-ac90-4a06-b5c8-6f1dbad7ad20"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3533401b-f40e-449b-a269-b09ffbeff64a"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("36cb2307-dfa1-4d59-bf01-d801a49db9a0"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("37120e8f-f7d1-47f3-9f00-1391f963c992"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3fccec62-810c-4198-b0da-b04141a22cc8"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("458ca4c9-dd4a-403c-9e96-2587498b30b6"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5328cb82-7848-4016-be1d-65b70d5a138d"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5f5da86f-96d3-4073-823e-33f2eec865d0"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("602ab198-c422-4582-b6bc-cac93ae7eb1c"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6108efa6-907f-437e-b475-65e34e3fb18c"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6479fa50-91bd-407c-a4ac-07a169ee954b"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7193c8fa-5d42-4465-b1da-c87d1cf1d2a7"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("71aa40b2-fb8f-418f-b41b-6ef71fa588d3"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("90cbe01a-b811-45b5-be95-ac1d545df436"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("92d23b42-6cc0-412d-9598-26e19eab0f11"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("935231cd-0b23-4462-8669-0e2144e5e550"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9ac37865-895e-4d43-a5aa-e638bd94fc06"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a5d87cec-773d-48ed-9e29-dd6142756c1f"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a9475a64-d40e-45d2-92b1-48b1bfcf7605"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad6da287-bd4e-4fdf-98f5-c30e82c28513"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("bd4de594-ed5d-42e6-af23-c409410687f7"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bf65f96f-e4ff-4f6f-86fd-b7c41df56fa2"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cd578e13-fa77-4795-b5c3-bad94ad360c2"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ceb5d696-778b-481f-bf62-fc2b774551d7"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dee70b07-ff2b-4a72-9684-749bd8c91653"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e54e444d-7aaf-4080-9ecd-aefd18c0e818"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e9184fd3-0699-4f9d-8d21-2935105bd14d"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1485b3f-1142-4558-862b-2c49b348e483"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("f4df74b1-ea85-420f-921c-4074b923aa06"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fbcabd92-c89e-48da-ad04-8b59862223d5"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe56fae9-69e1-49b5-9c40-cf8c83708b18"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "ef1700de-054f-414f-9e96-425982864753");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "480b6d2e-5dea-4b45-843d-7d11a054085a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "aeba2e22-96f7-42fd-b984-1172d93f539f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "ea0c1ffa-dd57-4e96-8339-65206a414514");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("051aec6e-f88e-43f2-b474-9804fe586c85"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("188150b9-d685-4eff-a19c-b95f2313dd9e"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("303dde0d-26cd-403e-b791-9cc5c396b4ee"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("aaab1017-5320-4ffa-aaa0-43dd69e31c58"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620), "$2a$11$nWkRCr.L93S092HtqDNKDOiFcyU0KZm/gxaz34JZV.1bZ3K9ti5TK", new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620), "$2a$11$BiiQ2tHfrArPGKCq9CIM9evTFYNDHzsig2KpZpzZSDuc2sDqkyC3S", new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620), "$2a$11$DcsQe3TrnMp1oAnKSleYN.k7zY4Wi2DkOiYTeNI4/cwQRC0zFF6Ie", new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620), "$2a$11$sXtFo3pRnN9Hm/FyEXfgpudp4/uf3GNGLfAPzRKcElgbARR18xW4q", new DateTime(2026, 1, 4, 16, 14, 32, 218, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161), new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161), new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161), new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161), new DateTime(2026, 1, 4, 16, 14, 32, 720, DateTimeKind.Utc).AddTicks(4161) });
        }
    }
}
