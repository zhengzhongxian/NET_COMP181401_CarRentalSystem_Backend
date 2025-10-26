using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.DTOs.PaymentDTOs.Get;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Payments.Queries.GetPaymentMethodQuery;

public class GetAllPaymentMethod : IQuery<List<GetPaymentMethodDto>>;

public class GetAllPaymentMethodHandler
    : IRequestHandler<GetAllPaymentMethod, List<GetPaymentMethodDto>>
{
    public Task<List<GetPaymentMethodDto>> Handle(GetAllPaymentMethod request, CancellationToken cancellationToken)
    {
        var methodsList = EnumHelper.GetEnumAsModelList<GetPaymentMethodDto>(typeof(PaymentMethod));
        
        return Task.FromResult(methodsList);
    }
}