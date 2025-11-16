using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("locations");
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
            .HasColumnName("location_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(l => l.Name)
            .HasColumnName("name")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(l => l.Address)
            .HasColumnName("address")
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(l => l.City)
            .HasColumnName("city")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(l => l.PhoneNumber)
            .HasColumnName("phone_number")
            .HasMaxLength(20);

        builder.Property(l => l.OpeningHours)
            .HasColumnName("opening_hours")
            .HasMaxLength(100);

        builder.Property(l => l.Latitude)
            .HasColumnName("latitude");

        builder.Property(l => l.Longitude)
            .HasColumnName("longitude");

        builder.Property(c => c.Description)
            .HasColumnName("description");

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(c => c.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(c => c.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(c => c.IsDeleted)
            .HasColumnName("is_deleted")
            .IsRequired();

        builder.HasData(LocationSeeder.Seed());
    }
}

