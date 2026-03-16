using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Identify_Ekyc_Phone_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_images_bookings_booking_id",
                table: "booking_images");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_insurances_bookings_booking_id",
                table: "booking_insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_insurances_insurance_packages_insurance_package_id",
                table: "booking_insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_violations_bookings_booking_id",
                table: "booking_violations");

            migrationBuilder.DropForeignKey(
                name: "FK_booking_violations_payment_transactions_payment_transaction_id",
                table: "booking_violations");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_customers_customer_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_locations_pickup_location_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_locations_return_location_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_vehicle_models_vehicle_model_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_vehicles_vehicle_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_users_UserId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_payment_transactions_bookings_booking_id",
                table: "payment_transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_refund_processing_logs_refund_requests_refund_request_id",
                table: "refund_processing_logs");

            migrationBuilder.DropForeignKey(
                name: "FK_role_claims_roles_role_id",
                table: "role_claims");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_processing_logs_payment_transactions_transaction_id",
                table: "transaction_processing_logs");

            migrationBuilder.DropForeignKey(
                name: "FK_user_claims_users_user_id",
                table: "user_claims");

            migrationBuilder.DropForeignKey(
                name: "FK_user_logins_users_user_id",
                table: "user_logins");

            migrationBuilder.DropForeignKey(
                name: "FK_user_roles_roles_role_id",
                table: "user_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_user_roles_users_user_id",
                table: "user_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_user_sessions_users_user_id",
                table: "user_sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_user_tokens_users_user_id",
                table: "user_tokens");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_attributes_vehicles_vehicle_id",
                table: "vehicle_attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_images_vehicles_vehicle_id",
                table: "vehicle_images");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_models_locations_location_id",
                table: "vehicle_models");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_models_vehicles_vehicle_id",
                table: "vehicle_models");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_return_images_bookings_booking_id",
                table: "vehicle_return_images");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_fuels_fuel_id",
                table: "vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_transmissions_transmission_id",
                table: "vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_vehicle_categories_vehicle_category_id",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_fuel_id",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_transmission_id",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_vehicle_category_id",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_return_images_booking_id",
                table: "vehicle_return_images");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_models_location_id",
                table: "vehicle_models");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_models_vehicle_id",
                table: "vehicle_models");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_images_vehicle_id",
                table: "vehicle_images");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_attributes_vehicle_id",
                table: "vehicle_attributes");

            migrationBuilder.DropIndex(
                name: "IX_user_sessions_user_id",
                table: "user_sessions");

            migrationBuilder.DropIndex(
                name: "IX_user_roles_role_id",
                table: "user_roles");

            migrationBuilder.DropIndex(
                name: "IX_user_roles_user_id",
                table: "user_roles");

            migrationBuilder.DropIndex(
                name: "IX_user_logins_user_id",
                table: "user_logins");

            migrationBuilder.DropIndex(
                name: "IX_user_claims_user_id",
                table: "user_claims");

            migrationBuilder.DropIndex(
                name: "IX_role_claims_role_id",
                table: "role_claims");

            migrationBuilder.DropIndex(
                name: "IX_payment_transactions_booking_id",
                table: "payment_transactions");

            migrationBuilder.DropIndex(
                name: "IX_bookings_customer_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_pickup_location_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_return_location_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_vehicle_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_vehicle_model_id",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_booking_violations_booking_id",
                table: "booking_violations");

            migrationBuilder.DropIndex(
                name: "IX_booking_violations_payment_transaction_id",
                table: "booking_violations");

            migrationBuilder.DropIndex(
                name: "IX_booking_insurances_booking_id",
                table: "booking_insurances");

            migrationBuilder.DropIndex(
                name: "IX_booking_insurances_insurance_package_id",
                table: "booking_insurances");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("019b19ba-3bcb-4b36-b5d5-855323646e1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("033fb2d2-b674-44d6-b3b9-5cb07a447eeb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05d6add5-71b1-43d1-8bbb-01f979b24474"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05ec6467-6c21-4e88-9523-720e182d449b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0af45f7d-a04d-4de8-9947-f313b65bfa68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0d32ce50-c304-4b47-a2e7-8251f2e15540"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1096fa9f-a4b2-497c-976b-3efc57330554"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("12795d13-5840-4e9a-8b91-292948bac81a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("185836bf-8821-4e4c-a90a-2add2094f146"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b6efc35-2163-41ac-94eb-eadda51d5df7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23a0b0f8-b68d-403d-8fc7-07a33d859525"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("253ef734-ea5d-47f4-8344-0fd2774547f7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2d3fec38-f30e-44e6-96ae-9fce557f0be7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3c33b09b-b1b8-4a06-b4e9-0d9c314254cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("47d20dcc-78a9-465f-a454-ee52efaa7319"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4d8f73fd-520e-42e7-83f5-1eba735be9b7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51bc435e-c40a-40b9-a54a-17bfac4f493c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("54a04ebe-450a-4a1a-b9f3-73aebc1b213a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("55db5750-9377-4ac1-a8a7-2edc287fc9ea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5a58f6eb-1330-4584-b40c-f4f91b3748cf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5baf969a-f283-4388-9154-e2ee57ab25a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5ca8e633-f269-4acf-83cd-269aa9e24bea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("63bb8685-2887-4f99-aabf-9bddeebf5f7a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6418b766-c29d-49de-bd45-92814aeca37c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a936093-3d9f-406b-bb32-e333fc35fd13"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6af1c8a9-2e08-4e08-93ad-713c08cb9011"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d73a0d3-83b4-4ebb-87c8-64fabbcc38f1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6da94770-7970-43d2-b9c7-305b331de584"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7afe59a3-859b-43af-a8b3-d01bae9cea4e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7cf95b98-3a4b-4177-9624-f6e6cf40b755"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("912c5e08-5fa6-4f01-90c5-c7d8d1e912d8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3b364ad-a47a-4bd5-bdd7-70e3c3d23106"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a66b8552-5e9e-4225-9a5d-85b29aee980e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac8a1c35-7217-405a-a587-fabad07535be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("afb15a35-d734-40aa-b15f-afb389df6446"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b3b65ebe-3d23-4b19-a084-0cb6eceb6677"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b895c185-4221-4798-9ab8-768c8c8e95ac"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c1dc3179-d52f-44ca-afe2-eb0889cf8d65"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c3247c6d-d24f-44d3-b723-d9e7cce71eba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c395d664-6cda-4edc-b7e4-9b6bc03486e3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c4510b09-edee-4f1a-8d44-e81f3b62c9e5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cae1ce8a-0dd8-4dc8-bee2-96ab0c9b0d3d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d3c91fa6-8910-4eac-acd7-cc614a1873fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d50c203f-a5b0-4a11-a151-9ea943c70d68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6a78503-ab11-4757-975f-d5d4d07cc897"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d9782588-4262-4c7b-8fbb-682183542366"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e2e78e8f-e9c9-4da4-9d11-01c31d6eda2b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed9fe09d-587d-42a2-bda4-78ea2c5888f2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edb699db-101b-4596-b933-6be6cbfa62d0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ef24dc86-1e89-466c-8f4b-42175264e9ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f087992c-d76c-4070-92f0-e471844a33e4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f7b1e32e-6264-4906-bc49-d341c240183c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fc30ef04-73b8-4ba2-b78e-deb7ca1a4d3a"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("0707c1dc-5ece-4842-bf8d-f3bbbe0d92df"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7b228628-3b17-4291-8ec8-7c306a6e9560"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("812c0431-2c72-4379-920e-8bc0844ae54e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("e36fac37-2ac8-482d-9c87-22e1a1cf2c0a"));

            migrationBuilder.AddColumn<bool>(
                name: "is_identity_verified",
                table: "customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_phone_verified",
                table: "customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "user_verifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    hometown = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    issue_date = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    issue_place = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    valid_date = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    face_match_score = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    is_card_liveness_pass = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    is_face_liveness_pass = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    is_face_match = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    verified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    front_image_hash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    back_image_hash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    selfie_hash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_user_verifications", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819), new DateTime(2026, 1, 24, 13, 56, 9, 823, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100), new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 824, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737), new DateTime(2026, 1, 24, 13, 56, 9, 825, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0cc989c0-b9bd-4cca-a713-f6d374eee3fb"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0eb63fb4-9a6c-4744-b6c2-e0b269c4a065"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0ee39bf2-be9e-4a16-99cc-fd1ba9a23ba6"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1129ec12-ea75-47fd-9314-a1a8851de9aa"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1241307b-3069-4d53-8650-c601c5f13bd2"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1360740c-f653-4a6f-949d-f7508ff85c45"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16c71a8a-30d8-4d90-a74d-a093ab368501"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("171ceeb6-c1c7-4a83-900a-a2084f312027"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1d4ce2a2-c330-4854-809b-97622d1250fe"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1fd3c2a1-0c93-428f-a01d-53f6080941aa"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2f94b43c-72fc-461e-ad66-ff89d25037eb"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3427d764-6117-4189-998c-01b398464cea"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3622cda4-576b-4ea5-b1a0-01b2cfed352f"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3bf2e04f-2c07-4726-bc0f-563f8c831c3a"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("3dbad722-cf8c-4307-96e8-e0bf85f041ba"), "Permission", "Permissions.Violations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4975fe5b-7467-4c6f-9aef-6d010bc80fa1"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4ab0a84a-c172-41c0-a96c-00acba9a59ca"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("4d45b7b1-b9a7-42af-bcb0-b6de8efb9436"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("509596ca-8485-4242-a3f5-d6fc27189422"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("565eaece-9fbb-4e6e-b625-725f0c581d60"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5684f162-7c9f-4f24-8b88-f51742ffafab"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("57ba77ca-59cb-4757-9fb3-5bb4e99129af"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("614803d5-de69-46b1-b7c6-9480675e2518"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("64de83ec-80fc-4051-95a7-b35af04d7b66"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("68f717c8-86b9-4f3a-b0f9-87930c7d57e0"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6a7a4120-a9bf-4662-8540-0e8f2e3ee26b"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7544e941-a017-4b63-b2d0-8db0a0cc58ec"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("7799e432-1e66-49b8-9bf3-3d8fd0fdf669"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("79c11f60-e501-476a-ae65-c9dc86d78ec2"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8b5e4359-9fcf-40c2-b54a-32ac91a78dbd"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91010f5a-68f6-43ba-bb2d-d784df48c27e"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("93e3ee21-3e47-406a-b4c3-cf9d9db43cd6"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("97cbee24-bb68-4fc9-aafa-3555ef235376"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a61c8cd-59a1-4c7f-843d-df30ca449e6b"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9a9437de-8893-4a95-a6b8-f99f61184acb"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9e7eb5ef-be6a-4f5d-bda5-633e82c4f89c"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a3e82519-9992-420b-bf77-b2ac449d45aa"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("a83b32e6-6b79-444c-a1c3-c9ceab62f97b"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a83d98f2-71db-4f38-9ea8-0dc9445dbde1"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a8416db1-a40a-445d-80fa-17fb21fba5b2"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a8bd2982-efd9-4f19-b526-2beda3145516"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a9fbb53e-7a03-43ae-bde6-cb65bdd6c34c"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b224c89b-5018-4513-a15b-072a5f7e44f1"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b408b51a-895e-4874-9187-b8ea8063f70b"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c3a91ba8-71cb-43ce-8056-b796f9a67d4f"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d0037745-81c3-469c-8f3e-4432805adecd"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d7d9292f-c06e-4515-a2a8-7918dac6af57"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da0aa2aa-e75e-4aa9-bec1-44e6c3b9b45c"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("db5a1ec6-141e-4269-95b6-aff833a0d812"), "Permission", "Permissions.Violations.Resolve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ddb88325-1ec4-45fd-96a4-066a2c09ef0c"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dfe85be0-aa00-469f-a58e-22b7024a5dec"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e32134ec-9d2d-4600-940b-0133fc2473cd"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e95a8969-85c6-41df-810a-b10114c9ae64"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ea309e6c-d9fe-442b-b6ec-23a177c8bb57"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1b25f90-a56a-49e8-886d-e2cafc6888c7"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f8a9e0fc-c130-4c95-aa50-461dd4c088fa"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "59b2f970-130c-441d-8959-9561085f9268");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "4def619a-012d-457c-92d2-428abcffa28e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "65a1ae46-3bfc-4c4c-a0e6-6b4714d743d6");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c8ed1af1-899f-4199-a30b-392b4c330f5e");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 843, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 843, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 24, 13, 56, 9, 843, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("9f1be8f7-6330-4b33-ad1f-5c519ce4e6aa"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("c88a4992-77af-4df5-955f-a931a6fda94d"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cd8494d8-0b48-49e6-8ba1-ef73ef4a1c30"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("f6eebabd-1f5e-42de-b8de-c1cc80fc1c7a"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$Oykg4rtqr0Xq4MR3XpXWqOekDwb/qJAMJ8io7336nBX7j8V.muRZe", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$0qKJZHCLatCVlixmnyNrmO/e2TCTMgV0INmGHbpKzyjmAcSkDPh1.", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$mKtBOr47Oc248TQwYP.u3e.e5FVIPt9CrbFlmXTHDAH2wdAceR0Hm", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706), "$2a$11$XS5ycwc0DGdV9ybgvSa.zu9PcQDDUc6vLRUjBBXAONQ5ClQj6WGd6", new DateTime(2026, 1, 24, 13, 56, 9, 847, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643), new DateTime(2026, 1, 24, 13, 56, 10, 413, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.CreateIndex(
                name: "IX_user_verifications_id_number",
                table: "user_verifications",
                column: "id_number");

            migrationBuilder.CreateIndex(
                name: "IX_user_verifications_user_id",
                table: "user_verifications",
                column: "user_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_verifications");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0cc989c0-b9bd-4cca-a713-f6d374eee3fb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0eb63fb4-9a6c-4744-b6c2-e0b269c4a065"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0ee39bf2-be9e-4a16-99cc-fd1ba9a23ba6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1129ec12-ea75-47fd-9314-a1a8851de9aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1241307b-3069-4d53-8650-c601c5f13bd2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1360740c-f653-4a6f-949d-f7508ff85c45"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16c71a8a-30d8-4d90-a74d-a093ab368501"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("171ceeb6-c1c7-4a83-900a-a2084f312027"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d4ce2a2-c330-4854-809b-97622d1250fe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1fd3c2a1-0c93-428f-a01d-53f6080941aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2f94b43c-72fc-461e-ad66-ff89d25037eb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3427d764-6117-4189-998c-01b398464cea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3622cda4-576b-4ea5-b1a0-01b2cfed352f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3bf2e04f-2c07-4726-bc0f-563f8c831c3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3dbad722-cf8c-4307-96e8-e0bf85f041ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4975fe5b-7467-4c6f-9aef-6d010bc80fa1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ab0a84a-c172-41c0-a96c-00acba9a59ca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4d45b7b1-b9a7-42af-bcb0-b6de8efb9436"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("509596ca-8485-4242-a3f5-d6fc27189422"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("565eaece-9fbb-4e6e-b625-725f0c581d60"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5684f162-7c9f-4f24-8b88-f51742ffafab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57ba77ca-59cb-4757-9fb3-5bb4e99129af"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("614803d5-de69-46b1-b7c6-9480675e2518"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("64de83ec-80fc-4051-95a7-b35af04d7b66"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("68f717c8-86b9-4f3a-b0f9-87930c7d57e0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6a7a4120-a9bf-4662-8540-0e8f2e3ee26b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7544e941-a017-4b63-b2d0-8db0a0cc58ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7799e432-1e66-49b8-9bf3-3d8fd0fdf669"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79c11f60-e501-476a-ae65-c9dc86d78ec2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b5e4359-9fcf-40c2-b54a-32ac91a78dbd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91010f5a-68f6-43ba-bb2d-d784df48c27e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("93e3ee21-3e47-406a-b4c3-cf9d9db43cd6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97cbee24-bb68-4fc9-aafa-3555ef235376"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a61c8cd-59a1-4c7f-843d-df30ca449e6b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a9437de-8893-4a95-a6b8-f99f61184acb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e7eb5ef-be6a-4f5d-bda5-633e82c4f89c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3e82519-9992-420b-bf77-b2ac449d45aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a83b32e6-6b79-444c-a1c3-c9ceab62f97b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a83d98f2-71db-4f38-9ea8-0dc9445dbde1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a8416db1-a40a-445d-80fa-17fb21fba5b2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a8bd2982-efd9-4f19-b526-2beda3145516"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a9fbb53e-7a03-43ae-bde6-cb65bdd6c34c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b224c89b-5018-4513-a15b-072a5f7e44f1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b408b51a-895e-4874-9187-b8ea8063f70b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c3a91ba8-71cb-43ce-8056-b796f9a67d4f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d0037745-81c3-469c-8f3e-4432805adecd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d7d9292f-c06e-4515-a2a8-7918dac6af57"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da0aa2aa-e75e-4aa9-bec1-44e6c3b9b45c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("db5a1ec6-141e-4269-95b6-aff833a0d812"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ddb88325-1ec4-45fd-96a4-066a2c09ef0c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dfe85be0-aa00-469f-a58e-22b7024a5dec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e32134ec-9d2d-4600-940b-0133fc2473cd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e95a8969-85c6-41df-810a-b10114c9ae64"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ea309e6c-d9fe-442b-b6ec-23a177c8bb57"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1b25f90-a56a-49e8-886d-e2cafc6888c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8a9e0fc-c130-4c95-aa50-461dd4c088fa"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9f1be8f7-6330-4b33-ad1f-5c519ce4e6aa"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("c88a4992-77af-4df5-955f-a931a6fda94d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("cd8494d8-0b48-49e6-8ba1-ef73ef4a1c30"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f6eebabd-1f5e-42de-b8de-c1cc80fc1c7a"));

            migrationBuilder.DropColumn(
                name: "is_identity_verified",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "is_phone_verified",
                table: "customers");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069), new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069), new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069), new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069), new DateTime(2026, 1, 15, 14, 53, 52, 20, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(2912), new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(2912), new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(2912), new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 15, 14, 53, 52, 21, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910), new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910), new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910), new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910), new DateTime(2026, 1, 15, 14, 53, 52, 22, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("019b19ba-3bcb-4b36-b5d5-855323646e1e"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("033fb2d2-b674-44d6-b3b9-5cb07a447eeb"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("05d6add5-71b1-43d1-8bbb-01f979b24474"), "Permission", "Permissions.Violations.Resolve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05ec6467-6c21-4e88-9523-720e182d449b"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0af45f7d-a04d-4de8-9947-f313b65bfa68"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0d32ce50-c304-4b47-a2e7-8251f2e15540"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1096fa9f-a4b2-497c-976b-3efc57330554"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("12795d13-5840-4e9a-8b91-292948bac81a"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("185836bf-8821-4e4c-a90a-2add2094f146"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1b6efc35-2163-41ac-94eb-eadda51d5df7"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("23a0b0f8-b68d-403d-8fc7-07a33d859525"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("253ef734-ea5d-47f4-8344-0fd2774547f7"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2d3fec38-f30e-44e6-96ae-9fce557f0be7"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3c33b09b-b1b8-4a06-b4e9-0d9c314254cc"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("47d20dcc-78a9-465f-a454-ee52efaa7319"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4d8f73fd-520e-42e7-83f5-1eba735be9b7"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("51bc435e-c40a-40b9-a54a-17bfac4f493c"), "Permission", "Permissions.Violations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("54a04ebe-450a-4a1a-b9f3-73aebc1b213a"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("55db5750-9377-4ac1-a8a7-2edc287fc9ea"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("5a58f6eb-1330-4584-b40c-f4f91b3748cf"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5baf969a-f283-4388-9154-e2ee57ab25a5"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5ca8e633-f269-4acf-83cd-269aa9e24bea"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("63bb8685-2887-4f99-aabf-9bddeebf5f7a"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6418b766-c29d-49de-bd45-92814aeca37c"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("6a936093-3d9f-406b-bb32-e333fc35fd13"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6af1c8a9-2e08-4e08-93ad-713c08cb9011"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6d73a0d3-83b4-4ebb-87c8-64fabbcc38f1"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6da94770-7970-43d2-b9c7-305b331de584"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7afe59a3-859b-43af-a8b3-d01bae9cea4e"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7cf95b98-3a4b-4177-9624-f6e6cf40b755"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("912c5e08-5fa6-4f01-90c5-c7d8d1e912d8"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a3b364ad-a47a-4bd5-bdd7-70e3c3d23106"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a66b8552-5e9e-4225-9a5d-85b29aee980e"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ac8a1c35-7217-405a-a587-fabad07535be"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("afb15a35-d734-40aa-b15f-afb389df6446"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b3b65ebe-3d23-4b19-a084-0cb6eceb6677"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b895c185-4221-4798-9ab8-768c8c8e95ac"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c1dc3179-d52f-44ca-afe2-eb0889cf8d65"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c3247c6d-d24f-44d3-b723-d9e7cce71eba"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c395d664-6cda-4edc-b7e4-9b6bc03486e3"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c4510b09-edee-4f1a-8d44-e81f3b62c9e5"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("cae1ce8a-0dd8-4dc8-bee2-96ab0c9b0d3d"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d3c91fa6-8910-4eac-acd7-cc614a1873fc"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d50c203f-a5b0-4a11-a151-9ea943c70d68"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6a78503-ab11-4757-975f-d5d4d07cc897"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("d9782588-4262-4c7b-8fbb-682183542366"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e2e78e8f-e9c9-4da4-9d11-01c31d6eda2b"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ed9fe09d-587d-42a2-bda4-78ea2c5888f2"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("edb699db-101b-4596-b933-6be6cbfa62d0"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ef24dc86-1e89-466c-8f4b-42175264e9ec"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f087992c-d76c-4070-92f0-e471844a33e4"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f7b1e32e-6264-4906-bc49-d341c240183c"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("fc30ef04-73b8-4ba2-b78e-deb7ca1a4d3a"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "44a9225c-468b-4c76-b4ca-bc3182b98590");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "6bbfb65e-b347-452e-8731-babab5d5e944");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "c70af0bd-fa0b-4665-b0ad-237497f5764a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "a6d5c6c5-b90d-41fb-b6dc-40add9c43cef");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 15, 14, 53, 52, 30, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 15, 14, 53, 52, 30, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 15, 14, 53, 52, 30, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("0707c1dc-5ece-4842-bf8d-f3bbbe0d92df"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("7b228628-3b17-4291-8ec8-7c306a6e9560"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("812c0431-2c72-4379-920e-8bc0844ae54e"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("e36fac37-2ac8-482d-9c87-22e1a1cf2c0a"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710), "$2a$11$kRdYOKshiyqOi0fwiGzP0OpybVCiWPBmivAwgjPOTSryzp.g0aIG2", new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710), "$2a$11$ugtHR2O06cEpceUfgEKb8OJ8w1XalyWZwSmTx19q5/aGn14eQSfhm", new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710), "$2a$11$lUh24pxx.KD2JnZ67MzJT.gxml1gmuwS/3jBDHh7JzHGrLIQCfyXy", new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710), "$2a$11$jh20rTPa/FuhoQAztgKJzOFnmRNjc19BDquJqjCChZO0jYfFVFuYG", new DateTime(2026, 1, 15, 14, 53, 52, 33, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775), new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775), new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775), new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775), new DateTime(2026, 1, 15, 14, 53, 52, 553, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_fuel_id",
                table: "vehicles",
                column: "fuel_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_transmission_id",
                table: "vehicles",
                column: "transmission_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_vehicle_category_id",
                table: "vehicles",
                column: "vehicle_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_return_images_booking_id",
                table: "vehicle_return_images",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_models_location_id",
                table: "vehicle_models",
                column: "location_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_models_vehicle_id",
                table: "vehicle_models",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_images_vehicle_id",
                table: "vehicle_images",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_attributes_vehicle_id",
                table: "vehicle_attributes",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_sessions_user_id",
                table: "user_sessions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_role_id",
                table: "user_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_user_id",
                table: "user_roles",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_logins_user_id",
                table: "user_logins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_claims_user_id",
                table: "user_claims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_role_claims_role_id",
                table: "role_claims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_payment_transactions_booking_id",
                table: "payment_transactions",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_customer_id",
                table: "bookings",
                column: "customer_id");

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
                name: "IX_bookings_vehicle_model_id",
                table: "bookings",
                column: "vehicle_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_violations_booking_id",
                table: "booking_violations",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_violations_payment_transaction_id",
                table: "booking_violations",
                column: "payment_transaction_id",
                unique: true,
                filter: "[payment_transaction_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_booking_insurances_booking_id",
                table: "booking_insurances",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_insurances_insurance_package_id",
                table: "booking_insurances",
                column: "insurance_package_id");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_images_bookings_booking_id",
                table: "booking_images",
                column: "booking_id",
                principalTable: "bookings",
                principalColumn: "booking_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_insurances_bookings_booking_id",
                table: "booking_insurances",
                column: "booking_id",
                principalTable: "bookings",
                principalColumn: "booking_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_insurances_insurance_packages_insurance_package_id",
                table: "booking_insurances",
                column: "insurance_package_id",
                principalTable: "insurance_packages",
                principalColumn: "insurance_package_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_violations_bookings_booking_id",
                table: "booking_violations",
                column: "booking_id",
                principalTable: "bookings",
                principalColumn: "booking_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_booking_violations_payment_transactions_payment_transaction_id",
                table: "booking_violations",
                column: "payment_transaction_id",
                principalTable: "payment_transactions",
                principalColumn: "transaction_id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_customers_customer_id",
                table: "bookings",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Restrict);

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_vehicle_models_vehicle_model_id",
                table: "bookings",
                column: "vehicle_model_id",
                principalTable: "vehicle_models",
                principalColumn: "vehicle_model_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_vehicles_vehicle_id",
                table: "bookings",
                column: "vehicle_id",
                principalTable: "vehicles",
                principalColumn: "vehicle_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_users_UserId",
                table: "customers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_payment_transactions_bookings_booking_id",
                table: "payment_transactions",
                column: "booking_id",
                principalTable: "bookings",
                principalColumn: "booking_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_refund_processing_logs_refund_requests_refund_request_id",
                table: "refund_processing_logs",
                column: "refund_request_id",
                principalTable: "refund_requests",
                principalColumn: "refund_request_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_role_claims_roles_role_id",
                table: "role_claims",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_processing_logs_payment_transactions_transaction_id",
                table: "transaction_processing_logs",
                column: "transaction_id",
                principalTable: "payment_transactions",
                principalColumn: "transaction_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_claims_users_user_id",
                table: "user_claims",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_logins_users_user_id",
                table: "user_logins",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_roles_roles_role_id",
                table: "user_roles",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_roles_users_user_id",
                table: "user_roles",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_sessions_users_user_id",
                table: "user_sessions",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_tokens_users_user_id",
                table: "user_tokens",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicle_attributes_vehicles_vehicle_id",
                table: "vehicle_attributes",
                column: "vehicle_id",
                principalTable: "vehicles",
                principalColumn: "vehicle_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicle_images_vehicles_vehicle_id",
                table: "vehicle_images",
                column: "vehicle_id",
                principalTable: "vehicles",
                principalColumn: "vehicle_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicle_models_locations_location_id",
                table: "vehicle_models",
                column: "location_id",
                principalTable: "locations",
                principalColumn: "location_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicle_models_vehicles_vehicle_id",
                table: "vehicle_models",
                column: "vehicle_id",
                principalTable: "vehicles",
                principalColumn: "vehicle_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicle_return_images_bookings_booking_id",
                table: "vehicle_return_images",
                column: "booking_id",
                principalTable: "bookings",
                principalColumn: "booking_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_fuels_fuel_id",
                table: "vehicles",
                column: "fuel_id",
                principalTable: "fuels",
                principalColumn: "fuel_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_transmissions_transmission_id",
                table: "vehicles",
                column: "transmission_id",
                principalTable: "transmissions",
                principalColumn: "transmission_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_vehicle_categories_vehicle_category_id",
                table: "vehicles",
                column: "vehicle_category_id",
                principalTable: "vehicle_categories",
                principalColumn: "vehicle_categorie_id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
