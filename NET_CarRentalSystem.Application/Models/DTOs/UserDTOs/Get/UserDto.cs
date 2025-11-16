namespace NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;

public class UserDto
{
    public Guid Id { get; set; }
    
    public string? Email { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? Address { get; set; }
    
    public DateTime? Dob { get; set; }
    
    public string? CccdNumber { get; set; }
    
    public DateTime? CccdIssueDate { get; set; }
    
    public string? CccdIssuePlace { get; set; }
    
    public string? CccdFrontUrl { get; set; }
    
    public string? CccdBackUrl { get; set; }
    
    public string? DriverLicenseId { get; set; }
    
    public DateTime? DriverLicenseExpiry { get; set; }
    
    public string? DriverLicenseFrontUrl { get; set; }
    
    public string? DriverLicenseBackUrl { get; set; }
    
    public string? AvatarUrl { get; set; }
}

