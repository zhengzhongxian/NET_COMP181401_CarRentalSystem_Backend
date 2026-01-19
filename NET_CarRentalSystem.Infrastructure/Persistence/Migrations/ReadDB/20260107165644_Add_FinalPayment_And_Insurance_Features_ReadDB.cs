using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Add_FinalPayment_And_Insurance_Features_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "discount_rate",
                table: "booking_read_flat",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "booking_read_flat",
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
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(7240), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(7240), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(7240), new DateTime(2026, 1, 7, 16, 56, 43, 677, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.InsertData(
                table: "insurance_packages",
                columns: new[] { "insurance_package_id", "coverage_amount", "coverage_details", "created_at", "created_by", "deleted_at", "deleted_by", "description", "display_order", "is_active", "is_deleted", "name", "price", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 50000000m, "- Bảo hiểm trách nhiệm dân sự bên thứ 3\n- Thiệt hại tài sản tối đa 50 triệu\n- Chi phí y tế cơ bản\n- Hỗ trợ pháp lý 24/7", new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(1722), null, null, null, "Bảo hiểm trách nhiệm dân sự bắt buộc, bảo vệ bạn trước các chi phí pháp lý cơ bản.", 1, true, false, "Bảo hiểm cơ bản", 50000m, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 100000000m, "- Tất cả quyền lợi gói Cơ bản\n- Bảo hiểm vật chất xe\n- Bảo hiểm tai nạn lái xe và hành khách\n- Hỗ trợ cứu hộ 24/7\n- Không khấu trừ khi xảy ra sự cố", new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(1724), null, null, null, "Bảo vệ toàn diện cho xe và hành khách với mức bồi thường cao hơn.", 2, true, false, "Bảo hiểm tiêu chuẩn", 100000m, null, null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 200000000m, "- Tất cả quyền lợi gói Tiêu chuẩn\n- Bảo hiểm mất trộm xe\n- Bảo hiểm thiên tai, hỏa hoạn\n- Xe thay thế khi sửa chữa\n- Bồi thường không giới hạn cho bên thứ 3\n- Hỗ trợ VIP 24/7", new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(1726), null, null, null, "Gói bảo hiểm toàn diện nhất với mức bồi thường tối đa và nhiều quyền lợi đặc biệt.", 3, true, false, "Bảo hiểm cao cấp", 200000m, null, null }
                });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441), new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441), new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441), new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441), new DateTime(2026, 1, 7, 16, 56, 43, 678, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("140f839e-1660-4e30-aae9-d448445fdafb"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1811bff1-9420-4d5a-97ca-e8e621be8912"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1e40a464-2fe2-4bc6-97f8-694165f55bdd"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1f5d0279-1a33-4aef-b1b3-a32dd6cfe66d"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("20cdd478-c43a-4c81-8d82-b653d0e939a4"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("236789f9-74af-49f8-b836-534e9fe17241"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("297d088c-a8f8-4986-b45d-fadc76146816"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2a9df9f6-3793-4741-a661-2bf04e858547"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("32af3fbc-78d4-43d9-913e-b2c47d3a12dc"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("337afea8-572c-48dd-a00d-0f9b99ee2acb"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("342e3d04-d894-40af-8e77-a0a5afc88af0"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3cce2c79-50d1-405e-b75e-0484695f3e1f"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("4c8226d5-b554-4e3b-adb4-821d0263ac10"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("509c681a-d0f8-45a1-9e2e-e3c73eb7204c"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5aa78f5a-45af-44b6-a279-3b8a93b72a6b"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5d02e865-d713-4251-898e-5678f45c61fe"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6e9c42ea-676e-4e02-9ccc-a4bc75fa83c8"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("79d8b6db-5d05-44f5-81be-e95e4c53c507"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7d0e3d2e-92a2-4818-869d-5fd30d292052"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7dabf0d0-d6ea-43af-a5cb-fbae4decab86"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7e4f7c89-c388-4305-a211-6d65c40681ba"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7f1632a6-c873-45bc-b3c9-2714e635a897"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("876e8fbe-f4f3-406f-99fd-c2b8413c36c6"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("87a3622a-c28e-49fb-91df-40d24452edd6"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8aac643c-e652-44ec-bad4-febcceaaab28"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad1af440-03a1-4af5-9307-a8f9dffb2dbb"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b2eb169a-23c2-4809-a455-fe4f1a63c302"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b5381bdd-2136-4588-9474-b494c7c9df01"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b6dd6829-9d1a-4e37-b673-3ebd460d9a4b"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c13bf40d-d022-4206-89f1-d1ea09cbddfc"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c5a53d38-9f08-455f-b324-31bf6fb4b349"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c5adf778-c165-49e5-b1a3-a36ed753689f"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cc3ed22f-01da-4c1c-b004-5b445cb01e5f"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cedb739e-24bf-49fe-86e4-486ece05537b"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d0fc627a-a95c-4825-9664-2ad9f36c1c17"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e5047bbb-2dd8-4cda-b6c4-e5923fa9c94a"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f03801bc-c601-44c7-98bb-21c605c655b1"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("fa38ace9-47de-4fcd-9df2-36a8a7edd57b"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fe0b3c16-9379-40c6-b801-0b0aeb178dd7"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "e7beef9c-af2d-45ec-aa38-b85474fd8e7c");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "4e51ee53-5714-4cf4-843f-dcaaa07d87af");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "4b100aa7-2782-4ec0-949c-bcdc9b709a5d");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "66c6ff86-d041-4b6d-8595-8b9fa989d6fb");

            migrationBuilder.InsertData(
                table: "terms_and_conditions",
                columns: new[] { "terms_id", "content", "created_at", "created_by", "deleted_at", "deleted_by", "effective_date", "is_active", "is_deleted", "title", "type", "updated_at", "updated_by", "version" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), "<h2>1. ĐIỀU KIỆN THUÊ XE</h2>\r\n<p>Khách hàng phải đáp ứng các điều kiện sau:</p>\r\n<ul>\r\n    <li>Tuổi từ 21 trở lên</li>\r\n    <li>Có giấy phép lái xe hợp lệ còn hiệu lực ít nhất 1 năm</li>\r\n    <li>Có CCCD/CMND còn hiệu lực</li>\r\n    <li>Đặt cọc theo quy định</li>\r\n</ul>\r\n\r\n<h2>2. QUY ĐỊNH VỀ ĐẶT CỌC</h2>\r\n<p>Khách hàng phải đặt cọc 30% giá trị hợp đồng khi đặt xe. Tiền cọc sẽ được hoàn trả sau khi trả xe và kiểm tra tình trạng xe.</p>\r\n\r\n<h2>3. TRÁCH NHIỆM CỦA KHÁCH HÀNG</h2>\r\n<ul>\r\n    <li>Sử dụng xe đúng mục đích đã đăng ký</li>\r\n    <li>Không cho người khác mượn xe</li>\r\n    <li>Không sử dụng xe vào mục đích vi phạm pháp luật</li>\r\n    <li>Bảo quản xe cẩn thận, không hút thuốc trong xe</li>\r\n    <li>Đổ đúng loại nhiên liệu theo quy định</li>\r\n    <li>Trả xe đúng hạn và đúng địa điểm</li>\r\n</ul>\r\n\r\n<h2>4. PHÍ PHẠT</h2>\r\n<ul>\r\n    <li>Trả xe trễ: 50.000đ/giờ (tối đa 500.000đ/ngày)</li>\r\n    <li>Thiếu xăng: Theo giá thị trường + 20% phí dịch vụ</li>\r\n    <li>Hư hỏng xe: Theo đánh giá thực tế</li>\r\n    <li>Mất xe: Đền bù 100% giá trị xe</li>\r\n</ul>\r\n\r\n<h2>5. CHÍNH SÁCH HỦY ĐẶT XE</h2>\r\n<ul>\r\n    <li>Hủy trước 24h: Hoàn 100% tiền cọc</li>\r\n    <li>Hủy trong vòng 24h: Hoàn 50% tiền cọc</li>\r\n    <li>Không đến nhận xe: Mất 100% tiền cọc</li>\r\n</ul>\r\n\r\n<h2>6. ĐIỀU KHOẢN KHÁC</h2>\r\n<p>Renticar có quyền từ chối cho thuê xe nếu khách hàng không đáp ứng các điều kiện trên hoặc có hành vi không phù hợp.</p>", new DateTime(2026, 1, 7, 16, 56, 43, 682, DateTimeKind.Utc).AddTicks(7993), null, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "Điều Khoản và Điều Kiện Thuê Xe", "Booking", null, null, "v1.0.0" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "<h2>1. PHẠM VI BẢO HIỂM</h2>\r\n<p>Bảo hiểm chỉ có hiệu lực trong thời gian thuê xe và trong phạm vi lãnh thổ Việt Nam.</p>\r\n\r\n<h2>2. CÁC TRƯỜNG HỢP ĐƯỢC BẢO HIỂM</h2>\r\n<ul>\r\n    <li>Tai nạn giao thông</li>\r\n    <li>Va chạm với phương tiện khác</li>\r\n    <li>Thiệt hại do thiên tai (gói Premium)</li>\r\n    <li>Mất trộm xe (gói Premium)</li>\r\n</ul>\r\n\r\n<h2>3. CÁC TRƯỜNG HỢP KHÔNG ĐƯỢC BẢO HIỂM</h2>\r\n<ul>\r\n    <li>Lái xe khi say rượu bia hoặc sử dụng chất kích thích</li>\r\n    <li>Cố ý gây thiệt hại</li>\r\n    <li>Sử dụng xe vào mục đích bất hợp pháp</li>\r\n    <li>Cho người không có giấy phép lái xe</li>\r\n</ul>\r\n\r\n<h2>4. THỦ TỤC YÊU CẦU BỒI THƯỜNG</h2>\r\n<p>Khi xảy ra sự cố, khách hàng cần:</p>\r\n<ul>\r\n    <li>Liên hệ hotline ngay lập tức</li>\r\n    <li>Không di chuyển xe khỏi hiện trường (nếu có thể)</li>\r\n    <li>Chụp ảnh hiện trường</li>\r\n    <li>Lập biên bản với cơ quan chức năng (nếu cần)</li>\r\n</ul>", new DateTime(2026, 1, 7, 16, 56, 43, 682, DateTimeKind.Utc).AddTicks(7997), null, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "Điều Khoản Bảo Hiểm Xe", "Insurance", null, null, "v1.0.0" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "<h2>1. GIỚI THIỆU</h2>\r\n<p>Chào mừng bạn đến với Renticar - dịch vụ cho thuê xe hàng đầu Việt Nam.</p>\r\n\r\n<h2>2. QUYỀN RIÊNG TƯ</h2>\r\n<p>Chúng tôi cam kết bảo vệ thông tin cá nhân của khách hàng theo quy định của pháp luật.</p>\r\n\r\n<h2>3. QUYỀN SỞ HỮU TRÍ TUỆ</h2>\r\n<p>Tất cả nội dung trên website thuộc quyền sở hữu của Renticar.</p>\r\n\r\n<h2>4. LIÊN HỆ</h2>\r\n<p>Mọi thắc mắc xin liên hệ:</p>\r\n<ul>\r\n    <li>Hotline: 1900 xxxx</li>\r\n    <li>Email: support@renticar.vn</li>\r\n</ul>", new DateTime(2026, 1, 7, 16, 56, 43, 682, DateTimeKind.Utc).AddTicks(7998), null, null, null, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "Điều Khoản Sử Dụng Chung", "General", null, null, "v1.0.0" }
                });

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("3f8027e6-aba5-4388-81e4-bed85712c3e5"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("4f019552-3eee-4097-ba0e-1086af312831"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("8569a6a6-1cd0-42d9-a00c-61421c6935ac"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("d35a30d5-173b-4a3c-a0f3-12437d4a7302"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212), "$2a$11$6amXexR4ns21Dj2G3arhledrOJWEN7CLwTaFhvs/D4b8FrlnAvDCW", new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212), "$2a$11$SHv.LxDhbqGV34RZM.4HFuTEExsJ4icy9BD2uleDJuEcf2cKu3vBC", new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212), "$2a$11$YpENJz9F0.rg9A4jdBBSVOWBcTznwg.QJpSjMaqMfYiDjeroKP95u", new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212), "$2a$11$7SZ9nMBaI9hF5T0YlvqvR.DNDM5Ejfo4q5zXCP8kAJj5Kq8nkZ0oW", new DateTime(2026, 1, 7, 16, 56, 43, 684, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480), new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480), new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480), new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480), new DateTime(2026, 1, 7, 16, 56, 44, 172, DateTimeKind.Utc).AddTicks(9480) });

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
                keyValue: new Guid("140f839e-1660-4e30-aae9-d448445fdafb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1811bff1-9420-4d5a-97ca-e8e621be8912"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e40a464-2fe2-4bc6-97f8-694165f55bdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1f5d0279-1a33-4aef-b1b3-a32dd6cfe66d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20cdd478-c43a-4c81-8d82-b653d0e939a4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("236789f9-74af-49f8-b836-534e9fe17241"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("297d088c-a8f8-4986-b45d-fadc76146816"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2a9df9f6-3793-4741-a661-2bf04e858547"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32af3fbc-78d4-43d9-913e-b2c47d3a12dc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("337afea8-572c-48dd-a00d-0f9b99ee2acb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("342e3d04-d894-40af-8e77-a0a5afc88af0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3cce2c79-50d1-405e-b75e-0484695f3e1f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4c8226d5-b554-4e3b-adb4-821d0263ac10"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("509c681a-d0f8-45a1-9e2e-e3c73eb7204c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5aa78f5a-45af-44b6-a279-3b8a93b72a6b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5d02e865-d713-4251-898e-5678f45c61fe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6e9c42ea-676e-4e02-9ccc-a4bc75fa83c8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79d8b6db-5d05-44f5-81be-e95e4c53c507"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d0e3d2e-92a2-4818-869d-5fd30d292052"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7dabf0d0-d6ea-43af-a5cb-fbae4decab86"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7e4f7c89-c388-4305-a211-6d65c40681ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7f1632a6-c873-45bc-b3c9-2714e635a897"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("876e8fbe-f4f3-406f-99fd-c2b8413c36c6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("87a3622a-c28e-49fb-91df-40d24452edd6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8aac643c-e652-44ec-bad4-febcceaaab28"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad1af440-03a1-4af5-9307-a8f9dffb2dbb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b2eb169a-23c2-4809-a455-fe4f1a63c302"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b5381bdd-2136-4588-9474-b494c7c9df01"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b6dd6829-9d1a-4e37-b673-3ebd460d9a4b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c13bf40d-d022-4206-89f1-d1ea09cbddfc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c5a53d38-9f08-455f-b324-31bf6fb4b349"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c5adf778-c165-49e5-b1a3-a36ed753689f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cc3ed22f-01da-4c1c-b004-5b445cb01e5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cedb739e-24bf-49fe-86e4-486ece05537b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0fc627a-a95c-4825-9664-2ad9f36c1c17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e5047bbb-2dd8-4cda-b6c4-e5923fa9c94a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f03801bc-c601-44c7-98bb-21c605c655b1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fa38ace9-47de-4fcd-9df2-36a8a7edd57b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe0b3c16-9379-40c6-b801-0b0aeb178dd7"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3f8027e6-aba5-4388-81e4-bed85712c3e5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("4f019552-3eee-4097-ba0e-1086af312831"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8569a6a6-1cd0-42d9-a00c-61421c6935ac"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d35a30d5-173b-4a3c-a0f3-12437d4a7302"));

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

            migrationBuilder.DropColumn(
                name: "discount_rate",
                table: "booking_read_flat");

            migrationBuilder.DropColumn(
                name: "status",
                table: "booking_read_flat");

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
    }
}
