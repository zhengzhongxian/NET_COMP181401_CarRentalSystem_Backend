using MediatR;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.UpdateVehicleCategory;

public class UpdateVehicleCategoryCommandHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<UpdateVehicleCategoryCommand, bool>
{
    public async Task<bool> Handle(
        UpdateVehicleCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var categoryToUpdate = await unitOfWork.GetRepository<VehicleCategory>()
            .GetByIdAsync(request.Id, cancellationToken);

        if (categoryToUpdate == null)
        {
            return false;
        }

        if (request.CategoryCode != null)
        {
            categoryToUpdate.CategoryCode = request.CategoryCode;
        }

        if (request.Seat.HasValue)
        {
            categoryToUpdate.Seat = request.Seat.Value;
        }

        unitOfWork.GetRepository<VehicleCategory>().Update(categoryToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}
