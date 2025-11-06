using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Auth;
using NET_CarRentalSystem.API.Models.Response.Auth;
using NET_CarRentalSystem.Application.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;
using NET_CarRentalSystem.Application.Interfaces.Services;

namespace NET_CarRentalSystem.API.Mappings;

public class AuthProfile : Profile
{
    public AuthProfile()
    {
        CreateMap<LoginRequest,LoginCommand>();
        CreateMap<TokenResponse,LoginResponse>();
        CreateMap<GetUserSessionDto, GetUserSessionResponse>();
    }
}