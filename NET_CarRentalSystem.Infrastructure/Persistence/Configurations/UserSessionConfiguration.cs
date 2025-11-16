using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class UserSessionConfiguration : IEntityTypeConfiguration<UserSession>
{
    public void Configure(EntityTypeBuilder<UserSession> builder)
    {
        builder.ToTable("user_sessions");

        builder.HasKey(us => us.Id);

        builder.Property(us => us.Id)
            .HasColumnName("user_session_id")
            .ValueGeneratedOnAdd();

        builder.Property(us => us.UserId)
            .HasColumnName("user_id")
            .IsRequired();

        builder.Property(us => us.RefreshToken)
            .HasColumnName("refresh_token")
            .IsRequired();

        builder.Property(us => us.RefreshTokenExpiryTime)
            .HasColumnName("refresh_token_expiry_time")
            .IsRequired();

        builder.Property(us => us.DeviceName)
            .HasColumnName("device_name")
            .HasMaxLength(255);

        builder.Property(us => us.IpAddress)
            .HasColumnName("ip_address")
            .HasMaxLength(50);

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(c => c.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(c => c.IsDeleted)
            .HasColumnName("is_deleted");
        
        builder.HasOne(us => us.User)
            .WithMany(u => u.UserSessions)
            .HasForeignKey(us => us.UserId);
    }
}

