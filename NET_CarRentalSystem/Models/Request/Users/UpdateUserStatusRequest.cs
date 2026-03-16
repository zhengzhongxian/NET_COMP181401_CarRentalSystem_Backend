using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Request.Users;

public class UpdateUserStatusRequest
{
    public UserStatus? Status { get; set; }
    
    public bool? IsIdentityVerified { get; set; }
    
    public bool? IsPhoneVerified { get; set; }
    
    public bool? IsDriverLicenseVerified { get; set; }
}

