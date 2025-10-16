using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleAttributeConfiguration : IEntityTypeConfiguration<VehicleAttribute>
{
    public void Configure(EntityTypeBuilder<VehicleAttribute> builder)
    {
        builder.ToTable("vehicle_attributes");

        builder.HasKey(va => va.AttributeId);

        builder.Property(va => va.AttributeId)
            .HasColumnName("attribute_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(va => va.AttributeKey)
            .HasColumnName("attribute_key")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(va => va.AttributeValue)
            .HasColumnName("attribute_value")
            .IsRequired();

        builder.Property(va => va.VehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.HasOne(va => va.Vehicle)
            .WithMany(v => v.VehicleAttributes)
            .HasForeignKey(va => va.VehicleId);
    }
}

