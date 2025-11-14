using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleDetailQuery;

public class GetVehicleDetailQuery : IQuery<GetVehicleDetailDto?>
{
    public Guid VehicleId { get; set; }
}

public class GetVehicleDetailQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetVehicleDetailQuery, GetVehicleDetailDto?>
{
    public async Task<GetVehicleDetailDto?> Handle(GetVehicleDetailQuery request, CancellationToken cancellationToken)
    {
        var includeBuilder = new IncludeBuilder<Vehicle>()
            .Include(v => v.Location)
            .Include(v => v.VehicleCategory)
            .Include(v => v.Fuel)
            .Include(v => v.Transmission)
            .Include(v => v.VehicleAttributes)
            .Include(v => v.VehicleImages);

        var vehicle = await unitOfWork.GetRepository<Vehicle>()
            .GetFirstOrDefaultAsync(
                v => v.Id == request.VehicleId,
                includeBuilder.Build(),
                cancellationToken);

        if (vehicle == null) return null;

        return new GetVehicleDetailDto
        {
            VehicleId = vehicle.Id,
            NumberPlate = vehicle.NumberPlate,
            Manufacturer = vehicle.Manufacturer,
            Model = vehicle.Model,
            PricePerHour = vehicle.PricePerHour,
            Rating = vehicle.Rating,
            Status = vehicle.Status,
            LocationName = vehicle.Location?.Name,
            VehicleCategoryCode = vehicle.VehicleCategory?.CategoryCode,
            FuelName = vehicle.Fuel?.Name,
            TransmissionName = vehicle.Transmission?.Name,
            Attributes = vehicle.VehicleAttributes
                .Select(att => new GetVehicleAttributeDto
                {
                    AttributeId = att.AttributeId, 
                    AttributeKey = att.AttributeKey, 
                    AttributeValue = att.AttributeValue
                })
                .ToList(),
            Images = vehicle.VehicleImages.Select(img => img.ImageUrl).ToList()
        };
    }
}