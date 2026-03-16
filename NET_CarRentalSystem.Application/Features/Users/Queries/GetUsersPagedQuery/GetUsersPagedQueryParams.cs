using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Users.Queries.GetUsersPagedQuery;

public class GetUsersPagedQueryParams : PagedParams
{
    public Guid? RoleId { get; set; }
}

