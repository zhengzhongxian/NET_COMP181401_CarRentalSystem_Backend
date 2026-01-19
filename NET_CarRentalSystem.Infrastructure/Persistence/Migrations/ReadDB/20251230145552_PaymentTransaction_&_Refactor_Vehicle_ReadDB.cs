using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class PaymentTransaction__Refactor_Vehicle_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_locations_location_id",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_location_id",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_number_plate",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_read_flat_location_id",
                table: "vehicle_read_flat");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_read_flat_number_plate",
                table: "vehicle_read_flat");

            migrationBuilder.DropIndex(
                name: "IX_vehicle_read_flat_status",
                table: "vehicle_read_flat");

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001001"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001002"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001003"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001004"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001005"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001006"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001007"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001008"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001009"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001010"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001011"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001012"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001013"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001014"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001015"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001016"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001017"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001018"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001019"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001020"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001021"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001022"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001023"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001024"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001025"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001026"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001027"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001028"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001029"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001030"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001031"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001032"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001033"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001034"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001035"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001036"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001037"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001038"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001039"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001040"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001041"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001042"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001043"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001044"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001045"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001046"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001047"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001048"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001049"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001050"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001051"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001052"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001053"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001054"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001055"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001056"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001057"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001058"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001059"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001060"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001061"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001062"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001063"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001064"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001065"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001066"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001067"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001068"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001069"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001070"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001071"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001072"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001073"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001074"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001075"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001076"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001077"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001078"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001079"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001080"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001081"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001082"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001083"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001084"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001085"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001086"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001087"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001088"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001089"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001090"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001091"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001092"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001093"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001094"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001095"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001096"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001097"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001098"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001099"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001100"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001101"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001102"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001103"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001104"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001105"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001106"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001107"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001108"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001109"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001110"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001111"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001112"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001113"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001114"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001115"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001116"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001117"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001118"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001119"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001120"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001121"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001122"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001123"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001124"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001125"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001126"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001127"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001128"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001129"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001130"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001131"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001132"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001133"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001134"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001135"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001136"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001137"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001138"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001139"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001140"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001141"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001142"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001143"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001144"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001145"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001146"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001147"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001148"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001149"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001150"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001151"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001152"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001153"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001154"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001155"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001156"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001157"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001158"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001159"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001160"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001161"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001162"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001163"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001164"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001165"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001166"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001167"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001168"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001169"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001170"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001171"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001172"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001173"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001174"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001175"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001176"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001177"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001178"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001179"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001180"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001181"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001182"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001183"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001184"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001185"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001186"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001187"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001188"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001189"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001190"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001191"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001192"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001193"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001194"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001195"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001196"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001197"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001198"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001199"));

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "booking_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000001200"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04b29980-fa64-4d33-b68b-32bbecee7f8a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("06f3a386-5fcd-4e9a-a4ee-ac356ed50e20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("15689755-f0d5-4197-841f-f1e8226757c7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("195eeeef-eb16-4c3b-b9a9-2b6132a16cbc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("19867f9a-1859-4e0c-8877-7cba6fa21724"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1be57947-58a8-491d-befa-2a9fc5bab405"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e7e40d2-8c92-40ee-8bb2-ff93b2b3df22"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1eaf2450-d47a-4bed-a189-d91f9a961f3d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("24871817-c373-4d27-b22a-333dddf7db4b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e573aab-3e88-4919-a937-08be54a75d17"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2fb8f42f-5761-4207-83d9-c2ef2d63e6b6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4118daa5-cc8e-4b73-bc0d-a35b6b062cd5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57627cc7-1a5a-4b33-b449-4cf6eb0918b0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5ad95047-ab09-4edb-b0bf-cf110268057d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("606c4549-1c65-4085-93d9-cf62366419cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6d2f2ded-969b-4d89-b6cd-9bbd589af886"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b9f6c8f-064e-42e9-b4f9-0c268ab0f642"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f42f3b9-266f-4f88-aa0e-9f5e133cc874"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f46284f-8a66-4b51-a497-21e67665c316"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a08d12fa-fafc-4be9-a0c8-005589a30c1e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a445d5d7-7095-4bac-bb2d-67ae595eebdf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a546573f-148e-4e99-a45d-4b0724f64ece"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aaccce28-7f04-4fe1-97db-2b521f1fcf36"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aae31b94-fb48-486b-a114-a86c3073072e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ab5dd01f-93f9-4b1a-9e7c-73014395ca6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b120e139-6c0d-4c69-b05b-c3b5f96c1452"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c1deca5d-3c7d-42fe-a128-c481e1781ccc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2b6264f-2f00-46cc-8257-54d3eb56c7cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c4691ddf-fc1d-4b77-8c74-d71878c2d5cb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ca93539b-ce62-4f54-900e-f030207fd209"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cd8cb1e5-3ec2-45e6-9f33-b86fb258f801"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d00b4a57-b2d5-4f93-9b2f-bcbec8609c5c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d46a379c-4b0f-4b77-aeda-766ba1c55875"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc65dd4c-73cf-4d4b-acdc-bd48c6061abb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e7a1a5dc-7eed-44a6-bbfc-3241af8381ce"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eb3cb783-b360-4c1e-9dfb-1c457cc21a20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed30119f-a5c2-4737-ba50-29597492e129"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f9d5a162-bc7c-4bf0-9d70-5656cda1c3d9"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("64f46619-c3ae-4e72-a2f4-dab927a92b21"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9c5e195a-987a-4dc0-b92f-180bf231ef56"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("dbe4a074-bab8-4635-836d-1547c7e05559"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ecfc21ec-5242-4d94-9727-acea208078a8"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000191"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000192"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000193"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000194"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000195"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000196"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000197"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000198"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000199"));

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "vehicle_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"));

            migrationBuilder.DropColumn(
                name: "condition_notes",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "last_checkout_at",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "location_id",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "mileage",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "number_plate",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "real_time_location",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "status",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "condition_notes",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "last_checkout_at",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "location_id",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "location_name",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "mileage",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "number_plate",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "status",
                table: "vehicle_read_flat");

            migrationBuilder.RenameColumn(
                name: "real_time_location",
                table: "vehicle_read_flat",
                newName: "ImagesJson");

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "bookings",
                newName: "StartDate");

            migrationBuilder.AddColumn<int>(
                name: "available_count",
                table: "vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "vehicles",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "available_count",
                table: "vehicle_read_flat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "vehicle_categories",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "transmissions",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "locations",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "fuels",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "LoyaltyPoints",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "customers",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "bookings",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<Guid>(
                name: "vehicle_model_id",
                table: "bookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "payment_transactions",
                columns: table => new
                {
                    transaction_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    transaction_code = table.Column<long>(type: "bigint", nullable: false),
                    booking_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    payment_method = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    transaction_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    external_transaction_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    row_version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
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
                    table.PrimaryKey("PK_payment_transactions", x => x.transaction_id);
                    table.ForeignKey(
                        name: "FK_payment_transactions_bookings_booking_id",
                        column: x => x.booking_id,
                        principalTable: "bookings",
                        principalColumn: "booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehicle_models",
                columns: table => new
                {
                    vehicle_model_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    mileage = table.Column<int>(type: "int", nullable: false),
                    number_plate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    condition_notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    real_time_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    vehicle_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    row_version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    deleted_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle_models", x => x.vehicle_model_id);
                    table.ForeignKey(
                        name: "FK_vehicle_models_locations_location_id",
                        column: x => x.location_id,
                        principalTable: "locations",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_vehicle_models_vehicles_vehicle_id",
                        column: x => x.vehicle_id,
                        principalTable: "vehicles",
                        principalColumn: "vehicle_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transaction_processing_logs",
                columns: table => new
                {
                    log_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    transaction_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    transaction_code = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    error_message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stack_trace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    retry_count = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    last_attempt_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    error_category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    raw_response = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_processing_logs", x => x.log_id);
                    table.ForeignKey(
                        name: "FK_transaction_processing_logs_payment_transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "payment_transactions",
                        principalColumn: "transaction_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "LoyaltyPoints", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222), 0, new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "LoyaltyPoints", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222), 0, new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "LoyaltyPoints", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222), 0, new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "LoyaltyPoints", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222), 0, new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(7398), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(7398), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(7398), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 848, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492), new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 849, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("06b7fc8b-1399-44b6-be82-c4900123ee25"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("07ee7850-3220-4600-af3a-feab9fe71b02"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0aba1b2a-4b77-4a5e-9a26-5f9f38e5bec9"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0ff2d3b8-d542-4033-8229-9d64b2f34f06"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1a2dffea-9b8d-40f7-952c-ed1ee872e3a9"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2afe724f-98f9-49bf-839d-918321ec913a"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2b97f961-1c84-4312-af51-c2bc4df6741d"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2d8c7d4e-e0dc-4539-89c3-c71edccb86e8"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("2e2149fe-b657-432c-bda5-277b1a854d34"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("35fe0410-b114-4267-99a4-e26f5b13617d"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3dc57589-2d43-4fc6-acf5-11d1928c52c6"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("51f867e6-6d3c-4c0a-9ba5-75ed3e29bb9c"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("52475a92-4d33-43b2-b112-c98ffb3c5e05"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("529f9f0c-6069-4214-aa54-06fbcc9d3bc5"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("57fe7cef-134b-464d-a97d-c53aba493070"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5be966a7-9d8d-4110-a7d9-45d0815a9185"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6eaeeb0c-d876-425a-b172-c1300f4faf22"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("77880ea7-e1ae-4e3d-993c-0a6aff953191"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("94ac442f-8d39-4618-9c3a-d412a19a35fe"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a3d5c301-ce1c-4df1-9cee-1dc43ce4e566"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad23ae3e-0d24-4c45-b003-dba9b36d951a"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae396cfc-d545-4544-9ae7-0c14a0b18824"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b0b9cfea-24bc-414a-af66-24b4f04d05d9"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b1a436cd-b3b7-4e72-aaec-83e51cd5cfac"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b38f562d-a75b-43ab-925b-fa991c6274ba"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("be6f6aac-f2aa-4700-b616-6db8caf5de20"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c0ca4182-f16d-41ff-8d31-3f094b835a6b"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c9a4a5d7-f1ef-4ebd-808e-8f3c2c524c5e"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d9957b82-37d7-486c-b825-58d594b71dcd"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dc513181-6ea4-44d5-be41-139f3fea7801"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("df78872b-dc05-4bef-b62a-bbf2de9716a5"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("e9a88e1e-4951-4272-9010-f08cd34c1886"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ed6ec7c9-82d9-4bda-8e84-7e1751c6fc3e"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f1c5721c-0f37-4cdf-b407-5680a5241832"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f557cff4-362c-47f0-bbdb-0c2dd807ccc4"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f5786855-c876-40ac-b4ad-7c1c3efe53b1"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fcee93ca-f4aa-4fa6-8b3c-1a121514b3b4"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ff1e418a-2a0e-4d70-a542-ef6dfc5a30cf"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "3a86d9b6-aad9-4556-9249-79ae20db6ba8");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "e6fc6c29-7994-47c2-8469-b0220f2bbce0");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "2a58c0eb-ba5e-48e7-8b33-0988e505bec8");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "1a51ea5f-e6dc-4055-80d7-1df84da46380");

            migrationBuilder.UpdateData(
                table: "transmissions",
                keyColumn: "transmission_id",
                keyValue: new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                column: "RowVersion",
                value: null);

            migrationBuilder.UpdateData(
                table: "transmissions",
                keyColumn: "transmission_id",
                keyValue: new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"),
                column: "RowVersion",
                value: null);

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("2be15351-3b15-4551-ad96-e95453abc84c"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("395c76d2-4c00-45d9-80f1-a95259afb672"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("6e4bdf54-c2d2-4605-9643-64ebcb0714c6"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("badd0565-bd4f-4982-a51d-66551d24c2d6"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909), "$2a$11$kTM6qUyDRHi1g8pk5kCELeJkc2KzIaBjghj1ubzjrFfzUWS4BQh6O", new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909), "$2a$11$EQWOzl0V2.c5KD887CYQxuqhUvs/RCZOMShmgq4/.9vFuJcrZUzke", new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909), "$2a$11$qQD24MkbX2o5aEEG1rZpjOOq2pdCDMquTBPrfiv8K9iNkX7CIGutm", new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909), "$2a$11$FmefYi4rzzrmyOhShp16lO8HOOIubrk14H.hi9UEpDncMl5M1kA.y", new byte[0], new DateTime(2025, 12, 30, 14, 55, 50, 854, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232), new byte[0], new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232), new byte[0], new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232), new byte[0], new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232), new byte[0], new DateTime(2025, 12, 30, 14, 55, 51, 355, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_vehicle_model_id",
                table: "bookings",
                column: "vehicle_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_payment_transactions_booking_id",
                table: "payment_transactions",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_processing_logs_status",
                table: "transaction_processing_logs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_processing_logs_transaction_code",
                table: "transaction_processing_logs",
                column: "transaction_code");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_processing_logs_transaction_id",
                table: "transaction_processing_logs",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_models_location_id",
                table: "vehicle_models",
                column: "location_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_models_number_plate",
                table: "vehicle_models",
                column: "number_plate",
                unique: true,
                filter: "[number_plate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_models_vehicle_id",
                table: "vehicle_models",
                column: "vehicle_id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_vehicle_models_vehicle_model_id",
                table: "bookings",
                column: "vehicle_model_id",
                principalTable: "vehicle_models",
                principalColumn: "vehicle_model_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_vehicle_models_vehicle_model_id",
                table: "bookings");

            migrationBuilder.DropTable(
                name: "transaction_processing_logs");

            migrationBuilder.DropTable(
                name: "vehicle_models");

            migrationBuilder.DropTable(
                name: "payment_transactions");

            migrationBuilder.DropIndex(
                name: "IX_bookings_vehicle_model_id",
                table: "bookings");

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("06b7fc8b-1399-44b6-be82-c4900123ee25"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("07ee7850-3220-4600-af3a-feab9fe71b02"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0aba1b2a-4b77-4a5e-9a26-5f9f38e5bec9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0ff2d3b8-d542-4033-8229-9d64b2f34f06"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1a2dffea-9b8d-40f7-952c-ed1ee872e3a9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2afe724f-98f9-49bf-839d-918321ec913a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2b97f961-1c84-4312-af51-c2bc4df6741d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2d8c7d4e-e0dc-4539-89c3-c71edccb86e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e2149fe-b657-432c-bda5-277b1a854d34"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("35fe0410-b114-4267-99a4-e26f5b13617d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3dc57589-2d43-4fc6-acf5-11d1928c52c6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51f867e6-6d3c-4c0a-9ba5-75ed3e29bb9c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("52475a92-4d33-43b2-b112-c98ffb3c5e05"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("529f9f0c-6069-4214-aa54-06fbcc9d3bc5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("57fe7cef-134b-464d-a97d-c53aba493070"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5be966a7-9d8d-4110-a7d9-45d0815a9185"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6eaeeb0c-d876-425a-b172-c1300f4faf22"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("77880ea7-e1ae-4e3d-993c-0a6aff953191"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("94ac442f-8d39-4618-9c3a-d412a19a35fe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a3d5c301-ce1c-4df1-9cee-1dc43ce4e566"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad23ae3e-0d24-4c45-b003-dba9b36d951a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae396cfc-d545-4544-9ae7-0c14a0b18824"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b0b9cfea-24bc-414a-af66-24b4f04d05d9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b1a436cd-b3b7-4e72-aaec-83e51cd5cfac"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b38f562d-a75b-43ab-925b-fa991c6274ba"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("be6f6aac-f2aa-4700-b616-6db8caf5de20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c0ca4182-f16d-41ff-8d31-3f094b835a6b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c9a4a5d7-f1ef-4ebd-808e-8f3c2c524c5e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d9957b82-37d7-486c-b825-58d594b71dcd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc513181-6ea4-44d5-be41-139f3fea7801"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("df78872b-dc05-4bef-b62a-bbf2de9716a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9a88e1e-4951-4272-9010-f08cd34c1886"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed6ec7c9-82d9-4bda-8e84-7e1751c6fc3e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f1c5721c-0f37-4cdf-b407-5680a5241832"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f557cff4-362c-47f0-bbdb-0c2dd807ccc4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f5786855-c876-40ac-b4ad-7c1c3efe53b1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fcee93ca-f4aa-4fa6-8b3c-1a121514b3b4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ff1e418a-2a0e-4d70-a542-ef6dfc5a30cf"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("2be15351-3b15-4551-ad96-e95453abc84c"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("395c76d2-4c00-45d9-80f1-a95259afb672"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("6e4bdf54-c2d2-4605-9643-64ebcb0714c6"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("badd0565-bd4f-4982-a51d-66551d24c2d6"));

            migrationBuilder.DropColumn(
                name: "available_count",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "row_version",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "available_count",
                table: "vehicle_read_flat");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "vehicle_categories");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "transmissions");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "locations");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "fuels");

            migrationBuilder.DropColumn(
                name: "LoyaltyPoints",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "row_version",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "row_version",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "vehicle_model_id",
                table: "bookings");

            migrationBuilder.RenameColumn(
                name: "ImagesJson",
                table: "vehicle_read_flat",
                newName: "real_time_location");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "bookings",
                newName: "start_date");

            migrationBuilder.AddColumn<string>(
                name: "condition_notes",
                table: "vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_checkout_at",
                table: "vehicles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "location_id",
                table: "vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mileage",
                table: "vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "number_plate",
                table: "vehicles",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "real_time_location",
                table: "vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "vehicles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "condition_notes",
                table: "vehicle_read_flat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_checkout_at",
                table: "vehicle_read_flat",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "location_id",
                table: "vehicle_read_flat",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "location_name",
                table: "vehicle_read_flat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mileage",
                table: "vehicle_read_flat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "number_plate",
                table: "vehicle_read_flat",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "vehicle_read_flat",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059), new DateTime(2025, 12, 18, 15, 35, 26, 565, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 12, 18, 15, 35, 26, 566, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 12, 18, 15, 35, 26, 567, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("04b29980-fa64-4d33-b68b-32bbecee7f8a"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("06f3a386-5fcd-4e9a-a4ee-ac356ed50e20"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("15689755-f0d5-4197-841f-f1e8226757c7"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("195eeeef-eb16-4c3b-b9a9-2b6132a16cbc"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("19867f9a-1859-4e0c-8877-7cba6fa21724"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1be57947-58a8-491d-befa-2a9fc5bab405"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("1e7e40d2-8c92-40ee-8bb2-ff93b2b3df22"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1eaf2450-d47a-4bed-a189-d91f9a961f3d"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("24871817-c373-4d27-b22a-333dddf7db4b"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("2e573aab-3e88-4919-a937-08be54a75d17"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2fb8f42f-5761-4207-83d9-c2ef2d63e6b6"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("4118daa5-cc8e-4b73-bc0d-a35b6b062cd5"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("57627cc7-1a5a-4b33-b449-4cf6eb0918b0"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("5ad95047-ab09-4edb-b0bf-cf110268057d"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("606c4549-1c65-4085-93d9-cf62366419cb"), "Permission", "Permissions.Bookings.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6d2f2ded-969b-4d89-b6cd-9bbd589af886"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8b9f6c8f-064e-42e9-b4f9-0c268ab0f642"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9f42f3b9-266f-4f88-aa0e-9f5e133cc874"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9f46284f-8a66-4b51-a497-21e67665c316"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("a08d12fa-fafc-4be9-a0c8-005589a30c1e"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a445d5d7-7095-4bac-bb2d-67ae595eebdf"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a546573f-148e-4e99-a45d-4b0724f64ece"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aaccce28-7f04-4fe1-97db-2b521f1fcf36"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aae31b94-fb48-486b-a114-a86c3073072e"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ab5dd01f-93f9-4b1a-9e7c-73014395ca6c"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b120e139-6c0d-4c69-b05b-c3b5f96c1452"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c1deca5d-3c7d-42fe-a128-c481e1781ccc"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c2b6264f-2f00-46cc-8257-54d3eb56c7cc"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c4691ddf-fc1d-4b77-8c74-d71878c2d5cb"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ca93539b-ce62-4f54-900e-f030207fd209"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("cd8cb1e5-3ec2-45e6-9f33-b86fb258f801"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d00b4a57-b2d5-4f93-9b2f-bcbec8609c5c"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d46a379c-4b0f-4b77-aeda-766ba1c55875"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("dc65dd4c-73cf-4d4b-acdc-bd48c6061abb"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e7a1a5dc-7eed-44a6-bbfc-3241af8381ce"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eb3cb783-b360-4c1e-9dfb-1c457cc21a20"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("ed30119f-a5c2-4737-ba50-29597492e129"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f9d5a162-bc7c-4bf0-9d70-5656cda1c3d9"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "ed4cb362-7df7-4ca7-8a2e-f8865f5a569e");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "21ad282a-e2d3-4308-a0b6-cfd9e52362cf");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "82eeb4a5-52a5-4084-973e-77a4cb46f853");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "c712561d-626a-4845-b4f0-488e21e5aae7");

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("64f46619-c3ae-4e72-a2f4-dab927a92b21"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("9c5e195a-987a-4dc0-b92f-180bf231ef56"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("dbe4a074-bab8-4635-836d-1547c7e05559"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("ecfc21ec-5242-4d94-9727-acea208078a8"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$8U47sA0mGRoy18diIbq3YuuFEtOpJnAKPYLRKfKCxEDxv4Smo42v2", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$.uiLcZsRIv8qkdd2IuiP.uv2Va8x0asMKWME0D8cZ.tO.1ZGZtAlK", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$QVdadgWFwlgN/TgrV8DF3eXErOAPQ79bOEavLY3/B76zUq48HHRte", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360), "$2a$11$c/.B4l/.Dms5znStgauQbeplliQeNJK4b6WxaliqMI4VUFK1maR02", new DateTime(2025, 12, 18, 15, 35, 26, 575, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327), new DateTime(2025, 12, 18, 15, 35, 27, 867, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "vehicle_id", "color", "condition_notes", "created_at", "created_by", "deleted_at", "deleted_by", "description", "fuel_id", "is_deleted", "last_checkout_at", "location_id", "manufacturer", "metadata", "mileage", "model", "number_plate", "price_per_hour", "rating", "real_time_location", "status", "thumbnail", "transmission_id", "updated_at", "updated_by", "vehicle_category_id" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 1000, "Everest", "11A-101.11", 21m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 2000, "Accent", "12A-102.12", 22m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 3000, "Seltos", "13A-103.13", 23m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 4000, "Vios", "14A-104.14", 24m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 5000, "Everest", "15A-105.15", 25m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 6000, "Accent", "16A-106.16", 26m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 7000, "Seltos", "17A-107.17", 27m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 8000, "Vios", "18A-108.18", 28m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 9000, "Everest", "19A-109.19", 29m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 10000, "Accent", "20A-110.20", 30m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 11000, "Seltos", "21A-111.21", 31m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 12000, "Vios", "22A-112.22", 32m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 13000, "Everest", "23A-113.23", 33m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 14000, "Accent", "24A-114.24", 34m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 15000, "Seltos", "25A-115.25", 35m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 16000, "Vios", "26A-116.26", 36m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 17000, "Everest", "27A-117.27", 37m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 18000, "Accent", "28A-118.28", 38m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 19000, "Seltos", "29A-119.29", 39m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 20000, "Vios", "30A-120.30", 40m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 21000, "Everest", "31A-121.31", 41m, 4.1f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 22000, "Accent", "32A-122.32", 42m, 4.2f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 23000, "Seltos", "33A-123.33", 43m, 4.3f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 24000, "Vios", "34A-124.34", 44m, 4.4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 25000, "Everest", "35A-125.35", 45m, 4.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 26000, "Accent", "36A-126.36", 46m, 4.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 27000, "Seltos", "37A-127.37", 47m, 4.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 28000, "Vios", "38A-128.38", 48m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 29000, "Everest", "39A-129.39", 49m, 4.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 30000, "Accent", "40A-130.40", 50m, 3.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000031"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 31000, "Seltos", "41A-131.41", 51m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000032"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 32000, "Vios", "42A-132.42", 52m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000033"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 33000, "Everest", "43A-133.43", 53m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000034"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 34000, "Accent", "44A-134.44", 54m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000035"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 35000, "Seltos", "45A-135.45", 55m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000036"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 36000, "Vios", "46A-136.46", 56m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000037"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 37000, "Everest", "47A-137.47", 57m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000038"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 38000, "Accent", "48A-138.48", 58m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000039"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 39000, "Seltos", "49A-139.49", 59m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000040"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 40000, "Vios", "50A-140.50", 60m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000041"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 41000, "Everest", "51A-141.51", 61m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000042"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 42000, "Accent", "52A-142.52", 62m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000043"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 43000, "Seltos", "53A-143.53", 63m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000044"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 44000, "Vios", "54A-144.54", 64m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000045"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 45000, "Everest", "55A-145.55", 65m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000046"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 46000, "Accent", "56A-146.56", 66m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000047"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 47000, "Seltos", "57A-147.57", 67m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 48000, "Vios", "58A-148.58", 68m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 49000, "Everest", "59A-149.59", 69m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 50000, "Accent", "10A-150.60", 70m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000051"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 51000, "Seltos", "11A-151.61", 71m, 4.1f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000052"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 52000, "Vios", "12A-152.62", 72m, 4.2f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000053"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 53000, "Everest", "13A-153.63", 73m, 4.3f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000054"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 54000, "Accent", "14A-154.64", 74m, 4.4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000055"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 55000, "Seltos", "15A-155.65", 75m, 4.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000056"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 56000, "Vios", "16A-156.66", 76m, 4.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000057"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 57000, "Everest", "17A-157.67", 77m, 4.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000058"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 58000, "Accent", "18A-158.68", 78m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000059"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 59000, "Seltos", "19A-159.69", 79m, 4.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000060"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 60000, "Vios", "20A-160.70", 20m, 3.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000061"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 61000, "Everest", "21A-161.71", 21m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000062"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 62000, "Accent", "22A-162.72", 22m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000063"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 63000, "Seltos", "23A-163.73", 23m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000064"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 64000, "Vios", "24A-164.74", 24m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000065"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 65000, "Everest", "25A-165.75", 25m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000066"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 66000, "Accent", "26A-166.76", 26m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000067"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 67000, "Seltos", "27A-167.77", 27m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000068"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 68000, "Vios", "28A-168.78", 28m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000069"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 69000, "Everest", "29A-169.79", 29m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000070"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 70000, "Accent", "30A-170.80", 30m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000071"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 71000, "Seltos", "31A-171.81", 31m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000072"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 72000, "Vios", "32A-172.82", 32m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000073"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 73000, "Everest", "33A-173.83", 33m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000074"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 74000, "Accent", "34A-174.84", 34m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000075"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 75000, "Seltos", "35A-175.85", 35m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000076"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 76000, "Vios", "36A-176.86", 36m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000077"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 77000, "Everest", "37A-177.87", 37m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000078"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 78000, "Accent", "38A-178.88", 38m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000079"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 79000, "Seltos", "39A-179.89", 39m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000080"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 80000, "Vios", "40A-180.90", 40m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000081"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 81000, "Everest", "41A-181.91", 41m, 4.1f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000082"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 82000, "Accent", "42A-182.92", 42m, 4.2f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000083"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 83000, "Seltos", "43A-183.93", 43m, 4.3f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000084"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 84000, "Vios", "44A-184.94", 44m, 4.4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000085"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 85000, "Everest", "45A-185.95", 45m, 4.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000086"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 86000, "Accent", "46A-186.96", 46m, 4.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000087"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 87000, "Seltos", "47A-187.97", 47m, 4.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000088"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 88000, "Vios", "48A-188.98", 48m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000089"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 89000, "Everest", "49A-189.99", 49m, 4.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000090"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 90000, "Accent", "50A-190.10", 50m, 3.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000091"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 91000, "Seltos", "51A-191.11", 51m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000092"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 92000, "Vios", "52A-192.12", 52m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000093"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 93000, "Everest", "53A-193.13", 53m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000094"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 94000, "Accent", "54A-194.14", 54m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000095"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 95000, "Seltos", "55A-195.15", 55m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000096"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 96000, "Vios", "56A-196.16", 56m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000097"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 97000, "Everest", "57A-197.17", 57m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000098"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 98000, "Accent", "58A-198.18", 58m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000099"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 99000, "Seltos", "59A-199.19", 59m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000100"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 100000, "Vios", "10A-200.20", 60m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000101"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 101000, "Everest", "11A-201.21", 61m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000102"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 102000, "Accent", "12A-202.22", 62m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000103"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 103000, "Seltos", "13A-203.23", 63m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000104"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 104000, "Vios", "14A-204.24", 64m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000105"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 105000, "Everest", "15A-205.25", 65m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000106"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 106000, "Accent", "16A-206.26", 66m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000107"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 107000, "Seltos", "17A-207.27", 67m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000108"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 108000, "Vios", "18A-208.28", 68m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000109"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 109000, "Everest", "19A-209.29", 69m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000110"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 110000, "Accent", "20A-210.30", 70m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000111"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 111000, "Seltos", "21A-211.31", 71m, 4.1f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000112"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 112000, "Vios", "22A-212.32", 72m, 4.2f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000113"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 113000, "Everest", "23A-213.33", 73m, 4.3f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000114"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 114000, "Accent", "24A-214.34", 74m, 4.4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000115"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 115000, "Seltos", "25A-215.35", 75m, 4.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000116"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 116000, "Vios", "26A-216.36", 76m, 4.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000117"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 117000, "Everest", "27A-217.37", 77m, 4.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000118"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 118000, "Accent", "28A-218.38", 78m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000119"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 119000, "Seltos", "29A-219.39", 79m, 4.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000120"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 120000, "Vios", "30A-220.40", 20m, 3.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000121"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 121000, "Everest", "31A-221.41", 21m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000122"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 122000, "Accent", "32A-222.42", 22m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000123"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 123000, "Seltos", "33A-223.43", 23m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000124"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 124000, "Vios", "34A-224.44", 24m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000125"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 125000, "Everest", "35A-225.45", 25m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000126"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 126000, "Accent", "36A-226.46", 26m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000127"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 127000, "Seltos", "37A-227.47", 27m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000128"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 128000, "Vios", "38A-228.48", 28m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000129"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 129000, "Everest", "39A-229.49", 29m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000130"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 130000, "Accent", "40A-230.50", 30m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000131"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 131000, "Seltos", "41A-231.51", 31m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000132"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 132000, "Vios", "42A-232.52", 32m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000133"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 133000, "Everest", "43A-233.53", 33m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000134"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 134000, "Accent", "44A-234.54", 34m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000135"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 135000, "Seltos", "45A-235.55", 35m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000136"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 136000, "Vios", "46A-236.56", 36m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000137"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 137000, "Everest", "47A-237.57", 37m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000138"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 138000, "Accent", "48A-238.58", 38m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000139"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 139000, "Seltos", "49A-239.59", 39m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000140"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 140000, "Vios", "50A-240.60", 40m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000141"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 141000, "Everest", "51A-241.61", 41m, 4.1f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000142"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 142000, "Accent", "52A-242.62", 42m, 4.2f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000143"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 143000, "Seltos", "53A-243.63", 43m, 4.3f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000144"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 144000, "Vios", "54A-244.64", 44m, 4.4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000145"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 145000, "Everest", "55A-245.65", 45m, 4.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000146"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 146000, "Accent", "56A-246.66", 46m, 4.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000147"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 147000, "Seltos", "57A-247.67", 47m, 4.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000148"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 148000, "Vios", "58A-248.68", 48m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000149"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 149000, "Everest", "59A-249.69", 49m, 4.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000150"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 150000, "Accent", "10A-250.70", 50m, 3.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000151"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 151000, "Seltos", "11A-251.71", 51m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000152"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 152000, "Vios", "12A-252.72", 52m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000153"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 153000, "Everest", "13A-253.73", 53m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000154"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 154000, "Accent", "14A-254.74", 54m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000155"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 155000, "Seltos", "15A-255.75", 55m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000156"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 156000, "Vios", "16A-256.76", 56m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000157"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 157000, "Everest", "17A-257.77", 57m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000158"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 158000, "Accent", "18A-258.78", 58m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000159"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 159000, "Seltos", "19A-259.79", 59m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000160"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 160000, "Vios", "20A-260.80", 60m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000161"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 161000, "Everest", "21A-261.81", 61m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000162"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 162000, "Accent", "22A-262.82", 62m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000163"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 163000, "Seltos", "23A-263.83", 63m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000164"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 164000, "Vios", "24A-264.84", 64m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000165"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 165000, "Everest", "25A-265.85", 65m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000166"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 166000, "Accent", "26A-266.86", 66m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000167"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 167000, "Seltos", "27A-267.87", 67m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000168"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 168000, "Vios", "28A-268.88", 68m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000169"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 169000, "Everest", "29A-269.89", 69m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000170"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 170000, "Accent", "30A-270.90", 70m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000171"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 171000, "Seltos", "31A-271.91", 71m, 4.1f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000172"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 172000, "Vios", "32A-272.92", 72m, 4.2f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000173"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 173000, "Everest", "33A-273.93", 73m, 4.3f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000174"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 174000, "Accent", "34A-274.94", 74m, 4.4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000175"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 175000, "Seltos", "35A-275.95", 75m, 4.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000176"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 176000, "Vios", "36A-276.96", 76m, 4.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000177"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 177000, "Everest", "37A-277.97", 77m, 4.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000178"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 178000, "Accent", "38A-278.98", 78m, 4.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000179"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 179000, "Seltos", "39A-279.99", 79m, 4.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000180"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 180000, "Vios", "40A-280.10", 20m, 3.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000181"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 181000, "Everest", "41A-281.11", 21m, 3.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000182"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 182000, "Accent", "42A-282.12", 22m, 3.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000183"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 183000, "Seltos", "43A-283.13", 23m, 3.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000184"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 184000, "Vios", "44A-284.14", 24m, 3.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000185"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 185000, "Everest", "45A-285.15", 25m, 4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000186"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 186000, "Accent", "46A-286.16", 26m, 4.1f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000187"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 187000, "Seltos", "47A-287.17", 27m, 4.2f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000188"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 188000, "Vios", "48A-288.18", 28m, 4.3f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000189"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 189000, "Everest", "49A-289.19", 29m, 4.4f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000190"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 190000, "Accent", "50A-290.20", 30m, 4.5f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000191"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 191000, "Seltos", "51A-291.21", 31m, 4.6f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000192"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 192000, "Vios", "52A-292.22", 32m, 4.7f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000193"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 193000, "Everest", "53A-293.23", 33m, 4.8f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000194"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 194000, "Accent", "54A-294.24", 34m, 4.9f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000195"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 195000, "Seltos", "55A-295.25", 35m, 3.5f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000196"), "Đen", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 196000, "Vios", "56A-296.26", 36m, 3.6f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") },
                    { new Guid("00000000-0000-0000-0000-000000000197"), "Trắng", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000002"), "Ford", null, 197000, "Everest", "57A-297.27", 37m, 3.7f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02") },
                    { new Guid("00000000-0000-0000-0000-000000000198"), "Đỏ", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"), false, null, new Guid("10000000-0000-0000-0000-000000000003"), "Hyundai", null, 198000, "Accent", "58A-298.28", 38m, 3.8f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03") },
                    { new Guid("00000000-0000-0000-0000-000000000199"), "Xanh", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"), false, null, new Guid("10000000-0000-0000-0000-000000000004"), "Kia", null, 199000, "Seltos", "59A-299.29", 39m, 3.9f, null, "Available", null, new Guid("b2c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04") },
                    { new Guid("00000000-0000-0000-0000-000000000200"), "Bạc", null, new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, null, null, null, new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"), false, null, new Guid("10000000-0000-0000-0000-000000000001"), "Toyota", null, 200000, "Vios", "10A-300.30", 40m, 4f, null, "Available", null, new Guid("a1b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), new DateTime(2025, 12, 18, 15, 35, 27, 871, DateTimeKind.Utc).AddTicks(5448), null, new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01") }
                });

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "booking_id", "actual_end_date", "condition_notes", "created_at", "created_by", "customer_id", "deleted_at", "deleted_by", "deposit_ratio", "description", "end_date", "fuel_level_end", "fuel_price", "is_deleted", "late_penalty_ratio", "mileage_start", "pickup_location_id", "return_location_id", "start_date", "total_price", "updated_at", "updated_by", "vehicle_id" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000001001"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 1000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 504m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("10000000-0000-0000-0000-000000001002"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 2000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 528m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("10000000-0000-0000-0000-000000001003"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 3000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 552m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("10000000-0000-0000-0000-000000001004"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 4000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 576m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("10000000-0000-0000-0000-000000001005"), new DateTime(2025, 12, 19, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 5000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 600m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("10000000-0000-0000-0000-000000001006"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 6000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 624m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("10000000-0000-0000-0000-000000001007"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 7000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 648m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("10000000-0000-0000-0000-000000001008"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 8000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 672m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("10000000-0000-0000-0000-000000001009"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 9000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 696m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("10000000-0000-0000-0000-000000001010"), new DateTime(2025, 12, 12, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 10000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 720m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("10000000-0000-0000-0000-000000001011"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 11000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 744m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("10000000-0000-0000-0000-000000001012"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 12000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 768m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("10000000-0000-0000-0000-000000001013"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 13000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 792m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("10000000-0000-0000-0000-000000001014"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 14000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 816m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("10000000-0000-0000-0000-000000001015"), new DateTime(2025, 12, 5, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 15000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 840m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("10000000-0000-0000-0000-000000001016"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 16000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 864m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("10000000-0000-0000-0000-000000001017"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 17000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 888m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("10000000-0000-0000-0000-000000001018"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 18000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 912m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("10000000-0000-0000-0000-000000001019"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 19000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 936m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("10000000-0000-0000-0000-000000001020"), new DateTime(2025, 12, 5, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 20000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 960m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("10000000-0000-0000-0000-000000001021"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 21000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 984m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("10000000-0000-0000-0000-000000001022"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 22000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1008m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("10000000-0000-0000-0000-000000001023"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 23000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1032m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("10000000-0000-0000-0000-000000001024"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 24000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1056m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("10000000-0000-0000-0000-000000001025"), new DateTime(2025, 11, 28, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 25000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1080m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("10000000-0000-0000-0000-000000001026"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 26000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1104m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("10000000-0000-0000-0000-000000001027"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 27000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1128m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000027") },
                    { new Guid("10000000-0000-0000-0000-000000001028"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 28000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1152m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000028") },
                    { new Guid("10000000-0000-0000-0000-000000001029"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 29000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1176m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000029") },
                    { new Guid("10000000-0000-0000-0000-000000001030"), new DateTime(2025, 12, 21, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 30000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1200m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000030") },
                    { new Guid("10000000-0000-0000-0000-000000001031"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 31000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1224m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000031") },
                    { new Guid("10000000-0000-0000-0000-000000001032"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 32000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1248m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000032") },
                    { new Guid("10000000-0000-0000-0000-000000001033"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 33000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1272m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000033") },
                    { new Guid("10000000-0000-0000-0000-000000001034"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 34000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1296m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000034") },
                    { new Guid("10000000-0000-0000-0000-000000001035"), new DateTime(2025, 12, 14, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 35000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1320m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000035") },
                    { new Guid("10000000-0000-0000-0000-000000001036"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 36000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1344m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000036") },
                    { new Guid("10000000-0000-0000-0000-000000001037"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 37000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1368m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000037") },
                    { new Guid("10000000-0000-0000-0000-000000001038"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 38000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1392m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000038") },
                    { new Guid("10000000-0000-0000-0000-000000001039"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 39000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1416m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000039") },
                    { new Guid("10000000-0000-0000-0000-000000001040"), new DateTime(2025, 12, 14, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 40000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1440m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000040") },
                    { new Guid("10000000-0000-0000-0000-000000001041"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 41000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1464m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000041") },
                    { new Guid("10000000-0000-0000-0000-000000001042"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 42000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1488m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000042") },
                    { new Guid("10000000-0000-0000-0000-000000001043"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 43000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1512m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000043") },
                    { new Guid("10000000-0000-0000-0000-000000001044"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 44000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1536m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000044") },
                    { new Guid("10000000-0000-0000-0000-000000001045"), new DateTime(2025, 12, 7, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 45000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1560m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000045") },
                    { new Guid("10000000-0000-0000-0000-000000001046"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 46000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1584m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000046") },
                    { new Guid("10000000-0000-0000-0000-000000001047"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 47000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1608m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000047") },
                    { new Guid("10000000-0000-0000-0000-000000001048"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 48000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1632m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000048") },
                    { new Guid("10000000-0000-0000-0000-000000001049"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 49000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1656m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000049") },
                    { new Guid("10000000-0000-0000-0000-000000001050"), new DateTime(2025, 11, 30, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 50000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1680m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000050") },
                    { new Guid("10000000-0000-0000-0000-000000001051"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 51000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1704m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000051") },
                    { new Guid("10000000-0000-0000-0000-000000001052"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 52000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1728m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000052") },
                    { new Guid("10000000-0000-0000-0000-000000001053"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 53000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1752m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000053") },
                    { new Guid("10000000-0000-0000-0000-000000001054"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 54000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1776m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000054") },
                    { new Guid("10000000-0000-0000-0000-000000001055"), new DateTime(2025, 11, 30, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 55000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1800m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000055") },
                    { new Guid("10000000-0000-0000-0000-000000001056"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 56000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1824m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000056") },
                    { new Guid("10000000-0000-0000-0000-000000001057"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 57000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1848m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000057") },
                    { new Guid("10000000-0000-0000-0000-000000001058"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 58000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1872m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000058") },
                    { new Guid("10000000-0000-0000-0000-000000001059"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 59000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1896m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000059") },
                    { new Guid("10000000-0000-0000-0000-000000001060"), new DateTime(2025, 12, 23, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 60000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 480m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000060") },
                    { new Guid("10000000-0000-0000-0000-000000001061"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 61000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 504m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000061") },
                    { new Guid("10000000-0000-0000-0000-000000001062"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 62000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 528m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000062") },
                    { new Guid("10000000-0000-0000-0000-000000001063"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 63000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 552m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000063") },
                    { new Guid("10000000-0000-0000-0000-000000001064"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 64000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 576m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000064") },
                    { new Guid("10000000-0000-0000-0000-000000001065"), new DateTime(2025, 12, 16, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 65000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 600m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000065") },
                    { new Guid("10000000-0000-0000-0000-000000001066"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 66000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 624m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000066") },
                    { new Guid("10000000-0000-0000-0000-000000001067"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 67000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 648m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000067") },
                    { new Guid("10000000-0000-0000-0000-000000001068"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 68000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 672m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000068") },
                    { new Guid("10000000-0000-0000-0000-000000001069"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 69000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 696m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000069") },
                    { new Guid("10000000-0000-0000-0000-000000001070"), new DateTime(2025, 12, 9, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 70000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 720m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000070") },
                    { new Guid("10000000-0000-0000-0000-000000001071"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 71000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 744m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000071") },
                    { new Guid("10000000-0000-0000-0000-000000001072"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 72000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 768m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000072") },
                    { new Guid("10000000-0000-0000-0000-000000001073"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 73000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 792m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000073") },
                    { new Guid("10000000-0000-0000-0000-000000001074"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 74000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 816m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000074") },
                    { new Guid("10000000-0000-0000-0000-000000001075"), new DateTime(2025, 12, 9, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 75000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 840m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000075") },
                    { new Guid("10000000-0000-0000-0000-000000001076"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 76000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 864m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000076") },
                    { new Guid("10000000-0000-0000-0000-000000001077"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 77000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 888m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000077") },
                    { new Guid("10000000-0000-0000-0000-000000001078"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 78000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 912m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000078") },
                    { new Guid("10000000-0000-0000-0000-000000001079"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 79000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 936m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000079") },
                    { new Guid("10000000-0000-0000-0000-000000001080"), new DateTime(2025, 12, 2, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 80000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 960m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000080") },
                    { new Guid("10000000-0000-0000-0000-000000001081"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 81000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 984m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000081") },
                    { new Guid("10000000-0000-0000-0000-000000001082"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 82000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1008m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000082") },
                    { new Guid("10000000-0000-0000-0000-000000001083"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 83000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1032m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000083") },
                    { new Guid("10000000-0000-0000-0000-000000001084"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 84000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1056m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000084") },
                    { new Guid("10000000-0000-0000-0000-000000001085"), new DateTime(2025, 11, 25, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 85000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1080m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000085") },
                    { new Guid("10000000-0000-0000-0000-000000001086"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 86000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1104m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000086") },
                    { new Guid("10000000-0000-0000-0000-000000001087"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 87000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1128m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000087") },
                    { new Guid("10000000-0000-0000-0000-000000001088"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 88000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1152m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000088") },
                    { new Guid("10000000-0000-0000-0000-000000001089"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 89000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1176m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000089") },
                    { new Guid("10000000-0000-0000-0000-000000001090"), new DateTime(2025, 12, 25, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 90000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1200m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000090") },
                    { new Guid("10000000-0000-0000-0000-000000001091"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 91000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1224m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000091") },
                    { new Guid("10000000-0000-0000-0000-000000001092"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 92000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1248m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000092") },
                    { new Guid("10000000-0000-0000-0000-000000001093"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 93000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1272m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000093") },
                    { new Guid("10000000-0000-0000-0000-000000001094"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 94000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1296m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000094") },
                    { new Guid("10000000-0000-0000-0000-000000001095"), new DateTime(2025, 12, 18, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 95000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1320m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000095") },
                    { new Guid("10000000-0000-0000-0000-000000001096"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 96000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1344m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000096") },
                    { new Guid("10000000-0000-0000-0000-000000001097"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 97000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1368m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000097") },
                    { new Guid("10000000-0000-0000-0000-000000001098"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 98000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1392m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000098") },
                    { new Guid("10000000-0000-0000-0000-000000001099"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 99000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1416m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000099") },
                    { new Guid("10000000-0000-0000-0000-000000001100"), new DateTime(2025, 12, 11, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 100000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1440m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000100") },
                    { new Guid("10000000-0000-0000-0000-000000001101"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 101000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1464m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000101") },
                    { new Guid("10000000-0000-0000-0000-000000001102"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 102000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1488m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000102") },
                    { new Guid("10000000-0000-0000-0000-000000001103"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 103000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1512m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000103") },
                    { new Guid("10000000-0000-0000-0000-000000001104"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 104000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1536m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000104") },
                    { new Guid("10000000-0000-0000-0000-000000001105"), new DateTime(2025, 12, 4, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 105000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1560m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000105") },
                    { new Guid("10000000-0000-0000-0000-000000001106"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 106000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1584m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000106") },
                    { new Guid("10000000-0000-0000-0000-000000001107"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 107000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1608m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000107") },
                    { new Guid("10000000-0000-0000-0000-000000001108"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 108000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1632m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000108") },
                    { new Guid("10000000-0000-0000-0000-000000001109"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 109000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1656m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000109") },
                    { new Guid("10000000-0000-0000-0000-000000001110"), new DateTime(2025, 12, 4, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 110000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1680m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000110") },
                    { new Guid("10000000-0000-0000-0000-000000001111"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 111000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1704m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000111") },
                    { new Guid("10000000-0000-0000-0000-000000001112"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 112000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1728m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000112") },
                    { new Guid("10000000-0000-0000-0000-000000001113"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 113000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1752m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000113") },
                    { new Guid("10000000-0000-0000-0000-000000001114"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 114000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1776m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000114") },
                    { new Guid("10000000-0000-0000-0000-000000001115"), new DateTime(2025, 11, 27, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 115000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1800m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000115") },
                    { new Guid("10000000-0000-0000-0000-000000001116"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 116000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1824m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000116") },
                    { new Guid("10000000-0000-0000-0000-000000001117"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 117000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1848m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000117") },
                    { new Guid("10000000-0000-0000-0000-000000001118"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 118000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1872m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000118") },
                    { new Guid("10000000-0000-0000-0000-000000001119"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 119000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1896m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000119") },
                    { new Guid("10000000-0000-0000-0000-000000001120"), new DateTime(2025, 12, 20, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 120000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 480m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000120") },
                    { new Guid("10000000-0000-0000-0000-000000001121"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 121000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 504m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000121") },
                    { new Guid("10000000-0000-0000-0000-000000001122"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 122000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 528m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000122") },
                    { new Guid("10000000-0000-0000-0000-000000001123"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 123000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 552m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000123") },
                    { new Guid("10000000-0000-0000-0000-000000001124"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 124000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 576m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000124") },
                    { new Guid("10000000-0000-0000-0000-000000001125"), new DateTime(2025, 12, 20, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 125000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 600m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000125") },
                    { new Guid("10000000-0000-0000-0000-000000001126"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 126000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 624m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000126") },
                    { new Guid("10000000-0000-0000-0000-000000001127"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 127000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 648m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000127") },
                    { new Guid("10000000-0000-0000-0000-000000001128"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 128000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 672m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000128") },
                    { new Guid("10000000-0000-0000-0000-000000001129"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 129000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 696m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000129") },
                    { new Guid("10000000-0000-0000-0000-000000001130"), new DateTime(2025, 12, 13, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 130000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 720m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000130") },
                    { new Guid("10000000-0000-0000-0000-000000001131"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 131000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 744m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000131") },
                    { new Guid("10000000-0000-0000-0000-000000001132"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 132000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 768m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000132") },
                    { new Guid("10000000-0000-0000-0000-000000001133"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 133000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 792m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000133") },
                    { new Guid("10000000-0000-0000-0000-000000001134"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 134000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 816m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000134") },
                    { new Guid("10000000-0000-0000-0000-000000001135"), new DateTime(2025, 12, 6, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 135000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 840m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000135") },
                    { new Guid("10000000-0000-0000-0000-000000001136"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 136000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 864m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000136") },
                    { new Guid("10000000-0000-0000-0000-000000001137"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 137000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 888m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000137") },
                    { new Guid("10000000-0000-0000-0000-000000001138"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 138000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 912m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000138") },
                    { new Guid("10000000-0000-0000-0000-000000001139"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 139000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 936m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000139") },
                    { new Guid("10000000-0000-0000-0000-000000001140"), new DateTime(2025, 11, 29, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 140000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 960m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000140") },
                    { new Guid("10000000-0000-0000-0000-000000001141"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 141000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 984m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000141") },
                    { new Guid("10000000-0000-0000-0000-000000001142"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 142000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1008m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000142") },
                    { new Guid("10000000-0000-0000-0000-000000001143"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 143000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1032m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000143") },
                    { new Guid("10000000-0000-0000-0000-000000001144"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 144000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1056m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000144") },
                    { new Guid("10000000-0000-0000-0000-000000001145"), new DateTime(2025, 11, 29, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 145000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1080m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000145") },
                    { new Guid("10000000-0000-0000-0000-000000001146"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 146000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1104m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000146") },
                    { new Guid("10000000-0000-0000-0000-000000001147"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 147000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1128m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000147") },
                    { new Guid("10000000-0000-0000-0000-000000001148"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 148000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1152m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000148") },
                    { new Guid("10000000-0000-0000-0000-000000001149"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 149000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1176m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000149") },
                    { new Guid("10000000-0000-0000-0000-000000001150"), new DateTime(2025, 12, 22, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 150000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1200m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000150") },
                    { new Guid("10000000-0000-0000-0000-000000001151"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 151000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1224m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000151") },
                    { new Guid("10000000-0000-0000-0000-000000001152"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 152000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1248m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000152") },
                    { new Guid("10000000-0000-0000-0000-000000001153"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 153000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1272m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000153") },
                    { new Guid("10000000-0000-0000-0000-000000001154"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 154000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1296m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000154") },
                    { new Guid("10000000-0000-0000-0000-000000001155"), new DateTime(2025, 12, 15, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 155000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1320m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000155") },
                    { new Guid("10000000-0000-0000-0000-000000001156"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 156000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1344m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000156") },
                    { new Guid("10000000-0000-0000-0000-000000001157"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 157000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1368m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000157") },
                    { new Guid("10000000-0000-0000-0000-000000001158"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 158000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1392m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000158") },
                    { new Guid("10000000-0000-0000-0000-000000001159"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 159000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1416m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000159") },
                    { new Guid("10000000-0000-0000-0000-000000001160"), new DateTime(2025, 12, 15, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 160000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1440m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000160") },
                    { new Guid("10000000-0000-0000-0000-000000001161"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 161000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1464m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000161") },
                    { new Guid("10000000-0000-0000-0000-000000001162"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 162000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1488m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000162") },
                    { new Guid("10000000-0000-0000-0000-000000001163"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 163000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1512m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000163") },
                    { new Guid("10000000-0000-0000-0000-000000001164"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 164000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1536m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000164") },
                    { new Guid("10000000-0000-0000-0000-000000001165"), new DateTime(2025, 12, 8, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 165000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1560m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000165") },
                    { new Guid("10000000-0000-0000-0000-000000001166"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 166000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1584m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000166") },
                    { new Guid("10000000-0000-0000-0000-000000001167"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 167000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1608m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000167") },
                    { new Guid("10000000-0000-0000-0000-000000001168"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 168000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1632m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000168") },
                    { new Guid("10000000-0000-0000-0000-000000001169"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 169000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1656m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000169") },
                    { new Guid("10000000-0000-0000-0000-000000001170"), new DateTime(2025, 12, 1, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 170000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1680m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000170") },
                    { new Guid("10000000-0000-0000-0000-000000001171"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 171000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 27, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1704m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000171") },
                    { new Guid("10000000-0000-0000-0000-000000001172"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 172000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1728m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000172") },
                    { new Guid("10000000-0000-0000-0000-000000001173"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 173000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 25, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1752m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000173") },
                    { new Guid("10000000-0000-0000-0000-000000001174"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 174000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1776m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000174") },
                    { new Guid("10000000-0000-0000-0000-000000001175"), new DateTime(2025, 11, 24, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 175000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 23, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1800m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000175") },
                    { new Guid("10000000-0000-0000-0000-000000001176"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 176000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 22, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1824m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000176") },
                    { new Guid("10000000-0000-0000-0000-000000001177"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 177000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 21, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1848m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000177") },
                    { new Guid("10000000-0000-0000-0000-000000001178"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 178000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 20, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1872m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000178") },
                    { new Guid("10000000-0000-0000-0000-000000001179"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 11, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 179000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 19, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 1896m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000179") },
                    { new Guid("10000000-0000-0000-0000-000000001180"), new DateTime(2025, 12, 24, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 180000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 480m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000180") },
                    { new Guid("10000000-0000-0000-0000-000000001181"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 24, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 181000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 504m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000181") },
                    { new Guid("10000000-0000-0000-0000-000000001182"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 182000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 16, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 528m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000182") },
                    { new Guid("10000000-0000-0000-0000-000000001183"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 183000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 15, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 552m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000183") },
                    { new Guid("10000000-0000-0000-0000-000000001184"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 184000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 14, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 576m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000184") },
                    { new Guid("10000000-0000-0000-0000-000000001185"), new DateTime(2025, 12, 17, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 185000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 13, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 600m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000185") },
                    { new Guid("10000000-0000-0000-0000-000000001186"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 186000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 12, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 624m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000186") },
                    { new Guid("10000000-0000-0000-0000-000000001187"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 187000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 11, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 648m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000187") },
                    { new Guid("10000000-0000-0000-0000-000000001188"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 17, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 188000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 672m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000188") },
                    { new Guid("10000000-0000-0000-0000-000000001189"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 189000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 9, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 696m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000189") },
                    { new Guid("10000000-0000-0000-0000-000000001190"), new DateTime(2025, 12, 10, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 190000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 8, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 720m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000190") },
                    { new Guid("10000000-0000-0000-0000-000000001191"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 191000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 7, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 744m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000191") },
                    { new Guid("10000000-0000-0000-0000-000000001192"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 192000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 6, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 768m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000192") },
                    { new Guid("10000000-0000-0000-0000-000000001193"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 193000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 5, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 792m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000193") },
                    { new Guid("10000000-0000-0000-0000-000000001194"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 194000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 12, 4, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 816m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000194") },
                    { new Guid("10000000-0000-0000-0000-000000001195"), new DateTime(2025, 12, 10, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 10, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, 200000m, false, 0.0m, 195000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 840m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000195") },
                    { new Guid("10000000-0000-0000-0000-000000001196"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 196000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 12, 2, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 864m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000196") },
                    { new Guid("10000000-0000-0000-0000-000000001197"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000002"), null, null, 0.1m, null, new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 197000, new Guid("10000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 12, 1, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 888m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000197") },
                    { new Guid("10000000-0000-0000-0000-000000001198"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000003"), null, null, 0.1m, null, new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, 200000m, false, 0.0m, 198000, new Guid("10000000-0000-0000-0000-000000000003"), new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 11, 30, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 912m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000198") },
                    { new Guid("10000000-0000-0000-0000-000000001199"), null, null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000004"), null, null, 0.1m, null, new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 60, null, false, 0.0m, 199000, new Guid("10000000-0000-0000-0000-000000000004"), new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 29, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 936m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000199") },
                    { new Guid("10000000-0000-0000-0000-000000001200"), new DateTime(2025, 12, 3, 17, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000001"), null, null, 0.1m, null, new DateTime(2025, 12, 3, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 80, null, false, 0.0m, 200000, new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), 960m, new DateTime(2025, 12, 18, 15, 35, 26, 561, DateTimeKind.Utc).AddTicks(8327), null, new Guid("00000000-0000-0000-0000-000000000200") }
                });

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
                name: "IX_vehicle_read_flat_location_id",
                table: "vehicle_read_flat",
                column: "location_id");

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_read_flat_number_plate",
                table: "vehicle_read_flat",
                column: "number_plate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicle_read_flat_status",
                table: "vehicle_read_flat",
                column: "status");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_locations_location_id",
                table: "vehicles",
                column: "location_id",
                principalTable: "locations",
                principalColumn: "location_id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
