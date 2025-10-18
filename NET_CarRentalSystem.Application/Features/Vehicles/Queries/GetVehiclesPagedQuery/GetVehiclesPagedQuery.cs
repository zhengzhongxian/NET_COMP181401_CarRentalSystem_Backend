using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class GetVehiclesPagedQuery : IQuery<PagedList<VehicleDto>>
{
    public required GetVehiclesPagedQueryParams QueryParams { get; set; }
}

public class GetVehiclesPagedQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetVehiclesPagedQuery, PagedList<VehicleDto>>
{
    public async Task<PagedList<VehicleDto>> Handle(GetVehiclesPagedQuery request, CancellationToken cancellationToken)
    {
        Expression<Func<Vehicle, bool>>? filter = null;

        if (!string.IsNullOrWhiteSpace(request.QueryParams.SearchKeyword))
        {
            var searchKeyword = request.QueryParams.SearchKeyword.ToLower();
            filter = v => v.NumberPlate.ToLower().Contains(searchKeyword) ||
                         v.Manufacturer.ToLower().Contains(searchKeyword) ||
                         v.Model.ToLower().Contains(searchKeyword) ||
                         (v.Color != null && v.Color.ToLower().Contains(searchKeyword));
        }

        var includeProperties = "VehicleCategory,Fuel,Transmission";

        var pagedList = await unitOfWork.GetRepository<Vehicle>().GetPagedAsync(
            request.QueryParams,
            filter,
            includeProperties);

        var vehicleDtos = pagedList.Items.Select(vehicle => new VehicleDto
        {
            VehicleId = vehicle.VehicleId,
            NumberPlate = vehicle.NumberPlate,
            Manufacturer = vehicle.Manufacturer,
            Model = vehicle.Model,
            Color = vehicle.Color,
            Mileage = vehicle.Mileage,
            PricePerHour = vehicle.PricePerHour,
            Thumbnail = vehicle.Thumbnail,
            LastCheckoutAt = vehicle.LastCheckoutAt,
            Rating = vehicle.Rating,
            Status = vehicle.Status,
            ConditionNotes = vehicle.ConditionNotes,
            RealTimeLocation = vehicle.RealTimeLocation,
            LocationId = vehicle.LocationId,
            Metadata = vehicle.Metadata,
            VehicleCategoryId = vehicle.VehicleCategoryId,
            FuelId = vehicle.FuelId,
            TransmissionId = vehicle.TransmissionId,
            VehicleCategoryCode = vehicle.VehicleCategory?.CategoryCode,
            FuelName = vehicle.Fuel?.Name,
            TransmissionName = vehicle.Transmission?.Name
        }).ToList();

        return new PagedList<VehicleDto>(
            vehicleDtos,
            pagedList.TotalCount,
            pagedList.CurrentPage,
            pagedList.PageSize);
    }
}
