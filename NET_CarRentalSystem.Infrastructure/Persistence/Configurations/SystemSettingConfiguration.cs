using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class SystemSettingConfiguration
{
    public void Configure(EntityTypeBuilder<SystemSetting> builder)
    {
        builder.ToTable("system_settings");
        
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .HasColumnName("setting_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(s => s.SettingKey)
            .HasColumnName("setting_key")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.SettingValue)
            .HasColumnName("setting_value")
            .IsRequired();
        
        builder.Property(s => s.Description)
            .HasColumnName("description")
            .HasMaxLength(500);
        
        builder.HasIndex(s => s.SettingKey).IsUnique();
        
        builder.HasData(SystemSettingSeeder.Seed());
    }
}