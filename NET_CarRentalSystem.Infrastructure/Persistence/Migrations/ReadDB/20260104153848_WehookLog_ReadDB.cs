using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class WehookLog_ReadDB : Migration
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
                keyValue: new Guid("044fb944-848d-4946-9dc0-b9b39d7e8696"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("048ff89d-0ad2-408a-8d38-485f371dedbc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("09fc38fb-9fb1-46d4-90ba-c16ce9a68b2b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0d2fb9ca-0677-4924-aa96-5c3232fd0f9b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1909240c-4aed-42a3-950d-ffbcad8fd976"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("27283632-aae5-4e5f-aea1-86a58dc2bfd2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ccdfe62-1058-417b-8718-be75b2696ce1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30c47417-63be-484e-b202-7d7a4e7e99ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("347cf4d9-1e81-4963-a5c5-4b15470aecef"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("42c12d1d-d6cb-4c1b-bf81-a97ea3f414f1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("44535f95-c32f-497d-abc2-1721aadd277e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("45454cb0-33fa-478c-87af-f5646d8a3ef5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4f2670ae-dbdc-48f7-b390-1d51ef7beb97"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("603f0f0b-3131-4a10-b00b-1fe57c85103b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("637d7c0f-036d-4f2d-a1e6-0a2d220621ae"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("67b2fec4-9a21-469e-9a66-f28d5cedbe4d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("67d70c4d-1e2b-4223-86e2-4d024cd8dd77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6cb166df-98b4-45e2-bbda-952cb2a764b9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6ebfd42f-a1c6-4e84-996a-678b8cbc9a3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("735b1e98-4c1f-4116-b750-6f9e844cc135"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7938e5d7-e565-4985-8dbd-00670a649b29"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7e32a252-4167-479a-86a5-ee0f16ce7a2a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7ecc4c01-ef96-4c83-822a-15007325b818"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7fd46917-b845-44bc-abef-a240df0d16b3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88df1b68-4c21-4294-bed6-7559e458f66b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9361b11e-16be-4769-b8da-603f37cd2c89"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94b5408d-9f2b-49ed-a5fb-946e55bc10b2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9c1b2a60-7300-4155-8c6a-988d6a829c3d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9d00ebc1-dbf0-4da2-8d10-17cab8910052"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b0a87cab-69f0-4b8d-baae-173bc020f751"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b725f9f3-149f-464a-9d49-89186d7b46bf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bad80b0d-fb91-4ec2-8611-e31be5f6dfe0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c453140b-71c2-40e9-aa18-4175201e1141"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c903bfd6-04e8-4b81-b460-9055e2c95370"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cb66dfc7-d30d-4533-b1aa-78c38ca16b41"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d4f0d118-a1d6-4631-a9e6-7faee7e3d55b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d57eb4fe-76ca-4264-91b4-7553d51e375e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f0454075-e230-449b-a0cc-b6ea58446ce1"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("0ee09bf9-86a5-4dec-a3fe-4435620acbb0"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("5da79e82-96a7-4dcd-b148-7245e98f03bf"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("cc652839-54b6-447c-a9aa-c0b2f41230d8"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e5256268-2074-4744-a2b8-4fe6517163db"));

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
                name: "booking_read_flat",
                columns: table => new
                {
                    booking_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    booking_id_src = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customer_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    customer_email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    customer_phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    vehicle_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vehicle_price_per_hour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vehicle_model_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    number_plate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    vehicle_status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    location_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    actual_end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    total_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deposit_ratio = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    late_penalty_ratio = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    mileage_start = table.Column<int>(type: "int", nullable: false),
                    fuel_level_end = table.Column<int>(type: "int", nullable: true),
                    fuel_price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    condition_notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    booking_images_json = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_transactions_json = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metadata = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_booking_read_flat", x => x.booking_id);
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

            migrationBuilder.CreateIndex(
                name: "IX_booking_images_booking_id",
                table: "booking_images",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_images_public_id",
                table: "booking_images",
                column: "public_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_read_flat_booking_id",
                table: "booking_read_flat",
                column: "booking_id_src");

            migrationBuilder.CreateIndex(
                name: "IX_booking_read_flat_customer_id",
                table: "booking_read_flat",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_read_flat_start_date",
                table: "booking_read_flat",
                column: "start_date");

            migrationBuilder.CreateIndex(
                name: "IX_booking_read_flat_vehicle_id",
                table: "booking_read_flat",
                column: "vehicle_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_images");

            migrationBuilder.DropTable(
                name: "booking_read_flat");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "webhook_logs");

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
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(8056), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(8056), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(8056), new DateTime(2025, 12, 30, 15, 17, 29, 975, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 12, 30, 15, 17, 29, 976, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("044fb944-848d-4946-9dc0-b9b39d7e8696"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("048ff89d-0ad2-408a-8d38-485f371dedbc"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("09fc38fb-9fb1-46d4-90ba-c16ce9a68b2b"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0d2fb9ca-0677-4924-aa96-5c3232fd0f9b"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1909240c-4aed-42a3-950d-ffbcad8fd976"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("27283632-aae5-4e5f-aea1-86a58dc2bfd2"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ccdfe62-1058-417b-8718-be75b2696ce1"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("30c47417-63be-484e-b202-7d7a4e7e99ba"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("347cf4d9-1e81-4963-a5c5-4b15470aecef"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("42c12d1d-d6cb-4c1b-bf81-a97ea3f414f1"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("44535f95-c32f-497d-abc2-1721aadd277e"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("45454cb0-33fa-478c-87af-f5646d8a3ef5"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("4f2670ae-dbdc-48f7-b390-1d51ef7beb97"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("603f0f0b-3131-4a10-b00b-1fe57c85103b"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("637d7c0f-036d-4f2d-a1e6-0a2d220621ae"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("67b2fec4-9a21-469e-9a66-f28d5cedbe4d"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("67d70c4d-1e2b-4223-86e2-4d024cd8dd77"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6cb166df-98b4-45e2-bbda-952cb2a764b9"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("6ebfd42f-a1c6-4e84-996a-678b8cbc9a3e"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("735b1e98-4c1f-4116-b750-6f9e844cc135"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7938e5d7-e565-4985-8dbd-00670a649b29"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7e32a252-4167-479a-86a5-ee0f16ce7a2a"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7ecc4c01-ef96-4c83-822a-15007325b818"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("7fd46917-b845-44bc-abef-a240df0d16b3"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("88df1b68-4c21-4294-bed6-7559e458f66b"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9361b11e-16be-4769-b8da-603f37cd2c89"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("94b5408d-9f2b-49ed-a5fb-946e55bc10b2"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9c1b2a60-7300-4155-8c6a-988d6a829c3d"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9d00ebc1-dbf0-4da2-8d10-17cab8910052"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b0a87cab-69f0-4b8d-baae-173bc020f751"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b725f9f3-149f-464a-9d49-89186d7b46bf"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bad80b0d-fb91-4ec2-8611-e31be5f6dfe0"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c453140b-71c2-40e9-aa18-4175201e1141"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c903bfd6-04e8-4b81-b460-9055e2c95370"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("cb66dfc7-d30d-4533-b1aa-78c38ca16b41"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d4f0d118-a1d6-4631-a9e6-7faee7e3d55b"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d57eb4fe-76ca-4264-91b4-7553d51e375e"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f0454075-e230-449b-a0cc-b6ea58446ce1"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "cfdf4ead-1b77-463c-9411-08ab5c13b4f6");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "c4a1e084-e5c4-4615-b0da-adffc27621cd");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "710441ec-b7ca-42c5-831d-e07b15fa5215");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "3ab2f5f1-1cdf-4bb6-bb63-e2219e585b85");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0ee09bf9-86a5-4dec-a3fe-4435620acbb0"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("5da79e82-96a7-4dcd-b148-7245e98f03bf"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cc652839-54b6-447c-a9aa-c0b2f41230d8"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("e5256268-2074-4744-a2b8-4fe6517163db"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576), "$2a$11$OdaRwyt9XO9gm3kNKGreReYWleCjWBQl.2/gk5YEQ2SAnl6k59nxK", new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576), "$2a$11$c.nUXkmepL1bo8oSK3.OTegEJUg5yBVYKPjlTkVD56z.Pg9FoNx26", new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576), "$2a$11$QkzitPIvV.WxDqECvRdi1uReoqFTxnWgvZpL0RC7Ea02wZu3y7.IW", new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576), "$2a$11$M41I4QDDjPRKGQ35zS2XJuiB6OJv64sLRsKeM/thnnM8Uamsypvy2", new DateTime(2025, 12, 30, 15, 17, 29, 986, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644), new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644), new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644), new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644), new DateTime(2025, 12, 30, 15, 17, 30, 570, DateTimeKind.Utc).AddTicks(7644) });

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
