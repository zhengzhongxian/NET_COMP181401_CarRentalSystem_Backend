using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Models.Request.Users;

public class GetUsersPagedRequest : PagedRequest
{
    public Guid? RoleId { get; set; }
}

