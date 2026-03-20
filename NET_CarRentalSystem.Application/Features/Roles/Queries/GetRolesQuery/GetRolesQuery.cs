using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.RoleDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Roles.Queries.GetRolesQuery;

public class GetRolesQuery : IQuery<List<GetRoleDto>>;

public class GetRolesQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetRolesQuery, List<GetRoleDto>>
{
    public async Task<List<GetRoleDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        var sql = """
            SELECT 
                role_id AS RoleId,
                name AS Name,
                description AS Description,
                CASE accessibility 
                    WHEN 1 THEN 'Admin'
                    WHEN 2 THEN 'Both'
                    ELSE 'Client'
                END AS Accessibility,
                created_at AS CreatedAt
            FROM roles
            WHERE is_deleted = 0
            ORDER BY name ASC
        """;

        var roles = await dapperRepository.QueryAsync<GetRoleDto>(sql, cancellationToken: cancellationToken);
        return roles.ToList();
    }
}
