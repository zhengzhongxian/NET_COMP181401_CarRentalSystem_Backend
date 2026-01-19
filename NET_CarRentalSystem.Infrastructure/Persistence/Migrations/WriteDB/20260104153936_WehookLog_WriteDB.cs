using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class WehookLog_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_locations_pickup_location_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_locations_return_location_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_pickup_location_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_return_location_id",
                table: "bookings");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("00c7e57d-d88c-4e39-8177-9780f6aeafcd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04cba150-76c5-4c88-8799-e0b7f8be9036"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05714408-1c7a-4baa-aaf2-fd3cf50df685"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("061a9eb0-097e-4247-9fe8-615819f4f816"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("06a15827-bb06-43f5-999c-d8e8ca6f8c17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0e9c8a5d-190c-4dab-a745-01e1612ca39a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("18151621-2d2c-4ba1-ba84-7910726c17d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1a5e4be7-6cc5-4f0e-b78f-671534572ca0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21599794-4893-43c4-b475-ff529d81e8a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2daad8e1-1268-4132-9c28-9a8999c67935"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30805ce6-8548-40e0-96a8-221c5e2fff54"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("39d9992a-8a6d-44d5-bb58-ebe0951eeb90"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("443646bd-342d-49f7-894d-27fcaf29d8d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("477ba6f5-c85a-45e9-9dc0-5527453274bf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47c64d3c-d14c-4392-a111-63f7e5dc1a74"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("50811b99-62b1-4829-afae-582ea3cf89ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51370b04-6913-4409-b185-3665e70eb43c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("549d1710-2643-407a-a9be-79fca78ccb4a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("60b7abd0-6975-4d55-b2f1-31f211b4ffb9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66828a07-783d-4420-aeac-172ae1292cec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a2d7f96-f25f-476b-8079-3c583209df28"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7147d681-0712-48ca-afdf-aad1fa1c172c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("77d13000-c5b8-488b-ac05-a5bfdf4d3d85"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80d1a291-bace-42d2-a34a-4639b7fd74be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8a7bf422-4fc5-4f8a-be37-022b89bf121d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8e639ba5-13fb-4eb6-9539-f22edfcd0f55"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c18a9188-91f5-45c1-a9ba-503b22bb0c7e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c97e341c-6b7c-4307-b074-8d20d4b5bac5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cb859630-d1cd-4cc0-962e-b0c286be65a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d75da50e-b43e-4681-b746-8247f92eb782"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d832930a-b4c7-49d8-9b5d-289d0d60a52b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e0ecc042-2953-446f-b3cf-e10783b00013"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3bcf162-c41d-4d16-a989-6df245ba1aa9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f565a3da-9902-4c75-9bf6-72bc26ab0acc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f59b58c3-deaa-4646-9f73-e061eef3d68e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd480aff-d99e-4cc8-a6a3-2e4f388354ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fd5a6fe3-9f86-45a4-b538-cc19cb9ed66f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe450712-ef95-4bdc-985a-564dfbc83b68"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("14afbd84-9085-40ac-9bd7-e78a67f9e9cd"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8587f03a-0634-4d02-8f0c-241fd3842c91"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9b38a97c-4210-40c3-98d5-135039a4909d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ad6d5081-539f-44b0-8218-87eae687230f"));

            migrationBuilder.DropColumn(
                name: "pickup_location_id",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "return_location_id",
                table: "bookings");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "bookings",
                newName: "start_date");

            migrationBuilder.CreateTable(
                name: "booking_images",
                columns: table => new
                {
                    image_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    booking_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    public_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    display_order = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_images", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_booking_images_bookings_booking_id",
                        column: x => x.booking_id,
                        principalTable: "bookings",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SettingKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "webhook_logs",
                columns: table => new
                {
                    webhook_log_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    event_type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    payload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order_code = table.Column<long>(type: "bigint", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    amount = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    error_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    processed_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    processed_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_webhook_logs", x => x.webhook_log_id);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(9946), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(9946), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(9946), new DateTime(2026, 1, 4, 15, 39, 34, 909, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832), new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832), new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832), new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832), new DateTime(2026, 1, 4, 15, 39, 34, 910, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("23f9abed-ddf2-490c-8503-219a23833497"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("290fe1f3-a64f-4846-981c-72bb0c18c566"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("363e93c6-6601-4f27-9c4e-a26c69861aa0"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("503dbda8-bc4e-4e99-95b5-2dc279918180"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("54a0574c-00c5-4c74-bfea-7879be028723"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5956ea2d-b494-4a3d-9cb2-ca9a5ef65a85"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5fe784b0-050e-49c2-b036-d871675e43b8"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66120ede-c1db-4936-b78c-22f136007490"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("68115e19-f9a5-4b10-a053-67d2028cf111"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6c07535b-2213-4307-9eca-c95491f608ca"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6cec74df-1678-4fa0-ab98-c88178a4b7a4"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("78f816e1-02d7-4fd9-8843-e9591e5a5765"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("824f25b0-9564-4fb6-a02d-fd6b2b94792f"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("82c41abc-093f-4b9b-8551-260dc9906b29"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("88ba6ff1-d1fe-4e63-849b-57a07ccfdd71"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("92ed85a3-be10-4b46-aed5-1667a0285391"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("94224882-d8b2-4902-9e1e-46e87d27e2d9"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("944fdd3e-8159-4289-b6ec-5f94dd86bade"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("986023f7-ac7f-43f4-814e-276d00885946"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("9e91cea2-f63f-43d7-9648-8b36feaa7070"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9f1c7700-ad65-4e4d-87ce-d840b63f7460"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9fbe45fd-7d56-465d-b12d-fb3a02efc7f3"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a06a0aea-308e-46f1-b2f5-8ffa7a37d7c3"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a9b4e4b4-7902-414f-8e2e-a3417178dc32"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ab86aeff-2f3e-4f4c-b373-3afe4a5cb5fb"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af790e12-09df-4b84-b059-493267a2fa78"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b250ab1c-1ad1-46f2-96f2-0fe0f3ddd4ed"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b6498a3e-45d9-4f52-bf93-580366d2d61d"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c638b3c8-5a8f-41b1-b928-854e08e7577d"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d1090d04-c79a-4118-8e0c-3fb027136734"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d19af40e-6fa6-4e71-9950-6030ad9900ef"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d3ff456c-30cd-4c8a-9281-a13d1dd8d287"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d4b7bbda-1046-403e-b6d0-b45d31d1bbcd"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da90e7fa-d1ea-4568-aab1-4675f1c0c7be"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ea08bc2d-4619-41ca-a9e5-b045c1f3934b"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ec904ea9-b59e-4d0c-80e5-17eb9dd08356"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ef19bf0c-1a28-45d7-92eb-a1c19c37b028"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f3c6680a-84e2-4eb3-aa04-9d126f128062"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f7e0a89e-42a4-4bae-8c94-543f88555534"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "27371db9-57fa-4b7a-a8a4-ab77ddf35c1f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "8daa1061-481e-4d91-a8e1-c9587b4ba98f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "ed2b97c9-b99c-43e9-b8d9-ead35de42d41");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "57d18a37-35fe-4521-9ee7-ba5332503c64");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("35deb153-41ed-4ede-aa61-8d32d9fae0f0"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("67faced7-da72-4dd5-8baa-41f523635b5c"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("809856e3-cb77-4651-bdba-8299d0d47505"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("ee5caa26-9228-45f7-8171-cbd9b417791f"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945), "$2a$11$JZi/nJYddAVmb8n2vtouEO.AbpK6PjRwLVwbFgDG2eJNDN/npwlCu", new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945), "$2a$11$p/L0/l97PULxMTqfoOfe9uNTQqwuV8MzH82bqbK3P55hv4fHYgFJO", new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945), "$2a$11$OU/qr/uA5gxAlKeNLwZXNOWNlPJGowqxoELiLQ5SaqzSaU8yhtXk2", new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945), "$2a$11$1DvWwsQZ2/n87mzky25v6.7rgexHDvibO5eAwQAJr7fRFzKKMUXMm", new DateTime(2026, 1, 4, 15, 39, 34, 915, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524), new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524), new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524), new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524), new DateTime(2026, 1, 4, 15, 39, 35, 413, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.CreateIndex(
                name: "IX_booking_images_booking_id",
                table: "booking_images",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_images_public_id",
                table: "booking_images",
                column: "public_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_images");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "webhook_logs");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23f9abed-ddf2-490c-8503-219a23833497"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("290fe1f3-a64f-4846-981c-72bb0c18c566"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("363e93c6-6601-4f27-9c4e-a26c69861aa0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("503dbda8-bc4e-4e99-95b5-2dc279918180"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("54a0574c-00c5-4c74-bfea-7879be028723"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5956ea2d-b494-4a3d-9cb2-ca9a5ef65a85"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5fe784b0-050e-49c2-b036-d871675e43b8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66120ede-c1db-4936-b78c-22f136007490"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("68115e19-f9a5-4b10-a053-67d2028cf111"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6c07535b-2213-4307-9eca-c95491f608ca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6cec74df-1678-4fa0-ab98-c88178a4b7a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("78f816e1-02d7-4fd9-8843-e9591e5a5765"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("824f25b0-9564-4fb6-a02d-fd6b2b94792f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("82c41abc-093f-4b9b-8551-260dc9906b29"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88ba6ff1-d1fe-4e63-849b-57a07ccfdd71"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("92ed85a3-be10-4b46-aed5-1667a0285391"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94224882-d8b2-4902-9e1e-46e87d27e2d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("944fdd3e-8159-4289-b6ec-5f94dd86bade"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("986023f7-ac7f-43f4-814e-276d00885946"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e91cea2-f63f-43d7-9648-8b36feaa7070"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f1c7700-ad65-4e4d-87ce-d840b63f7460"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9fbe45fd-7d56-465d-b12d-fb3a02efc7f3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a06a0aea-308e-46f1-b2f5-8ffa7a37d7c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a9b4e4b4-7902-414f-8e2e-a3417178dc32"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ab86aeff-2f3e-4f4c-b373-3afe4a5cb5fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af790e12-09df-4b84-b059-493267a2fa78"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b250ab1c-1ad1-46f2-96f2-0fe0f3ddd4ed"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b6498a3e-45d9-4f52-bf93-580366d2d61d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c638b3c8-5a8f-41b1-b928-854e08e7577d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d1090d04-c79a-4118-8e0c-3fb027136734"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d19af40e-6fa6-4e71-9950-6030ad9900ef"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d3ff456c-30cd-4c8a-9281-a13d1dd8d287"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d4b7bbda-1046-403e-b6d0-b45d31d1bbcd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da90e7fa-d1ea-4568-aab1-4675f1c0c7be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea08bc2d-4619-41ca-a9e5-b045c1f3934b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ec904ea9-b59e-4d0c-80e5-17eb9dd08356"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ef19bf0c-1a28-45d7-92eb-a1c19c37b028"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f3c6680a-84e2-4eb3-aa04-9d126f128062"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f7e0a89e-42a4-4bae-8c94-543f88555534"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("35deb153-41ed-4ede-aa61-8d32d9fae0f0"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("67faced7-da72-4dd5-8baa-41f523635b5c"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("809856e3-cb77-4651-bdba-8299d0d47505"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ee5caa26-9228-45f7-8171-cbd9b417791f"));

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "bookings",
                newName: "StartDate");

            migrationBuilder.AddColumn<Guid>(
                name: "pickup_location_id",
                table: "bookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "return_location_id",
                table: "bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 12, 30, 14, 55, 11, 16, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147), new DateTime(2025, 12, 30, 14, 55, 11, 17, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("00c7e57d-d88c-4e39-8177-9780f6aeafcd"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("04cba150-76c5-4c88-8799-e0b7f8be9036"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05714408-1c7a-4baa-aaf2-fd3cf50df685"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("061a9eb0-097e-4247-9fe8-615819f4f816"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("06a15827-bb06-43f5-999c-d8e8ca6f8c17"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0e9c8a5d-190c-4dab-a745-01e1612ca39a"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("18151621-2d2c-4ba1-ba84-7910726c17d9"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("1a5e4be7-6cc5-4f0e-b78f-671534572ca0"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("21599794-4893-43c4-b475-ff529d81e8a4"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2daad8e1-1268-4132-9c28-9a8999c67935"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30805ce6-8548-40e0-96a8-221c5e2fff54"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("39d9992a-8a6d-44d5-bb58-ebe0951eeb90"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("443646bd-342d-49f7-894d-27fcaf29d8d0"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("477ba6f5-c85a-45e9-9dc0-5527453274bf"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("47c64d3c-d14c-4392-a111-63f7e5dc1a74"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("50811b99-62b1-4829-afae-582ea3cf89ba"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("51370b04-6913-4409-b185-3665e70eb43c"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("549d1710-2643-407a-a9be-79fca78ccb4a"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("60b7abd0-6975-4d55-b2f1-31f211b4ffb9"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66828a07-783d-4420-aeac-172ae1292cec"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6a2d7f96-f25f-476b-8079-3c583209df28"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7147d681-0712-48ca-afdf-aad1fa1c172c"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("77d13000-c5b8-488b-ac05-a5bfdf4d3d85"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80d1a291-bace-42d2-a34a-4639b7fd74be"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8a7bf422-4fc5-4f8a-be37-022b89bf121d"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8e639ba5-13fb-4eb6-9539-f22edfcd0f55"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c18a9188-91f5-45c1-a9ba-503b22bb0c7e"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c97e341c-6b7c-4307-b074-8d20d4b5bac5"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cb859630-d1cd-4cc0-962e-b0c286be65a2"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d75da50e-b43e-4681-b746-8247f92eb782"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d832930a-b4c7-49d8-9b5d-289d0d60a52b"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e0ecc042-2953-446f-b3cf-e10783b00013"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e3bcf162-c41d-4d16-a989-6df245ba1aa9"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f565a3da-9902-4c75-9bf6-72bc26ab0acc"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f59b58c3-deaa-4646-9f73-e061eef3d68e"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fd480aff-d99e-4cc8-a6a3-2e4f388354ed"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fd5a6fe3-9f86-45a4-b538-cc19cb9ed66f"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("fe450712-ef95-4bdc-985a-564dfbc83b68"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "371d493f-9f44-42fc-a7b5-ce9d575c6fdb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "0b68840c-ba3d-4074-bbbd-3877226108a6");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "f698d31f-5eca-42d5-b977-b3b311551a1f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "5b801005-6b53-4b89-8e3d-67a74643e5bb");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("14afbd84-9085-40ac-9bd7-e78a67f9e9cd"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("8587f03a-0634-4d02-8f0c-241fd3842c91"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("9b38a97c-4210-40c3-98d5-135039a4909d"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("ad6d5081-539f-44b0-8218-87eae687230f"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576), "$2a$11$Lb.0b03Ce6biRRzPZAcGKu4dMM8x1q7ph160dSf63t5HPmS8HbC6.", new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576), "$2a$11$TK1nDD/keb1B6ktfPBpmUeVHjEED93ypCC/38mIlNPZTFbfyTg4cy", new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576), "$2a$11$7Gn/QKybAm3EOkhfXc9wwuR3s9zaGeIo1x7LxtBhiJJVy86XnuHoS", new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576), "$2a$11$L.3DAQmZf2ajgyC0WfP0UeiErJ56lHplmQjLb.YnJkMmtAKBAMSEi", new DateTime(2025, 12, 30, 14, 55, 11, 22, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804), new DateTime(2025, 12, 30, 14, 55, 11, 549, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_pickup_location_id",
                table: "bookings",
                column: "pickup_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_return_location_id",
                table: "bookings",
                column: "return_location_id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_locations_pickup_location_id",
                table: "bookings",
                column: "pickup_location_id",
                principalTable: "locations",
                principalColumn: "location_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_locations_return_location_id",
                table: "bookings",
                column: "return_location_id",
                principalTable: "locations",
                principalColumn: "location_id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
