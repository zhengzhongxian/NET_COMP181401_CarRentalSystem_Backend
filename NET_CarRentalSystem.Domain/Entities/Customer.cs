using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Customer : BaseEntity
{
    public Guid CustomerId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime Dob { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    public string CccdNumber { get; set; }

    public DateTime CccdIssueDate { get; set; }

    public string CccdIssuePlace { get; set; }

    public string CccdFrontUrl { get; set; }

    public string CccdBackUrl { get; set; }

    public string DriverLicenseId { get; set; }

    public DateTime DriverLicenseExpiry { get; set; }

    public string DriverLicenseFrontUrl { get; set; }

    public string DriverLicenseBackUrl { get; set; }

    public string? AvatarUrl { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = [];
}
