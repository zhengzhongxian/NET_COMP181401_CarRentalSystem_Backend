using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NET_CarRentalSystem.Infrastructure.Persistence.Migrations.ReadDB
{
    /// <inheritdoc />
    public partial class Refactor_BaseEntity_ReadDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("04359469-76fb-4077-8fa7-d159683bef8b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0efe80d9-14c4-4cfa-9af5-9bd8153dd6e7"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1126fa72-92e7-45a6-b39d-5d753fdac6ee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("11b3e189-c271-4b97-8a81-1165f5e51112"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("16a911fd-3a89-4548-8d13-da313f002356"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("17a47c76-a2e2-4698-b5e0-d71cc7a68cb0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1b654908-c85f-4916-8099-f0ac070868ff"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1bf20d44-bc91-493b-8ca6-da6d7f707dea"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1dcfbb73-a355-4bd9-8c67-1b5d4b0a232a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1f36dc52-325c-470f-8fd4-130c1c344070"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("21eb37aa-3629-46ff-a4cf-6a2ee736ef1f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2bff8c33-4991-45c7-971d-0e460a8d63ab"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2dd91366-c867-4fd0-a663-0886174c1484"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2ef8b685-5509-4160-adde-1cc6c6203269"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("362ac8a7-28a8-4d79-a01a-ed19475ed52b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4092830e-f3dc-499b-a967-bef69d98d5b5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("446698c6-37bf-4fc2-9910-29697a08e1e6"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4ba92ee4-b268-4429-b797-f4828d391c6a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("511934fe-e2f8-4e7f-a17a-2e8b49ebfc3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("51648138-9cb2-43c5-8838-d468b0036e5f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("59c4dbc2-253f-4523-8929-8b40e14b6ae1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("61285281-32ec-46ac-a421-5de8d309c07c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("63987aac-1f6c-4a74-a2f4-c5821518fb45"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("66c6d29a-c890-441c-ab19-2fcd2e797cb1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("6cb9d1ea-c067-4d1e-9e62-d29c1e9a9501"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("80d1b6f1-0338-4a1e-9969-60391b88c946"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8378e753-b212-43a8-adb5-1a5aff97a32a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("84b2a423-78c3-4895-9674-6bab2325f0da"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8650f4f1-1d96-4844-b593-c77afc75a7ec"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("86ef0752-353c-408c-9cbd-d47a22f66e68"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8898749e-57bb-4b18-9110-1b4ebf2cf366"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("88e537c5-5405-44e5-a181-8c798fce024b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8af9dbe6-3f0f-4095-a1c8-0ce402b15fcb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8d48da88-df36-4d48-9f6a-c39156c8b9b9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("950e6fdc-c885-4be2-9b5e-d183ca598749"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9761ea88-33e0-4966-8500-e7820c90b3f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9976254d-6068-4496-a88d-27fe6208e0aa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9a1c1d3f-557f-492d-83e4-332f93bfae14"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a4962488-1937-455a-bfac-6378b7715fc1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a7903267-0109-46e4-84f3-72015b275429"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("aae02558-6369-4347-a42a-35fd74706ac1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae2fa53a-f0d5-4942-ac33-de6d6ea0cae4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ae61abef-d75b-4b6b-af75-0d486741fd77"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af3adbae-fc68-49c7-a51e-6120cb2b335b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b4dc2ee4-6a7f-4961-9ab7-ff35cab9a5bc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2bb4b88-078a-4739-9ddb-d13d63699e72"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c2c22453-fe69-4ef5-8a55-e9536116b052"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c63851e1-424c-4343-8f62-55d6b5084239"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d13942d3-8c98-4ed2-9514-b8a19550d62d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d2700d61-5e47-40aa-adec-0484b5ad9e4d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("d6f20951-8db3-4420-83aa-a2ebbbce2f82"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e861d2ea-ef16-44a8-a8a0-36429678e919"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e9b86d0f-ad46-4514-8227-058aebf31cd3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f30dfaab-cdca-4333-b3ee-95bf1ea6077c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f8604159-a830-405e-bb3a-8409adb23455"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("3b5d7095-482f-4b52-9ca8-e308ddbe925e"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("53b015f9-8add-47f4-a4ea-4e454539b8b9"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("63410530-7a56-4a1d-ba4f-8d956f0c1533"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("b4fca666-5c6b-47e8-9f40-29c43ef5c6ad"));

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
                table: "booking_read_flat",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                table: "booking_read_flat",
                newName: "deleted_at");

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

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "vehicle_read_flat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deleted_by",
                table: "vehicle_read_flat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "vehicle_read_flat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "booking_read_flat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "booking_read_flat",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "booking_read_flat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

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
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153), new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153), new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153), new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153), new DateTime(2026, 2, 7, 7, 39, 43, 299, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(3480), new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(3480), new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(3480), new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 39, 43, 300, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828), new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828), new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828), new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828), new DateTime(2026, 2, 7, 7, 39, 43, 301, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("0416c16b-1034-415e-b996-2669a5d98a37"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("05d928e0-4aa6-4e37-b3da-811ff00ec28f"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("08d37fef-d3b8-4193-bc61-1a2b05a4014a"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("112f0236-bc79-4b73-ad03-dc72a0da5a96"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1ea6a143-6534-475d-b12e-cb67bc957c14"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2147f197-f0bc-423a-8d53-061b1e6af1de"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("238362fc-fc07-4703-a815-6ab3277ce096"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("23a0fe02-054e-4a69-b66c-ae259e1741db"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("29cad567-07a0-4057-a0f3-24633498e523"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("326b9a92-2288-4fdd-b9a2-b61055a1bdb2"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("37251f82-ce92-4089-b368-417226760d58"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("3842f33f-ebcb-41ec-ba3a-dfcedd619daa"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("435b994b-78c3-4742-8439-fa91a6960357"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("439c92b6-43ac-444c-a6a7-29a787163251"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("43a1c47d-b518-4fc3-befc-f846e60b6e2d"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("463ed5eb-b41a-4623-8cac-293572f06ba9"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("49086fe8-0391-493a-bb1e-abdae311bfee"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("4bd34c63-9b10-42a4-b041-d22977dffdf1"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("53fe8a94-305c-40c7-b9e5-91ce0d937a9a"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("5f0b02d7-1e48-4ed3-a9e0-cfe221c9ae12"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("62d51c2f-a13b-4ab8-8322-63e8218048a5"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("636d04cc-e6ba-439e-a115-e1ed75dea262"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("764b5ad9-cb1b-49cf-bab1-57659794f616"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("789b3949-0524-4bb3-8434-418b447354fe"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("79fefc4a-b8f7-480f-a75e-94f98fb9d007"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("7d2adee3-0dd1-4743-993c-ae16218d277a"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("873feb08-215a-469e-8fc4-ddbb6165d7c1"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8934ec3b-5655-40b8-b7a5-e723688d479e"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8f2510c5-ac4a-4064-945d-22c4c27b6acf"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("951b47b1-5e3b-47a7-be2c-c433c7504db0"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9e99b733-fba8-4a77-9d2b-54e848775bc3"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a6433a23-503c-4440-a6bc-cacc6965f356"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ad51c9e9-3307-47ef-abff-4dbb94fb893e"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af7e9cb6-4031-4439-bae4-737d530ab84d"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("af94a741-c5ee-4c2b-b930-912d93548c2f"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("afb96db3-339c-478c-b8ee-334d450469a1"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b0ca726c-fded-4639-987f-45071873163a"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ba9de0eb-d423-4742-b3c4-fbb744b25022"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("bdf4fc4f-86f3-4aaa-8d60-fefdb6c36a3a"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("c1f090e5-f631-4a92-bf69-723586d05d2d"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("cde24191-7366-4ae1-a12a-d8d46145b8f4"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("dd152b84-11c6-4203-b295-85ac85e9f793"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("de2933be-22cf-4fcb-ae41-0809f9033e2e"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("df4e5376-84a3-4dd5-8ecb-1f6cff3e7ce8"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e3f5a3e5-b5f5-4d11-b95a-035fd837d893"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e5bfb048-60eb-4b56-b343-d0072d749ffc"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("e8278a68-b300-40be-81db-2fd74580175b"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e8f868ba-edb1-4c8f-9722-6f8d4d950fb3"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eaa68986-fc05-4876-9a10-40b3f502095c"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ec147fcc-33bd-4c2a-a3eb-97f14ccfba7a"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("eca0c49b-b15a-4760-a49c-9450f89e9cfd"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("ef780c6e-17c5-4c3f-9e79-d6164e513feb"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f024d4a0-1b45-4dd4-bc15-fba5f73fd74e"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f2a87291-8261-4380-b8f3-a7028417e72b"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("fca0e106-50f0-4206-a21d-242162ea5178"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "1767a2d5-a4a8-49ae-8ce7-2504ffad5ac4");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "41806235-30f1-4558-9326-2345d4f14087");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "301b2f91-7716-4382-93e7-01af3ac8af18");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "7504b3fe-0d0a-42ad-a219-fdffae8e4a0a");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 39, 43, 308, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 39, 43, 308, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 2, 7, 7, 39, 43, 308, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.InsertData(
                table: "user_roles",
                columns: new[] { "user_role_id", "role_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("02cf2611-9982-4946-a62c-9bc5ece84789"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("4f8c9002-7df1-40bd-8c5e-259fd331b46d"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("9d2147c5-d135-4205-8055-13d1f5629fbd"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("f50289de-ebe3-4c5e-bbb8-1c8ad773a116"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347), "$2a$11$9qrW6Y52dF0yEIxK/fKhh.gHcM3I.sHg0b8QaohoAtVVHGueb02J.", new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347), "$2a$11$q.HBv1BlsWPtFd7IQka0EOzOukq.aGqo6rjzBQBzhSlv9Bhv6fCAe", new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347), "$2a$11$nWCdJTSzwjasqYNImGzm9etf.JQ7iIuEL8D/Qdhej9KLZaJRrHcy6", new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347), "$2a$11$Oc6LPn3YISyOlXukFy5fi.EAHsrY2rmdT1hW4gmaN/XNj5JfErn.W", new DateTime(2026, 2, 7, 7, 39, 43, 311, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535), new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535), new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535), new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535), new DateTime(2026, 2, 7, 7, 39, 43, 807, DateTimeKind.Utc).AddTicks(8535) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("0416c16b-1034-415e-b996-2669a5d98a37"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("05d928e0-4aa6-4e37-b3da-811ff00ec28f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("08d37fef-d3b8-4193-bc61-1a2b05a4014a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("112f0236-bc79-4b73-ad03-dc72a0da5a96"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("1ea6a143-6534-475d-b12e-cb67bc957c14"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("2147f197-f0bc-423a-8d53-061b1e6af1de"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("238362fc-fc07-4703-a815-6ab3277ce096"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("23a0fe02-054e-4a69-b66c-ae259e1741db"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("29cad567-07a0-4057-a0f3-24633498e523"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("326b9a92-2288-4fdd-b9a2-b61055a1bdb2"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("37251f82-ce92-4089-b368-417226760d58"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("3842f33f-ebcb-41ec-ba3a-dfcedd619daa"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("435b994b-78c3-4742-8439-fa91a6960357"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("439c92b6-43ac-444c-a6a7-29a787163251"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("43a1c47d-b518-4fc3-befc-f846e60b6e2d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("463ed5eb-b41a-4623-8cac-293572f06ba9"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("49086fe8-0391-493a-bb1e-abdae311bfee"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("4bd34c63-9b10-42a4-b041-d22977dffdf1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("53fe8a94-305c-40c7-b9e5-91ce0d937a9a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("5f0b02d7-1e48-4ed3-a9e0-cfe221c9ae12"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("62d51c2f-a13b-4ab8-8322-63e8218048a5"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("636d04cc-e6ba-439e-a115-e1ed75dea262"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("764b5ad9-cb1b-49cf-bab1-57659794f616"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("789b3949-0524-4bb3-8434-418b447354fe"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("79fefc4a-b8f7-480f-a75e-94f98fb9d007"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("7d2adee3-0dd1-4743-993c-ae16218d277a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("873feb08-215a-469e-8fc4-ddbb6165d7c1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8934ec3b-5655-40b8-b7a5-e723688d479e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("8f2510c5-ac4a-4064-945d-22c4c27b6acf"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("951b47b1-5e3b-47a7-be2c-c433c7504db0"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("9e99b733-fba8-4a77-9d2b-54e848775bc3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("a6433a23-503c-4440-a6bc-cacc6965f356"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ad51c9e9-3307-47ef-abff-4dbb94fb893e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af7e9cb6-4031-4439-bae4-737d530ab84d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("af94a741-c5ee-4c2b-b930-912d93548c2f"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("afb96db3-339c-478c-b8ee-334d450469a1"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("b0ca726c-fded-4639-987f-45071873163a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ba9de0eb-d423-4742-b3c4-fbb744b25022"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("bdf4fc4f-86f3-4aaa-8d60-fefdb6c36a3a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("c1f090e5-f631-4a92-bf69-723586d05d2d"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("cde24191-7366-4ae1-a12a-d8d46145b8f4"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("dd152b84-11c6-4203-b295-85ac85e9f793"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("de2933be-22cf-4fcb-ae41-0809f9033e2e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("df4e5376-84a3-4dd5-8ecb-1f6cff3e7ce8"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e3f5a3e5-b5f5-4d11-b95a-035fd837d893"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e5bfb048-60eb-4b56-b343-d0072d749ffc"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e8278a68-b300-40be-81db-2fd74580175b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("e8f868ba-edb1-4c8f-9722-6f8d4d950fb3"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eaa68986-fc05-4876-9a10-40b3f502095c"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ec147fcc-33bd-4c2a-a3eb-97f14ccfba7a"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("eca0c49b-b15a-4760-a49c-9450f89e9cfd"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("ef780c6e-17c5-4c3f-9e79-d6164e513feb"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f024d4a0-1b45-4dd4-bc15-fba5f73fd74e"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("f2a87291-8261-4380-b8f3-a7028417e72b"));

            migrationBuilder.DeleteData(
                table: "role_claims",
                keyColumn: "id",
                keyValue: new Guid("fca0e106-50f0-4206-a21d-242162ea5178"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("02cf2611-9982-4946-a62c-9bc5ece84789"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("4f8c9002-7df1-40bd-8c5e-259fd331b46d"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("9d2147c5-d135-4205-8055-13d1f5629fbd"));

            migrationBuilder.DeleteData(
                table: "user_roles",
                keyColumn: "user_role_id",
                keyValue: new Guid("f50289de-ebe3-4c5e-bbb8-1c8ad773a116"));

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
                table: "booking_read_flat",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "booking_read_flat",
                newName: "DeletedAt");

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

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "vehicle_read_flat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deleted_by",
                table: "vehicle_read_flat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "vehicle_read_flat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.AlterColumn<string>(
                name: "updated_by",
                table: "booking_read_flat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "is_deleted",
                table: "booking_read_flat",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "created_by",
                table: "booking_read_flat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 1, 28, 14, 43, 33, 934, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("a3d4e5f6-c7b8-9012-3456-7890abcdef01"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("e1b2c3d4-a5f6-7890-1234-567890abcdef"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "fuels",
                keyColumn: "fuel_id",
                keyValue: new Guid("f2c3d4e5-b6a7-8901-2345-67890abcdef0"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 935, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "insurance_packages",
                keyColumn: "insurance_package_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447), new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 936, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.InsertData(
                table: "role_claims",
                columns: new[] { "id", "claim_type", "claim_value", "role_id" },
                values: new object[,]
                {
                    { new Guid("04359469-76fb-4077-8fa7-d159683bef8b"), "Permission", "Permissions.Vehicles.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("0efe80d9-14c4-4cfa-9af5-9bd8153dd6e7"), "Permission", "Permissions.Vehicles.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1126fa72-92e7-45a6-b39d-5d753fdac6ee"), "Permission", "Permissions.VehicleCategory.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("11b3e189-c271-4b97-8a81-1165f5e51112"), "Permission", "Permissions.Locations.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("16a911fd-3a89-4548-8d13-da313f002356"), "Permission", "Permissions.Locations.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("17a47c76-a2e2-4698-b5e0-d71cc7a68cb0"), "Permission", "Permissions.Bookings.CreateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1b654908-c85f-4916-8099-f0ac070868ff"), "Permission", "Permissions.Fuels.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("1bf20d44-bc91-493b-8ca6-da6d7f707dea"), "Permission", "Permissions.VehicleCategory.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("1dcfbb73-a355-4bd9-8c67-1b5d4b0a232a"), "Permission", "Permissions.Vehicles.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("1f36dc52-325c-470f-8fd4-130c1c344070"), "Permission", "Permissions.Bookings.Cancel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("21eb37aa-3629-46ff-a4cf-6a2ee736ef1f"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2bff8c33-4991-45c7-971d-0e460a8d63ab"), "Permission", "Permissions.RefundRequests.Approve", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2dd91366-c867-4fd0-a663-0886174c1484"), "Permission", "Permissions.Vehicles.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("2ef8b685-5509-4160-adde-1cc6c6203269"), "Permission", "Permissions.Bookings.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("362ac8a7-28a8-4d79-a01a-ed19475ed52b"), "Permission", "Permissions.Bookings.Create", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("4092830e-f3dc-499b-a967-bef69d98d5b5"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("446698c6-37bf-4fc2-9910-29697a08e1e6"), "Permission", "Permissions.Bookings.View", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("4ba92ee4-b268-4429-b797-f4828d391c6a"), "Permission", "Permissions.RefundRequests.Reject", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("511934fe-e2f8-4e7f-a17a-2e8b49ebfc3a"), "Permission", "Permissions.Bookings.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("51648138-9cb2-43c5-8838-d468b0036e5f"), "Permission", "Permissions.Transmissions.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("59c4dbc2-253f-4523-8929-8b40e14b6ae1"), "Permission", "Permissions.Ekyc.DriverLicenseVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("61285281-32ec-46ac-a421-5de8d309c07c"), "Permission", "Permissions.Vehicles.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("63987aac-1f6c-4a74-a2f4-c5821518fb45"), "Permission", "Permissions.Fuels.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("66c6d29a-c890-441c-ab19-2fcd2e797cb1"), "Permission", "Permissions.Transmissions.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("6cb9d1ea-c067-4d1e-9e62-d29c1e9a9501"), "Permission", "Permissions.Locations.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("80d1b6f1-0338-4a1e-9969-60391b88c946"), "Permission", "Permissions.Vehicles.SendEmail", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8378e753-b212-43a8-adb5-1a5aff97a32a"), "Permission", "Permissions.Ekyc.FullyVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("84b2a423-78c3-4895-9674-6bab2325f0da"), "Permission", "Permissions.Fuels.Delete", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8650f4f1-1d96-4844-b593-c77afc75a7ec"), "Permission", "Permissions.Bookings.Cancel", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("86ef0752-353c-408c-9cbd-d47a22f66e68"), "Permission", "Permissions.Vehicles.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8898749e-57bb-4b18-9110-1b4ebf2cf366"), "Permission", "Permissions.Vehicles.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("88e537c5-5405-44e5-a181-8c798fce024b"), "Permission", "Permissions.Bookings.ExportContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8af9dbe6-3f0f-4095-a1c8-0ce402b15fcb"), "Permission", "Permissions.Transmissions.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("8d48da88-df36-4d48-9f6a-c39156c8b9b9"), "Permission", "Permissions.Ekyc.IdentityVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("950e6fdc-c885-4be2-9b5e-d183ca598749"), "Permission", "Permissions.Bookings.Create", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("9761ea88-33e0-4966-8500-e7820c90b3f4"), "Permission", "Permissions.Transmissions.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("9976254d-6068-4496-a88d-27fe6208e0aa"), "Permission", "Permissions.Fuels.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("9a1c1d3f-557f-492d-83e4-332f93bfae14"), "Permission", "Permissions.Fuels.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a4962488-1937-455a-bfac-6378b7715fc1"), "Permission", "Permissions.Fuels.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("a7903267-0109-46e4-84f3-72015b275429"), "Permission", "Permissions.Fuels.Create", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("aae02558-6369-4347-a42a-35fd74706ac1"), "Permission", "Permissions.Ekyc.PhoneVerified", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae2fa53a-f0d5-4942-ac33-de6d6ea0cae4"), "Permission", "Permissions.Bookings.Create", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("ae61abef-d75b-4b6b-af75-0d486741fd77"), "Permission", "Permissions.VehicleCategory.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("af3adbae-fc68-49c7-a51e-6120cb2b335b"), "Permission", "Permissions.RefundRequests.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("b4dc2ee4-6a7f-4961-9ab7-ff35cab9a5bc"), "Permission", "Permissions.Bookings.ViewDetail", new Guid("2fd185ee-d561-4b48-9185-eed5617b4881") },
                    { new Guid("c2bb4b88-078a-4739-9ddb-d13d63699e72"), "Permission", "Permissions.Bookings.View", new Guid("7a908619-1c82-4d16-9086-191c82fd1671") },
                    { new Guid("c2c22453-fe69-4ef5-8a55-e9536116b052"), "Permission", "Permissions.VehicleCategory.Edit", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("c63851e1-424c-4343-8f62-55d6b5084239"), "Permission", "Permissions.Bookings.Edit", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("d13942d3-8c98-4ed2-9514-b8a19550d62d"), "Permission", "Permissions.Bookings.UpdateFinalPayment", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d2700d61-5e47-40aa-adec-0484b5ad9e4d"), "Permission", "Permissions.Locations.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("d6f20951-8db3-4420-83aa-a2ebbbce2f82"), "Permission", "Permissions.Bookings.GenerateContract", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("e861d2ea-ef16-44a8-a8a0-36429678e919"), "Permission", "Permissions.Fuels.Delete", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("e9b86d0f-ad46-4514-8227-058aebf31cd3"), "Permission", "Permissions.Bookings.SwapVehicleModel", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") },
                    { new Guid("f30dfaab-cdca-4333-b3ee-95bf1ea6077c"), "Permission", "Permissions.Vehicles.View", new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6") },
                    { new Guid("f8604159-a830-405e-bb3a-8409adb23455"), "Permission", "Permissions.Bookings.View", new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826") }
                });

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"),
                column: "concurrency_stamp",
                value: "ed313200-a6bf-4c79-b205-b5323599dfdb");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"),
                column: "concurrency_stamp",
                value: "149b6a49-d658-44fb-9281-15df496a0f3f");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"),
                column: "concurrency_stamp",
                value: "50bb4d21-57a6-47a7-950d-c9949e286c31");

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "role_id",
                keyValue: new Guid("7a908619-1c82-4d16-9086-191c82fd1671"),
                column: "concurrency_stamp",
                value: "614cbbbe-9e1c-4b87-89fc-32cc1020c11f");

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 944, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 944, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "terms_and_conditions",
                keyColumn: "terms_id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "created_at",
                value: new DateTime(2026, 1, 28, 14, 43, 33, 944, DateTimeKind.Utc).AddTicks(4982));

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
                    { new Guid("3b5d7095-482f-4b52-9ca8-e308ddbe925e"), new Guid("71af4b53-dcd0-4498-af4b-53dcd0249826"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("53b015f9-8add-47f4-a4ea-4e454539b8b9"), new Guid("1e46a445-4351-4d0a-86a4-454351dd0aa6"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("63410530-7a56-4a1d-ba4f-8d956f0c1533"), new Guid("2fd185ee-d561-4b48-9185-eed5617b4881"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("b4fca666-5c6b-47e8-9f40-29c43ef5c6ad"), new Guid("7a908619-1c82-4d16-9086-191c82fd1671"), new Guid("44444444-4444-4444-4444-444444444444") }
                });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$ZcOdTBUEZ2BcdYwIo6.R4uiUeHlnpJKzUx/s56vxOi1cLnZFl9Puq", new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$DrNNb1fuyUBCmUTzNx7is.xTdATT6zyr6olozK10WNOXA6XDYFnXC", new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$CkByaOQxXCUK1VZVnzI7veyi4ThN15EE7qhF368P/dadRsnT0xJ1S", new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "created_at", "password", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713), "$2a$11$H2SbydPd9XW8EIf2s.vrHOkyzuO.8UNoKZ3/2ASA9lNaAvH.hqzP.", new byte[0], new DateTime(2026, 1, 28, 14, 43, 33, 947, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a01"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new byte[0], new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a02"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new byte[0], new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a03"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new byte[0], new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "vehicle_categories",
                keyColumn: "vehicle_categorie_id",
                keyValue: new Guid("f7a3f3a0-3b1a-4b0a-8f0a-0a0a0a0a0a04"),
                columns: new[] { "created_at", "RowVersion", "updated_at" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10), new byte[0], new DateTime(2026, 1, 28, 14, 43, 34, 453, DateTimeKind.Utc).AddTicks(10) });
        }
    }
}
