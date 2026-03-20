using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Roles;
using NET_CarRentalSystem.Application.Models.DTOs.RoleDTOs.Get;

namespace NET_CarRentalSystem.API.Mappings;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<GetRoleDto, GetRoleResponse>();
        CreateMap<GetRoleClaimDto, GetRoleClaimResponse>();
    }
}
