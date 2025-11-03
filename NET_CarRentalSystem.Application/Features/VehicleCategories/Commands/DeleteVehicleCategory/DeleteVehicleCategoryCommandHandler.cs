using MediatR;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.DeleteVehicleCategory;

public class DeleteVehicleCategoryCommand : IRequest<(string, bool)>
{
    [Required]
    public Guid Id { get; set; }
}

public class DeleteVehicleCategoryCommandHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<DeleteVehicleCategoryCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(
        DeleteVehicleCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var categoryToDelete = await unitOfWork.GetRepository<VehicleCategory>()
            .GetByIdAsync(request.Id, cancellationToken);

        if (categoryToDelete == null)
        {
            return (VehicleCategoryMessage.Delete.NotFound, false);
        }

        unitOfWork.GetRepository<VehicleCategory>().Remove(categoryToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (VehicleCategoryMessage.Delete.Success, true);
    }
}
