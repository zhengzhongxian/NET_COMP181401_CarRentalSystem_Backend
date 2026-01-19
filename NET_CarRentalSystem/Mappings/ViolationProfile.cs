using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Violations;
using NET_CarRentalSystem.Application.Features.Violations.Commands.CreateViolationPaymentCommand;

namespace NET_CarRentalSystem.API.Mappings;

public class ViolationProfile : Profile
{
    public ViolationProfile()
    {
        CreateMap<CreateViolationPaymentRequest, CreateViolationPaymentCommand>();
    }
}

