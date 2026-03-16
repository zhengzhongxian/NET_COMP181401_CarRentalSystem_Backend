using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.RoleDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Roles.Queries.GetRoleClaimsQuery;

public class GetRoleClaimsQuery : IQuery<List<GetRoleClaimDto>>
{
    public Guid? RoleId { get; set; }
}

public class GetRoleClaimsQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetRoleClaimsQuery, List<GetRoleClaimDto>>
{
    public async Task<List<GetRoleClaimDto>> Handle(GetRoleClaimsQuery request, CancellationToken cancellationToken)
    {
        var parameters = new Dictionary<string, object>();
        var whereConditions = new List<string> { "r.is_deleted = 0" };

        if (request.RoleId.HasValue)
        {
            whereConditions.Add("rc.role_id = @RoleId");
            parameters["RoleId"] = request.RoleId.Value;
        }

        var whereClause = string.Join(" AND ", whereConditions);

        var sql = $"""
            SELECT 
                rc.id AS Id,
                rc.role_id AS RoleId,
                r.name AS RoleName,
                rc.claim_type AS ClaimType,
                rc.claim_value AS ClaimValue
            FROM role_claims rc
            INNER JOIN roles r ON rc.role_id = r.role_id
            WHERE {whereClause}
            ORDER BY r.name ASC, rc.claim_value ASC
        """;

        var roleClaims = await dapperRepository.QueryAsync<GetRoleClaimDto>(sql, parameters, cancellationToken: cancellationToken);
        return roleClaims.ToList();
    }
}

