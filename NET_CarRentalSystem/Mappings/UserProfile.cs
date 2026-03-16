using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Users;
using NET_CarRentalSystem.API.Models.Response.Users;
using NET_CarRentalSystem.Application.Features.Users.Queries.GetUsersPagedQuery;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;

namespace NET_CarRentalSystem.API.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<GetUsersPagedRequest, GetUsersPagedQueryParams>();
        
        CreateMap<GetUserListDto, GetUserListResponse>();
        CreateMap<GetUserDetailDto, GetUserDetailResponse>();
        CreateMap<GetCustomerInfoDto, GetCustomerInfoResponse>();
        CreateMap<GetUserLoginInfoDto, GetUserLoginInfoResponse>();
    }
}

