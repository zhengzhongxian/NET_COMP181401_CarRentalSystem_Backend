using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Bookings;
using NET_CarRentalSystem.API.Models.Response.Bookings;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CancelBookingCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CompleteBookingCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateAfterReturnCommand;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingsPagedQuery;
using NET_CarRentalSystem.Application.Features.Bookings.Queries.GetCustomerBookingsPagedQuery;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Update;
using NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;

namespace NET_CarRentalSystem.API.Mappings;

public class BookingProfile : Profile
{
    public BookingProfile()
    {
        CreateMap<CreateBookingRequest, CreateBookingCommand>();

        CreateMap<CancelBookingRequest, CancelBookingCommand>();

        CreateMap<UpdateAfterReturnRequest, UpdateAfterReturnCommand>()
            .ForMember(dest => dest.ReturnImages, opt => opt.Ignore());

        CreateMap<CompleteBookingRequest, CompleteBookingCommand>();

        CreateMap<PaymentTransactionDto, CreateBookingResponse>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.PaymentMethod, opt => opt.MapFrom(src => src.PaymentMethod.ToString()))
            .ForMember(dest => dest.TransactionType, opt => opt.MapFrom(src => src.TransactionType.ToString()));

        CreateMap<SwapVehicleModelDto, SwapVehicleModelResponse>();

        CreateMap<GetBookingsPagedRequest, GetBookingsPagedQueryParams>();
        CreateMap<GetCustomerBookingsPagedRequest, GetCustomerBookingsPagedQueryParams>();

        CreateMap<GetBookingDto, GetBookingResponse>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.PickupLocationName, opt => opt.MapFrom(src => src.PickupLocationName))
            .ForMember(dest => dest.ReturnLocationName, opt => opt.MapFrom(src => src.ReturnLocationName))
            .ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.FileName));

        CreateMap<GetBookingDetailDto, GetBookingDetailResponse>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.PickupLocationName, opt => opt.MapFrom(src => src.PickupLocationName))
            .ForMember(dest => dest.ReturnLocationName, opt => opt.MapFrom(src => src.ReturnLocationName))
            .ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.FileName));

        CreateMap<GetBookingImageDto, GetBookingImageResponse>();
    }
}
