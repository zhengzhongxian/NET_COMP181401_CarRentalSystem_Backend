using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
{
    public void Configure(EntityTypeBuilder<UserLogin> builder)
    {
        builder.ToTable("user_logins");
        builder.HasKey(ul => ul.UserLoginId)
            .HasName("PK_user_logins");
        
        builder.Property(ul => ul.UserLoginId)
            .HasColumnName("user_login_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(ul => ul.LoginProvider)
            .HasColumnName("login_provider")
            .HasMaxLength(128);

        builder.Property(ul => ul.ProviderKey)
            .HasColumnName("provider_key")
            .HasMaxLength(128);

        builder.Property(ul => ul.ProviderDisplayName)
            .HasColumnName("provider_display_name");

        builder.Property(ul => ul.UserId)
            .HasColumnName("user_id")
            .IsRequired();

        builder.HasQueryFilter(l => !l.User.IsDeleted);
    }
}