using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Configurations;

public class UserVerificationConfiguration : IEntityTypeConfiguration<UserVerification>
{
    public void Configure(EntityTypeBuilder<UserVerification> builder)
    {
        builder.ToTable("user_verifications");

        builder.HasKey(uv => uv.Id);

        builder.Property(uv => uv.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property(uv => uv.UserId)
            .HasColumnName("user_id")
            .IsRequired();

        builder.Property(uv => uv.IdNumber)
            .HasColumnName("id_number")
            .IsRequired()
            .HasMaxLength(300);
        builder.Property(uv => uv.FullName)
            .HasColumnName("full_name")
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(uv => uv.DateOfBirth)
            .HasColumnName("date_of_birth")
            .HasColumnType("date");

        builder.Property(uv => uv.Gender)
            .HasColumnName("gender")
            .HasMaxLength(10);

        builder.Property(uv => uv.Address)
            .HasColumnName("address")
            .HasMaxLength(500);

        builder.Property(uv => uv.Hometown)
            .HasColumnName("hometown")
            .HasMaxLength(500);

        builder.Property(uv => uv.IssueDate)
            .HasColumnName("issue_date")
            .HasMaxLength(20);

        builder.Property(uv => uv.IssuePlace)
            .HasColumnName("issue_place")
            .HasMaxLength(255);

        builder.Property(uv => uv.ValidDate)
            .HasColumnName("valid_date")
            .HasMaxLength(20);

        builder.Property(uv => uv.FaceMatchScore)
            .HasColumnName("face_match_score")
            .HasColumnType("decimal(5,2)");

        builder.Property(uv => uv.IsCardLivenessPass)
            .HasColumnName("is_card_liveness_pass")
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(uv => uv.IsFaceLivenessPass)
            .HasColumnName("is_face_liveness_pass")
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(uv => uv.IsFaceMatch)
            .HasColumnName("is_face_match")
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(uv => uv.Status)
            .HasColumnName("status")
            .IsRequired()
            .HasConversion<int>();

        builder.Property(uv => uv.VerifiedAt)
            .HasColumnName("verified_at")
            .IsRequired();

        builder.Property(uv => uv.FrontImageHash)
            .HasColumnName("front_image_hash")
            .HasMaxLength(500);

        builder.Property(uv => uv.BackImageHash)
            .HasColumnName("back_image_hash")
            .HasMaxLength(500);

        builder.Property(uv => uv.SelfieHash)
            .HasColumnName("selfie_hash")
            .HasMaxLength(500);

        // GPLX (Driver License) fields
        builder.Property(uv => uv.DriverLicenseNumber)
            .HasColumnName("driver_license_number")
            .HasMaxLength(300);

        builder.Property(uv => uv.DriverLicenseClass)
            .HasColumnName("driver_license_class");

        builder.Property(uv => uv.DriverLicenseExpiry)
            .HasColumnName("driver_license_expiry")
            .HasMaxLength(20);

        builder.Property(uv => uv.DriverLicenseFrontHash)
            .HasColumnName("driver_license_front_hash")
            .HasMaxLength(500);

        builder.Property(uv => uv.DriverLicenseBackHash)
            .HasColumnName("driver_license_back_hash")
            .HasMaxLength(500);

        builder.Property(uv => uv.IsDriverLicenseVerified)
            .HasColumnName("is_driver_license_verified")
            .IsRequired()
            .HasDefaultValue(false);

        builder.HasIndex(uv => uv.UserId)
            .IsUnique();

        builder.HasIndex(uv => uv.IdNumber);

        builder.HasOne(uv => uv.User)
            .WithOne()
            .HasForeignKey<UserVerification>(uv => uv.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
