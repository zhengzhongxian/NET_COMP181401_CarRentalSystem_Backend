using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class TermsAndConditionsConfiguration : IEntityTypeConfiguration<TermsAndConditions>
{
    public void Configure(EntityTypeBuilder<TermsAndConditions> builder)
    {
        builder.ToTable("terms_and_conditions");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .HasColumnName("terms_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(t => t.Title)
            .HasColumnName("title")
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(t => t.Content)
            .HasColumnName("content")
            .IsRequired();

        builder.Property(t => t.Version)
            .HasColumnName("version")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.EffectiveDate)
            .HasColumnName("effective_date")
            .IsRequired();

        builder.Property(t => t.IsActive)
            .HasColumnName("is_active")
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(t => t.Type)
            .HasColumnName("type")
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.HasIndex(t => new { t.Type, t.Version, t.IsActive });

        builder.HasQueryFilter(t => !t.IsDeleted);
        
        builder.HasData(TermsAndConditionsSeeder.Seed());
    }
}

