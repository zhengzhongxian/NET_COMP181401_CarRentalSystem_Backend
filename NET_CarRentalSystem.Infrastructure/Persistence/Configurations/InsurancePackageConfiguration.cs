using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class InsurancePackageConfiguration : IEntityTypeConfiguration<InsurancePackage>
{
    public void Configure(EntityTypeBuilder<InsurancePackage> builder)
    {
        builder.ToTable("insurance_packages");
        builder.HasKey(i => i.Id);

        builder.Property(i => i.Id)
            .HasColumnName("insurance_package_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(i => i.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(i => i.Description)
            .HasColumnName("description")
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(i => i.Price)
            .HasColumnName("price")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(i => i.CoverageAmount)
            .HasColumnName("coverage_amount")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(i => i.CoverageDetails)
            .HasColumnName("coverage_details")
            .IsRequired();

        builder.Property(i => i.IsActive)
            .HasColumnName("is_active")
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(i => i.DisplayOrder)
            .HasColumnName("display_order")
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(i => i.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(i => i.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(i => i.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(i => i.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(i => i.IsDeleted)
            .HasColumnName("is_deleted")
            .IsRequired();

        builder.Property(i => i.DeletedBy)
            .HasColumnName("deleted_by");

        builder.Property(i => i.DeletedAt)
            .HasColumnName("deleted_at");

        builder.HasQueryFilter(i => !i.IsDeleted);
        
        builder.HasData(InsurancePackageSeeder.Seed());
    }
}

