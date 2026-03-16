namespace NET_CarRentalSystem.Application.Models.Ekyc;

public class EkycVerificationResult
{
    public bool IsSuccess { get; set; }

    public string Message { get; set; } = string.Empty;

    public string IdNumber { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string DateOfBirth { get; set; } = string.Empty;

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

    public string FrontImageHash { get; set; } = string.Empty;

    public string BackImageHash { get; set; } = string.Empty;

    public string SelfieHash { get; set; } = string.Empty;

    public List<string>? Warnings { get; set; }

    // GPLX (Driver License) OCR Results
    public string DriverLicenseNumber { get; set; } = string.Empty;

    public int? DriverLicenseClass { get; set; }

    public string DriverLicenseExpiry { get; set; } = string.Empty;

    public string DriverLicenseFrontHash { get; set; } = string.Empty;

    public string DriverLicenseBackHash { get; set; } = string.Empty;

    public bool IsDriverLicenseVerified { get; set; }
}
