using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Auth;
using NET_CarRentalSystem.API.Models.Response.Auth;
using NET_CarRentalSystem.Application.Features.Auth.Commands.GoogLogupCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LogupCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtpCommand;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Models.DTOs.AuthDTOs;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;


namespace NET_CarRentalSystem.API.Mappings;

public class AuthProfile : Profile
{
    public AuthProfile()
    {
        CreateMap<LoginRequest,LoginCommand>();
        CreateMap<TokenResponse,LoginResponse>();
        CreateMap<GetUserSessionDto, GetUserSessionResponse>();
        CreateMap<SendOtpRequest, SendOtpParams>();
        CreateMap<LogupRequest, LogupCommandParams>();
        CreateMap<UserDto, GetUserResponse>();
        CreateMap<GoogleLoginDto, GoogleLoginResponse>();
        CreateMap<GoogleLoginDto, LoginResponse>();
        CreateMap<GoogleLogupRequest, GoogleLogupCommandParams>();
    }
}