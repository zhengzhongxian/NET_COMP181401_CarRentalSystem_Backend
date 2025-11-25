using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Payments;
using NET_CarRentalSystem.Application.Models.DTOs.PaymentDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.PaymentDTOs.Create;

namespace NET_CarRentalSystem.API.Mappings;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<GetPaymentMethodDto, GetPaymentMethodResponse>();
        CreateMap<CreatePaymentQrLinkDto, CreatePaymentQrResponse>();
    }
}