using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Users.Queries.GetUsersPagedQuery;

public class GetUsersPagedQuery : IQuery<PagedList<GetUserListDto>>
{
    public required GetUsersPagedQueryParams RequestParams { get; set; }
}

public class GetUsersPagedQueryHandler(
    IDapperRepository dapperRepository,
    ICryptographyService cryptographyService)
    : IRequestHandler<GetUsersPagedQuery, PagedList<GetUserListDto>>
{
    public async Task<PagedList<GetUserListDto>> Handle(GetUsersPagedQuery request, CancellationToken cancellationToken)
    {
        var parameters = new Dictionary<string, object>();
        var query = request.RequestParams;

        var whereConditions = new List<string> { "u.is_deleted = 0" };
        
        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var keyword = query.SearchKeyword.Trim();
            var keywordLike = $"%{keyword}%";
            
            var encryptedPhone = cryptographyService.EncryptAes(keyword);
            
            whereConditions.Add("""
                (
                    c.first_name LIKE @Keyword OR 
                    c.last_name LIKE @Keyword OR 
                    u.email LIKE @Keyword OR
                    c.phone_number = @EncryptedPhone
                )
            """);

            parameters["Keyword"] = keywordLike;
            parameters["EncryptedPhone"] = encryptedPhone;
        }
        
        if (query.RoleId.HasValue)
        {
            whereConditions.Add("ur.role_id = @RoleId");
            parameters["RoleId"] = query.RoleId.Value;
        }

        var whereClause = string.Join(" AND ", whereConditions);

        var allowedSortColumns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "UserName", "u.user_name" },
            { "Email", "u.email" },
            { "Created", "u.created_at" },
            { "Status", "u.status" }
        };

        var sortBy = "u.created_at";

        if (!string.IsNullOrEmpty(query.SortBy) && allowedSortColumns.TryGetValue(query.SortBy, out var column))
        {
            sortBy = column;
        }

        var sortDirection = query.SortDirection?.ToLower() == "asc" ? "ASC" : "DESC";
        var orderByClause = $"ORDER BY {sortBy} {sortDirection}";

        var offset = (query.PageNumber - 1) * query.PageSize;
        parameters["Offset"] = offset;
        parameters["PageSize"] = query.PageSize;

        var countSql = $"""
            SELECT COUNT(DISTINCT u.user_id)
            FROM users u
            LEFT JOIN customers c ON u.user_id = c.user_id
            LEFT JOIN user_roles ur ON u.user_id = ur.user_id
            WHERE {whereClause}
        """;

        var totalCount = await dapperRepository.ExecuteScalarAsync<int>(countSql, parameters, cancellationToken: cancellationToken);

        var dataSql = $"""
            SELECT DISTINCT
                u.user_id AS UserId,
                u.user_name AS UserName,
                u.email AS Email,
                u.status AS Status,
                u.is_verified AS IsVerified,
                r.name AS RoleName,
                u.created_at AS CreatedAt
            FROM users u
            LEFT JOIN customers c ON u.user_id = c.user_id
            LEFT JOIN user_roles ur ON u.user_id = ur.user_id
            LEFT JOIN roles r ON ur.role_id = r.role_id AND r.is_deleted = 0
            WHERE {whereClause}
            {orderByClause}
            OFFSET @Offset ROWS
            FETCH NEXT @PageSize ROWS ONLY
        """;

        var users = await dapperRepository.QueryAsync<GetUserListDto>(dataSql, parameters, cancellationToken: cancellationToken);

        return new PagedList<GetUserListDto>(
            users.ToList(),
            totalCount,
            query.PageNumber,
            query.PageSize);
    }
}

