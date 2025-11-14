using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customers");
        builder.HasKey(c => c.CustomerId);
        
        builder.HasIndex(customer => customer.UserId)
            .IsUnique();
        
        builder.Property(c => c.CustomerId)
            .HasColumnName("customer_id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(c => c.FirstName)
            .HasColumnName("first_name")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.LastName)
            .HasColumnName("last_name")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Dob)
            .HasColumnName("dob")
            .HasColumnType("date");

        builder.Property(c => c.PhoneNumber)
            .HasColumnName("phone_number")
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.Address)
            .HasColumnName("address")
            .HasMaxLength(500);

        builder.Property(c => c.CccdNumber)
            .HasColumnName("cccd_number")
            .HasMaxLength(150);

        builder.Property(c => c.CccdIssueDate)
            .HasColumnName("cccd_issue_date")
            .HasColumnType("date");

        builder.Property(c => c.CccdIssuePlace)
            .HasColumnName("cccd_issue_place")
            .HasMaxLength(255);

        builder.Property(c => c.CccdFrontUrl)
            .HasColumnName("cccd_front_url");

        builder.Property(c => c.CccdBackUrl)
            .HasColumnName("cccd_back_url");

        builder.Property(c => c.DriverLicenseId)
            .HasColumnName("driver_license_id")
            .HasMaxLength(20);

        builder.Property(c => c.DriverLicenseExpiry)
            .HasColumnName("driver_license_expiry")
            .HasColumnType("date");

        builder.Property(c => c.DriverLicenseFrontUrl)
            .HasColumnName("driver_license_front_url");

        builder.Property(c => c.DriverLicenseBackUrl)
            .HasColumnName("driver_license_back_url");

        builder.Property(c => c.AvatarUrl)
            .HasColumnName("avatar_url");

        builder.HasIndex(c => c.PhoneNumber).IsUnique();
        builder.HasIndex(c => c.CccdNumber).IsUnique();
        builder.HasIndex(c => c.DriverLicenseId).IsUnique();

        builder.HasQueryFilter(c => c.User == null || !c.User.IsDeleted);

        builder.HasData(CustomerSeeder.Seed());
    }
}

