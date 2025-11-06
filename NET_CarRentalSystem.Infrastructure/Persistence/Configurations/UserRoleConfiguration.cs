using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("user_roles");
        builder.HasKey(ur => ur.UserRoleId);

        builder.Property(ur => ur.UserRoleId)
            .HasColumnName("user_role_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");
        
        builder.Property(ur => ur.UserId)
            .HasColumnName("user_id");

        builder.Property(ur => ur.RoleId)
            .HasColumnName("role_id");

        builder.HasQueryFilter(ur => !ur.User.IsDeleted && !ur.Role.IsDeleted);

        builder.HasData(UserRoleSeeder.Seed());
    }
}