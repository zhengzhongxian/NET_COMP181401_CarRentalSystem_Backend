using System.Reflection;
using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.PermissionDTOs.Get;
using NET_CarRentalSystem.Domain.Constants;

namespace NET_CarRentalSystem.Application.Features.Permissions.Queries.GetPermissionsQuery;

public class GetPermissionsQuery : IQuery<List<GetPermissionGroupDto>>
{
    public string? GroupName { get; set; }
}

public class GetPermissionsQueryHandler
    : IRequestHandler<GetPermissionsQuery, List<GetPermissionGroupDto>>
{
    public Task<List<GetPermissionGroupDto>> Handle(GetPermissionsQuery request, CancellationToken cancellationToken)
    {
        var result = new List<GetPermissionGroupDto>();
        var permissionType = typeof(PermissionConstants);
        
        var nestedTypes = permissionType.GetNestedTypes(BindingFlags.Public);

        foreach (var nestedType in nestedTypes)
        {
            if (!string.IsNullOrWhiteSpace(request.GroupName) &&
                !nestedType.Name.Contains(request.GroupName, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var permissions = new List<GetPermissionDto>();
            var fields = nestedType.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Where(fi => fi.IsLiteral && !fi.IsInitOnly && fi.FieldType == typeof(string));

            foreach (var field in fields)
            {
                var value = field.GetRawConstantValue()?.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    permissions.Add(new GetPermissionDto
                    {
                        Name = field.Name,
                        Value = value
                    });
                }
            }

            if (permissions.Count > 0)
            {
                result.Add(new GetPermissionGroupDto
                {
                    GroupName = nestedType.Name,
                    Permissions = permissions
                });
            }
        }

        return Task.FromResult(result);
    }
}

