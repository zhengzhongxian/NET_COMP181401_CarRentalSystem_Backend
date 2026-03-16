using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Permissions;
using NET_CarRentalSystem.Application.Models.DTOs.PermissionDTOs.Get;

namespace NET_CarRentalSystem.API.Mappings;

public class PermissionProfile : Profile
{
    public PermissionProfile()
    {
        CreateMap<GetPermissionGroupDto, GetPermissionGroupResponse>();
        CreateMap<GetPermissionDto, GetPermissionResponse>();
    }
}

