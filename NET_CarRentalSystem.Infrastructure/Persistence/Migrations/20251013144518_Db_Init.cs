using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Db_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fuels",
                columns: table => new
                {
                    fuel_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fuels", x => x.fuel_id);
                });

            migrationBuilder.CreateTable(
                name: "transmissions",
                columns: table => new
                {
                    transmission_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transmissions", x => x.transmission_id);
                });

            migrationBuilder.CreateTable(
                name: "vehicle_categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    category_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    seat = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    vehicle_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    number_plate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mileage = table.Column<int>(type: "int", nullable: false),
                    price_per_hour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_checkout_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    rating = table.Column<float>(type: "real", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    condition_notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    real_time_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location_id = table.Column<int>(type: "int", nullable: true),
                    metadata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fuel_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    transmission_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.vehicle_id);
                    table.ForeignKey(
                        name: "FK_vehicles_fuels_fuel_id",
                        column: x => x.fuel_id,
                        principalTable: "fuels",
                        principalColumn: "fuel_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_vehicles_transmissions_transmission_id",
                        column: x => x.transmission_id,
                        principalTable: "transmissions",
                        principalColumn: "transmission_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_vehicles_vehicle_categories_vehicle_category_id",
                        column: x => x.vehicle_category_id,
                        principalTable: "vehicle_categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "fuels",
                columns: new[] { "fuel_id", "created_at", "created_by", "description", "is_deleted", "name", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), new DateTime(2025, 10, 13, 14, 45, 18, 302, DateTimeKind.Utc).AddTicks(6120), null, "Sử dụng năng lượng điện", false, "Electric", null, null },
                    { new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), new DateTime(2025, 10, 13, 14, 45, 18, 302, DateTimeKind.Utc).AddTicks(6114), null, "Sử dụng xăng", false, "Gasoline", null, null },
                    { new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), new DateTime(2025, 10, 13, 14, 45, 18, 302, DateTimeKind.Utc).AddTicks(6117), null, "Sử dụng dầu Diesel", false, "Diesel", null, null }
                });

            migrationBuilder.InsertData(
                table: "transmissions",
                columns: new[] { "transmission_id", "code", "description", "name" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), "AT", "Hộp số tự động", "Automatic Transmission" },
                    { new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), "MT", "Hộp số sàn", "Manual Transmission" }
                });

            migrationBuilder.InsertData(
                table: "vehicle_categories",
                columns: new[] { "CategoryId", "category_code", "created_at", "created_by", "description", "is_deleted", "seat", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"), "SEDAN", new DateTime(2025, 10, 13, 14, 45, 18, 304, DateTimeKind.Utc).AddTicks(227), null, "Xe sedan 4-5 chỗ, phổ thông", false, 5, null, null },
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"), "SUV", new DateTime(2025, 10, 13, 14, 45, 18, 304, DateTimeKind.Utc).AddTicks(234), null, "Xe thể thao đa dụng, gầm cao", false, 7, null, null },
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"), "HATCHBACK", new DateTime(2025, 10, 13, 14, 45, 18, 304, DateTimeKind.Utc).AddTicks(235), null, "Xe cỡ nhỏ cho đô thị", false, 5, null, null },
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"), "MINIVAN", new DateTime(2025, 10, 13, 14, 45, 18, 304, DateTimeKind.Utc).AddTicks(237), null, "Xe gia đình, rộng rãi", false, 7, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_fuel_id",
                table: "vehicles",
                column: "fuel_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_number_plate",
                table: "vehicles",
                column: "number_plate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_transmission_id",
                table: "vehicles",
                column: "transmission_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_vehicle_category_id",
                table: "vehicles",
                column: "vehicle_category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "fuels");

            migrationBuilder.DropTable(
                name: "transmissions");

            migrationBuilder.DropTable(
                name: "vehicle_categories");
        }
    }
}
