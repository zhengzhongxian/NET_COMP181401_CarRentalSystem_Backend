using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.ToTable("transmissions");

        builder.HasKey(t => t.TransmissionId);

        builder.Property(t => t.TransmissionId)
            .HasColumnName("transmission_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(t => t.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.Code)
            .HasColumnName("code")
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.Description)
            .HasColumnName("description");

        builder.HasData(TransmissionSeeder.Seed());
    }
}