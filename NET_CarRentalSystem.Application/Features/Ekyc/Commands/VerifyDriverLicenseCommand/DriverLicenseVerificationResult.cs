namespace NET_CarRentalSystem.Application.Features.Ekyc.Commands.VerifyDriverLicenseCommand;

public class DriverLicenseVerificationResult
{
    public bool IsSuccess { get; set; }
    
    public string Message { get; set; } = string.Empty;
    
    public string? DriverLicenseNumber { get; set; }
    
    public int? DriverLicenseClass { get; set; }
    
    public string? DriverLicenseExpiry { get; set; }
    
    public double FaceMatchScore { get; set; }
    
    public string? FrontImageHash { get; set; }
    
    public string? BackImageHash { get; set; }
}