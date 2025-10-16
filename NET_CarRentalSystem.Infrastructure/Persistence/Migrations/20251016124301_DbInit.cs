using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
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
                name: "locations",
                columns: table => new
                {
                    location_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    city = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    opening_hours = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: true),
                    longitude = table.Column<double>(type: "float", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.location_id);
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
                    location_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_vehicles_locations_location_id",
                        column: x => x.location_id,
                        principalTable: "locations",
                        principalColumn: "location_id");
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

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    booking_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    customer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vehicle_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    actual_end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    late_penalty_ratio = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    deposit_ratio = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    total_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mileage_start = table.Column<int>(type: "int", nullable: false),
                    fuel_level_end = table.Column<int>(type: "int", nullable: true),
                    fuel_price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    condition_notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickup_location_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    return_location_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.booking_id);
                    table.ForeignKey(
                        name: "FK_bookings_locations_pickup_location_id",
                        column: x => x.pickup_location_id,
                        principalTable: "locations",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bookings_locations_return_location_id",
                        column: x => x.return_location_id,
                        principalTable: "locations",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_bookings_vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vehicle_attributes",
                columns: table => new
                {
                    attribute_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    attribute_key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    attribute_value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicle_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle_attributes", x => x.attribute_id);
                    table.ForeignKey(
                        name: "FK_vehicle_attributes_vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehicle_images",
                columns: table => new
                {
                    image_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    order = table.Column<int>(type: "int", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alt_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    public_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle_images", x => x.image_id);
                    table.ForeignKey(
                        name: "FK_vehicle_images_vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "fuels",
                columns: new[] { "fuel_id", "created_at", "created_by", "description", "is_deleted", "name", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), new DateTime(2025, 10, 16, 12, 43, 1, 601, DateTimeKind.Utc).AddTicks(7151), null, "Sử dụng năng lượng điện", false, "Electric", null, null },
                    { new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), new DateTime(2025, 10, 16, 12, 43, 1, 601, DateTimeKind.Utc).AddTicks(7144), null, "Sử dụng xăng", false, "Gasoline", null, null },
                    { new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), new DateTime(2025, 10, 16, 12, 43, 1, 601, DateTimeKind.Utc).AddTicks(7147), null, "Sử dụng dầu Diesel", false, "Diesel", null, null }
                });

            migrationBuilder.InsertData(
                table: "locations",
                columns: new[] { "location_id", "address", "city", "created_at", "created_by", "description", "is_deleted", "latitude", "longitude", "name", "opening_hours", "phone_number", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "123 Lê Lợi, P. Bến Nghé", "Hồ Chí Minh", new DateTime(2025, 10, 16, 12, 43, 1, 602, DateTimeKind.Utc).AddTicks(374), null, null, false, 10.7758, 106.702, "Chi nhánh Quận 1", "8:00 - 20:00", "02838123456", null, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "456 Xuân Thủy, P. Dịch Vọng Hậu", "Hà Nội", new DateTime(2025, 10, 16, 12, 43, 1, 602, DateTimeKind.Utc).AddTicks(379), null, null, false, 21.036000000000001, 105.782, "Chi nhánh Cầu Giấy", "7:30 - 19:30", "02439123456", null, null }
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
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"), "SEDAN", new DateTime(2025, 10, 16, 12, 43, 1, 603, DateTimeKind.Utc).AddTicks(7090), null, "Xe sedan 4-5 chỗ, phổ thông", false, 5, null, null },
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"), "SUV", new DateTime(2025, 10, 16, 12, 43, 1, 603, DateTimeKind.Utc).AddTicks(7093), null, "Xe thể thao đa dụng, gầm cao", false, 7, null, null },
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"), "HATCHBACK", new DateTime(2025, 10, 16, 12, 43, 1, 603, DateTimeKind.Utc).AddTicks(7129), null, "Xe cỡ nhỏ cho đô thị", false, 5, null, null },
                    { new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"), "MINIVAN", new DateTime(2025, 10, 16, 12, 43, 1, 603, DateTimeKind.Utc).AddTicks(7130), null, "Xe gia đình, rộng rãi", false, 7, null, null }
                });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "vehicle_id", "color", "condition_notes", "created_at", "created_by", "description", "fuel_id", "is_deleted", "last_checkout_at", "location_id", "manufacturer", "metadata", "mileage", "model", "number_plate", "price_per_hour", "rating", "real_time_location", "status", "thumbnail", "transmission_id", "updated_at", "updated_by", "vehicle_category_id" },
                values: new object[,]
                {
                    { new Guid("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a01"), "Bạc", null, new DateTime(2025, 10, 16, 12, 43, 1, 604, DateTimeKind.Utc).AddTicks(6543), null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 15000, "Vios", "51K-123.45", 30m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), null, null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a02"), "Đen", null, new DateTime(2025, 10, 16, 12, 43, 1, 604, DateTimeKind.Utc).AddTicks(6553), null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 5000, "Everest", "29A-678.90", 50m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), null, null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") }
                });

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "booking_id", "actual_end_date", "condition_notes", "created_at", "created_by", "customer_id", "deposit_ratio", "description", "end_date", "fuel_level_end", "fuel_price", "is_deleted", "late_penalty_ratio", "mileage_start", "pickup_location_id", "return_location_id", "start_date", "total_price", "updated_at", "updated_by", "vehicle_id" },
                values: new object[] { new Guid("c1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), null, null, new DateTime(2025, 10, 16, 12, 43, 1, 601, DateTimeKind.Utc).AddTicks(2290), null, new Guid("00000000-0000-0000-0000-000000000001"), 0m, null, new DateTime(2025, 10, 23, 12, 43, 1, 601, DateTimeKind.Utc).AddTicks(2286), null, null, false, 0m, 0, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 10, 21, 12, 43, 1, 601, DateTimeKind.Utc).AddTicks(2282), 1440m, null, null, new Guid("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a01") });

            migrationBuilder.InsertData(
                table: "vehicle_images",
                columns: new[] { "image_id", "alt_text", "caption", "image_url", "order", "public_id", "vehicle_id" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), "Ảnh ngoại thất Toyota Vios", null, "https://hientoyota.vn/wp-content/uploads/2019/05/Toyota-Vios-1.jpg", 1, null, new Guid("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a01") },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "Ảnh nội thất Toyota Vios", null, "https://toyotatanphu.vn/quannguyenphat/uploads/2019/06/Vios-Nau-vang.png.webp", 2, null, new Guid("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a01") },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "Ảnh ngoại thất Ford Everest", null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKY7Bfrr6iP-Al8YWIBsqEjOfrRn0EZ--QMg&s", 1, null, new Guid("d6e4a8c0-9b1a-4a7a-9a0a-0a0a0a0a0a02") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_pickup_location_id",
                table: "bookings",
                column: "pickup_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_return_location_id",
                table: "bookings",
                column: "return_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_vehicle_id",
                table: "bookings",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_attributes_vehicle_id",
                table: "vehicle_attributes",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_images_vehicle_id",
                table: "vehicle_images",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_fuel_id",
                table: "vehicles",
                column: "fuel_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_location_id",
                table: "vehicles",
                column: "location_id");

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
                name: "bookings");

            migrationBuilder.DropTable(
                name: "vehicle_attributes");

            migrationBuilder.DropTable(
                name: "vehicle_images");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "fuels");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "transmissions");

            migrationBuilder.DropTable(
                name: "vehicle_categories");
        }
    }
}
