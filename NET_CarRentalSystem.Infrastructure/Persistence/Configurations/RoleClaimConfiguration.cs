using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
{
    public void Configure(EntityTypeBuilder<RoleClaim> builder)
    {
        builder.ToTable("role_claims");
        builder.HasKey(rc => rc.Id);

        builder.Property(rc => rc.Id)
            .HasColumnName("id");

        builder.Property(rc => rc.RoleId)
            .HasColumnName("role_id")
            .IsRequired();

        builder.Property(rc => rc.ClaimType)
            .HasColumnName("claim_type");

        builder.Property(rc => rc.ClaimValue)
            .HasColumnName("claim_value");

        builder.HasQueryFilter(rc => !rc.Role.IsDeleted);
    }
}