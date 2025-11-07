using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Auth;
using NET_CarRentalSystem.API.Models.Response.Auth;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LogupCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtp;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;


namespace NET_CarRentalSystem.API.Mappings;

public class AuthProfile : Profile
{
    public AuthProfile()
    {
        CreateMap<LoginRequest,LoginCommand>();
        CreateMap<TokenResponse,LoginResponse>();
        CreateMap<GetUserSessionDto, GetUserSessionResponse>();
        CreateMap<SendOtpRequest, SendOtpDto>();
        CreateMap<LogupRequest, LogupDto>();
        CreateMap<UserDto, GetUserResponse>();
    }
}