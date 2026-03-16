using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
{
    public void Configure(EntityTypeBuilder<Fuel> builder)
    {
        builder.ToTable("fuels");

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Id)
            .HasColumnName("fuel_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(f => f.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Description)
            .HasColumnName("description");

        builder.HasData(FuelSeeder.Seed());
    }
}