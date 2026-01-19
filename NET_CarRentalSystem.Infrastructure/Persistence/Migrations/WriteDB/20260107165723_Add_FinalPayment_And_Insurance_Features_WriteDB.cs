using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Add_FinalPayment_And_Insurance_Features_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "LoyaltyPoints",
                table: "customers",
                newName: "loyalty_points");

            migrationBuilder.AddColumn<DateTime>(
                name: "last_available_at",
                table: "vehicle_models",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "loyalty_points",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "is_renting",
                table: "customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "accepted_terms_at",
                table: "bookings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "accepted_terms_version",
                table: "bookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "bookings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "insurance_packages",
                columns: table => new
                {
                    insurance_package_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    coverage_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    coverage_details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    display_order = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insurance_packages", x => x.insurance_package_id);
                });

            migrationBuilder.CreateTable(
                name: "terms_and_conditions",
                columns: table => new
                {
                    terms_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    effective_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_terms_and_conditions", x => x.terms_id);
                });

            migrationBuilder.CreateTable(
                name: "booking_insurances",
                columns: table => new
                {
                    booking_insurance_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    booking_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    insurance_package_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_insurances", x => x.booking_insurance_id);
                    table.ForeignKey(
                        name: "FK_booking_insurances_bookings_booking_id",
                        column: x => x.booking_id,
                        principalTable: "bookings",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_booking_insurances_insurance_packages_insurance_package_id",
                        column: x => x.insurance_package_id,
                        principalTable: "insurance_packages",
                        principalColumn: "insurance_package_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902), new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902), new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902), new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902), new DateTime(2026, 1, 7, 16, 57, 21, 860, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 861, DateTimeKind.Utc).AddTicks(4182), new DateTime(2026, 1, 7, 16, 57, 21, 861, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 861, DateTimeKind.Utc).AddTicks(4182), new DateTime(2026, 1, 7, 16, 57, 21, 861, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 861, DateTimeKind.Utc).AddTicks(4182), new DateTime(2026, 1, 7, 16, 57, 21, 861, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.InsertData(
                table: "insurance_packages",
                columns: new[] { "insurance_package_id", "coverage_amount", "coverage_details", "created_at", "created_by", "deleted_at", "deleted_by", "description", "display_order", "is_active", "is_deleted", "name", "price", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 50000000m, "- Bảo hiểm trách nhiệm dân sự bên thứ 3\n- Thiệt hại tài sản tối đa 50 triệu\n- Chi phí y tế cơ bản\n- Hỗ trợ pháp lý 24/7", new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(1587), null, null, null, "Bảo hiểm trách nhiệm dân sự bắt buộc, bảo vệ bạn trước các chi phí pháp lý cơ bản.", 1, true, false, "Bảo hiểm cơ bản", 50000m, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 100000000m, "- Tất cả quyền lợi gói Cơ bản\n- Bảo hiểm vật chất xe\n- Bảo hiểm tai nạn lái xe và hành khách\n- Hỗ trợ cứu hộ 24/7\n- Không khấu trừ khi xảy ra sự cố", new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(1591), null, null, null, "Bảo vệ toàn diện cho xe và hành khách với mức bồi thường cao hơn.", 2, true, false, "Bảo hiểm tiêu chuẩn", 100000m, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 200000000m, "- Tất cả quyền lợi gói Tiêu chuẩn\n- Bảo hiểm mất trộm xe\n- Bảo hiểm thiên tai, hỏa hoạn\n- Xe thay thế khi sửa chữa\n- Bồi thường không giới hạn cho bên thứ 3\n- Hỗ trợ VIP 24/7", new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(1593), null, null, null, "Gói bảo hiểm toàn diện nhất với mức bồi thường tối đa và nhiều quyền lợi đặc biệt.", 3, true, false, "Bảo hiểm cao cấp", 200000m, null, null }
                });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078), new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078), new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078), new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078), new DateTime(2026, 1, 7, 16, 57, 21, 862, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("00f1df71-8fa0-4833-856e-0aec7a577602"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("02e3445c-1224-4dd2-9f1e-ff726a5d5f72"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("04edbbad-e7b3-4f0a-bf5c-bf471a17a9c9"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0c47f548-2c95-4cb7-aec4-2fe37570220c"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1471a920-0f21-4b07-a503-9cdb478bd45c"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16dd92a8-5aab-4a96-8fc5-76f70b233b3b"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1d4a1902-d13c-42af-94a0-2a31ec8cb986"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("22b748ed-9142-4244-85c5-914d64c86031"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("22d7435b-593d-493d-9fff-4f3b3bd83de0"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("23df3626-0407-4602-877c-bc6c032d8d40"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2541b577-0bd8-4c38-bceb-5c3eaf579e48"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("270cf0dc-a4fe-496e-8e10-0b7dceb76437"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2c967763-8f0d-4769-bfa2-c7783d838843"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("32b8491f-0984-459e-9c83-0f08b195dfb5"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3932eedc-342f-4dbe-bff1-a898384c3d1c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("39d5891d-604a-4577-81cf-cfd122f6dfe5"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("45e6344c-6965-44be-bd88-018b73f2fad7"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("46d460f8-7210-4878-9f42-205d540dc19b"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4a8ed742-3e0c-4cf7-aa4a-032059fe98c7"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4b53104b-009d-462f-b163-13085ba48508"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4dc43fb1-29de-43dd-9c44-16efd68257da"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6060803a-0b34-4ff6-8ef4-4c430fced597"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66084651-ac03-44c8-817e-85f39b7fbca5"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("684c2a7c-5d52-4cee-92f0-28ff686097e1"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("69580004-dd89-47a8-8e53-bdd7990155bd"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("70fa48e0-6bc8-498a-878b-de7825077ba6"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("79387447-be3f-4621-91c0-abb72c4b34bf"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("85004a0e-07bc-41b9-af54-e0de20ba3c9f"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("864a5a8e-8a88-4ad1-a8ed-e719a42eed71"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("902d7838-19f6-4db1-9e20-176f5898b6e9"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("972199eb-7118-4758-b984-db622a0207aa"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a5b3fa1d-7ff5-47f9-b394-1238d6bd63fa"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("b603c09f-400b-4c73-99f5-fe09c7aedb85"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("be818b49-d520-4a77-b8b1-2cb51fff0035"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c2812f5a-842f-4dbb-8be3-490926211b94"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c9551cc9-7c3d-4872-8407-0363a500430e"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e09a73cd-b61b-4015-97dd-a386b3c30799"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f34b9293-d9cb-471a-a921-315d8520c653"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f6e71979-e05b-4e42-b63c-6d03eea43a73"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "41038979-aa93-413b-91dc-18b2f17be991");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "fbda937f-dcbf-407b-9f2c-30d38216aef4");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "f5a16d8d-2723-468d-b731-9b03d12bdf1f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c20ab027-ce4f-4183-a222-ccb8a6f55518");

            migrationBuilder.InsertData(
                table: "terms_and_conditions",
                columns: new[] { "terms_id", "content", "created_at", "created_by", "deleted_at", "deleted_by", "effective_date", "is_active", "is_deleted", "title", "type", "updated_at", "updated_by", "version" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), "<h2>1. ĐIỀU KIỆN THUÊ XE</h2>\r\n<p>Khách hàng phải đáp ứng các điều kiện sau:</p>\r\n<ul>\r\n    <li>Tuổi từ 21 trở lên</li>\r\n    <li>Có giấy phép lái xe hợp lệ còn hiệu lực ít nhất 1 năm</li>\r\n    <li>Có CCCD/CMND còn hiệu lực</li>\r\n    <li>Đặt cọc theo quy định</li>\r\n</ul>\r\n\r\n<h2>2. QUY ĐỊNH VỀ ĐẶT CỌC</h2>\r\n<p>Khách hàng phải đặt cọc 30% giá trị hợp đồng khi đặt xe. Tiền cọc sẽ được hoàn trả sau khi trả xe và kiểm tra tình trạng xe.</p>\r\n\r\n<h2>3. TRÁCH NHIỆM CỦA KHÁCH HÀNG</h2>\r\n<ul>\r\n    <li>Sử dụng xe đúng mục đích đã đăng ký</li>\r\n    <li>Không cho người khác mượn xe</li>\r\n    <li>Không sử dụng xe vào mục đích vi phạm pháp luật</li>\r\n    <li>Bảo quản xe cẩn thận, không hút thuốc trong xe</li>\r\n    <li>Đổ đúng loại nhiên liệu theo quy định</li>\r\n    <li>Trả xe đúng hạn và đúng địa điểm</li>\r\n</ul>\r\n\r\n<h2>4. PHÍ PHẠT</h2>\r\n<ul>\r\n    <li>Trả xe trễ: 50.000đ/giờ (tối đa 500.000đ/ngày)</li>\r\n    <li>Thiếu xăng: Theo giá thị trường + 20% phí dịch vụ</li>\r\n    <li>Hư hỏng xe: Theo đánh giá thực tế</li>\r\n    <li>Mất xe: Đền bù 100% giá trị xe</li>\r\n</ul>\r\n\r\n<h2>5. CHÍNH SÁCH HỦY ĐẶT XE</h2>\r\n<ul>\r\n    <li>Hủy trước 24h: Hoàn 100% tiền cọc</li>\r\n    <li>Hủy trong vòng 24h: Hoàn 50% tiền cọc</li>\r\n    <li>Không đến nhận xe: Mất 100% tiền cọc</li>\r\n</ul>\r\n\r\n<h2>6. ĐIỀU KHOẢN KHÁC</h2>\r\n<p>Renticar có quyền từ chối cho thuê xe nếu khách hàng không đáp ứng các điều kiện trên hoặc có hành vi không phù hợp.</p>", new DateTime(2026, 1, 7, 16, 57, 21, 868, DateTimeKind.Utc).AddTicks(8982), null, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "Điều Khoản và Điều Kiện Thuê Xe", "Booking", null, null, "v1.0.0" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "<h2>1. PHẠM VI BẢO HIỂM</h2>\r\n<p>Bảo hiểm chỉ có hiệu lực trong thời gian thuê xe và trong phạm vi lãnh thổ Việt Nam.</p>\r\n\r\n<h2>2. CÁC TRƯỜNG HỢP ĐƯỢC BẢO HIỂM</h2>\r\n<ul>\r\n    <li>Tai nạn giao thông</li>\r\n    <li>Va chạm với phương tiện khác</li>\r\n    <li>Thiệt hại do thiên tai (gói Premium)</li>\r\n    <li>Mất trộm xe (gói Premium)</li>\r\n</ul>\r\n\r\n<h2>3. CÁC TRƯỜNG HỢP KHÔNG ĐƯỢC BẢO HIỂM</h2>\r\n<ul>\r\n    <li>Lái xe khi say rượu bia hoặc sử dụng chất kích thích</li>\r\n    <li>Cố ý gây thiệt hại</li>\r\n    <li>Sử dụng xe vào mục đích bất hợp pháp</li>\r\n    <li>Cho người không có giấy phép lái xe</li>\r\n</ul>\r\n\r\n<h2>4. THỦ TỤC YÊU CẦU BỒI THƯỜNG</h2>\r\n<p>Khi xảy ra sự cố, khách hàng cần:</p>\r\n<ul>\r\n    <li>Liên hệ hotline ngay lập tức</li>\r\n    <li>Không di chuyển xe khỏi hiện trường (nếu có thể)</li>\r\n    <li>Chụp ảnh hiện trường</li>\r\n    <li>Lập biên bản với cơ quan chức năng (nếu cần)</li>\r\n</ul>", new DateTime(2026, 1, 7, 16, 57, 21, 868, DateTimeKind.Utc).AddTicks(8987), null, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "Điều Khoản Bảo Hiểm Xe", "Insurance", null, null, "v1.0.0" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "<h2>1. GIỚI THIỆU</h2>\r\n<p>Chào mừng bạn đến với Renticar - dịch vụ cho thuê xe hàng đầu Việt Nam.</p>\r\n\r\n<h2>2. QUYỀN RIÊNG TƯ</h2>\r\n<p>Chúng tôi cam kết bảo vệ thông tin cá nhân của khách hàng theo quy định của pháp luật.</p>\r\n\r\n<h2>3. QUYỀN SỞ HỮU TRÍ TUỆ</h2>\r\n<p>Tất cả nội dung trên website thuộc quyền sở hữu của Renticar.</p>\r\n\r\n<h2>4. LIÊN HỆ</h2>\r\n<p>Mọi thắc mắc xin liên hệ:</p>\r\n<ul>\r\n    <li>Hotline: 1900 xxxx</li>\r\n    <li>Email: support@renticar.vn</li>\r\n</ul>", new DateTime(2026, 1, 7, 16, 57, 21, 868, DateTimeKind.Utc).AddTicks(8989), null, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "Điều Khoản Sử Dụng Chung", "General", null, null, "v1.0.0" }
                });

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("4cf69930-e8ae-47e2-be25-0fcef3466044"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("9cc05aee-319f-4356-b5d4-46349c181376"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("b8a44be1-a79b-467b-bf1b-265db22e5732"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("d7797883-29f0-4851-9dd4-cb3bf649548e"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170), "$2a$11$JRzl6dY5lA.GY4hIN96akeg4jQCtSiZVfHYrm3YATGrq8hlua1Z6q", new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170), "$2a$11$PEgMAFYyTw.5rwI8PWytXe7sBJU1ZAbYA5JHyu6s8zDomO42dv70W", new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170), "$2a$11$JIz1Z2Qzyn3camsENzMpo.0JQqmspSu2kv7lnIz4lkOQ8KCE9kdgi", new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170), "$2a$11$GmjimnlURroz.8iwfO4y4Ot0mDYXVGITdCCNs5XXk3cyuZLI5/UJW", new DateTime(2026, 1, 7, 16, 57, 21, 872, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116), new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116), new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116), new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116), new DateTime(2026, 1, 7, 16, 57, 22, 397, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.CreateIndex(
                name: "IX_booking_insurances_booking_id",
                table: "booking_insurances",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_insurances_insurance_package_id",
                table: "booking_insurances",
                column: "insurance_package_id");

            migrationBuilder.CreateIndex(
                name: "IX_terms_and_conditions_type_version_is_active",
                table: "terms_and_conditions",
                columns: new[] { "type", "version", "is_active" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_insurances");

            migrationBuilder.DropTable(
                name: "terms_and_conditions");

            migrationBuilder.DropTable(
                name: "insurance_packages");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("00f1df71-8fa0-4833-856e-0aec7a577602"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("02e3445c-1224-4dd2-9f1e-ff726a5d5f72"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04edbbad-e7b3-4f0a-bf5c-bf471a17a9c9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c47f548-2c95-4cb7-aec4-2fe37570220c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1471a920-0f21-4b07-a503-9cdb478bd45c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16dd92a8-5aab-4a96-8fc5-76f70b233b3b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d4a1902-d13c-42af-94a0-2a31ec8cb986"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22b748ed-9142-4244-85c5-914d64c86031"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("22d7435b-593d-493d-9fff-4f3b3bd83de0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23df3626-0407-4602-877c-bc6c032d8d40"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2541b577-0bd8-4c38-bceb-5c3eaf579e48"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("270cf0dc-a4fe-496e-8e10-0b7dceb76437"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2c967763-8f0d-4769-bfa2-c7783d838843"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32b8491f-0984-459e-9c83-0f08b195dfb5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3932eedc-342f-4dbe-bff1-a898384c3d1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("39d5891d-604a-4577-81cf-cfd122f6dfe5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("45e6344c-6965-44be-bd88-018b73f2fad7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("46d460f8-7210-4878-9f42-205d540dc19b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4a8ed742-3e0c-4cf7-aa4a-032059fe98c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4b53104b-009d-462f-b163-13085ba48508"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4dc43fb1-29de-43dd-9c44-16efd68257da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6060803a-0b34-4ff6-8ef4-4c430fced597"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66084651-ac03-44c8-817e-85f39b7fbca5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("684c2a7c-5d52-4cee-92f0-28ff686097e1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("69580004-dd89-47a8-8e53-bdd7990155bd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("70fa48e0-6bc8-498a-878b-de7825077ba6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79387447-be3f-4621-91c0-abb72c4b34bf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("85004a0e-07bc-41b9-af54-e0de20ba3c9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("864a5a8e-8a88-4ad1-a8ed-e719a42eed71"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("902d7838-19f6-4db1-9e20-176f5898b6e9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("972199eb-7118-4758-b984-db622a0207aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a5b3fa1d-7ff5-47f9-b394-1238d6bd63fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b603c09f-400b-4c73-99f5-fe09c7aedb85"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be818b49-d520-4a77-b8b1-2cb51fff0035"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2812f5a-842f-4dbb-8be3-490926211b94"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c9551cc9-7c3d-4872-8407-0363a500430e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e09a73cd-b61b-4015-97dd-a386b3c30799"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f34b9293-d9cb-471a-a921-315d8520c653"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f6e71979-e05b-4e42-b63c-6d03eea43a73"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("4cf69930-e8ae-47e2-be25-0fcef3466044"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9cc05aee-319f-4356-b5d4-46349c181376"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b8a44be1-a79b-467b-bf1b-265db22e5732"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d7797883-29f0-4851-9dd4-cb3bf649548e"));

            migrationBuilder.DropColumn(
                name: "last_available_at",
                table: "vehicle_models");

            migrationBuilder.DropColumn(
                name: "is_renting",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "accepted_terms_at",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "accepted_terms_version",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "status",
                table: "bookings");

            migrationBuilder.RenameColumn(
                name: "loyalty_points",
                table: "customers",
                newName: "LoyaltyPoints");

            migrationBuilder.AlterColumn<int>(
                name: "LoyaltyPoints",
                table: "customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

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
        }
    }
}
