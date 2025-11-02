using MediatR;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.DeleteVehicleCategory;

public class DeleteVehicleCategoryCommandHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<DeleteVehicleCategoryCommand, bool>
{
    public async Task<bool> Handle(
        DeleteVehicleCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var categoryToDelete = await unitOfWork.GetRepository<VehicleCategory>()
            .GetByIdAsync(request.Id, cancellationToken);

        if (categoryToDelete == null)
        {
            return false;
        }

        unitOfWork.GetRepository<VehicleCategory>().Remove(categoryToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}
