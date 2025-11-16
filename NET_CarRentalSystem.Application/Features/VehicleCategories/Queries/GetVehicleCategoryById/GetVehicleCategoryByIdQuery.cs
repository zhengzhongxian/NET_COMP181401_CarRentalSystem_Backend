using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleCategoryDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetVehicleCategoryById;

public class GetVehicleCategoryByIdQuery : IQuery<GetVehicleCategoryDto?>
{
    public Guid Id { get; set; }
}

public class GetVehicleCategoryByIdQueryHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetVehicleCategoryByIdQuery, GetVehicleCategoryDto?>
{
    public async Task<GetVehicleCategoryDto?> Handle(
        GetVehicleCategoryByIdQuery request,
        CancellationToken cancellationToken)
    {
        var category = await unitOfWork.GetRepository<VehicleCategory>()
            .GetByIdAsync(request.Id, cancellationToken);

        if (category == null)
        {
            return null;
        }

        return new GetVehicleCategoryDto
        {
            CategoryId = category.Id,
            CategoryCode = category.CategoryCode,
            Seat = category.Seat
        };
    }
}
