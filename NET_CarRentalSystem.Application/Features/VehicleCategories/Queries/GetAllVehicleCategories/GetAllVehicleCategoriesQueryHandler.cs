using MediatR;
using NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetAllVehicleCategories;

public class GetAllVehicleCategoriesQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetAllVehicleCategoriesQuery, List<GetVehicleCategoryDto>>
{
    public async Task<List<GetVehicleCategoryDto>> Handle(
        GetAllVehicleCategoriesQuery request, 
        CancellationToken cancellationToken)
    {
        var categories = await unitOfWork.GetRepository<VehicleCategory>().GetAllAsync(cancellationToken);

        var categoryDtos = categories.Select(category => new GetVehicleCategoryDto
        {
            CategoryId = category.CategoryId,
            CategoryCode = category.CategoryCode,
            Seat = category.Seat
        }).ToList();

        return categoryDtos;
    }
}
