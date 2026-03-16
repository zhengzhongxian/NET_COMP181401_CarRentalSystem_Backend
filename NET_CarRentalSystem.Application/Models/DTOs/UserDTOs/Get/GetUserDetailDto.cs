namespace NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;

public class GetUserDetailDto
{
    public Guid UserId { get; set; }
    
    public string? UserName { get; set; }
    
    public string? Email { get; set; }
    
    public string? Status { get; set; }
    
    public bool IsVerified { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
    
    public GetCustomerInfoDto? Customer { get; set; }
    
    public List<GetUserLoginInfoDto> UserLogins { get; set; } = [];
    
    public List<string> UserClaims { get; set; } = [];
    
    public List<string> RoleClaims { get; set; } = [];
    
    public List<string> Roles { get; set; } = [];
}

public class GetCustomerInfoDto
{
    public Guid CustomerId { get; set; }
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public DateTime? Dob { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? Address { get; set; }
    
    public string? CccdNumber { get; set; }
    
    public DateTime? CccdIssueDate { get; set; }
    
    public string? CccdIssuePlace { get; set; }
    
    public string? CccdFrontUrl { get; set; }
    
    public string? CccdBackUrl { get; set; }
    
    public string? DriverLicenseId { get; set; }
    
    public DateTime? DriverLicenseExpiry { get; set; }
    
    public int? DriverLicenseClass { get; set; }
    
    public string? DriverLicenseFrontUrl { get; set; }
    
    public string? DriverLicenseBackUrl { get; set; }
    
    public string? AvatarUrl { get; set; }
    
    public int LoyaltyPoints { get; set; }
    
    public bool IsRenting { get; set; }
    
    public bool HasActiveViolation { get; set; }
    
    public bool IsIdentityVerified { get; set; }
    
    public bool IsPhoneVerified { get; set; }
    
    public bool IsDriverLicenseVerified { get; set; }
}

public class GetUserLoginInfoDto
{
    public string? LoginProvider { get; set; }
    
    public string? ProviderDisplayName { get; set; }
}

