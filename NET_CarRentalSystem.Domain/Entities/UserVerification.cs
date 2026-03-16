using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class UserVerification : BaseEntity<Guid>
{
    public Guid UserId { get; set; }

    public string IdNumber { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public DateTime? DateOfBirth { get; set; }

    public string Gender { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Hometown { get; set; } = string.Empty;

    public string IssueDate { get; set; } = string.Empty;

    public string IssuePlace { get; set; } = string.Empty;

    public string ValidDate { get; set; } = string.Empty;

    public double FaceMatchScore { get; set; }

    public bool IsCardLivenessPass { get; set; }

    public bool IsFaceLivenessPass { get; set; }

    public bool IsFaceMatch { get; set; }

    public VerificationStatus Status { get; set; }

    public DateTime VerifiedAt { get; set; }

    public string? FrontImageHash { get; set; }

    public string? BackImageHash { get; set; }

    public string? SelfieHash { get; set; }

    // GPLX (Driver License) fields
    public string? DriverLicenseNumber { get; set; }  // Encrypted

    public int? DriverLicenseClass { get; set; }

    public string? DriverLicenseExpiry { get; set; }

    public string? DriverLicenseFrontHash { get; set; }

    public string? DriverLicenseBackHash { get; set; }

    public bool IsDriverLicenseVerified { get; set; } = false;

    public virtual User User { get; set; } = null!;
}
