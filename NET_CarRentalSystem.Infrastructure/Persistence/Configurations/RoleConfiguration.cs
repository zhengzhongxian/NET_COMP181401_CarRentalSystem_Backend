using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Id)
            .HasColumnName("role_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(r => r.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(r => r.NormalizedName)
            .HasColumnName("normalized_name")
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(r => r.ConcurrencyStamp)
            .HasColumnName("concurrency_stamp")
            .IsConcurrencyToken();

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(c => c.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(c => c.IsDeleted)
            .HasColumnName("is_deleted");

        builder.HasIndex(r => r.NormalizedName).IsUnique();

        builder.HasMany(r => r.UserRoles)
            .WithOne(ur => ur.Role)
            .HasForeignKey(ur => ur.RoleId)
            .IsRequired();

        builder.HasMany(r => r.RoleClaims)
            .WithOne(rc => rc.Role)
            .HasForeignKey(rc => rc.RoleId)
            .IsRequired();

        builder.HasData(RoleSeeder.Seed());
    }
}