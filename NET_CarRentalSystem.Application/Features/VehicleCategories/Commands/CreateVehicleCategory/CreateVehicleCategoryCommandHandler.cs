using MediatR;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.CreateVehicleCategory;

public class CreateVehicleCategoryCommandHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<CreateVehicleCategoryCommand, Guid>
{
    public async Task<Guid> Handle(
        CreateVehicleCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var newCategory = new VehicleCategory
        {
            CategoryId = Guid.NewGuid(),
            CategoryCode = request.CategoryCode,
            Seat = request.Seat
        };

        await unitOfWork.GetRepository<VehicleCategory>().AddAsync(newCategory, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return newCategory.CategoryId;
    }
}
