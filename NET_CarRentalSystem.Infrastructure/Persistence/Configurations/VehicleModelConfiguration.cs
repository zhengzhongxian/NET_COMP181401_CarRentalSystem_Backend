using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class VehicleModelConfiguration : IEntityTypeConfiguration<VehicleModel>
{
    public void Configure(EntityTypeBuilder<VehicleModel> builder)
    {
        builder.ToTable("vehicle_models");

        builder.HasKey(vm => vm.Id);

        builder.Property(vm => vm.Id)
            .HasColumnName("vehicle_model_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(vm => vm.Mileage)
            .HasColumnName("mileage");

        builder.Property(vm => vm.NumberPlate)
            .HasColumnName("number_plate")
            .HasMaxLength(20);

        builder.Property(vm => vm.Status)
            .HasColumnName("status")
            .HasConversion<string>()
            .HasMaxLength(50);
        
        builder.Property(vm => vm.LastAvailableAt)
            .HasColumnName("last_available_at");

        builder.Property(vm => vm.ConditionNotes)
            .HasColumnName("condition_notes");

        builder.Property(vm => vm.RealTimeLocation)
            .HasColumnName("real_time_location");

        builder.Property(vm => vm.LocationId)
            .HasColumnName("location_id");

        builder.Property(vm => vm.VehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(vm => vm.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(vm => vm.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(vm => vm.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(vm => vm.UpdatedBy)
            .HasColumnName("updated_by");

        builder.Property(vm => vm.IsDeleted)
            .HasColumnName("is_deleted");

        builder.Property(vm => vm.DeletedBy)
            .HasColumnName("deleted_by");

        builder.Property(vm => vm.DeletedAt)
            .HasColumnName("deleted_at");

        builder.Property(vm => vm.RowVersion)
            .HasColumnName("row_version")
            .IsRowVersion()
            .ValueGeneratedOnAddOrUpdate();

        builder.HasIndex(vm => vm.NumberPlate).IsUnique();

        builder.HasOne(vm => vm.Vehicle)
            .WithMany(v => v.VehicleModels)
            .HasForeignKey(vm => vm.VehicleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(vm => vm.Location)
            .WithMany(l => l.VehicleModels)
            .HasForeignKey(vm => vm.LocationId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);
    }
}

