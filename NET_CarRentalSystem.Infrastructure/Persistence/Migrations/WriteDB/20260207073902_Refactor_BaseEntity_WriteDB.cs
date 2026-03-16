using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.WriteDB
{
    /// <inheritdoc />
    public partial class Refactor_BaseEntity_WriteDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("005b4d69-5344-4291-94de-576bdcc72bdd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0098b202-186f-4d58-890e-9746cf047da4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05b377ef-aebe-4f00-b161-c731cf66b8fc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0962978e-f68c-4f10-b9e4-2f2296e72463"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0c5831f8-ff5c-47ec-bd31-2b493472b535"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1947bd74-1510-4683-b588-95b3da54bab2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1e5a5032-ab87-4576-b21a-95d21e16c874"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("20f898ce-53e7-4fee-8185-d5b282228591"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2321e197-cd51-4c58-bf73-5297a4f07075"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2792fcbf-5ddf-4ec7-871a-bee665d99960"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e7b4e01-eb9e-4123-b206-7e026dc092a9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2e82356e-0207-4a8f-a26a-c427dfc0d90e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("30b8dfc6-309d-4d90-8ae0-a6dd0d2a9d3d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("32344919-e5fe-457c-9646-1e939404cf9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("329ecd33-6992-4bb0-9465-bd8b621d40e3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3634b9f8-a2a9-4c7b-9379-cbd480c97ed2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("38d5c80b-dc58-492c-b773-2e71aca4795b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3d401069-8db6-46fc-a460-d5ceaa2e91a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("41d11d35-587a-40fe-a555-d82d168b102d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("46f6cd7f-e83b-45ec-99e1-154b3ddde079"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4839d953-04df-4b78-9026-a771dbcd664a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("48e4eea2-9ed0-4ad8-8892-3091de5f2117"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("56cc240f-f9ad-4844-8966-0ba7b6fb7d54"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6494f7d3-a1ed-41ac-86d0-142662bf9048"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6db0fa88-8ed1-41a7-ab9b-65888b1e6e1c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("718d3603-3dc5-480e-b4f5-78d682b3b834"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("791192bd-839e-4e7d-9682-0113c13c0f54"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("815ac59a-b756-4da0-afbd-dd38d7c9d0a8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("826c7dbd-60ee-40b5-87fa-32fd6610fcd4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8cd3d87b-4fc1-40ae-9c06-0a535d075f16"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f069dc0-47cc-464b-a61f-0ae31dd53786"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f64b21a-d7b0-4e68-a42a-488311b4df63"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("91be52ef-2300-40b1-8f70-634c9485cff1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("928e1bcd-710a-4119-a768-477bb5740e02"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97abd8e5-700e-4b25-ba64-6942bdbff8cc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("97dc0b84-9751-4e3e-a850-175e2713cb3c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9f7fdbb9-3bbe-4c22-9632-d20fb7438c5e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a36ca8b0-6052-4343-a922-60e5c2edbe6c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aba0ca0c-f9a5-4ad0-b45c-081fee1e5355"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ac386893-a9d4-4e35-b7b6-e4252e3eee25"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("acd44ea5-a453-4402-93dd-ddd52104be77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad6863bf-1873-4b08-a8af-8442e224873d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("adc71771-1032-4655-8eb7-e7bf7ec43a9f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b14fde3d-b044-403a-8044-1fb5b9e09793"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b31d455b-4e06-42ad-9a8b-86d592b1f715"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bb53521b-af3d-46f6-ae2e-dd2f224d5363"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bd04cc24-50de-4c95-9afc-e173f0a6ff74"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ceda8ced-a7c2-46c2-b738-80e718ebbeea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("da40a484-5876-4991-a36c-f223c900862a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e899fa20-fe31-487b-bd65-e2d944e3bde7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ecded164-6a3a-46c7-a90f-c36a29e0a622"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edddfc96-eb9b-459b-9601-ea88a1a5dab9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("edf7769c-0d58-43f4-acf2-1e60d676db93"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f502c62c-8f99-49a4-8ae6-223a0c29f2aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fe72254c-0552-4d78-b039-6bf09a31b5e4"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("7f7b946d-455d-4b34-876c-e7abcffe47b5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9475bf82-ce98-4ebe-9856-0e11b19fdac5"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b39dd88b-e36c-43d7-a348-845b96c8e6f9"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("ee1d31d0-2a4c-4b7d-84c2-96a9bf0c85e0"));

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "webhook_logs",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "webhook_logs",
                newName: "deleted_at");

// Rename removed

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "users",
                newName: "updated_by");

// Rename removed

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "users",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "users",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "users",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "user_verifications",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "user_verifications",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "user_verifications",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "user_verifications",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "user_verifications",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "user_verifications",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "user_verifications",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "user_sessions",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "user_sessions",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "user_sessions",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "user_sessions",
                newName: "created_by");

// Rename removed

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "system_settings",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "system_settings",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "system_settings",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "system_settings",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "system_settings",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "system_settings",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "system_settings",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "refund_requests",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "refund_requests",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "refund_processing_logs",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "refund_processing_logs",
                newName: "deleted_at");

// Rename removed

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "locations",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "locations",
                newName: "deleted_at");

// Rename removed

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "customers",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "customers",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "customers",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "customers",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "customers",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "customers",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "customers",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "booking_images",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "booking_images",
                newName: "deleted_at");

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "webhook_logs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "webhook_logs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "webhook_logs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "vehicle_return_images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "vehicle_categories");

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "vehicle_categories",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValueSql: "MIN_ACTIVE_ROWVERSION()");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "users");

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "users",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValueSql: "MIN_ACTIVE_ROWVERSION()");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "transmissions");

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "transmissions",
                type: "rowversion",
                rowVersion: true,
                nullable: true,
                defaultValueSql: "MIN_ACTIVE_ROWVERSION()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "terms_and_conditions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "refund_requests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "refund_requests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "refund_requests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "refund_processing_logs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "refund_processing_logs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "refund_processing_logs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "refund_processing_logs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "payment_transactions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "locations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "locations");

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "locations",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValueSql: "MIN_ACTIVE_ROWVERSION()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "insurance_packages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "fuels");

            migrationBuilder.AddColumn<byte[]>(
                name: "row_version",
                table: "fuels",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValueSql: "MIN_ACTIVE_ROWVERSION()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "booking_violations",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "booking_insurances",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "booking_images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "booking_images",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "booking_images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(9343), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(9343), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(9343), new DateTime(2026, 2, 7, 7, 38, 59, 674, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 38, 59, 675, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 38, 59, 675, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 38, 59, 675, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919), new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919), new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919), new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919), new DateTime(2026, 2, 7, 7, 38, 59, 676, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("01e392e8-34aa-4735-9739-03e4d169fc64"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0276d65e-f12d-4fdb-9273-3291c5f1fc1b"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0480c097-5e31-41bf-975d-7888621e0ec6"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("048145e0-1193-46ea-8888-a0850b10ba50"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0498b729-a848-47cf-acc7-478152f72b37"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1d0939a2-b377-48aa-9516-e24533e5ced7"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1f0f3fbd-70a5-480e-960f-2ba2c8be8821"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("225a7986-f06c-4b89-9bc5-0e1b6e3b835b"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2c7ad222-e899-4540-8bbc-13524480ba91"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("34bf2614-89ee-4f3d-8c24-19345535c27b"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("39ed973c-db65-4a8b-888b-3dd13c6f1fbd"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("3e94edce-7fe1-421c-875d-ee0624567bc8"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("42853313-a30e-49d7-9990-834cc487f018"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("438b6cd0-5b98-4a44-b8e0-17a479f608fa"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("501be2fb-311a-450f-9609-28c2f26ad3be"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("589a5433-a9bb-4941-b8e1-624d96faa338"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("619e8f9d-5ed6-4686-b806-afae1bb0c322"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("62b9c77f-92e5-45d2-8a4e-1ed22e02118d"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66a0b8c7-32b9-4f84-9e8b-4459652f7fec"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6b604b77-ea11-4216-a86d-bc7f4241cef1"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("74ab74fc-f2e6-4230-8562-bbabadd02c5c"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("76460e49-a964-4be4-b662-9ebca50281b8"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("76fe0bbc-f7f3-43a1-a087-f4cec79f9f31"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7a78e57f-421e-47dc-8959-e261e5576c19"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7ae739f5-5aaf-4a7d-b6d3-35f275744011"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80e05b76-f308-42dd-92d7-f0a4c90fc0e6"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("8816b5b0-2537-433e-ad03-2d256758207c"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8b49adaf-db53-4925-bda5-72bfb9056f03"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("933a7e7b-3079-48e7-b688-a3dbdfb28fbc"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9375d9b5-090b-4db5-9735-45f3167972c3"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9cdc2a7e-2ca3-4e00-80f4-ba9ea7deef40"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9ef75a28-37c2-420b-865e-692be2919f20"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("a2074970-7d09-4b73-bfa5-f55ff6fce5ca"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a47a77ef-d955-42eb-a6b8-392e3192c0e8"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a74d2039-39d9-4877-95f1-2887c8f045f4"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ab691da4-24dd-4464-bf80-89c3cde83361"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("adc5daec-ce0b-47c8-b382-83cc35497f2d"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("b5037c0a-8c21-4117-abea-f5f4d4ba3c1f"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b78366b0-fb7e-45e8-b239-50a5b54c13d5"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bef9580f-755e-45df-a209-684174c537e3"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("bf06a93c-0de2-45ec-8919-83c16b964844"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c0a45b08-b212-493b-aa9f-c2014eaa85da"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c2fc4367-f21c-402e-8055-61779f811d20"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c3e909f5-befd-4a8c-b828-b0ac30a4769e"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cde42ca2-d6ca-4f61-97d4-73d010f4ae0d"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dbf37e38-9eda-45fc-8912-2a087fe28b23"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("dc6f14b1-0cf9-4eee-96a8-4e29dcf22c38"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("de3c58be-d5ee-4705-ac3b-5471a1ffdda2"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e497d3f2-31b4-41af-b37c-772ffc8a8486"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e59756ac-a2f6-44cd-a6a5-ef559a7755fd"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ece10d3a-8267-418d-a925-361016833503"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ed2a1f1f-27a5-478a-a148-5a27c4b58915"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eea56142-b50c-4c79-be39-a590e2047293"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f41c0d35-a139-48cd-8319-32782443a1a2"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f644d931-19c0-4308-baa0-67e8f2e88e65"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "a0369725-e90f-4b48-9da4-5b5a1bddb553");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "8532e3f7-6e2f-4a93-ae8d-1a3619b6ae7c");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "a7dfe446-2274-4c1e-9c4f-0b857f86a0b7");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "14aa0fdf-3b02-4a34-a739-4957a91c4c33");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 38, 59, 683, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 38, 59, 683, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 38, 59, 683, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("1279144e-c3e5-407b-ac22-c498654783df"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("4a6d01f5-81db-41d8-95bb-3e2fdebf2b38"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("8ff28803-6134-4220-9b33-f73b1adbad05"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("d3ceafd1-bb03-4259-a4f5-162207354ec2"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265), "$2a$11$ZWoElEhL53WGuEWSyBdTvOSV4Ik9dSQtZOhShhXqBGqzZtZkDP8JO", new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265), "$2a$11$GuazhvqIYTAsEPr4u4Sz7.ajpDEeJz9bAT2pkZdtbMvmfii1FQTVq", new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265), "$2a$11$oqpIUXOBjdansXs9nXcUPeFiwjQu1kOsJSe8C7vdnVHuK39uiMqv.", new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265), "$2a$11$BTR2SF3pd7IvreFa1hFReOQw7FPWoooGXYyzX9729dIn47OWV1kbG", new DateTime(2026, 2, 7, 7, 38, 59, 687, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530), new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530), new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530), new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530), new DateTime(2026, 2, 7, 7, 39, 0, 221, DateTimeKind.Utc).AddTicks(3530) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("01e392e8-34aa-4735-9739-03e4d169fc64"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0276d65e-f12d-4fdb-9273-3291c5f1fc1b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0480c097-5e31-41bf-975d-7888621e0ec6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("048145e0-1193-46ea-8888-a0850b10ba50"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0498b729-a848-47cf-acc7-478152f72b37"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1d0939a2-b377-48aa-9516-e24533e5ced7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1f0f3fbd-70a5-480e-960f-2ba2c8be8821"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("225a7986-f06c-4b89-9bc5-0e1b6e3b835b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2c7ad222-e899-4540-8bbc-13524480ba91"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("34bf2614-89ee-4f3d-8c24-19345535c27b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("39ed973c-db65-4a8b-888b-3dd13c6f1fbd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3e94edce-7fe1-421c-875d-ee0624567bc8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("42853313-a30e-49d7-9990-834cc487f018"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("438b6cd0-5b98-4a44-b8e0-17a479f608fa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("501be2fb-311a-450f-9609-28c2f26ad3be"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("589a5433-a9bb-4941-b8e1-624d96faa338"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("619e8f9d-5ed6-4686-b806-afae1bb0c322"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("62b9c77f-92e5-45d2-8a4e-1ed22e02118d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66a0b8c7-32b9-4f84-9e8b-4459652f7fec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6b604b77-ea11-4216-a86d-bc7f4241cef1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("74ab74fc-f2e6-4230-8562-bbabadd02c5c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("76460e49-a964-4be4-b662-9ebca50281b8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("76fe0bbc-f7f3-43a1-a087-f4cec79f9f31"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7a78e57f-421e-47dc-8959-e261e5576c19"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7ae739f5-5aaf-4a7d-b6d3-35f275744011"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80e05b76-f308-42dd-92d7-f0a4c90fc0e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8816b5b0-2537-433e-ad03-2d256758207c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8b49adaf-db53-4925-bda5-72bfb9056f03"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("933a7e7b-3079-48e7-b688-a3dbdfb28fbc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9375d9b5-090b-4db5-9735-45f3167972c3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9cdc2a7e-2ca3-4e00-80f4-ba9ea7deef40"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9ef75a28-37c2-420b-865e-692be2919f20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a2074970-7d09-4b73-bfa5-f55ff6fce5ca"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a47a77ef-d955-42eb-a6b8-392e3192c0e8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a74d2039-39d9-4877-95f1-2887c8f045f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ab691da4-24dd-4464-bf80-89c3cde83361"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("adc5daec-ce0b-47c8-b382-83cc35497f2d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b5037c0a-8c21-4117-abea-f5f4d4ba3c1f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b78366b0-fb7e-45e8-b239-50a5b54c13d5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bef9580f-755e-45df-a209-684174c537e3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bf06a93c-0de2-45ec-8919-83c16b964844"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c0a45b08-b212-493b-aa9f-c2014eaa85da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2fc4367-f21c-402e-8055-61779f811d20"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c3e909f5-befd-4a8c-b828-b0ac30a4769e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cde42ca2-d6ca-4f61-97d4-73d010f4ae0d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dbf37e38-9eda-45fc-8912-2a087fe28b23"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dc6f14b1-0cf9-4eee-96a8-4e29dcf22c38"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de3c58be-d5ee-4705-ac3b-5471a1ffdda2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e497d3f2-31b4-41af-b37c-772ffc8a8486"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e59756ac-a2f6-44cd-a6a5-ef559a7755fd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ece10d3a-8267-418d-a925-361016833503"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ed2a1f1f-27a5-478a-a148-5a27c4b58915"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eea56142-b50c-4c79-be39-a590e2047293"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f41c0d35-a139-48cd-8319-32782443a1a2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f644d931-19c0-4308-baa0-67e8f2e88e65"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("1279144e-c3e5-407b-ac22-c498654783df"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("4a6d01f5-81db-41d8-95bb-3e2fdebf2b38"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("8ff28803-6134-4220-9b33-f73b1adbad05"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("d3ceafd1-bb03-4259-a4f5-162207354ec2"));

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "webhook_logs",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "webhook_logs",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "row_version",
                table: "vehicle_categories",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "users",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "row_version",
                table: "users",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "users",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "users",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "users",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "user_verifications",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "user_verifications",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "user_verifications",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "user_verifications",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "user_verifications",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "user_verifications",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "user_verifications",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "user_sessions",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "user_sessions",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "user_sessions",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "user_sessions",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "row_version",
                table: "transmissions",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "system_settings",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "system_settings",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "system_settings",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "system_settings",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "system_settings",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "system_settings",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "system_settings",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "refund_requests",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "refund_requests",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "refund_processing_logs",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "refund_processing_logs",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "row_version",
                table: "locations",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "locations",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "locations",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "row_version",
                table: "fuels",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "customers",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "customers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "customers",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "customers",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "customers",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "customers",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "customers",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "booking_images",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "booking_images",
                newName: "DeletedAt");

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "webhook_logs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "webhook_logs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "webhook_logs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "vehicle_return_images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "vehicle_categories",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "users",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "transmissions",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "terms_and_conditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "refund_requests",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "refund_requests",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "refund_requests",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "refund_processing_logs",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "refund_processing_logs",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "refund_processing_logs",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "refund_processing_logs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "payment_transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "locations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "locations",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "insurance_packages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "fuels",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "rowversion",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "booking_violations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "booking_insurances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "booking_images",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "booking_images",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "booking_images",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706), new DateTime(2026, 1, 28, 14, 44, 24, 801, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 802, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006), new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 803, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("005b4d69-5344-4291-94de-576bdcc72bdd"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0098b202-186f-4d58-890e-9746cf047da4"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05b377ef-aebe-4f00-b161-c731cf66b8fc"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("0962978e-f68c-4f10-b9e4-2f2296e72463"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("0c5831f8-ff5c-47ec-bd31-2b493472b535"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1947bd74-1510-4683-b588-95b3da54bab2"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1e5a5032-ab87-4576-b21a-95d21e16c874"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("20f898ce-53e7-4fee-8185-d5b282228591"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2321e197-cd51-4c58-bf73-5297a4f07075"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2792fcbf-5ddf-4ec7-871a-bee665d99960"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e7b4e01-eb9e-4123-b206-7e026dc092a9"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2e82356e-0207-4a8f-a26a-c427dfc0d90e"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("30b8dfc6-309d-4d90-8ae0-a6dd0d2a9d3d"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("32344919-e5fe-457c-9646-1e939404cf9f"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("329ecd33-6992-4bb0-9465-bd8b621d40e3"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3634b9f8-a2a9-4c7b-9379-cbd480c97ed2"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("38d5c80b-dc58-492c-b773-2e71aca4795b"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("3d401069-8db6-46fc-a460-d5ceaa2e91a5"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("41d11d35-587a-40fe-a555-d82d168b102d"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("46f6cd7f-e83b-45ec-99e1-154b3ddde079"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("4839d953-04df-4b78-9026-a771dbcd664a"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("48e4eea2-9ed0-4ad8-8892-3091de5f2117"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("56cc240f-f9ad-4844-8966-0ba7b6fb7d54"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6494f7d3-a1ed-41ac-86d0-142662bf9048"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6db0fa88-8ed1-41a7-ab9b-65888b1e6e1c"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("718d3603-3dc5-480e-b4f5-78d682b3b834"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("791192bd-839e-4e7d-9682-0113c13c0f54"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("815ac59a-b756-4da0-afbd-dd38d7c9d0a8"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("826c7dbd-60ee-40b5-87fa-32fd6610fcd4"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8cd3d87b-4fc1-40ae-9c06-0a535d075f16"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("8f069dc0-47cc-464b-a61f-0ae31dd53786"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8f64b21a-d7b0-4e68-a42a-488311b4df63"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("91be52ef-2300-40b1-8f70-634c9485cff1"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("928e1bcd-710a-4119-a768-477bb5740e02"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("97abd8e5-700e-4b25-ba64-6942bdbff8cc"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("97dc0b84-9751-4e3e-a850-175e2713cb3c"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9f7fdbb9-3bbe-4c22-9632-d20fb7438c5e"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a36ca8b0-6052-4343-a922-60e5c2edbe6c"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("aba0ca0c-f9a5-4ad0-b45c-081fee1e5355"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ac386893-a9d4-4e35-b7b6-e4252e3eee25"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("acd44ea5-a453-4402-93dd-ddd52104be77"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad6863bf-1873-4b08-a8af-8442e224873d"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("adc71771-1032-4655-8eb7-e7bf7ec43a9f"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b14fde3d-b044-403a-8044-1fb5b9e09793"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b31d455b-4e06-42ad-9a8b-86d592b1f715"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("bb53521b-af3d-46f6-ae2e-dd2f224d5363"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("bd04cc24-50de-4c95-9afc-e173f0a6ff74"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ceda8ced-a7c2-46c2-b738-80e718ebbeea"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("da40a484-5876-4991-a36c-f223c900862a"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e899fa20-fe31-487b-bd65-e2d944e3bde7"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ecded164-6a3a-46c7-a90f-c36a29e0a622"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("edddfc96-eb9b-459b-9601-ea88a1a5dab9"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("edf7769c-0d58-43f4-acf2-1e60d676db93"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f502c62c-8f99-49a4-8ae6-223a0c29f2aa"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("fe72254c-0552-4d78-b039-6bf09a31b5e4"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "71ae4f89-2cbc-4f4e-a78a-d7e63c52d89a");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "4f3d351d-c8dd-43e0-85c0-07b8273c5e29");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "233dcf6e-702a-4e22-aa12-9acc39936b67");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "5aad462e-dcac-42a3-a7d8-d5b59ded8056");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 811, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 811, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 44, 24, 811, DateTimeKind.Utc).AddTicks(3247));

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
                    { new Guid("7f7b946d-455d-4b34-876c-e7abcffe47b5"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("9475bf82-ce98-4ebe-9856-0e11b19fdac5"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("b39dd88b-e36c-43d7-a348-845b96c8e6f9"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("ee1d31d0-2a4c-4b7d-84c2-96a9bf0c85e0"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$QnbpCkSQpDJGDGkTvtBJZ.DxVAXpSJEjD2/oAFs0R4nBf6u03dYzK", new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$5NcaWtPdR2e/D.8AUJahxO3DTTtGknQQmc0Z3UJWCbTKKoWsB9XZy", new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$2b73amhKmkQuElZjem1ABev4r5UFGlxysovrmTLaNaLe9hvqWzOTG", new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068), "$2a$11$lgLLu./RNuelvMAd2XVVZeG0MmlyblpU3JiqMMdjfaN/95gNiJp5G", new byte[0], new DateTime(2026, 1, 28, 14, 44, 24, 813, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new byte[0], new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new byte[0], new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new byte[0], new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344), new byte[0], new DateTime(2026, 1, 28, 14, 44, 25, 335, DateTimeKind.Utc).AddTicks(5344) });
        }
    }
}
