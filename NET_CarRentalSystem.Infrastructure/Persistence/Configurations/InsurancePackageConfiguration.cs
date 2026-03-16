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

        builder.HasQueryFilter(i => !i.IsDeleted);
        
        builder.HasData(InsurancePackageSeeder.Seed());
    }
}

